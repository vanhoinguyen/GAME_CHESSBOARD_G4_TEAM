using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME_CARO_G4_TEAM
{
    public partial class frmPlayerVsCom : Form
    {
        #region Init

        private CaroChess carochess;
        private Graphics grs;
        public frmPlayerVsCom()
        {
            InitializeComponent();
            carochess = new CaroChess();
            grs = pnChessBoard.CreateGraphics();
        }

        #endregion

        #region Event
        private void pnChessBoard_Paint(object sender, PaintEventArgs e)
        {
            
            carochess.VeBanCo(grs); //Vẽ bàn cờ
            carochess.VeLaiOCo(grs);  //Vẽ lại quân cờ

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            grs.Clear(pnChessBoard.BackColor);
            txtPlayerName.Text = PlayerName.Name;
            carochess.StartPvsCom(grs,txtPlayerName);
        }

        private void pnChessBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (!carochess.SanSang)
                return;
           if( carochess.DanhCo(e.X, e.Y, grs, txtPlayerName))
            {
                if (carochess.KiemTraChienThang())
                    carochess.KetThucTroChoi();
                else
                {
                    if (carochess.CheDoChoi == 2)
                    {
                        carochess.KhoiDongMay(grs,txtPlayerName);
                        if (carochess.KiemTraChienThang())
                            carochess.KetThucTroChoi();
                    }
                }
            }


        }

        private void chơiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grs.Clear(pnChessBoard.BackColor);
            txtPlayerName.Text = PlayerName.Name;
            carochess.StartPvsCom(grs, txtPlayerName);
        }

        #endregion

        #region UndoReDo
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carochess.Undo(grs);
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carochess.Redo(grs);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            carochess.Undo(grs);
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            carochess.Redo(grs);
        }

        #endregion

        #region Thoát và Thu Nhỏ
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void thoátGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        #endregion

        #region MoveForm
        Boolean flag;
        int x, y;

        private void frmPlayerVsCom_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void frmPlayerVsCom_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void frmPlayerVsCom_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPlayerVsCom_Load(object sender, EventArgs e)
        {
            txtPlayerName.Text = PlayerName.Name;
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
