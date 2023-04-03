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
    public partial class HomeGame : Form
    {
        public HomeGame()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            String UserN = textBox1.Text;
            User.username = UserN;

            this.Hide();
            DoVanLam_GameXepHinh next = new DoVanLam_GameXepHinh();
            next.ShowDialog();
            this.Close();
        }
    }
}
