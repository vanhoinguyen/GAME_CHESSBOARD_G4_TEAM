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
            grs = pnChessBoard.CreateGraphics();
        }

        private void pnChessBoard_Paint(object sender, PaintEventArgs e)
        {
            carochess.DrawChessBoard(grs);
        }
    }
}
