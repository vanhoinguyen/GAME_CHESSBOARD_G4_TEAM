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
    public partial class NameInput : Form
    {
        public NameInput()
        {
            InitializeComponent();
        }

        private void okBt_Click(object sender, EventArgs e)
        {
            PlayerName.Name = tbName.Text;
            this.Close();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public static class PlayerName
    {

        private static string _name = "";

        public static string Name { get => _name; set => _name = value; }

    }
}
