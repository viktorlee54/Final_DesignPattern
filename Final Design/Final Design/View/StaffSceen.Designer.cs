namespace Final_Design.View
{
    partial class StaffSceen
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrivateNotice = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPublicNotice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNoticeType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotification = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffPos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddstaff = new System.Windows.Forms.Button();
            this.dtgStaff = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(131)))), ((int)(((byte)(149)))));
            this.button1.Location = new System.Drawing.Point(765, 159);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Đăng Thông Báo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPrivateNotice);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Private Notice";
            // 
            // lblPrivateNotice
            // 
            this.lblPrivateNotice.AutoSize = true;
            this.lblPrivateNotice.Location = new System.Drawing.Point(6, 40);
            this.lblPrivateNotice.Name = "lblPrivateNotice";
            this.lblPrivateNotice.Size = new System.Drawing.Size(0, 16);
            this.lblPrivateNotice.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPublicNotice);
            this.groupBox2.Location = new System.Drawing.Point(526, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 117);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Public Notice";
            // 
            // lblPublicNotice
            // 
            this.lblPublicNotice.AutoSize = true;
            this.lblPublicNotice.Location = new System.Drawing.Point(6, 40);
            this.lblPublicNotice.Name = "lblPublicNotice";
            this.lblPublicNotice.Size = new System.Drawing.Size(0, 16);
            this.lblPublicNotice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose Type :";
            // 
            // cbNoticeType
            // 
            this.cbNoticeType.FormattingEnabled = true;
            this.cbNoticeType.Items.AddRange(new object[] {
            "Public Notification",
            "Private Notification"});
            this.cbNoticeType.Location = new System.Drawing.Point(122, 154);
            this.cbNoticeType.Name = "cbNoticeType";
            this.cbNoticeType.Size = new System.Drawing.Size(121, 24);
            this.cbNoticeType.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Notification: ";
            // 
            // txtNotification
            // 
            this.txtNotification.Location = new System.Drawing.Point(359, 156);
            this.txtNotification.Name = "txtNotification";
            this.txtNotification.Size = new System.Drawing.Size(299, 22);
            this.txtNotification.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Staff Name";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(122, 242);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(177, 22);
            this.txtStaffName.TabIndex = 12;
            // 
            // txtStaffPos
            // 
            this.txtStaffPos.Location = new System.Drawing.Point(437, 247);
            this.txtStaffPos.Name = "txtStaffPos";
            this.txtStaffPos.Size = new System.Drawing.Size(221, 22);
            this.txtStaffPos.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Position";
            // 
            // btnAddstaff
            // 
            this.btnAddstaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(131)))), ((int)(((byte)(149)))));
            this.btnAddstaff.Location = new System.Drawing.Point(765, 247);
            this.btnAddstaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddstaff.Name = "btnAddstaff";
            this.btnAddstaff.Size = new System.Drawing.Size(167, 48);
            this.btnAddstaff.TabIndex = 15;
            this.btnAddstaff.Text = "Add Staff";
            this.btnAddstaff.UseVisualStyleBackColor = false;
            this.btnAddstaff.Click += new System.EventHandler(this.btnAddstaff_Click);
            // 
            // dtgStaff
            // 
            this.dtgStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStaff.Location = new System.Drawing.Point(36, 340);
            this.dtgStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgStaff.Name = "dtgStaff";
            this.dtgStaff.RowHeadersWidth = 62;
            this.dtgStaff.RowTemplate.Height = 28;
            this.dtgStaff.Size = new System.Drawing.Size(621, 120);
            this.dtgStaff.TabIndex = 16;
            // 
            // StaffSceen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtgStaff);
            this.Controls.Add(this.btnAddstaff);
            this.Controls.Add(this.txtStaffPos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNotification);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNoticeType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StaffSceen";
            this.Text = "StaffSceen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPrivateNotice;
        private System.Windows.Forms.Label lblPublicNotice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNoticeType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffPos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddstaff;
        private System.Windows.Forms.DataGridView dtgStaff;
    }
}