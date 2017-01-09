namespace WindowsFormsApplication.Bill_Management
{
    partial class GUI_InsertBill
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
            this.txtbranch = new System.Windows.Forms.ComboBox();
            this.txtpos = new System.Windows.Forms.ComboBox();
            this.quảnLíHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numsoluong = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btncancle = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.txtproduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpsaleday = new System.Windows.Forms.DateTimePicker();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lstbilldetail = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtoutmoney = new System.Windows.Forms.TextBox();
            this.txtinmoney = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numsoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstbilldetail)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbranch
            // 
            this.txtbranch.FormattingEnabled = true;
            this.txtbranch.Location = new System.Drawing.Point(79, 132);
            this.txtbranch.Name = "txtbranch";
            this.txtbranch.Size = new System.Drawing.Size(108, 21);
            this.txtbranch.TabIndex = 99;
            // 
            // txtpos
            // 
            this.txtpos.FormattingEnabled = true;
            this.txtpos.Location = new System.Drawing.Point(265, 102);
            this.txtpos.Name = "txtpos";
            this.txtpos.Size = new System.Drawing.Size(85, 21);
            this.txtpos.TabIndex = 98;
            // 
            // quảnLíHóaĐơnToolStripMenuItem
            // 
            this.quảnLíHóaĐơnToolStripMenuItem.Name = "quảnLíHóaĐơnToolStripMenuItem";
            this.quảnLíHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.quảnLíHóaĐơnToolStripMenuItem.Text = "Manage Bill";
            this.quảnLíHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.quảnLíHóaĐơnToolStripMenuItem_Click);
            // 
            // numsoluong
            // 
            this.numsoluong.Location = new System.Drawing.Point(245, 231);
            this.numsoluong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numsoluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numsoluong.Name = "numsoluong";
            this.numsoluong.Size = new System.Drawing.Size(55, 20);
            this.numsoluong.TabIndex = 97;
            this.numsoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numsoluong.Visible = false;
            this.numsoluong.ValueChanged += new System.EventHandler(this.numsoluong_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(17, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 96;
            this.label11.Text = "Brach";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(79, 103);
            this.txtuser.Name = "txtuser";
            this.txtuser.ReadOnly = true;
            this.txtuser.Size = new System.Drawing.Size(108, 20);
            this.txtuser.TabIndex = 95;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(260, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 29);
            this.label13.TabIndex = 93;
            this.label13.Text = "BILL DETAIL";
            // 
            // btncancle
            // 
            this.btncancle.Location = new System.Drawing.Point(468, 487);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(51, 43);
            this.btncancle.TabIndex = 92;
            this.btncancle.Text = "Cancel";
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(525, 487);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(130, 43);
            this.btncreate.TabIndex = 91;
            this.btncreate.Text = "Create Bill";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.createbillbutton);
            // 
            // txtproduct
            // 
            this.txtproduct.Location = new System.Drawing.Point(92, 231);
            this.txtproduct.Name = "txtproduct";
            this.txtproduct.Size = new System.Drawing.Size(98, 20);
            this.txtproduct.TabIndex = 90;
            this.txtproduct.TextChanged += new System.EventHandler(this.showProductInfo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(17, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Product ID";
            // 
            // dtpsaleday
            // 
            this.dtpsaleday.Enabled = false;
            this.dtpsaleday.Location = new System.Drawing.Point(452, 103);
            this.dtpsaleday.Name = "dtpsaleday";
            this.dtpsaleday.Size = new System.Drawing.Size(200, 20);
            this.dtpsaleday.TabIndex = 88;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(324, 487);
            this.txtsl.Name = "txtsl";
            this.txtsl.ReadOnly = true;
            this.txtsl.Size = new System.Drawing.Size(100, 20);
            this.txtsl.TabIndex = 87;
            this.txtsl.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(243, 490);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 86;
            this.label10.Text = "Total quantity";
            // 
            // lstbilldetail
            // 
            this.lstbilldetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstbilldetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.Price,
            this.Total});
            this.lstbilldetail.Location = new System.Drawing.Point(20, 268);
            this.lstbilldetail.Name = "lstbilldetail";
            this.lstbilldetail.ReadOnly = true;
            this.lstbilldetail.Size = new System.Drawing.Size(638, 185);
            this.lstbilldetail.TabIndex = 85;
            this.lstbilldetail.Click += new System.EventHandler(this.lstbilldetail_Click);
            this.lstbilldetail.DoubleClick += new System.EventHandler(this.lstbilldetail_DoubleClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(215, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 84;
            this.label9.Text = "POS";
            // 
            // txtoutmoney
            // 
            this.txtoutmoney.Location = new System.Drawing.Point(123, 510);
            this.txtoutmoney.Name = "txtoutmoney";
            this.txtoutmoney.ReadOnly = true;
            this.txtoutmoney.Size = new System.Drawing.Size(100, 20);
            this.txtoutmoney.TabIndex = 83;
            this.txtoutmoney.Text = "0";
            // 
            // txtinmoney
            // 
            this.txtinmoney.Location = new System.Drawing.Point(123, 487);
            this.txtinmoney.Name = "txtinmoney";
            this.txtinmoney.Size = new System.Drawing.Size(100, 20);
            this.txtinmoney.TabIndex = 82;
            this.txtinmoney.Text = "0";
            this.txtinmoney.TextChanged += new System.EventHandler(this.txtinmoney_TextChanged);
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(324, 510);
            this.txtamount.Name = "txtamount";
            this.txtamount.ReadOnly = true;
            this.txtamount.Size = new System.Drawing.Size(100, 20);
            this.txtamount.TabIndex = 81;
            this.txtamount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(20, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Pay money";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(20, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Back money";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(243, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "Total money";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(391, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Date";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.quảnLíHóaĐơnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 94;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnBack
            // 
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 20);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(17, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Account ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 29);
            this.label2.TabIndex = 75;
            this.label2.Text = "BILL DETAIL MANAGEMENT";
            // 
            // GUI_InsertBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication.Properties.Resources._8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(673, 596);
            this.Controls.Add(this.txtbranch);
            this.Controls.Add(this.txtpos);
            this.Controls.Add(this.numsoluong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.txtproduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpsaleday);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstbilldetail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtoutmoney);
            this.Controls.Add(this.txtinmoney);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "GUI_InsertBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_InsertBill";
            ((System.ComponentModel.ISupportInitialize)(this.numsoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstbilldetail)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtbranch;
        private System.Windows.Forms.ComboBox txtpos;
        private System.Windows.Forms.ToolStripMenuItem quảnLíHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numsoluong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.TextBox txtproduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpsaleday;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView lstbilldetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtoutmoney;
        private System.Windows.Forms.TextBox txtinmoney;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
    }
}