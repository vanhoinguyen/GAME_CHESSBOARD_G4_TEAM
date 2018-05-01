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
        private int _CheDoChoi;


        public bool SanSang { get => _SanSang;  }
        public int CheDoChoi { get => _CheDoChoi;  }
       

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
            _CheDoChoi = 1;
            InitializationArrayChessPieces();
            DrawChessBoard(g);
        }        //Chức năng chơi với người
        public void StartPvsCom(Graphics g,TextBox PlayerName)
        {
            _SanSang = true;
            Stack_CacNuocDaDi = new Stack<ChessPieces>();
            Stack_CacNuocUndo = new Stack<ChessPieces>();
            _LuotDi = 1;
            _CheDoChoi = 2;
            InitializationArrayChessPieces();
            DrawChessBoard(g);
            StartComputer(g,PlayerName);
        }
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


        #region AI
        private long[] MangDiemTanCong = new long[7] {0,3,24,192,1536,12288,98304};
        private long[] MangDiemPhongThu = new long[7] { 0,1,9,81,729,6561,59049};



        public void StartComputer(Graphics g, TextBox PlayerName)
        {
            if (Stack_CacNuocDaDi.Count == 0)
            {
                ChessPlay(_ChessBoard.NumLines / 2 * ChessPieces._Height + 1, _ChessBoard.NumColumns / 2 * ChessPieces._Width + 1, g, PlayerName);
            }
            else
            {
                ChessPieces chesspieces = TimKiemNuocDi();
                ChessPlay(chesspieces.Location.X+1,chesspieces.Location.Y+1,g,PlayerName);

            }
        }

        private ChessPieces TimKiemNuocDi()
        {
            ChessPieces result = new ChessPieces();
            long PointMax = 0;
            for(int i=0;i<_ChessBoard.NumLines;i++)
            {
                for(int j=0;j<_ChessBoard.NumColumns;j++)
                {
                    if(_ArrayChessPieces[i,j].Owned==0)
                    {
                        long DiemTanCong = DiemTanCong_DuyetDoc(i,j) + DiemTanCong_DuyetNgang(i, j) + DiemTanCong_DuyetCheoNguoc(i, j) + DiemTanCong_DuyetCheoXuoi(i, j);
                        long DiemPhongNgu= DiemPhongNgu_DuyetDoc(i, j) + DiemPhongNgu_DuyetNgang(i, j) + DiemPhongNgu_DuyetCheoNguoc(i, j) + DiemPhongNgu_DuyetCheoXuoi(i, j);
                        long DiemTam = DiemTanCong > DiemPhongNgu ? DiemTanCong : DiemPhongNgu;
                        if(PointMax<DiemTam)
                        {
                            PointMax = DiemTam;
                            result = new ChessPieces(_ArrayChessPieces[i, j].Lines, _ArrayChessPieces[i, j].Columns, _ArrayChessPieces[i, j].Location, _ArrayChessPieces[i, j].Owned);

                        }
                    }
                }
            }

            return result;
        }
        #region TanCong
        private long DiemTanCong_DuyetDoc(int CurrLine,int CurrColumn)
        {
            long DiemTong = 0;
            int SoQuanDich = 0;
            int SoQuanTa = 0;
            for(int dem=1;dem<6&&CurrLine+dem<_ChessBoard.NumLines;dem++)
            {
                if (_ArrayChessPieces[CurrLine + dem, CurrColumn].Owned == 1)
                    SoQuanTa++;
                else if(_ArrayChessPieces[CurrLine + dem, CurrColumn].Owned == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }

            }

            for (int dem = 0; dem < 6 && CurrLine - dem >= 0; dem++)
            {
                if (_ArrayChessPieces[CurrLine - dem, CurrColumn].Owned == 1)
                    SoQuanTa++;
                else if (_ArrayChessPieces[CurrLine - dem, CurrColumn].Owned == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }

            }
            if (SoQuanDich == 2)
                return 0;
            DiemTong -= MangDiemPhongThu[SoQuanDich+1];
            DiemTong += MangDiemTanCong[SoQuanTa];
            return DiemTong;
        }
        private long DiemTanCong_DuyetNgang(int CurrLine, int CurrColumn)
        {
            long DiemTong = 0;
            int SoQuanDich = 0;
            int SoQuanTa = 0;
            for (int dem = 0; dem < 6 && CurrColumn + dem < _ChessBoard.NumColumns; dem++)
            {
                if (_ArrayChessPieces[CurrLine , CurrColumn + dem].Owned == 1)
                    SoQuanTa++;
                else if (_ArrayChessPieces[CurrLine , CurrColumn + dem].Owned == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }

            }

            for (int dem = 0; dem < 6 && CurrColumn - dem >= 0; dem++)
            {
                if (_ArrayChessPieces[CurrLine , CurrColumn - dem].Owned == 1)
                    SoQuanTa++;
                else if (_ArrayChessPieces[CurrLine , CurrColumn - dem].Owned == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }

            }
            if (SoQuanDich == 2)
                return 0;
            DiemTong -= MangDiemPhongThu[SoQuanDich + 1];
            DiemTong += MangDiemTanCong[SoQuanTa];
            return DiemTong;
        }
        private long DiemTanCong_DuyetCheoNguoc(int CurrLine, int CurrColumn)
        {
            long DiemTong = 0;
            int SoQuanDich = 0;
            int SoQuanTa = 0;
            for (int dem = 0; dem < 6 && CurrColumn + dem < _ChessBoard.NumColumns&&CurrLine-dem>=0; dem++)
            {
                if (_ArrayChessPieces[CurrLine-dem, CurrColumn + dem].Owned == 1)
                    SoQuanTa++;
                else if (_ArrayChessPieces[CurrLine-dem, CurrColumn + dem].Owned == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }

            }

            for (int dem = 0; dem < 6 && CurrColumn - dem >= 0&&CurrLine+dem<_ChessBoard.NumLines; dem++)
            {
                if (_ArrayChessPieces[CurrLine+dem, CurrColumn - dem].Owned == 1)
                    SoQuanTa++;
                else if (_ArrayChessPieces[CurrLine+dem, CurrColumn - dem].Owned == 2)
                {
                    SoQuanDich++;   
                    break;
                }
                else
                {
                    break;
                }

            }
            if (SoQuanDich == 2)
                return 0;
            DiemTong -= MangDiemPhongThu[SoQuanDich + 1];
            DiemTong += MangDiemTanCong[SoQuanTa];
            return DiemTong;
        }
        private long DiemTanCong_DuyetCheoXuoi(int CurrLine, int CurrColumn)
        {
            long DiemTong = 0;
            int SoQuanDich = 0;
            int SoQuanTa = 0;
            for (int dem = 0; dem < 6 && CurrColumn + dem < _ChessBoard.NumColumns && CurrLine + dem <= _ChessBoard.NumLines; dem++)
            {
                if (_ArrayChessPieces[CurrLine + dem, CurrColumn + dem].Owned == 1)
                    SoQuanTa++;
                else if (_ArrayChessPieces[CurrLine + dem, CurrColumn + dem].Owned == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }

            }

            for (int dem = 0; dem < 6 && CurrColumn - dem >= 0 && CurrLine - dem >= 0; dem++)
            {
                if (_ArrayChessPieces[CurrLine - dem, CurrColumn - dem].Owned == 1)
                    SoQuanTa++;
                else if (_ArrayChessPieces[CurrLine - dem, CurrColumn - dem].Owned == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }

            }
            if (SoQuanDich == 2)
                return 0;
            DiemTong -= MangDiemPhongThu[SoQuanDich + 1];
            DiemTong += MangDiemTanCong[SoQuanTa];
            return DiemTong;
        }
        #endregion

        #region PhongNgu
        private long DiemPhongNgu_DuyetDoc(int CurrLine, int CurrColumn)
        {
            long DiemTong = 0;
            int SoQuanDich = 0;
            int SoQuanTa = 0;
            for (int dem = 0; dem < 6 && CurrLine + dem < _ChessBoard.NumLines; dem++)
            {
                if (_ArrayChessPieces[CurrLine + dem, CurrColumn].Owned == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_ArrayChessPieces[CurrLine + dem, CurrColumn].Owned == 2)
                {
                    SoQuanDich++;
                   
                }
                else
                {
                    break;
                }

            }

            for (int dem = 0; dem < 6 && CurrLine - dem >= 0; dem++)
            {
                if (_ArrayChessPieces[CurrLine - dem, CurrColumn].Owned == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_ArrayChessPieces[CurrLine - dem, CurrColumn].Owned == 2)
                {
                    SoQuanDich++;
                   
                }
                else
                {
                    break;
                }

            }
            if (SoQuanTa == 2)
                return 0;
            DiemTong += MangDiemPhongThu[SoQuanDich ];
           
            return DiemTong;
        }
        private long DiemPhongNgu_DuyetNgang(int CurrLine, int CurrColumn)
        {
            long DiemTong = 0;
            int SoQuanDich = 0;
            int SoQuanTa = 0;
            for (int dem = 0; dem < 6 && CurrColumn + dem < _ChessBoard.NumColumns; dem++)
            {
                if (_ArrayChessPieces[CurrLine, CurrColumn + dem].Owned == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_ArrayChessPieces[CurrLine, CurrColumn + dem].Owned == 2)
                {
                    SoQuanDich++;
                    
                }
                else
                {
                    break;
                }

            }

            for (int dem = 0; dem < 6 && CurrColumn - dem >= 0; dem++)
            {
                if (_ArrayChessPieces[CurrLine, CurrColumn - dem].Owned == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_ArrayChessPieces[CurrLine, CurrColumn - dem].Owned == 2)
                {
                    SoQuanDich++;
                   
                }
                else
                {
                    break;
                }

            }
            if (SoQuanTa == 2)
                return 0;
            DiemTong += MangDiemPhongThu[SoQuanDich];
            
            return DiemTong;
        }
        private long DiemPhongNgu_DuyetCheoNguoc(int CurrLine, int CurrColumn)
        {
            long DiemTong = 0;
            int SoQuanDich = 0;
            int SoQuanTa = 0;
            for (int dem = 0; dem < 6 && CurrColumn + dem < _ChessBoard.NumColumns && CurrLine - dem >= 0; dem++)
            {
                if (_ArrayChessPieces[CurrLine - dem, CurrColumn + dem].Owned == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_ArrayChessPieces[CurrLine - dem, CurrColumn + dem].Owned == 2)
                {
                    SoQuanDich++;
                 
                }
                else
                {
                    break;
                }

            }

            for (int dem = 0; dem < 6 && CurrColumn - dem >= 0 && CurrLine + dem < _ChessBoard.NumLines; dem++)
            {
                if (_ArrayChessPieces[CurrLine + dem, CurrColumn - dem].Owned == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_ArrayChessPieces[CurrLine + dem, CurrColumn - dem].Owned == 2)
                {
                    SoQuanDich++;
                  
                }
                else
                {
                    break;
                }

            }
            if (SoQuanTa == 2)
                return 0;
           
            DiemTong += MangDiemPhongThu[SoQuanTa];
            return DiemTong;
        }
        private long DiemPhongNgu_DuyetCheoXuoi(int CurrLine, int CurrColumn)
        {
            long DiemTong = 0;
            int SoQuanDich = 0;
            int SoQuanTa = 0;
            for (int dem = 0; dem < 6 && CurrColumn + dem < _ChessBoard.NumColumns && CurrLine + dem <= _ChessBoard.NumLines; dem++)
            {
                if (_ArrayChessPieces[CurrLine + dem, CurrColumn + dem].Owned == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_ArrayChessPieces[CurrLine + dem, CurrColumn + dem].Owned == 2)
                {
                    SoQuanDich++;

                }
                else
                {
                    break;
                }

            }

            for (int dem = 0; dem < 6 && CurrColumn - dem >= 0 && CurrLine - dem >= 0; dem++)
            {
                if (_ArrayChessPieces[CurrLine - dem, CurrColumn - dem].Owned == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_ArrayChessPieces[CurrLine - dem, CurrColumn - dem].Owned == 2)
                {
                    SoQuanDich++;
                   
                }
                else
                {
                    break;
                }

            }
            if (SoQuanDich == 2)
                return 0;

            DiemTong += MangDiemPhongThu[SoQuanTa];
            return DiemTong;
        }
        #endregion


        #endregion


    }
}
