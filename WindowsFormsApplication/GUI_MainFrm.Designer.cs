namespace WindowsFormsApplication
{
    partial class GUI_MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_MainFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnManageCategory = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnPromotion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnProposed = new System.Windows.Forms.Button();
            this.btnHeadquater = new System.Windows.Forms.Button();
            this.btnBranchOffice = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.lblLogout = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "C - MART";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnManageCategory);
            this.groupBox1.Controls.Add(this.btnProduct);
            this.groupBox1.Controls.Add(this.btnPrice);
            this.groupBox1.Controls.Add(this.btnSupplier);
            this.groupBox1.Controls.Add(this.btnPromotion);
            this.groupBox1.Location = new System.Drawing.Point(38, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 136);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCT\'S MANAGEMENT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Promotion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Category";
            // 
            // btnManageCategory
            // 
            this.btnManageCategory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageCategory.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.category21;
            this.btnManageCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManageCategory.Location = new System.Drawing.Point(116, 28);
            this.btnManageCategory.Name = "btnManageCategory";
            this.btnManageCategory.Size = new System.Drawing.Size(87, 80);
            this.btnManageCategory.TabIndex = 6;
            this.btnManageCategory.UseVisualStyleBackColor = false;
            this.btnManageCategory.Click += new System.EventHandler(this.ManageCategory_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduct.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.product11;
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProduct.Location = new System.Drawing.Point(227, 28);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(83, 80);
            this.btnProduct.TabIndex = 5;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrice.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.money;
            this.btnPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrice.Location = new System.Drawing.Point(341, 28);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(83, 80);
            this.btnPrice.TabIndex = 2;
            this.btnPrice.UseVisualStyleBackColor = false;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSupplier.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.supp2;
            this.btnSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSupplier.Location = new System.Drawing.Point(458, 28);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(83, 80);
            this.btnSupplier.TabIndex = 7;
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnPromotion
            // 
            this.btnPromotion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPromotion.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.promotion1;
            this.btnPromotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPromotion.Location = new System.Drawing.Point(572, 28);
            this.btnPromotion.Name = "btnPromotion";
            this.btnPromotion.Size = new System.Drawing.Size(87, 80);
            this.btnPromotion.TabIndex = 9;
            this.btnPromotion.UseVisualStyleBackColor = false;
            this.btnPromotion.Click += new System.EventHandler(this.btnPromotion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnProposed);
            this.groupBox2.Controls.Add(this.btnHeadquater);
            this.groupBox2.Controls.Add(this.btnBranchOffice);
            this.groupBox2.Location = new System.Drawing.Point(38, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 136);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IMPORT MANAGEMENT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Branch Receipt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Headquarter Receipt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Propose Receipt";
            // 
            // btnProposed
            // 
            this.btnProposed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProposed.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.propose;
            this.btnProposed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProposed.Location = new System.Drawing.Point(23, 28);
            this.btnProposed.Name = "btnProposed";
            this.btnProposed.Size = new System.Drawing.Size(83, 80);
            this.btnProposed.TabIndex = 10;
            this.btnProposed.UseVisualStyleBackColor = false;
            this.btnProposed.Click += new System.EventHandler(this.btnProposed_Click);
            // 
            // btnHeadquater
            // 
            this.btnHeadquater.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHeadquater.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.head;
            this.btnHeadquater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeadquater.Location = new System.Drawing.Point(138, 28);
            this.btnHeadquater.Name = "btnHeadquater";
            this.btnHeadquater.Size = new System.Drawing.Size(83, 80);
            this.btnHeadquater.TabIndex = 11;
            this.btnHeadquater.UseVisualStyleBackColor = false;
            this.btnHeadquater.Click += new System.EventHandler(this.btnHeadquater_Click);
            // 
            // btnBranchOffice
            // 
            this.btnBranchOffice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBranchOffice.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.branch;
            this.btnBranchOffice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBranchOffice.Location = new System.Drawing.Point(252, 28);
            this.btnBranchOffice.Name = "btnBranchOffice";
            this.btnBranchOffice.Size = new System.Drawing.Size(83, 80);
            this.btnBranchOffice.TabIndex = 12;
            this.btnBranchOffice.UseVisualStyleBackColor = false;
            this.btnBranchOffice.Click += new System.EventHandler(this.btnBranchOffice_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnInvoice);
            this.groupBox3.Controls.Add(this.btnManageAccount);
            this.groupBox3.Controls.Add(this.btnStatistic);
            this.groupBox3.Location = new System.Drawing.Point(432, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 136);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(278, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Statistic";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Account";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Invoice";
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInvoice.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.invoice;
            this.btnInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInvoice.Location = new System.Drawing.Point(29, 28);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(83, 80);
            this.btnInvoice.TabIndex = 3;
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnManageAccount.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.acc;
            this.btnManageAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageAccount.Location = new System.Drawing.Point(144, 28);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(83, 80);
            this.btnManageAccount.TabIndex = 13;
            this.btnManageAccount.UseVisualStyleBackColor = false;
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStatistic.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.sta;
            this.btnStatistic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatistic.Location = new System.Drawing.Point(258, 28);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(83, 80);
            this.btnStatistic.TabIndex = 14;
            this.btnStatistic.UseVisualStyleBackColor = false;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.Transparent;
            this.lblLogout.Location = new System.Drawing.Point(782, 9);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(43, 13);
            this.lblLogout.TabIndex = 18;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "Log out";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // GUI_MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication.Properties.Resources._8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 408);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI_MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_MainFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnManageCategory;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnPromotion;
        private System.Windows.Forms.Button btnProposed;
        private System.Windows.Forms.Button btnHeadquater;
        private System.Windows.Forms.Button btnBranchOffice;
        private System.Windows.Forms.Button btnManageAccount;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel lblLogout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}