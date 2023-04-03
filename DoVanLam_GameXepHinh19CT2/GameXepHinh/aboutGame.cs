using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameXepHinh
{
    public partial class aboutGame : Form
    {

        List<string> ListTopRankAbout = new List<String>();

        public aboutGame()
        {
            InitializeComponent();

            int x = 200;
            int y = 200;

            foreach (string item in ListTopRankAbout)
            {

                Label label = new Label();
                label.Text = item;

                label.Location = new Point(x, y);
                label.Size = new Size(50, 50);
                x += 50;
                y += 50;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoVanLam_GameXepHinh xepHinhMain = new DoVanLam_GameXepHinh();
            xepHinhMain.ShowDialog();
            this.Close();
        }
    }
}
