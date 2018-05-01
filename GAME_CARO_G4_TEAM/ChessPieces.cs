using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_CARO_G4_TEAM
{
    class ChessPieces
    {
        public const int _Width = 25;//chiều rộng
        public const int _Height = 25;//chiều cao

       
        private int _Lines;//dòng
        private int _Columns;//cột

        public int Lines
        {
            get
            {
                return _Lines;
            }

            set
            {
                _Lines = value;
            }
        }

        public int Columns
        {
            get
            {
                return _Columns;
            }

            set
            {
                _Columns = value;
            }
        }

        private Point _Location;//vị trí
        public Point Location
        {
            get
            {
                return _Location;
            }

            set
            {
                _Location = value;
            }
        }


        private int _Owned;//sở hữu
        public int Owned
        {
            get
            {
                return _Owned;
            }

            set
            {
                _Owned = value;
            }
        }
        public ChessPieces()
        { }

   
        public ChessPieces(int lines,int columns,Point location,int owned)
        {
            _Lines = lines;
            _Columns = columns;
            _Location = location;
            _Owned = owned;


        }


    }
}
