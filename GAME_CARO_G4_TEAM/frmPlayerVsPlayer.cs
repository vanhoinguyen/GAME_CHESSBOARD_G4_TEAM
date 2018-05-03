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
    public partial class frmPlayerVsPlayer : Form
    {
        private CaroChess carochess;
        private Graphics grs;
        
        
        
        public frmPlayerVsPlayer()
        {
            
            InitializeComponent();
            carochess = new CaroChess();
            carochess.KhoiTaoMangOCo(); //Khởi tạo mảng ô cờ
            grs = pnChessBoard.CreateGraphics();   // Tạo mới Graphics
        }

        private void pnChessBoard_Paint(object sender, PaintEventArgs e)
        {
            carochess.VeBanCo(grs); //Vẽ bàn cờ
            carochess.VeLaiOCo(grs);  //Vẽ lại quân cờ
            txtPlayerName.Text = "";
        }

        private void pnChessBoard_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (!carochess.SanSang)
               return;
            carochess.DanhCo(e.X, e.Y, grs,txtPlayerName);

            if (carochess.KiemTraChienThang())
                carochess.KetThucTroChoi();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            grs.Clear(pnChessBoard.BackColor);
            txtPlayerName.Text = "Nguời chơi 1";            
            carochess.StartPvsP(grs);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carochess.Undo(grs);
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carochess.Redo(grs);
        }
    }
}
