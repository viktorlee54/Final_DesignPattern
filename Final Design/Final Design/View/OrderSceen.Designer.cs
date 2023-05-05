namespace Final_Design.View
{
    partial class OrderSceen
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbFoodToping = new System.Windows.Forms.ComboBox();
            this.numBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDrink = new System.Windows.Forms.ComboBox();
            this.cbDrinkToping = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdMomo = new System.Windows.Forms.RadioButton();
            this.rdATM = new System.Windows.Forms.RadioButton();
            this.rdCash = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtTotal = new System.Windows.Forms.Label();
            this.numMoneyReceive = new System.Windows.Forms.NumericUpDown();
            this.dtgFood = new System.Windows.Forms.DataGridView();
            this.lblExchange = new System.Windows.Forms.Label();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMoneyReceive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFood)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(665, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số Lượng:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(211)))), ((int)(((byte)(226)))));
            this.btnAdd.Location = new System.Drawing.Point(923, 84);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 49);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(751, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tổng tiền:";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(145)))), ((int)(((byte)(101)))));
            this.btnPay.Location = new System.Drawing.Point(910, 484);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(200, 49);
            this.btnPay.TabIndex = 27;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Items.AddRange(new object[] {
            "Sweet Chicken",
            "Spicy Chicken"});
            this.cbFood.Location = new System.Drawing.Point(110, 64);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(211, 24);
            this.cbFood.TabIndex = 34;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbFood_SelectedIndexChanged);
            // 
            // cbFoodToping
            // 
            this.cbFoodToping.FormattingEnabled = true;
            this.cbFoodToping.Items.AddRange(new object[] {
            "Cheese",
            "Onion",
            "None"});
            this.cbFoodToping.Location = new System.Drawing.Point(435, 64);
            this.cbFoodToping.Name = "cbFoodToping";
            this.cbFoodToping.Size = new System.Drawing.Size(194, 24);
            this.cbFoodToping.TabIndex = 35;
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(754, 84);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(120, 22);
            this.numBox.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Food";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Topings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Water";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Topings";
            // 
            // cbDrink
            // 
            this.cbDrink.FormattingEnabled = true;
            this.cbDrink.Items.AddRange(new object[] {
            "Traditional MilkTea",
            "Honey MilkTea"});
            this.cbDrink.Location = new System.Drawing.Point(110, 123);
            this.cbDrink.Name = "cbDrink";
            this.cbDrink.Size = new System.Drawing.Size(211, 24);
            this.cbDrink.TabIndex = 41;
            this.cbDrink.SelectedIndexChanged += new System.EventHandler(this.cbDrink_SelectedIndexChanged);
            // 
            // cbDrinkToping
            // 
            this.cbDrinkToping.FormattingEnabled = true;
            this.cbDrinkToping.Items.AddRange(new object[] {
            "Flan",
            "Strawbery",
            "None"});
            this.cbDrinkToping.Location = new System.Drawing.Point(435, 123);
            this.cbDrinkToping.Name = "cbDrinkToping";
            this.cbDrinkToping.Size = new System.Drawing.Size(194, 24);
            this.cbDrinkToping.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(663, 402);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Tiền Thừa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(663, 352);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Tiền Nhận:";
            // 
            // rdMomo
            // 
            this.rdMomo.AutoSize = true;
            this.rdMomo.Location = new System.Drawing.Point(976, 294);
            this.rdMomo.Margin = new System.Windows.Forms.Padding(4);
            this.rdMomo.Name = "rdMomo";
            this.rdMomo.Size = new System.Drawing.Size(66, 20);
            this.rdMomo.TabIndex = 46;
            this.rdMomo.TabStop = true;
            this.rdMomo.Text = "Momo";
            this.rdMomo.UseVisualStyleBackColor = true;
            this.rdMomo.CheckedChanged += new System.EventHandler(this.rdMomo_CheckedChanged);
            // 
            // rdATM
            // 
            this.rdATM.AutoSize = true;
            this.rdATM.Location = new System.Drawing.Point(815, 294);
            this.rdATM.Margin = new System.Windows.Forms.Padding(4);
            this.rdATM.Name = "rdATM";
            this.rdATM.Size = new System.Drawing.Size(84, 20);
            this.rdATM.TabIndex = 45;
            this.rdATM.TabStop = true;
            this.rdATM.Text = "Thẻ ATM";
            this.rdATM.UseVisualStyleBackColor = true;
            this.rdATM.CheckedChanged += new System.EventHandler(this.rdATM_CheckedChanged);
            // 
            // rdCash
            // 
            this.rdCash.AutoSize = true;
            this.rdCash.Location = new System.Drawing.Point(652, 294);
            this.rdCash.Margin = new System.Windows.Forms.Padding(4);
            this.rdCash.Name = "rdCash";
            this.rdCash.Size = new System.Drawing.Size(80, 20);
            this.rdCash.TabIndex = 44;
            this.rdCash.TabStop = true;
            this.rdCash.Text = "Tiền mặt";
            this.rdCash.UseVisualStyleBackColor = true;
            this.rdCash.CheckedChanged += new System.EventHandler(this.rdCash_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(648, 271);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Thanh toán bằng hình thức:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(835, 183);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(224, 53);
            this.listView1.TabIndex = 53;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(854, 193);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(31, 32);
            this.txtTotal.TabIndex = 54;
            this.txtTotal.Text = "0";
            // 
            // numMoneyReceive
            // 
            this.numMoneyReceive.Location = new System.Drawing.Point(773, 352);
            this.numMoneyReceive.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numMoneyReceive.Name = "numMoneyReceive";
            this.numMoneyReceive.Size = new System.Drawing.Size(210, 22);
            this.numMoneyReceive.TabIndex = 55;
            // 
            // dtgFood
            // 
            this.dtgFood.BackgroundColor = System.Drawing.Color.White;
            this.dtgFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colQuan,
            this.colPrize,
            this.colDel});
            this.dtgFood.Location = new System.Drawing.Point(12, 271);
            this.dtgFood.Name = "dtgFood";
            this.dtgFood.RowHeadersWidth = 51;
            this.dtgFood.RowTemplate.Height = 24;
            this.dtgFood.Size = new System.Drawing.Size(629, 262);
            this.dtgFood.TabIndex = 56;
            this.dtgFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFood_CellContentClick);
            // 
            // lblExchange
            // 
            this.lblExchange.AutoSize = true;
            this.lblExchange.Location = new System.Drawing.Point(770, 402);
            this.lblExchange.Name = "lblExchange";
            this.lblExchange.Size = new System.Drawing.Size(14, 16);
            this.lblExchange.TabIndex = 57;
            this.lblExchange.Text = "0";
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 125;
            // 
            // colQuan
            // 
            this.colQuan.HeaderText = "Quantity";
            this.colQuan.MinimumWidth = 6;
            this.colQuan.Name = "colQuan";
            this.colQuan.Width = 125;
            // 
            // colPrize
            // 
            this.colPrize.HeaderText = "Prize";
            this.colPrize.MinimumWidth = 6;
            this.colPrize.Name = "colPrize";
            this.colPrize.Width = 125;
            // 
            // colDel
            // 
            this.colDel.HeaderText = "Delete";
            this.colDel.MinimumWidth = 6;
            this.colDel.Name = "colDel";
            this.colDel.Text = "Delete";
            this.colDel.UseColumnTextForButtonValue = true;
            this.colDel.Width = 125;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(685, 484);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 49);
            this.btnClear.TabIndex = 58;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // OrderSceen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1139, 602);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblExchange);
            this.Controls.Add(this.dtgFood);
            this.Controls.Add(this.numMoneyReceive);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rdMomo);
            this.Controls.Add(this.rdATM);
            this.Controls.Add(this.rdCash);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbDrinkToping);
            this.Controls.Add(this.cbDrink);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.cbFoodToping);
            this.Controls.Add(this.cbFood);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderSceen";
            this.Text = "Order Screen";
            ((System.ComponentModel.ISupportInitialize)(this.numBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMoneyReceive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbFoodToping;
        private System.Windows.Forms.NumericUpDown numBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDrink;
        private System.Windows.Forms.ComboBox cbDrinkToping;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdMomo;
        private System.Windows.Forms.RadioButton rdATM;
        private System.Windows.Forms.RadioButton rdCash;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.NumericUpDown numMoneyReceive;
        private System.Windows.Forms.DataGridView dtgFood;
        private System.Windows.Forms.Label lblExchange;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrize;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
        private System.Windows.Forms.Button btnClear;
    }
}