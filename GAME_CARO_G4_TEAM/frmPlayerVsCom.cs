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
        private CaroChess carochess;
        private Graphics grs;
        public frmPlayerVsCom()
        {
            InitializeComponent();
            carochess = new CaroChess();
            grs = pnChessBoard.CreateGraphics();
        }

        private void pnChessBoard_Paint(object sender, PaintEventArgs e)
        {
            
            carochess.VeBanCo(grs); //Vẽ bàn cờ
            carochess.VeLaiOCo(grs);  //Vẽ lại quân cờ
            txtPlayerName.Text = "";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            grs.Clear(pnChessBoard.BackColor);
            txtPlayerName.Text = "Nguời chơi 1";
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

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carochess.Undo(grs);
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carochess.Redo(grs);
        }

        private void màuNềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.FullOpen = true;
            if (dlgColor.ShowDialog() == DialogResult.OK)
                this.BackColor = dlgColor.Color;
        }

        private void màuBànCờToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.FullOpen = true;
            if (dlgColor.ShowDialog() == DialogResult.OK)
                pnChessBoard.BackColor = dlgColor.Color;
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


    }
}
