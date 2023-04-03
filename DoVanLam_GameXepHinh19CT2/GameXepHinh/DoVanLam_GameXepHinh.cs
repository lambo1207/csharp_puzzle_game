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
using System.Windows.Forms.VisualStyles;

namespace GameXepHinh
{
    public partial class DoVanLam_GameXepHinh : Form
    {

        private PictureBox[,] picTB;
        private Bitmap[,] aBmp;
        private static int edgBm;
        private static int RowColum;
        private static int ColumRow;

        private static Timer timer;
        private static Timer timer2;
        private int second;
        private int minute;
        private int width;
        private int lineRow;
        private int lineColum;

        int soHinh = 0;

        public DoVanLam_GameXepHinh()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            String state = btnStart.Text;
            String StringSoHinh = cbbSoHinh.Text;
            if (StringSoHinh == "")
            {
                MessageBox.Show("Bạn chưa chọn số hình!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(state == "Bắt đầu")
                {
                    soHinh = int.Parse(StringSoHinh);
                    if(soHinh == 9)
                    {
                        minute = 2;
                        second = 0;
                        Begin_Click();
                    }
                    else if(soHinh == 12)
                    {
                        minute = 2;
                        second = 30;
                        Begin_Click();
                    }
                    else if (soHinh == 16)
                    {
                        minute = 3;
                        second = 30;
                        Begin_Click();
                    }
                    else if (soHinh == 20)
                    {
                        minute = 4;
                        second = 0;
                        Begin_Click();
                    }
                    else if (soHinh == 25)
                    {
                        minute = 5;
                        second = 30;
                        Begin_Click();
                    }
                    Win();
                    thoigian.Start();
                    

                    btnStart.Text = "Dừng";
                }
                else
                {
                    thoigian.Stop();
                    btnStart.Text = "Bắt đầu";
                }

            }

        }

        private void Begin_Click()
        {
            if (soHinh == 9)
            {
                RowColum = 3;
                ColumRow = 3;
                edgBm = 166;
                width = 249;
                lineRow = 83;
                lineColum = 83;
            }
            if (soHinh == 12)
            {
                RowColum = 3;
                ColumRow = 4;
                edgBm = 125;
                width = 249;
                lineRow = 83;
                lineColum = 62;
            }
            if (soHinh == 16)
            {
                RowColum = 4;
                ColumRow = 4;
                edgBm = 125;
                width = 248;
                lineRow = 62;
                lineColum = 62;
            }
            if (soHinh == 20)
            {
                RowColum = 4;
                ColumRow = 5;
                edgBm = 100;
                width = 248;
                lineRow = 62;
                lineColum = 50;
            }
            if (soHinh == 25)
            {
                RowColum = 5;
                ColumRow = 5;
                edgBm = 100;
                width = 250;
                lineRow = 50;
                lineColum = 50;
            }

            aBmp = new Bitmap[RowColum, ColumRow];
            picTB = new PictureBox[RowColum, ColumRow];

            cutImage(RowColum, ColumRow, width, lineRow, lineColum);
            SetPtr();
            TronAnh();

        }

        private void cutImage(int RowColum, int ColumRow, int width, int lineRow, int lineColum)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            Bitmap bmp;
            Bitmap ptShow;

            openFile.ShowDialog();
            string s = openFile.FileName;
            Image img = Image.FromFile(s);
            bmp = new Bitmap(img, 500, 500);
            ptShow = new Bitmap(img, 250, 250);

            for (int i = 0; i < RowColum; i++)
            {
                for (int j = 0; j < ColumRow; j++)
                {
                    aBmp[i, j] = new Bitmap(edgBm, edgBm);
                    for (int k = 0; k < edgBm; k++)
                    {
                        for (int l = 0; l < edgBm; l++)
                        {
                            aBmp[i, j].SetPixel(l, k, bmp.GetPixel(edgBm * j + l, edgBm * i + k));
                        }
                    }
                }
            }

            Graphics g = Graphics.FromImage(ptShow);
            for (int i = 1; i < RowColum; i++)
            {
                g.DrawLine(Pens.Black, 0, i * lineRow, width, i * lineRow);
            }
            for (int i = 1; i < ColumRow; i++)
            {
                g.DrawLine(Pens.Black, i * lineColum, 0, i * lineColum, width);
            }
            PictureBox picTB = new PictureBox();
            picTB.Image = ptShow;
            picTB.Top = 20;
            picTB.Left = 550;
            picTB.Width = width;
            picTB.Height = width;
            picTB.Parent = this;
        }

