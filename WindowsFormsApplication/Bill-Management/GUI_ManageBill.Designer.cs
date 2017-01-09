namespace WindowsFormsApplication.Bill_Management
{
    partial class GUI_ManageBill
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
            this.btnsearch = new System.Windows.Forms.Button();
            this.lstbill = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbranch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtpos = new System.Windows.Forms.ComboBox();
            this.lstbilldetail = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numsoluong = new System.Windows.Forms.NumericUpDown();
            this.txtproduct = new System.Windows.Forms.TextBox();
            this.cboaccount = new System.Windows.Forms.ComboBox();
            this.dtpsaleday = new System.Windows.Forms.DateTimePicker();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnclean = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtoutmoney = new System.Windows.Forms.TextBox();
            this.txtinmoney = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstbill)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstbilldetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(593, 55);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 81;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lstbill
            // 
            this.lstbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstbill.Location = new System.Drawing.Point(6, 19);
            this.lstbill.Name = "lstbill";
            this.lstbill.ReadOnly = true;
            this.lstbill.Size = new System.Drawing.Size(648, 196);
            this.lstbill.TabIndex = 80;
            this.lstbill.Click += new System.EventHandler(this.selectBillToUpdate);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(371, 57);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(216, 20);
            this.txtsearch.TabIndex = 79;
            this.txtsearch.TextChanged += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lstbill);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 221);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LIST OF INVOICE";
            // 
            // txtbranch
            // 
            this.txtbranch.Location = new System.Drawing.Point(278, 358);
            this.txtbranch.Name = "txtbranch";
            this.txtbranch.ReadOnly = true;
            this.txtbranch.Size = new System.Drawing.Size(38, 20);
            this.txtbranch.TabIndex = 158;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(216, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 157;
            this.label12.Text = "Branch";
            // 
            // txtpos
            // 
            this.txtpos.FormattingEnabled = true;
            this.txtpos.Location = new System.Drawing.Point(361, 358);
            this.txtpos.Name = "txtpos";
            this.txtpos.Size = new System.Drawing.Size(38, 21);
            this.txtpos.TabIndex = 156;
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
            this.lstbilldetail.Location = new System.Drawing.Point(18, 499);
            this.lstbilldetail.Name = "lstbilldetail";
            this.lstbilldetail.ReadOnly = true;
            this.lstbilldetail.Size = new System.Drawing.Size(650, 162);
            this.lstbilldetail.TabIndex = 155;
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
            // numsoluong
            // 
            this.numsoluong.Location = new System.Drawing.Point(278, 472);
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
            this.numsoluong.TabIndex = 153;
            this.numsoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numsoluong.Visible = false;
            this.numsoluong.ValueChanged += new System.EventHandler(this.numsoluong_ValueChanged);
            // 
            // txtproduct
            // 
            this.txtproduct.Location = new System.Drawing.Point(77, 472);
            this.txtproduct.Name = "txtproduct";
            this.txtproduct.Size = new System.Drawing.Size(98, 20);
            this.txtproduct.TabIndex = 152;
            this.txtproduct.Visible = false;
            this.txtproduct.TextChanged += new System.EventHandler(this.txtproduct_TextChanged);
            // 
            // cboaccount
            // 
            this.cboaccount.FormattingEnabled = true;
            this.cboaccount.Location = new System.Drawing.Point(77, 394);
            this.cboaccount.Name = "cboaccount";
            this.cboaccount.Size = new System.Drawing.Size(100, 21);
            this.cboaccount.TabIndex = 151;
            // 
            // dtpsaleday
            // 
            this.dtpsaleday.Location = new System.Drawing.Point(76, 434);
            this.dtpsaleday.Name = "dtpsaleday";
            this.dtpsaleday.Size = new System.Drawing.Size(181, 20);
            this.dtpsaleday.TabIndex = 150;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(278, 395);
            this.txtsl.Name = "txtsl";
            this.txtsl.ReadOnly = true;
            this.txtsl.Size = new System.Drawing.Size(100, 20);
            this.txtsl.TabIndex = 149;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(204, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 148;
            this.label10.Text = "Total quanity";
            // 
            // btnclean
            // 
            this.btnclean.Location = new System.Drawing.Point(591, 667);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(75, 23);
            this.btnclean.TabIndex = 147;
            this.btnclean.Text = "Clean";
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(15, 475);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 154;
            this.label11.Text = "Product";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(510, 667);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 146;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.clickSaveButton);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(429, 667);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 145;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(326, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 144;
            this.label9.Text = "POS";
            // 
            // txtoutmoney
            // 
            this.txtoutmoney.Location = new System.Drawing.Point(510, 431);
            this.txtoutmoney.Name = "txtoutmoney";
            this.txtoutmoney.ReadOnly = true;
            this.txtoutmoney.Size = new System.Drawing.Size(109, 20);
            this.txtoutmoney.TabIndex = 143;
            // 
            // txtinmoney
            // 
            this.txtinmoney.Location = new System.Drawing.Point(510, 394);
            this.txtinmoney.Name = "txtinmoney";
            this.txtinmoney.Size = new System.Drawing.Size(109, 20);
            this.txtinmoney.TabIndex = 142;
            this.txtinmoney.TextChanged += new System.EventHandler(this.txtinmoney_TextChanged);
            // 
            // txtamount
            // 
            this.txtamount.AcceptsTab = true;
            this.txtamount.Location = new System.Drawing.Point(510, 358);
            this.txtamount.Name = "txtamount";
            this.txtamount.ReadOnly = true;
            this.txtamount.Size = new System.Drawing.Size(109, 20);
            this.txtamount.TabIndex = 141;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(76, 358);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 140;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(434, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 139;
            this.label7.Text = "Pay money";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(434, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 138;
            this.label8.Text = "Back money";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(434, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 137;
            this.label6.Text = "Total Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(15, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 136;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(15, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 135;
            this.label4.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(15, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 134;
            this.label3.Text = "Bill ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 159;
            this.label1.Text = "INVOICE INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(204, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 160;
            this.label2.Text = "Quantity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(243, 25);
            this.label13.TabIndex = 161;
            this.label13.Text = "INVOICE MANAGEMENT";
            // 
            // GUI_ManageBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication.Properties.Resources._8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(683, 705);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbranch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtpos);
            this.Controls.Add(this.lstbilldetail);
            this.Controls.Add(this.numsoluong);
            this.Controls.Add(this.txtproduct);
            this.Controls.Add(this.cboaccount);
            this.Controls.Add(this.dtpsaleday);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtoutmoney);
            this.Controls.Add(this.txtinmoney);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Name = "GUI_ManageBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_ManageBill";
            ((System.ComponentModel.ISupportInitialize)(this.lstbill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstbilldetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsoluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView lstbill;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbranch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txtpos;
        private System.Windows.Forms.DataGridView lstbilldetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.NumericUpDown numsoluong;
        private System.Windows.Forms.TextBox txtproduct;
        private System.Windows.Forms.ComboBox cboaccount;
        private System.Windows.Forms.DateTimePicker dtpsaleday;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtoutmoney;
        private System.Windows.Forms.TextBox txtinmoney;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
    }
}