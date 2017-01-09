namespace WindowsFormsApplication.Statistic_Management
{
    partial class GUI_ManageStatistic
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
            this.btnprint = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbofill = new System.Windows.Forms.ComboBox();
            this.lstdata = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtto = new System.Windows.Forms.DateTimePicker();
            this.dtfrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboyear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbomonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboday = new System.Windows.Forms.ComboBox();
            this.rbdistance = new System.Windows.Forms.RadioButton();
            this.rbdate = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(342, 152);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 31;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(189, 152);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 30;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(14, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Filter";
            // 
            // cbofill
            // 
            this.cbofill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbofill.FormattingEnabled = true;
            this.cbofill.Items.AddRange(new object[] {
            "All",
            "Top 5",
            "Top 10",
            "Top 20"});
            this.cbofill.Location = new System.Drawing.Point(49, 152);
            this.cbofill.Name = "cbofill";
            this.cbofill.Size = new System.Drawing.Size(121, 21);
            this.cbofill.TabIndex = 28;
            // 
            // lstdata
            // 
            this.lstdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstdata.Location = new System.Drawing.Point(17, 187);
            this.lstdata.Name = "lstdata";
            this.lstdata.ReadOnly = true;
            this.lstdata.Size = new System.Drawing.Size(638, 202);
            this.lstdata.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(371, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "TO";
            // 
            // dtto
            // 
            this.dtto.Location = new System.Drawing.Point(455, 112);
            this.dtto.Name = "dtto";
            this.dtto.Size = new System.Drawing.Size(200, 20);
            this.dtto.TabIndex = 25;
            // 
            // dtfrom
            // 
            this.dtfrom.Location = new System.Drawing.Point(114, 112);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Size = new System.Drawing.Size(200, 20);
            this.dtfrom.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(492, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "YEAR";
            // 
            // cboyear
            // 
            this.cboyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboyear.FormattingEnabled = true;
            this.cboyear.Items.AddRange(new object[] {
            "All",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cboyear.Location = new System.Drawing.Point(534, 68);
            this.cboyear.Name = "cboyear";
            this.cboyear.Size = new System.Drawing.Size(121, 21);
            this.cboyear.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(289, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "MONTH";
            // 
            // cbomonth
            // 
            this.cbomonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomonth.FormattingEnabled = true;
            this.cbomonth.Items.AddRange(new object[] {
            "All",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbomonth.Location = new System.Drawing.Point(342, 68);
            this.cbomonth.Name = "cbomonth";
            this.cbomonth.Size = new System.Drawing.Size(121, 21);
            this.cbomonth.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(111, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "DAY";
            // 
            // cboday
            // 
            this.cboday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboday.FormattingEnabled = true;
            this.cboday.Items.AddRange(new object[] {
            "All",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cboday.Location = new System.Drawing.Point(143, 68);
            this.cboday.Name = "cboday";
            this.cboday.Size = new System.Drawing.Size(121, 21);
            this.cboday.TabIndex = 18;
            // 
            // rbdistance
            // 
            this.rbdistance.AutoSize = true;
            this.rbdistance.BackColor = System.Drawing.Color.Transparent;
            this.rbdistance.Location = new System.Drawing.Point(14, 112);
            this.rbdistance.Name = "rbdistance";
            this.rbdistance.Size = new System.Drawing.Size(67, 17);
            this.rbdistance.TabIndex = 17;
            this.rbdistance.TabStop = true;
            this.rbdistance.Text = "Distance";
            this.rbdistance.UseVisualStyleBackColor = false;
            this.rbdistance.CheckedChanged += new System.EventHandler(this.rbdistance_CheckedChanged);
            // 
            // rbdate
            // 
            this.rbdate.AutoSize = true;
            this.rbdate.BackColor = System.Drawing.Color.Transparent;
            this.rbdate.Location = new System.Drawing.Point(16, 69);
            this.rbdate.Name = "rbdate";
            this.rbdate.Size = new System.Drawing.Size(48, 17);
            this.rbdate.TabIndex = 16;
            this.rbdate.TabStop = true;
            this.rbdate.Text = "Date";
            this.rbdate.UseVisualStyleBackColor = false;
            this.rbdate.CheckedChanged += new System.EventHandler(this.rbdate_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Statistic Management";
            // 
            // GUI_ManageStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication.Properties.Resources._8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 458);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbofill);
            this.Controls.Add(this.lstdata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtto);
            this.Controls.Add(this.dtfrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboyear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbomonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboday);
            this.Controls.Add(this.rbdistance);
            this.Controls.Add(this.rbdate);
            this.Name = "GUI_ManageStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_ManageStatistic";
            ((System.ComponentModel.ISupportInitialize)(this.lstdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbofill;
        private System.Windows.Forms.DataGridView lstdata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtto;
        private System.Windows.Forms.DateTimePicker dtfrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboyear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbomonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboday;
        private System.Windows.Forms.RadioButton rbdistance;
        private System.Windows.Forms.RadioButton rbdate;
        private System.Windows.Forms.Label label6;
    }
}