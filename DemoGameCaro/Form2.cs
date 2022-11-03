using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGameCaro
{
    public partial class Form2 : Form
    {
        private string namePlayer1;
        private string namePlayer2;
        public Form2()
        {
            InitializeComponent();
        }

        public string NamePlayer1 { get => namePlayer1; set => namePlayer1 = value; }
        public string NamePlayer2 { get => namePlayer2; set => namePlayer2 = value; }

        private void btnPlaygame_Click(object sender, EventArgs e)
        {
            NamePlayer1 = txbNameplayer1.Text;
            NamePlayer2 = txbNameplayer2.Text;
            this.Close();
        }
    }
}
