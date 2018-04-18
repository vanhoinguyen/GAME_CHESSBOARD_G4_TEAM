﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_CARO_G4_TEAM
{
    class ChessBoard
    {
        private int _NumLines;//số dòng
        private int _NumColumns;//số cột

        public ChessBoard()
        {
            _NumColumns = 0;
            _NumLines = 0;
        }
        public ChessBoard(int NumColumns, int NumLines)
        {
            _NumLines = NumLines;
            _NumColumns = NumColumns;
        }

        public void DrawChessBoard(Graphics g)
        {
            for(int i=0;i <= _NumColumns;i++)
            {
                g.DrawLine(Program.pen, i*ChessPieces._Width, 0 , i*ChessPieces._Width, _NumLines*ChessPieces._Height);
            }

            for (int j = 0; j <= _NumLines; j++)
            {
                g.DrawLine(Program.pen, 0 , j*ChessPieces._Height, _NumColumns*ChessPieces._Width, j*ChessPieces._Height);
            }
        }
    }
}
