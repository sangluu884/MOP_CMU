namespace WindowsFormsApplication.HeadquarterReceipt_Management
{
    partial class GUI_PrintHeadquarter
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
            this.crvHeadquarter = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvHeadquarter
            // 
            this.crvHeadquarter.ActiveViewIndex = -1;
            this.crvHeadquarter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvHeadquarter.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvHeadquarter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvHeadquarter.Location = new System.Drawing.Point(0, 0);
            this.crvHeadquarter.Name = "crvHeadquarter";
            this.crvHeadquarter.Size = new System.Drawing.Size(816, 344);
            this.crvHeadquarter.TabIndex = 0;
            // 
            // GUI_PrintHeadquarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 344);
            this.Controls.Add(this.crvHeadquarter);
            this.Name = "GUI_PrintHeadquarter";
            this.Text = "GUI_PrintHeadquarter";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvHeadquarter;
    }
}