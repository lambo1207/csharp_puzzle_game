
namespace GameXepHinh
{
    partial class DoVanLam_GameXepHinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbbSoHinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.thoigian = new System.Windows.Forms.Timer(this.components);
            this.lb_1 = new System.Windows.Forms.Label();
            this.lb_3 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnTopRank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Info;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.Location = new System.Drawing.Point(866, 166);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 30);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(974, 166);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbbSoHinh
            // 
            this.cbbSoHinh.FormattingEnabled = true;
            this.cbbSoHinh.Items.AddRange(new object[] {
            "9",
            "12",
            "16",
            "20",
            "25"});
            this.cbbSoHinh.Location = new System.Drawing.Point(866, 85);
            this.cbbSoHinh.Name = "cbbSoHinh";
            this.cbbSoHinh.Size = new System.Drawing.Size(80, 21);
            this.cbbSoHinh.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(863, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn số hình:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // thoigian
            // 
            this.thoigian.Interval = 1000;
            this.thoigian.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Location = new System.Drawing.Point(990, 60);
            this.lb_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(51, 13);
            this.lb_1.TabIndex = 8;
            this.lb_1.Text = "Thời gian";
            // 
            // lb_3
            // 
            this.lb_3.AutoSize = true;
            this.lb_3.Location = new System.Drawing.Point(1022, 85);
            this.lb_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(19, 13);
            this.lb_3.TabIndex = 10;
            this.lb_3.Text = "00";
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Location = new System.Drawing.Point(1002, 85);
            this.lb_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(19, 13);
            this.lb_2.TabIndex = 9;
            this.lb_2.Text = "00";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(866, 231);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(111, 23);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.Text = "About Game";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnTopRank
            // 
            this.btnTopRank.BackColor = System.Drawing.Color.Coral;
            this.btnTopRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopRank.Location = new System.Drawing.Point(866, 278);
            this.btnTopRank.Name = "btnTopRank";
            this.btnTopRank.Size = new System.Drawing.Size(111, 23);
            this.btnTopRank.TabIndex = 12;
            this.btnTopRank.Text = "Top Rank";
            this.btnTopRank.UseVisualStyleBackColor = false;
            this.btnTopRank.Click += new System.EventHandler(this.btnTopRank_Click);
            // 
            // DoVanLam_GameXepHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 861);
            this.Controls.Add(this.btnTopRank);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lb_3);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbSoHinh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Name = "DoVanLam_GameXepHinh";
            this.Text = "XepHinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbbSoHinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer thoigian;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label lb_3;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnTopRank;
    }
}

