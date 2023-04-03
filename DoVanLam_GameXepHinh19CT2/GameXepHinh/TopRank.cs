using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameXepHinh
{
    public partial class TopRank : Form
    {
        public TopRank()
        {
            InitializeComponent();
            ShowTopRank();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoVanLam_GameXepHinh next = new DoVanLam_GameXepHinh();
            next.ShowDialog();
            this.Close();
        }

        public void ShowTopRank()
        {
            String path = @"D:\Winform\BaiTap\DoVanLam_GameXepHinh19CT2\TopRank\" + ".txt";
            String Result = File.ReadAllText(path);

            Label label = new Label();
            label.Top = 200;
            label.Left = 150;
            label.AutoSize = true;
            label.Text = "" + Result;
            label.BackColor = Color.Red;
            label.Parent = this;
            label.BringToFront();

            
        }
    }
}
