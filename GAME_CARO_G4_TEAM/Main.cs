using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace GAME_CARO_G4_TEAM
{
    public partial class Main : Form
    {
        private SoundPlayer _SoundPlayer;
        public void PlaySound()
        {
            ckbSound.Text = "   Tắt nhạc";
            _SoundPlayer.Play();
        }
      
        public Main()
        {
            InitializeComponent();
            _SoundPlayer = new SoundPlayer("NguoiAmPhuwav.wav");
            PlaySound();
        }

        private void btnPlayerVsPlayer_Click(object sender, EventArgs e)
        {
            frmPlayerVsPlayer p = new frmPlayerVsPlayer();
            p.ShowDialog();
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ckbSound_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSound.Checked)
            {
                ckbSound.Text = "   Tắt nhạc";
                _SoundPlayer.Play();
            }
            else
            {
                ckbSound.Text = "   Bật nhạc";
                _SoundPlayer.Stop();
            }

        }

        private void btnPlayerVsCom_Click(object sender, EventArgs e)
        {
            frmPlayerVsCom com = new frmPlayerVsCom();
            com.ShowDialog();
        }
    }
}
