using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_CARO_G4_TEAM
{
    class BanCo
    {
        
        private int _NumDong;//số dòng
        private int _NumCot;//số cột

        public int NumDong
        {
            get
            {
                return _NumDong;
            }

        }
        public int NumCot
        {
            get
            {
                return _NumCot;
            }

    
        }  
        public BanCo()
        {
            _NumCot = 0;
            _NumDong = 0;
        }
        public BanCo(int NumCot, int NumDong)
        {
            _NumDong = NumDong;
            _NumCot = NumCot;
        }

        public void VeBanCo(Graphics g)
        {
            for(int i=0;i <= NumCot;i++)
            {
                g.DrawLine(CaroChess.pen, i*OCo._ChieuRong, 0 , i*OCo._ChieuRong, NumDong*OCo._ChieuCao);
            }

            for (int j = 0; j <= NumDong; j++)
            {
                g.DrawLine(CaroChess.pen, 0 , j*OCo._ChieuCao, NumCot*OCo._ChieuRong, j*OCo._ChieuCao);
            }
        }   //Ve Ban Co
          public void VeO(Graphics g, Point point)
        {           
            g.DrawEllipse(CaroChess.penO, point.X + 5, point.Y + 5, OCo._ChieuRong - 10, OCo._ChieuCao - 10);           
        } //Ve Quan O
        public void VeX(Graphics g, Point point)
        {   
            g.DrawLine(CaroChess.penX, point.X + 5, point.Y + 5, point.X + 20, point.Y + 20);
            g.DrawLine(CaroChess.penX, point.X + 20, point.Y + 5, point.X + 5, point.Y + 20);          
        }  // Ve Quan X

        public void XoaOCo(Graphics g,Point p,SolidBrush sbr) 
        {
            g.FillRectangle(sbr, p.X+1, p.Y+1, OCo._ChieuRong-2, OCo._ChieuCao-2);
        } //Xoa Quan Co

        
    }
}
