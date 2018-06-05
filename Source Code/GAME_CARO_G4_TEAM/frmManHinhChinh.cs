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

    public partial class frmManHinhChinh : Form
    {
        public frmManHinhChinh()
        {
            InitializeComponent();
        }

        private void pbThoatGame_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbChoiVoiMay_Click(object sender, EventArgs e)
        {
            frmPlayerVsCom con = new frmPlayerVsCom();
            this.Hide();
            con.ShowDialog();
            this.Show();
            
        }

        private void pbChoiVoiNguoi_Click(object sender, EventArgs e)
        {
            frmPlayerVsPlayer con = new frmPlayerVsPlayer();
            this.Hide();
            con.ShowDialog();
            this.Show();
        }

        Boolean flag;
        int x, y;
        private void frmManHinhChinh_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;        
        }

        private void frmManHinhChinh_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void frmManHinhChinh_Shown(object sender, EventArgs e)
        {

        }

        private void frmManHinhChinh_Load(object sender, EventArgs e)
        {
            NameInput temp = new NameInput();
            temp.ShowDialog();
        }

        private void pbHuongDan_Click(object sender, EventArgs e)
        {
            HuongDan form = new HuongDan();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void frmManHinhChinh_MouseMove(object sender, MouseEventArgs e)
        {
            if(flag==true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }
    }

}