        public void SetPtr()
        {
            for (int i = 0; i < RowColum; i++)
            {
                for (int j = 0; j < ColumRow; j++)
                {
                    picTB[i, j] = new PictureBox();
                    picTB[i, j].Parent = this;
                    picTB[i, j].Top = i * (edgBm + 2) + 20;
                    picTB[i, j].Left = j * (edgBm + 2) + 20;
                    picTB[i, j].Size = new Size(edgBm, edgBm);
                    picTB[i, j].BackColor = Color.BurlyWood;

                    picTB[i, j].Click += Form1_Click;
                }
            }

            for (int i = 0; i < RowColum ; i++)
            {
                for (int j = 0; j < ColumRow; j++)
                {
                    picTB[i, j].Image = aBmp[i, j];
                }
            }
            for (int j = 0; j < RowColum - 1; j++)
            {
                picTB[RowColum - 1, j].Image = aBmp[RowColum - 1, j];
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (CheckComplete()) return;
            PictureBox pt = (PictureBox)sender;
            if (pt.Image == null) return;
            int x = (pt.Top - 20) / (edgBm + 2);
            int y = (pt.Left - 20) / (edgBm + 2);

            if (x > 0 && picTB[x - 1, y].Image == null)
            {
                picTB[x - 1, y].Image = pt.Image;
                pt.Image = null;
            }
            else if (x < (RowColum - 1) && picTB[x + 1, y].Image == null)
            {
                picTB[x + 1, y].Image = pt.Image;
                pt.Image = null;
            }
            else if (y > 0 && picTB[x, y - 1].Image == null)
            {
                picTB[x, y - 1].Image = pt.Image;
                pt.Image = null;
            }
            else if (y < (RowColum - 1) && picTB[x, y + 1].Image == null)
            {
                picTB[x, y + 1].Image = pt.Image;
                pt.Image = null;
            }

            if (CheckComplete()) GameComple();
        }

        private void TronAnh()
        {
            Random random = new Random();
            int r;
            bool f;
            int x = RowColum - 1, y = RowColum - 1;
            for (int i = 0; i < 200; i++)
            {
                do
                {
                    r = random.Next(1, 5);
                    if (r == 1)
                    {
                        if (x - 1 >= 0)
                        {
                            picTB[x, y].Image = picTB[x - 1, y].Image;
                            picTB[x - 1, y].Image = null;
                            x--;
                            f = false;
                        }
                        else f = true;
                    }
                    else if (r == 2)
                    {
                        if (y + 1 < RowColum)
                        {
                            picTB[x, y].Image = picTB[x, y + 1].Image;
                            picTB[x, y + 1].Image = null;
                            y++;
                            f = false;
                        }
                        else f = true;

                    }
                    else if (r == 3)
                    {
                        if (x + 1 < RowColum)
                        {
                            picTB[x, y].Image = picTB[x + 1, y].Image;
                            picTB[x + 1, y].Image = null;
                            x++;
                            f = false;
                        }
                        f = true;
                    }
                    else
                    {
                        if (y - 1 >= 0)
                        {
                            picTB[x, y].Image = picTB[x, y - 1].Image;
                            picTB[x, y - 1].Image = null;
                            y--;
                            f = false;
                        }
                        else f = true;
                    }
                } while (f);
            }
        }

        private bool CheckComplete()
        {
            for (int i = 0; i < RowColum - 1; i++)
            {
                for (int j = 0; j < ColumRow; j++)
                {
                    if (picTB[i, j].Image != aBmp[i, j]) return false;
                }
            }
            for (int j = 0; j < RowColum - 1; j++)
            {
                if (picTB[RowColum - 1, j].Image != aBmp[RowColum - 1, j]) return false;
            }

            return true;
        }

        private void GameComple()
        {
            Label label = new Label();
            label.Top = 200;
            label.Left = 150;
            label.AutoSize = true;
            label.Font = new Font("Arial", 12);
            label.Size = new Size(200, 50);
            label.Text = "Chúc mừng bạn đã chiến thắng";
            label.BackColor = Color.Red;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Parent = this;
            label.BringToFront();
            thoigian.Stop();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_3.Text = second.ToString() + " s";
            lb_2.Text = minute.ToString() + ":";
            second--;
            if(second < 0)
            {
                minute--;
                if (minute < 0)
                {
                    KetThuc();
                }
                else
                {
                    second = 59;
                }
            }

        }

        private void Win()
        {
            String UserName = User.username;
            String path = @"D:\Winform\BaiTap\DoVanLam_GameXepHinh19CT2\TopRank\" + ".txt";
            File.WriteAllText(path, UserName);
        }

        private void KetThuc()
        {
            thoigian.Stop();
            MessageBox.Show("Game over!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            aboutGame ab = new aboutGame();
            ab.ShowDialog();
            this.Close();

        }

        private void btnTopRank_Click(object sender, EventArgs e)
        {
            this.Hide();
            TopRank next = new TopRank();
            next.ShowDialog();
            this.Close();
        }
    }
}
