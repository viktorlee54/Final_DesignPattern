namespace Final_Design
{
    partial class MainForm
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
            this.bttDatMon = new System.Windows.Forms.Button();
            this.bttNhanVien = new System.Windows.Forms.Button();
            this.bttQuay = new System.Windows.Forms.Button();
            this.bttBan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttDatMon
            // 
            this.bttDatMon.Location = new System.Drawing.Point(18, 314);
            this.bttDatMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttDatMon.Name = "bttDatMon";
            this.bttDatMon.Size = new System.Drawing.Size(321, 158);
            this.bttDatMon.TabIndex = 1;
            this.bttDatMon.Text = "Đặt Món";
            this.bttDatMon.UseVisualStyleBackColor = true;
            this.bttDatMon.Click += new System.EventHandler(this.bttDatMon_Click);
            // 
            // bttNhanVien
            // 
            this.bttNhanVien.Location = new System.Drawing.Point(544, 314);
            this.bttNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttNhanVien.Name = "bttNhanVien";
            this.bttNhanVien.Size = new System.Drawing.Size(321, 158);
            this.bttNhanVien.TabIndex = 2;
            this.bttNhanVien.Text = "Quản lý nhân viên";
            this.bttNhanVien.UseVisualStyleBackColor = true;
            this.bttNhanVien.Click += new System.EventHandler(this.bttNhanVien_Click);
            // 
            // bttQuay
            // 
            this.bttQuay.Location = new System.Drawing.Point(18, 539);
            this.bttQuay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttQuay.Name = "bttQuay";
            this.bttQuay.Size = new System.Drawing.Size(321, 158);
            this.bttQuay.TabIndex = 3;
            this.bttQuay.Text = "Khu quầy";
            this.bttQuay.UseVisualStyleBackColor = true;
            this.bttQuay.Click += new System.EventHandler(this.BttQuay_Click);
            // 
            // bttBan
            // 
            this.bttBan.Location = new System.Drawing.Point(544, 539);
            this.bttBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttBan.Name = "bttBan";
            this.bttBan.Size = new System.Drawing.Size(321, 158);
            this.bttBan.TabIndex = 4;
            this.bttBan.Text = "Quản lý bàn";
            this.bttBan.UseVisualStyleBackColor = true;
            this.bttBan.Click += new System.EventHandler(this.bttBan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = global::Final_Design.Properties.Resources.background1;
            this.pictureBox1.Location = new System.Drawing.Point(266, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 278);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 714);
            this.Controls.Add(this.bttBan);
            this.Controls.Add(this.bttQuay);
            this.Controls.Add(this.bttNhanVien);
            this.Controls.Add(this.bttDatMon);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttDatMon;
        private System.Windows.Forms.Button bttNhanVien;
        private System.Windows.Forms.Button bttQuay;
        private System.Windows.Forms.Button bttBan;
    }
}

