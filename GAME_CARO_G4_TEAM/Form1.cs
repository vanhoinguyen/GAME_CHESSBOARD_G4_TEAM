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
    public partial class frmChessBoard : Form
    {
        private CaroChess caroChess;
        private Graphics grs;

        public frmChessBoard()
        {
            InitializeComponent();
            caroChess = new CaroChess();
            grs = pnChessBoard.CreateGraphics();
        }

        private void pnChessBoard_Paint(object sender, PaintEventArgs e)
        {
            caroChess.DrawChessBoard(grs);
        }

        private void frmChessBoard_Load(object sender, EventArgs e)
        {
           
        }
    }
}
