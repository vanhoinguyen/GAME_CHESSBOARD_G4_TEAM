using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_CARO_G4_TEAM
{
    class CaroChess
    {
        private ChessBoard _ChessBoard;
        public CaroChess()
        {
            _ChessBoard = new ChessBoard(24, 21);
        }

        public void DrawChessBoard(Graphics g)
        {
            _ChessBoard.DrawChessBoard(g);
        }
    }
}
