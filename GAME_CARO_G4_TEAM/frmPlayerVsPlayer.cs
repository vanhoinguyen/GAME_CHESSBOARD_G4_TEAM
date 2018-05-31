using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace GAME_CARO_G4_TEAM
{
    public partial class frmPlayerVsPlayer : Form
    {

        #region INIT

        bool isLanGame = false;
        private CaroChess carochess;
        private Graphics grs;
        private QuanLiSocket socket;
        private string rivalName = "";
        

        public frmPlayerVsPlayer()
        {
            
            InitializeComponent();
            carochess = new CaroChess();
            carochess.KhoiTaoMangOCo(); //Khởi tạo mảng ô cờ
            grs = pnChessBoard.CreateGraphics();   // Tạo mới Graphics
            rtbChat.WordWrap = true;
            socket = new QuanLiSocket();
            IP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

        }

        #endregion

        #region Event

        #region GAMEPLAY

        private void pnChessBoard_Paint(object sender, PaintEventArgs e)
        {
            carochess.VeBanCo(grs); //Vẽ bàn cờ
            carochess.VeLaiOCo(grs);  //Vẽ lại quân cờ
        }

        private void pnChessBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (isLanGame&&socket.IsConnected)// LAN game
            {
                if (!carochess.SanSang)
                    return;
                if(carochess.DanhCoOnLan(e.X, e.Y, grs, socket.IsServer)){

                    pnChessBoard.Enabled = false;
                    
                    socket.Send(new DataTransfer(e.Location, (int)CommandType.POINT, "", socket.IsServer));

                    prbCoolDown.Value = 0;

                    timer1.Stop();

                    Listen();
                }
            }
            else//Phần chơi trên 1 máy 
            {
                if (!carochess.SanSang)
                    return;
                carochess.DanhCo(e.X, e.Y, grs, txtPlayerName);

                if (carochess.KiemTraChienThang())
                {
                    carochess.KetThucTroChoi();
                }
                    
            }
        }

        private void chơiMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isLanGame)
            {
                grs.Clear(pnChessBoard.BackColor);
                pnChessBoard.Enabled = true;
                txtPlayerName.Text = "Nguời chơi 1";
                carochess.StartPvsP(grs);
            }
            else 
                if(socket.IsConnected)
                {
                    socket.Send(new DataTransfer(new Point(0,0), (int)CommandType.NEW_GAME, " ", socket.IsServer));
                    grs.Clear(pnChessBoard.BackColor);
                    carochess.StartLanGame(grs);
                }
            
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carochess.Undo(grs);
            socket.Send(new DataTransfer(new Point(0, 0), (int)CommandType.UNDO, "", socket.IsServer));
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carochess.Redo(grs);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            carochess.Undo(grs);
            if(isLanGame&&socket.IsConnected)
                socket.Send(new DataTransfer(new Point(0, 0), (int)CommandType.UNDO, "", socket.IsServer));
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            carochess.Redo(grs);
            if (isLanGame&&socket.IsConnected)
                socket.Send(new DataTransfer(new Point(0, 0), (int)CommandType.REDO, "", socket.IsServer));
        }
        #endregion

        #region Phím chức năng

        private void btnPlay_Click(object sender, EventArgs e)
        {
            grs.Clear(pnChessBoard.BackColor);

            if (isLanGame && socket.IsConnected)
            {
                socket.Send(new DataTransfer(new Point(0, 0), (int)CommandType.QUIT, "", socket.IsServer));
            }

            isLanGame = false;

            pnChessBoard.Enabled = true;
            txtPlayerName.Text = "Nguời chơi 1";
            carochess.StartPvsP(grs);
        }

        private void btnLan_Click(object sender, EventArgs e)
        {
            isLanGame = true;
            btnLan.Enabled = false;
            socket = new QuanLiSocket();
            socket.PlayerName = PlayerName.Name;
            socket.IP = IPAddress.Parse(IP.Text);
            if (!socket.ConnectServer())
            // chưa có server thì sẽ tạo server
            {
                socket.IsServer = true;
                socket.CreateServer();
                Thread temp = new Thread(() =>
                {
                    while (!socket.IsConnected)
                    {
                        Listen();
                    }
                });
                temp.IsBackground = true;
                temp.Start();
                // lắng nghe kết nối từ client                   
            }
            else
            // có rồi thì sẽ chờ kết nối
            {
                socket.IsServer = false;
                pnChessBoard.Enabled = false;
                socket.Send(new DataTransfer(new Point(0, 0), (int)CommandType.CONNECT, socket.PlayerName, socket.IsServer));
                panel4.Visible = true;
                Listen();
            }
            txtPlayerName.Text = PlayerName.Name;
            grs.Clear(pnChessBoard.BackColor);
            carochess.StartLanGame(grs);
            Timer();
            StopLanGame();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            ExitLanGame();
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        { 
            rtbChat.AppendText(socket.PlayerName + ": " + textBox1.Text + "\n");
            socket.Send(new DataTransfer(new Point(0, 0), (int)CommandType.MESSAGE, textBox1.Text, socket.IsServer));
            textBox1.Clear();
            Listen();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ExitLanGame();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prbCoolDown.Value == prbCoolDown.Maximum)
            {
                timer1.Stop();
                prbCoolDown.Value = 0;
                pnChessBoard.Enabled = false;
                MessageBox.Show("Bạn đã bỏ lượt !");
                socket.Send(new DataTransfer(new Point(0, 0), (int)CommandType.TURN_PASSED, "", socket.IsServer));
            }
            else
                prbCoolDown.Value++;
        }

        private void thoátGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitLanGame();
        }

        #endregion


        #endregion

        #region Method

        void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    DataTransfer dataReceived = (DataTransfer)socket.Receive();

                    ProcessData(dataReceived);
                }
                catch (Exception e)
                {
                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void ProcessData(DataTransfer data)
        {
            switch (data.CommandType)
            {
                case (int)CommandType.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        MessageBox.Show("New Game");
                        grs.Clear(pnChessBoard.BackColor);
                        carochess.StartLanGame(grs);
                        if (socket.IsServer == true)
                            StopLanGame();
                    }));
                    break;
                case (int)CommandType.POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        carochess.DanhCoOnLan(data.Point.X, data.Point.Y, grs, data.IsServer);
                        pnChessBoard.Enabled = true;
                        prbCoolDown.Value = 0;
                        undoToolStripMenuItem.Enabled = true;
                        timer1.Start();
                    }));
                    break;
                case (int)CommandType.UNDO:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        carochess.Undo(grs);
                    }));
                    break;
                case (int)CommandType.QUIT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        MessageBox.Show(this.rivalName + " đã thoát");
                        panel4.Visible = false;
                        socket.IsConnected = false;
                        isLanGame = false;
                        StopLanGame();
                        socket.Server1.Close();

                    }));
                    break;
                case (int)CommandType.MESSAGE:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        rtbChat.AppendText(this.rivalName + ": " +data.Message + "\n" );
                    }));
                    
                    break;
                case (int)CommandType.NAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        rivalName = data.Message;
                    }));
                    
                    break;
                case (int)CommandType.CONNECT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        pnChessBoard.Enabled = true;
                        socket.IsConnected = true;
                        panel4.Visible = true;
                        rivalName = data.Message;
                        MessageBox.Show(rivalName + " đã kết nối !");
                        MessageBox.Show("Trò chơi bắt đầu");
                        socket.Send(new DataTransfer(new Point(0,0),(int)CommandType.NAME,socket.PlayerName,socket.IsServer));
                        
                    }));
                    break;
                case (int)CommandType.TURN_PASSED:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        MessageBox.Show(rivalName + " đã bỏ lượt!");
                        timer1.Start();
                        pnChessBoard.Enabled = true;
                    }));
                    break;
                case (int)CommandType.REDO:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        carochess.Redo(grs);
                    }));
                    break;
                default:
                    break;
            }
            Listen();
        }

        void Timer()
        {
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        void ExitLanGame()
        {
            if (isLanGame)
            {
                if(socket.IsConnected)
                    socket.Send(new DataTransfer(new Point(0, 0), (int)CommandType.QUIT, "", socket.IsServer));
            }

            this.Close();
        }

        void StopLanGame()
        {
            pnChessBoard.Enabled = false;
            timer1.Stop();
            prbCoolDown.Value = 0;

        }

        #endregion

        #region MoveForm
        Boolean flag;
        int x, y;

        private void frmPlayerVsPlayer_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void frmPlayerVsPlayer_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
        private void frmPlayerVsPlayer_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }
        #endregion

        #region Color
        private void màuViềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.FullOpen = true;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                CaroChess.pen = new Pen(dlgColor.Color);
                carochess.VeBanCo(grs);
            }
        }

        private void màuQuânOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.FullOpen = true;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                CaroChess.penO = new Pen(dlgColor.Color, 2f);
                carochess.VeBanCo(grs);
                carochess.VeLaiOCo(grs);
            }
        }

        private void màuQuânXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.FullOpen = true;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                CaroChess.penX = new Pen(dlgColor.Color, 2f);
                carochess.VeBanCo(grs);
                carochess.VeLaiOCo(grs);
            }
        }



        private void màuBànCờToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.FullOpen = true;
            if (dlgColor.ShowDialog() == DialogResult.OK)
                pnChessBoard.BackColor = dlgColor.Color;
        }

        #endregion

      
    }
}
