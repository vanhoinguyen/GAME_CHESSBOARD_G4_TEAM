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
        private OCo[,] _MangOCo;
        private BanCo _BanCo;
        private Stack<OCo> Stack_CacNuocDaDi;
        private Stack<OCo> Stack_CacNuocUndo;
        private int _LuotDi;
        private bool _SanSang;
        SolidBrush sbrWhite;
        private KETTHUC _KetThuc;
        private int _CheDoChoi;


        public bool SanSang { get { return _SanSang; } }
        public int CheDoChoi { get { return _CheDoChoi; } }
       

        public CaroChess()
        {
            pen = new Pen(Color.Black);
            penX = new Pen(Color.Blue,3f);
            penO = new Pen(Color.Red,3f);
            Stack_CacNuocDaDi = new Stack<OCo>();
            Stack_CacNuocUndo = new Stack<OCo>();
            _LuotDi = 1;
            sbrWhite = new SolidBrush(Color.White);
            _BanCo = new BanCo(24, 21);
            _MangOCo = new OCo[_BanCo.NumDong, _BanCo.NumCot];
        }
        public void VeBanCo(Graphics g)
        {
            _BanCo.VeBanCo(g);
        }  // Vẽ Bàn Cờ
        public void KhoiTaoMangOCo()
        {
            for(int i=0;i<_BanCo.NumDong;i++)
            {
                for(int j=0;j<_BanCo.NumCot;j++)
                {
                    _MangOCo[i, j] = new OCo(i,j,new Point(j*OCo._ChieuRong,i*OCo._ChieuCao),0);
                }
            }
        }     // Khởi tạo mảng quân cờ
        public bool DanhCo(int MouseX, int MouseY, Graphics g,TextBox playername)
        {
            if (MouseX % OCo._ChieuRong == 0 || MouseY % OCo._ChieuCao == 0)
                return false;
            int Cot = MouseX / OCo._ChieuRong;
            int Dong = MouseY / OCo._ChieuCao;

            if (_MangOCo[Dong, Cot].SoHuu != 0)
                return false;

            switch(_LuotDi)
            {
                case 1:
                    _MangOCo[Dong, Cot].SoHuu = 1;
                    playername.Text= "Người chơi 1";
                   
                    _BanCo.VeX(g, _MangOCo[Dong, Cot].ViTri);
                    _LuotDi = 2;
                    break;
                case 2:
                    _MangOCo[Dong, Cot].SoHuu = 2;
                   playername.Text = "Người chơi 2";
                    
                    _BanCo.VeO(g, _MangOCo[Dong, Cot].ViTri);
                    _LuotDi = 1;
                    break;
                default:
                    MessageBox.Show("Có lỗi");
                    break;
            }
            Stack_CacNuocUndo = new Stack<OCo>();
            OCo oco = new OCo(_MangOCo[Dong, Cot].Dong, _MangOCo[Dong, Cot].Cot, _MangOCo[Dong, Cot].ViTri, _MangOCo[Dong, Cot].SoHuu);
            Stack_CacNuocDaDi.Push(_MangOCo[Dong, Cot]);
            return true;
        }   // Chức năng đánh cờ
        public void VeLaiOCo(Graphics g)
        {
            foreach(OCo oco in Stack_CacNuocDaDi)
            {
                if (oco.SoHuu == 1)
                    _BanCo.VeX(g, oco.ViTri);
                else if(oco.SoHuu==2)
                {
                    _BanCo.VeO(g, oco.ViTri);
                }
            }
        }   //Vẽ lại quân cơ
        public void StartPvsP(Graphics g)
        {
            _SanSang = true;
            Stack_CacNuocDaDi = new Stack<OCo>();
            Stack_CacNuocUndo = new Stack<OCo>();
            _LuotDi = 1;
            _CheDoChoi = 1;
            KhoiTaoMangOCo();
            VeBanCo(g);
        }        //Chức năng chơi với người
        public void StartPvsCom(Graphics g ,TextBox playername)
        {
            _SanSang = true;
            Stack_CacNuocDaDi = new Stack<OCo>();
            Stack_CacNuocUndo = new Stack<OCo>();
            _LuotDi = 1;
            _CheDoChoi = 2;
            KhoiTaoMangOCo();
            VeBanCo(g);
            KhoiDongMay(g,playername);
        }
        public void Undo(Graphics g)
        {
            if(Stack_CacNuocDaDi.Count!=0)
            {
                OCo oco = Stack_CacNuocDaDi.Pop();
                Stack_CacNuocUndo.Push(new OCo(oco.Dong,oco.Cot,oco.ViTri,oco.SoHuu));
                _MangOCo[oco.Dong, oco.Cot].SoHuu = 0;
                _BanCo.XoaOCo(g, oco.ViTri, sbrWhite);

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
                OCo oco = Stack_CacNuocUndo.Pop();
                Stack_CacNuocDaDi.Push(new OCo(oco.Dong, oco.Cot, oco.ViTri, oco.SoHuu));
                _MangOCo[oco.Dong, oco.Cot].SoHuu = oco.SoHuu;
               if(oco.SoHuu==1)
                {
                    _BanCo.VeX(g, _MangOCo[oco.Dong,oco.Cot].ViTri);
                }
               else 
                {
                    _BanCo.VeO(g, _MangOCo[oco.Dong, oco.Cot].ViTri);
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
        private bool DuyetDoc(int iDong,int iCot,int iSoHuu)
        {
            if (iDong > _BanCo.NumDong - 5)
                return false;
            int Count;
            for(Count=1;Count<5;Count++)
            {
                if (_MangOCo[iDong + Count, iCot].SoHuu != iSoHuu)
                    return false;
            }
            if (iDong == 0||iDong+Count==_BanCo.NumDong)
                return true;

            if (_MangOCo[iDong - 1, iCot].SoHuu == 0 || _MangOCo[iDong + Count, iCot].SoHuu == 0)
                return true;

            return false;
        }
        private bool DuyetNgang(int iDong, int iCot, int iSoHuu)
        {
            if (iCot > _BanCo.NumCot - 5)
                return false;
            int Count;
            for (Count = 1; Count < 5; Count++)
            {
                if (_MangOCo[iDong , iCot + Count].SoHuu != iSoHuu)
                    return false;
            }
            if (iCot == 0 || iCot + Count == _BanCo.NumCot)
                return true;

            if (_MangOCo[iDong , iCot - 1].SoHuu == 0 || _MangOCo[iDong , iCot + Count].SoHuu == 0)
                return true;

            return false;
        }
        private bool DuyetCheoXuoi(int iDong, int iCot, int iSoHuu)
        {
            if (iCot > _BanCo.NumCot - 5  || iDong>_BanCo.NumDong-5)
                return false;
            int Count;
            for (Count = 1; Count < 5; Count++)
            {
                if (_MangOCo[iDong+Count, iCot + Count].SoHuu != iSoHuu)
                    return false;
            }
            if (iCot == 0||iCot+Count==_BanCo.NumCot ||iDong==0|| iDong + Count == _BanCo.NumDong)
                return true;

            if (_MangOCo[iDong-1, iCot - 1].SoHuu == 0 || _MangOCo[iDong+Count, iCot + Count].SoHuu == 0)
                return true;

            return false;
        }
        private bool DuyetCheoNguoc(int iDong, int iCot, int iSoHuu)
        {
            if (iCot > _BanCo.NumCot - 5 || iDong <4  )
                return false;
            int Count;
            for (Count = 1; Count < 5; Count++)
            {
                if (_MangOCo[iDong - Count, iCot + Count].SoHuu != iSoHuu)
                    return false;
            }
            if ( iDong==4||iDong==_BanCo.NumDong-1||iCot==0||iCot+Count==_BanCo.NumCot)
                return true;

            if (_MangOCo[iDong + 1, iCot - 1].SoHuu == 0 || _MangOCo[iDong - Count, iCot + Count].SoHuu == 0)
                return true;

            return false;
        }


        public bool KiemTraChienThang()
        {
            if (Stack_CacNuocDaDi.Count == _BanCo.NumCot * _BanCo.NumDong)
            {
                _KetThuc = KETTHUC.HoaCo;
                return true;
            }

            foreach(OCo oco in Stack_CacNuocDaDi)
            {
                if(DuyetDoc(oco.Dong,oco.Cot,oco.SoHuu)||DuyetNgang(oco.Dong,oco.Cot,oco.SoHuu)|| DuyetCheoNguoc(oco.Dong, oco.Cot, oco.SoHuu)|| DuyetCheoXuoi(oco.Dong, oco.Cot, oco.SoHuu)) 
                {
                    _KetThuc = oco.SoHuu == 1 ? KETTHUC.Player1 : KETTHUC.Player2;
                    return true;
                }
            }

            return false;
        }
        #endregion




        //{0,64,4096,262144,16777216,1073741824}
        //{0,8,512,32768,2097152,134217728}
        //level hard

        #region AI levels Normal

        private long[] MangDiemTanCong = new long[7] { 0, 3, 24, 192, 1536, 12288, 98304 }; //Điểm tấn công
        private long[] MangDiemPhongNgu = new long[7] { 0, 1, 9, 81, 729, 6561, 59049 }; // Điểm phòng thủ
        public void KhoiDongMay(Graphics g, TextBox playername)
        {
            if (Stack_CacNuocDaDi.Count == 0)
            {
                DanhCo(_BanCo.NumDong / 2 * OCo._ChieuCao + 1, _BanCo.NumCot / 2 * OCo._ChieuRong + 1, g, playername);
            }
            else
            {
                OCo _o_co = TimKiemNuocDi();
                DanhCo(_o_co.ViTri.X + 1, _o_co.ViTri.Y + 1, g, playername);
            }

        }
        private OCo TimKiemNuocDi()
        {
            OCo kq = new OCo();
            long DiemMax = 0;
            for (int i = 0; i < _BanCo.NumDong; i++)
            {
                for (int j = 0; j < _BanCo.NumCot; j++)
                {
                    if (_MangOCo[i, j].SoHuu == 0)
                    {
                        long DiemTanCong = DiemTanCong_DuyetDoc(i, j) + DiemTanCong_DuyetNgang(i, j) + DiemTanCong_DuyetCheoXuoi(i, j) + DiemTanCong_DuyetCheoNguoc(i, j);
                        long DiemPhongNgu = DiemPhongNgu_DuyetNgang(i, j) + DiemPhongNgu_DuyetDoc(i, j) + DiemPhongNgu_DuyetCheoXuoi(i, j) + DiemPhongNgu_DuyetCheoNguoc(i, j);
                        long DiemTam = DiemTanCong > DiemPhongNgu ? DiemTanCong : DiemPhongNgu;
                        long DiemTong = (DiemPhongNgu + DiemTanCong) > DiemTam ? (DiemPhongNgu + DiemTanCong) : DiemTam;
                        if (DiemMax < DiemTong)
                        {
                            DiemMax = DiemTong;
                            kq = new OCo(_MangOCo[i, j].Dong, _MangOCo[i, j].Cot, _MangOCo[i, j].ViTri, _MangOCo[i, j].SoHuu);
                        }
                    }
                }
            }
            return kq;
        }
        // Duyệt điểm tấn công
        #region DuyetDiemTanCong
        private long DiemTanCong_DuyetDoc(int iDong, int iCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            int SoQuanTa2 = 0;
            int SoQuanDich2 = 0;
            if (iDong + 1 < _BanCo.NumDong && _MangOCo[iDong + 1, iCot].SoHuu == 0)
            {

            }
            if (iDong > 0 && _MangOCo[iDong - 1, iCot].SoHuu == 0)
            {

            }
            //
            for (int dem = 1; dem < 5 && iDong + dem < _BanCo.NumDong; dem++)
            {
                if (_MangOCo[iDong + dem, iCot].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[iDong + dem, iCot].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else // SoHuu = 0
                {
                    for (int dem2 = 2; dem2 < 6 && iDong + dem2 < _BanCo.NumDong; dem2++)
                        if (_MangOCo[iDong + dem2, iCot].SoHuu == 1)
                        {
                            SoQuanTa2++;
                        }
                        else if (_MangOCo[iDong + dem2, iCot].SoHuu == 2)
                        {
                            SoQuanDich2++;
                            break;
                        }
                        else
                            break;
                    break;
                }
            }
            for (int dem = 1; dem < 5 && iDong - dem >= 0; dem++)
            {
                if (_MangOCo[iDong - dem, iCot].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[iDong - dem, iCot].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else // SoHuu = 0
                {
                    for (int dem2 = 2; dem2 < 6 && iDong - dem2 >= 0; dem2++)
                        if (_MangOCo[iDong - dem2, iCot].SoHuu == 1)
                        {
                            SoQuanTa2++;
                        }
                        else if (_MangOCo[iDong - dem2, iCot].SoHuu == 2)
                        {
                            SoQuanDich2++;
                            break;
                        }
                        else
                            break;
                    break;
                }
            }
            if (SoQuanDich == 2)
                return 0;
            if (SoQuanDich == 0)
                DiemTong += MangDiemTanCong[SoQuanTa] * 2;
            else
                DiemTong += MangDiemTanCong[SoQuanTa];
            if (SoQuanDich2 == 0)
                DiemTong += MangDiemTanCong[SoQuanTa2] * 2;
            else
                DiemTong += MangDiemTanCong[SoQuanTa2];
            if (SoQuanTa >= SoQuanTa2)
                DiemTong -= 1;
            else
                DiemTong -= 2;
            if (SoQuanTa == 4)
                DiemTong *= 2;
            if (SoQuanTa == 0)
                DiemTong += MangDiemPhongNgu[SoQuanDich] * 2;
            else
                DiemTong += MangDiemPhongNgu[SoQuanDich];
            if (SoQuanTa2 == 0)
                DiemTong += MangDiemPhongNgu[SoQuanDich2] * 2;
            else
                DiemTong += MangDiemPhongNgu[SoQuanDich2];
            return DiemTong;
        }
        private long DiemTanCong_DuyetNgang(int iDong, int iCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            int SoQuanTa2 = 0;
            int SoQuanDich2 = 0;
            if (iCot + 1 < _BanCo.NumCot && _MangOCo[iDong, iCot + 1].SoHuu == 0)
            {

            }
            if (iCot > 0 && _MangOCo[iDong, iCot - 1].SoHuu == 0)
            {

            }
            //
            for (int dem = 1; dem < 5 && iCot + dem < _BanCo.NumCot; dem++)
            {
                if (_MangOCo[iDong, iCot + dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[iDong, iCot + dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else // SoHuu = 0
                {
                    for (int dem2 = 2; dem2 < 6 && iCot + dem2 < _BanCo.NumCot; dem2++)
                        if (_MangOCo[iDong, iCot + dem2].SoHuu == 1)
                        {
                            SoQuanTa2++;
                        }
                        else if (_MangOCo[iDong, iCot + dem2].SoHuu == 2)
                        {
                            SoQuanDich2++;
                            break;
                        }
                        else
                            break;
                    break;
                }
            }
            for (int dem = 1; dem < 5 && iCot - dem >= 0; dem++)
            {
                if (_MangOCo[iDong, iCot - dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[iDong, iCot - dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else // SoHuu = 0
                {
                    for (int dem2 = 2; dem2 < 6 && iCot - dem2 >= 0; dem2++)
                        if (_MangOCo[iDong, iCot - dem2].SoHuu == 1)
                        {
                            SoQuanTa2++;
                        }
                        else if (_MangOCo[iDong, iCot - dem2].SoHuu == 2)
                        {
                            SoQuanDich2++;
                            break;
                        }
                        else
                            break;
                    break;
                }
            }
            if (SoQuanDich == 2)
                return 0;
            if (SoQuanDich == 0)
                DiemTong += MangDiemTanCong[SoQuanTa] * 2;
            else
                DiemTong += MangDiemTanCong[SoQuanTa];
            if (SoQuanDich2 == 0)
                DiemTong += MangDiemTanCong[SoQuanTa2] * 2;
            else
                DiemTong += MangDiemTanCong[SoQuanTa2];
            if (SoQuanTa >= SoQuanTa2)
                DiemTong -= 1;
            else
                DiemTong -= 2;
            if (SoQuanTa == 4)
                DiemTong *= 2;
            if (SoQuanTa == 0)
                DiemTong += MangDiemPhongNgu[SoQuanDich] * 2;
            else
                DiemTong += MangDiemPhongNgu[SoQuanDich];
            if (SoQuanTa2 == 0)
                DiemTong += MangDiemPhongNgu[SoQuanDich2] * 2;
            else
                DiemTong += MangDiemPhongNgu[SoQuanDich2];
            return DiemTong;
        }
        private long DiemTanCong_DuyetCheoXuoi(int iDong, int iCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            int SoQuanTa2 = 0;
            int SoQuanDich2 = 0;
            if (iDong + 1 < _BanCo.NumDong && iCot + 1 < _BanCo.NumCot && _MangOCo[iDong + 1, iCot + 1].SoHuu == 0)
            {

            }
            if (iDong > 0 && iCot > 0 && _MangOCo[iDong - 1, iCot - 1].SoHuu == 0)
            {

            }
            //
            for (int dem = 1; dem < 5 && iCot + dem < _BanCo.NumCot && iDong + dem < _BanCo.NumDong; dem++)
            {
                if (_MangOCo[iDong + dem, iCot + dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[iDong + dem, iCot + dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else // SoHuu = 0
                {
                    for (int dem2 = 2; dem2 < 6 && iCot + dem2 < _BanCo.NumCot && iDong + dem2 < _BanCo.NumDong; dem2++)
                        if (_MangOCo[iDong + dem2, iCot + dem2].SoHuu == 1)
                        {
                            SoQuanTa2++;
                        }
                        else if (_MangOCo[iDong + dem2, iCot + dem2].SoHuu == 2)
                        {
                            SoQuanDich2++;
                            break;
                        }
                        else
                            break;
                    break;
                }
            }
            for (int dem = 1; dem < 5 && iCot - dem >= 0 && iDong - dem >= 0; dem++)
            {
                if (_MangOCo[iDong - dem, iCot - dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[iDong - dem, iCot - dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else // SoHuu = 0
                {
                    for (int dem2 = 2; dem2 < 6 && iCot - dem2 >= 0 && iDong - dem2 >= 0; dem2++)
                        if (_MangOCo[iDong - dem2, iCot - dem2].SoHuu == 1)
                        {
                            SoQuanTa2++;
                        }
                        else if (_MangOCo[iDong - dem2, iCot - dem2].SoHuu == 2)
                        {
                            SoQuanDich2++;
                            break;
                        }
                        else
                            break;
                    break;
                }
            }
            if (SoQuanDich == 2)
                return 0;
            if (SoQuanDich == 0)
                DiemTong += MangDiemTanCong[SoQuanTa] * 2;
            else
                DiemTong += MangDiemTanCong[SoQuanTa];
            if (SoQuanDich2 == 0)
                DiemTong += MangDiemTanCong[SoQuanTa2] * 2;
            else
                DiemTong += MangDiemTanCong[SoQuanTa2];
            if (SoQuanTa >= SoQuanTa2)
                DiemTong -= 1;
            else
                DiemTong -= 2;

            if (SoQuanTa == 4)
                DiemTong *= 2;
            if (SoQuanTa == 0)
                DiemTong += MangDiemPhongNgu[SoQuanDich] * 2;
            else
                DiemTong += MangDiemPhongNgu[SoQuanDich];
            if (SoQuanTa2 == 0)
                DiemTong += MangDiemPhongNgu[SoQuanDich2] * 2;
            else
                DiemTong += MangDiemPhongNgu[SoQuanDich2];
            return DiemTong;
        }
        private long DiemTanCong_DuyetCheoNguoc(int iDong, int iCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            int SoQuanTa2 = 0;
            int SoQuanDich2 = 0;
            if (iDong > 0 && iCot + 1 < _BanCo.NumCot && _MangOCo[iDong - 1, iCot + 1].SoHuu == 0)
            {

            }
            if (iDong + 1 < _BanCo.NumDong && iCot > 0 && _MangOCo[iDong + 1, iCot - 1].SoHuu == 0)
            {

            }
            //
            for (int dem = 1; dem < 5 && iCot + dem < _BanCo.NumCot && iDong - dem > 0; dem++)
            {
                if (_MangOCo[iDong - dem, iCot + dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[iDong - dem, iCot + dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else // SoHuu = 0
                {
                    for (int dem2 = 2; dem2 < 6 && iCot + dem2 < _BanCo.NumCot && iDong - dem2 > 0; dem2++)
                        if (_MangOCo[iDong - dem2, iCot + dem2].SoHuu == 1)
                        {
                            SoQuanTa2++;
                        }
                        else if (_MangOCo[iDong - dem2, iCot + dem2].SoHuu == 2)
                        {
                            SoQuanDich2++;
                            break;
                        }
                        else
                            break;
                    break;
                }
            }
            for (int dem = 1; dem < 5 && iCot - dem >= 0 && iDong + dem < _BanCo.NumDong; dem++)
            {
                if (_MangOCo[iDong + dem, iCot - dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[iDong + dem, iCot - dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else // SoHuu = 0
                {
                    for (int dem2 = 1; dem2 < 6 && iCot - dem2 >= 0 && iDong + dem2 < _BanCo.NumDong; dem2++)
                        if (_MangOCo[iDong + dem2, iCot - dem2].SoHuu == 1)
                        {
                            SoQuanTa2++;
                        }
                        else if (_MangOCo[iDong + dem2, iCot - dem2].SoHuu == 2)
                        {
                            SoQuanDich2++;
                            break;
                        }
                        else
                            break;
                    break;
                }
            }
            if (SoQuanDich == 2)
                return 0;
            if (SoQuanDich == 0)
                DiemTong += MangDiemTanCong[SoQuanTa] * 2;
            else
                DiemTong += MangDiemTanCong[SoQuanTa];
            if (SoQuanDich2 == 0)
                DiemTong += MangDiemTanCong[SoQuanTa2] * 2;
            else
                DiemTong += MangDiemTanCong[SoQuanTa2];
            if (SoQuanTa >= SoQuanTa2)
                DiemTong -= 1;
            else
                DiemTong -= 2;
            if (SoQuanTa == 4)
                DiemTong *= 2;
            if (SoQuanTa == 0)
                DiemTong += MangDiemPhongNgu[SoQuanDich] * 2;
            else
                DiemTong += MangDiemPhongNgu[SoQuanDich];
            if (SoQuanTa2 == 0)
                DiemTong += MangDiemPhongNgu[SoQuanDich2] * 2;
            else
                DiemTong += MangDiemPhongNgu[SoQuanDich2];
            return DiemTong;
        }
        #endregion
        // Duyệt điểm phòng thủ
        #region DuyetDiemPhongThu
        private long DiemPhongNgu_DuyetDoc(int iDong, int iCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            int SoQuanTa2 = 0;
            int SoQuanDich2 = 0;
            for (int dem = 1; dem < 5 && iDong + dem < _BanCo.NumDong; dem++)
            {
                if (_MangOCo[iDong + dem, iCot].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[iDong + dem, iCot].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else // SoHuu = 0
                {
                    for (int dem2 = 2; dem2 < 6 && iDong + dem2 < _BanCo.NumDong; dem2++)
                        if (_MangOCo[iDong + dem, iCot].SoHuu == 1)
                        {
                            SoQuanTa2++;
                            break;
                        }
                        else if (_MangOCo[iDong + dem, iCot].SoHuu == 2)
                        {
                            SoQuanDich2++;
                        }
                        else
                            break;
                    break;
                }
            }
            for (int dem = 1; dem < 5 && iDong - dem >= 0; dem++)
            {
                if (_MangOCo[iDong - dem, iCot].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[iDong - dem, iCot].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else // SoHuu = 0
                {
                    for (int dem2 = 2; dem2 < 6 && iDong - dem2 >= 0; dem2++)
                        if (_MangOCo[iDong - dem2, iCot].SoHuu == 1)
                        {
                            SoQuanTa2++;
                            break;
                        }
                        else if (_MangOCo[iDong - dem2, iCot].SoHuu == 2)
                        {
                            SoQuanDich2++;
                        }
                        else
                            break;
                    break;
                }
            }
            if (SoQuanTa == 2)
                return 0;
            if (SoQuanTa == 0)
                DiemTong += MangDiemPhongNgu[SoQuanDich] * 2;
            else
                DiemTong += MangDiemPhongNgu[SoQuanDich];
            /* 
            if (SoQuanTa2 == 0)
                DiemTong += MangDiemPhongNgu[SoQuanDich2] * 2;
            else
                DiemTong += MangDiemPhongNgu[SoQuanDich2];
            */
            if (SoQuanDich >= SoQuanDich2)
                DiemTong -= 1;
            else
                DiemTong -= 2;
            if (SoQuanDich == 4)
                DiemTong *= 2;
            return DiemTong;
        }
        private long DiemPhongNgu_DuyetNgang(int iDong, int iCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            int SoQuanTa2 = 0;
            int SoQuanDich2 = 0;
            for (int dem = 1; dem < 5 && iCot + dem < _BanCo.NumCot; dem++)
            {
                if (_MangOCo[iDong, iCot + dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[iDong, iCot + dem].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else // SoHuu = 0
                {
                    for (int dem2 = 2; dem2 < 6 && iCot + dem2 < _BanCo.NumCot; dem2++)
                        if (_MangOCo[iDong, iCot + dem2].SoHuu == 1)
                        {
                            SoQuanTa2++;
                            break;
                        }
                        else if (_MangOCo[iDong, iCot + dem2].SoHuu == 2)
                        {
                            SoQuanDich2++;
                        }
                        else
                            break;
                    break;
                }
            }
            for (int dem = 1; dem < 5 && iCot - dem >= 0; dem++)
            {
                if (_MangOCo[iDong, iCot - dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[iDong, iCot - dem].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else // SoHuu = 0
                {
                    for (int dem2 = 2; dem2 < 6 && iCot - dem2 >= 0; dem2++)
                        if (_MangOCo[iDong, iCot - dem2].SoHuu == 1)
                        {
                            SoQuanTa2++;
                            break;
                        }
                        else if (_MangOCo[iDong, iCot - dem2].SoHuu == 2)
                        {
                            SoQuanDich2++;
                        }
                        else break;
                    break;
                }
            }
            if (SoQuanTa == 2)
                return 0;
            if (SoQuanTa == 0)
                DiemTong += MangDiemPhongNgu[SoQuanDich] * 2;
            else
                DiemTong += MangDiemPhongNgu[SoQuanDich];
            /* 
            if (SoQuanTa2 == 0)
                DiemTong += MangDiemPhongNgu[SoQuanDich2] * 2;
            else
                DiemTong += MangDiemPhongNgu[SoQuanDich2];
            */
            if (SoQuanDich >= SoQuanDich2)
                DiemTong -= 1;
            else
                DiemTong -= 2;
            if (SoQuanDich == 4)
                DiemTong *= 2;
            return DiemTong;
        }
        private long DiemPhongNgu_DuyetCheoXuoi(int iDong, int iCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            int SoQuanTa2 = 0;
            int SoQuanDich2 = 0;
            for (int dem = 1; dem < 5 && iCot + dem < _BanCo.NumCot && iDong + dem < _BanCo.NumDong; dem++)
            {
                if (_MangOCo[iDong + dem, iCot + dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[iDong + dem, iCot + dem].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else // SoHuu = 0
                {
                    for (int dem2 = 2; dem2 < 6 && iDong + dem2 < _BanCo.NumDong && iCot + dem2 < _BanCo.NumCot; dem2++)
                        if (_MangOCo[iDong + dem2, iCot + dem2].SoHuu == 1)
                        {
                            SoQuanTa2++;
                            break;
                        }
                        else if (_MangOCo[iDong + dem2, iCot + dem2].SoHuu == 2)
                        {
                            SoQuanDich2++;
                        }
                        else
                            break;
                    break;
                }
            }
            for (int dem = 1; dem < 5 && iCot - dem >= 0 && iDong - dem >= 0; dem++)
            {
                if (_MangOCo[iDong - dem, iCot - dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[iDong - dem, iCot - dem].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else // SoHuu = 0
                {
                    for (int dem2 = 2; dem2 < 6 && iCot - dem2 >= 0 && iDong - dem2 >= 0; dem2++)
                        if (_MangOCo[iDong - dem2, iCot - dem2].SoHuu == 1)
                        {
                            SoQuanTa2++;
                            break;
                        }
                        else if (_MangOCo[iDong - dem2, iCot - dem2].SoHuu == 2)
                        {
                            SoQuanDich2++;
                        }
                        else
                            break;
                    break;
                }
            }
            if (SoQuanTa == 2)
                return 0;
            if (SoQuanTa == 0)
                DiemTong += MangDiemPhongNgu[SoQuanDich] * 2;
            else
                DiemTong += MangDiemPhongNgu[SoQuanDich];
            /* 
            if (SoQuanTa2 == 0)
                DiemTong += MangDiemPhongNgu[SoQuanDich2] * 2;
            else
                DiemTong += MangDiemPhongNgu[SoQuanDich2];
            */
            if (SoQuanDich >= SoQuanDich2)
                DiemTong -= 1;
            else
                DiemTong -= 2;
            if (SoQuanDich == 4)
                DiemTong *= 2;
            return DiemTong;
        }
        private long DiemPhongNgu_DuyetCheoNguoc(int iDong, int iCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            int SoQuanTa2 = 0;
            int SoQuanDich2 = 0;
            for (int dem = 1; dem < 5 && iCot + dem < _BanCo.NumCot && iDong - dem > 0; dem++)
            {
                if (_MangOCo[iDong - dem, iCot + dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[iDong - dem, iCot + dem].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else // SoHuu = 0
                {
                    for (int dem2 = 2; dem2 < 6 && iDong - dem2 >= 0 && iCot + dem2 < _BanCo.NumCot; dem2++)
                        if (_MangOCo[iDong - dem2, iCot + dem2].SoHuu == 1)
                        {
                            SoQuanTa2++;
                            break;
                        }
                        else if (_MangOCo[iDong - dem2, iCot + dem2].SoHuu == 2)
                        {
                            SoQuanDich2++;
                        }
                        else
                            break;
                    break;
                }
            }
            for (int dem = 1; dem < 5 && iCot - dem >= 0 && iDong + dem < _BanCo.NumDong; dem++)
            {
                if (_MangOCo[iDong + dem, iCot - dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[iDong + dem, iCot - dem].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else // SoHuu = 0
                {
                    for (int dem2 = 2; dem2 < 6 && iDong + dem2 < _BanCo.NumDong && iCot - dem2 >= 0; dem2++)
                        if (_MangOCo[iDong + dem2, iCot - dem2].SoHuu == 1)
                        {
                            SoQuanTa2++;
                            break;
                        }
                        else if (_MangOCo[iDong + dem2, iCot - dem2].SoHuu == 2)
                        {
                            SoQuanDich2++;
                        }
                        else
                            break;
                    break;
                }
            }
            if (SoQuanTa == 2)
                return 0;
            if (SoQuanTa == 0)
                DiemTong += MangDiemPhongNgu[SoQuanDich] * 2;
            else
                DiemTong += MangDiemPhongNgu[SoQuanDich];
            /* 
            if (SoQuanTa2 == 0)
                DiemTong += MangDiemPhongNgu[SoQuanDich2] * 2;
            else
                DiemTong += MangDiemPhongNgu[SoQuanDich2];
            */
            if (SoQuanDich >= SoQuanDich2)
                DiemTong -= 1;
            else
                DiemTong -= 2;
            if (SoQuanDich == 4)
                DiemTong *= 2;
            return DiemTong;
        }
        #endregion

        #endregion
    }
}
