using System;
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

        public int NumLines
        {
            get
            {
                return _NumLines;
            }

        }
        public int NumColumns
        {
            get
            {
                return _NumColumns;
            }

    
        }  
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
            for(int i=0;i <= NumColumns;i++)
            {
                g.DrawLine(CaroChess.pen, i*ChessPieces._Width, 0 , i*ChessPieces._Width, NumLines*ChessPieces._Height);
            }

            for (int j = 0; j <= NumLines; j++)
            {
                g.DrawLine(CaroChess.pen, 0 , j*ChessPieces._Height, NumColumns*ChessPieces._Width, j*ChessPieces._Height);
            }
        }   //Ve Ban Co
          public void DrawO(Graphics g, Point point)
        {           
            g.DrawEllipse(CaroChess.penO, point.X + 5, point.Y + 5, ChessPieces._Width - 10, ChessPieces._Height - 10);           
        } //Ve Quan O
        public void DrawX(Graphics g, Point point)
        {   
            g.DrawLine(CaroChess.penX, point.X + 5, point.Y + 5, point.X + 20, point.Y + 20);
            g.DrawLine(CaroChess.penX, point.X + 20, point.Y + 5, point.X + 5, point.Y + 20);          
        }  // Ve Quan X

        public void RemovePieces(Graphics g,Point p,SolidBrush sbr) 
        {
            g.FillRectangle(sbr, p.X+1, p.Y+1, ChessPieces._Width-2, ChessPieces._Height-2);
        } //Xoa Quan Co

        
    }
}
