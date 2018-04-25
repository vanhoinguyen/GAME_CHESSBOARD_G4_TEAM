using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME_CARO_G4_TEAM
{
    public enum KETTHUC
    {
        HoaCo,
        Player1,
        Player2,
        COM
    }
    class CaroChess
    {
       
        public static Pen pen;
        public static Pen penX;
        public static Pen penO;
        private ChessPieces[,] _ArrayChessPieces;
        private ChessBoard _ChessBoard;
        private Stack<ChessPieces> Stack_CacNuocDaDi;
        private Stack<ChessPieces> Stack_CacNuocUndo;
        private int _LuotDi;
        private bool _SanSang;
        SolidBrush sbrWhite;
        private KETTHUC _KetThuc;
        public bool SanSang { get => _SanSang;  }
       

        public CaroChess()
        {
            pen = new Pen(Color.Black);
            penX = new Pen(Color.Blue,3f);
            penO = new Pen(Color.Red,3f);
            Stack_CacNuocDaDi = new Stack<ChessPieces>();
            Stack_CacNuocUndo = new Stack<ChessPieces>();
            _LuotDi = 1;
            sbrWhite = new SolidBrush(Color.White);
            _ChessBoard = new ChessBoard(24, 21);
            _ArrayChessPieces = new ChessPieces[_ChessBoard.NumLines, _ChessBoard.NumColumns];
        }
        public void DrawChessBoard(Graphics g)
        {
            _ChessBoard.DrawChessBoard(g);
        }  // Vẽ Bàn Cờ
        public void InitializationArrayChessPieces()
        {
            for(int i=0;i<_ChessBoard.NumLines;i++)
            {
                for(int j=0;j<_ChessBoard.NumColumns;j++)
                {
                    _ArrayChessPieces[i, j] = new ChessPieces(i,j,new Point(j*ChessPieces._Width,i*ChessPieces._Height),0);
                }
            }
        }     // Khởi tạo mảng quân cờ
        public bool ChessPlay(int MouseX, int MouseY, Graphics g,TextBox playername)
        {
            if (MouseX % ChessPieces._Width == 0 || MouseY % ChessPieces._Height == 0)
                return false;
            int Columns = MouseX / ChessPieces._Width;
            int Lines = MouseY / ChessPieces._Height;

            if (_ArrayChessPieces[Lines, Columns].Owned != 0)
                return false;

            switch(_LuotDi)
            {
                case 1:
                    _ArrayChessPieces[Lines, Columns].Owned = 1;
                    playername.Text= "Người chơi 1";
                   
                    _ChessBoard.DrawX(g, _ArrayChessPieces[Lines, Columns].Location);
                    _LuotDi = 2;
                    break;
                case 2:
                    _ArrayChessPieces[Lines, Columns].Owned = 2;
                   playername.Text = "Người chơi 2";
                    
                    _ChessBoard.DrawO(g, _ArrayChessPieces[Lines, Columns].Location);
                    _LuotDi = 1;
                    break;
                default:
                    MessageBox.Show("Có lỗi");
                    break;
            }
            Stack_CacNuocUndo = new Stack<ChessPieces>();
            ChessPieces chesspieces = new ChessPieces(_ArrayChessPieces[Lines, Columns].Lines, _ArrayChessPieces[Lines, Columns].Columns, _ArrayChessPieces[Lines, Columns].Location, _ArrayChessPieces[Lines, Columns].Owned);
            Stack_CacNuocDaDi.Push(_ArrayChessPieces[Lines, Columns]);
            return true;
        }   // Chức năng đánh cờ
        public void ReDrawChessPieces(Graphics g)
        {
            foreach(ChessPieces chesspieces in Stack_CacNuocDaDi)
            {
                if (chesspieces.Owned == 1)
                    _ChessBoard.DrawX(g, chesspieces.Location);
                else if(chesspieces.Owned==2)
                {
                    _ChessBoard.DrawO(g, chesspieces.Location);
                }
            }
        }   //Vẽ lại quân cơ
        public void StartPvsP(Graphics g)
        {
            _SanSang = true;
            Stack_CacNuocDaDi = new Stack<ChessPieces>();
            Stack_CacNuocUndo = new Stack<ChessPieces>();
            _LuotDi = 1;
            InitializationArrayChessPieces();
            DrawChessBoard(g);
        }        //Chức năng chơi với người
        public void Undo(Graphics g)
        {
            if(Stack_CacNuocDaDi.Count!=0)
            {
                ChessPieces chessPieces = Stack_CacNuocDaDi.Pop();
                Stack_CacNuocUndo.Push(new ChessPieces(chessPieces.Lines,chessPieces.Columns,chessPieces.Location,chessPieces.Owned));
                _ArrayChessPieces[chessPieces.Lines, chessPieces.Columns].Owned = 0;
                _ChessBoard.RemovePieces(g, chessPieces.Location, sbrWhite);

                if (_LuotDi == 1)
                    _LuotDi = 2;
                else
                    _LuotDi = 1;
            }
                       
        }  //Undo
        public void Redo(Graphics g)
        {
            if (Stack_CacNuocUndo.Count != 0)
            {
                ChessPieces chessPieces = Stack_CacNuocUndo.Pop();
                Stack_CacNuocDaDi.Push(new ChessPieces(chessPieces.Lines, chessPieces.Columns, chessPieces.Location, chessPieces.Owned));
                _ArrayChessPieces[chessPieces.Lines, chessPieces.Columns].Owned = chessPieces.Owned;
               if(chessPieces.Owned==1)
                {
                    _ChessBoard.DrawX(g, _ArrayChessPieces[chessPieces.Lines,chessPieces.Columns].Location);
                }
               else 
                {
                    _ChessBoard.DrawO(g, _ArrayChessPieces[chessPieces.Lines, chessPieces.Columns].Location);
                }
                if (_LuotDi == 1)
                    _LuotDi = 2;
                else
                    _LuotDi = 1;
            }
        }  //Redo

        #region Duyệt chiến thắng
        public void KetThucTroChoi()
        {
            switch(_KetThuc)
            {
                case KETTHUC.HoaCo:
                    MessageBox.Show("Hòa Cờ");
                    break;
                case KETTHUC.Player1:
                    MessageBox.Show("Nguời chơi 1 thắng");
                    break;
                case KETTHUC.Player2:
                    MessageBox.Show("Người chơi 2 thắng");
                    break;
                case KETTHUC.COM:
                    MessageBox.Show("Máy thắng");
                    break;
                   
            }
            _SanSang = false;
        }
        private bool DuyetDoc(int CurrLine,int CurrColumn,int CurrOwned)
        {
            if (CurrLine > _ChessBoard.NumLines - 5)
                return false;
            int Count;
            for(Count=1;Count<5;Count++)
            {
                if (_ArrayChessPieces[CurrLine + Count, CurrColumn].Owned != CurrOwned)
                    return false;
            }
            if (CurrLine == 0||CurrLine+Count==_ChessBoard.NumLines)
                return true;

            if (_ArrayChessPieces[CurrLine - 1, CurrColumn].Owned == 0 || _ArrayChessPieces[CurrLine + Count, CurrColumn].Owned == 0)
                return true;

            return false;
        }
        private bool DuyetNgang(int CurrLine, int CurrColumn, int CurrOwned)
        {
            if (CurrColumn > _ChessBoard.NumColumns - 5)
                return false;
            int Count;
            for (Count = 1; Count < 5; Count++)
            {
                if (_ArrayChessPieces[CurrLine , CurrColumn + Count].Owned != CurrOwned)
                    return false;
            }
            if (CurrColumn == 0 || CurrColumn + Count == _ChessBoard.NumColumns)
                return true;

            if (_ArrayChessPieces[CurrLine , CurrColumn - 1].Owned == 0 || _ArrayChessPieces[CurrLine , CurrColumn + Count].Owned == 0)
                return true;

            return false;
        }
        private bool DuyetCheoXuoi(int CurrLine, int CurrColumn, int CurrOwned)
        {
            if (CurrColumn > _ChessBoard.NumColumns - 5  || CurrLine>_ChessBoard.NumLines-5)
                return false;
            int Count;
            for (Count = 1; Count < 5; Count++)
            {
                if (_ArrayChessPieces[CurrLine+Count, CurrColumn + Count].Owned != CurrOwned)
                    return false;
            }
            if (CurrColumn == 0||CurrColumn+Count==_ChessBoard.NumColumns ||CurrLine==0|| CurrLine + Count == _ChessBoard.NumLines)
                return true;

            if (_ArrayChessPieces[CurrLine-1, CurrColumn - 1].Owned == 0 || _ArrayChessPieces[CurrLine+Count, CurrColumn + Count].Owned == 0)
                return true;

            return false;
        }
        private bool DuyetCheoNguoc(int CurrLine, int CurrColumn, int CurrOwned)
        {
            if (CurrColumn > _ChessBoard.NumColumns - 5 || CurrLine <4  )
                return false;
            int Count;
            for (Count = 1; Count < 5; Count++)
            {
                if (_ArrayChessPieces[CurrLine - Count, CurrColumn + Count].Owned != CurrOwned)
                    return false;
            }
            if ( CurrLine==4||CurrLine==_ChessBoard.NumLines-1||CurrColumn==0||CurrColumn+Count==_ChessBoard.NumColumns)
                return true;

            if (_ArrayChessPieces[CurrLine + 1, CurrColumn - 1].Owned == 0 || _ArrayChessPieces[CurrLine - Count, CurrColumn + Count].Owned == 0)
                return true;

            return false;
        }


        public bool KiemTraChienThang()
        {
            if (Stack_CacNuocDaDi.Count == _ChessBoard.NumColumns * _ChessBoard.NumLines)
            {
                _KetThuc = KETTHUC.HoaCo;
                return true;
            }

            foreach(ChessPieces chesspieces in Stack_CacNuocDaDi)
            {
                if(DuyetDoc(chesspieces.Lines,chesspieces.Columns,chesspieces.Owned)||DuyetNgang(chesspieces.Lines,chesspieces.Columns,chesspieces.Owned)|| DuyetCheoNguoc(chesspieces.Lines, chesspieces.Columns, chesspieces.Owned)|| DuyetCheoXuoi(chesspieces.Lines, chesspieces.Columns, chesspieces.Owned)) 
                {
                    _KetThuc = chesspieces.Owned == 1 ? KETTHUC.Player1 : KETTHUC.Player2;
                    return true;
                }
            }

            return false;
        }
        #endregion


    }
}
