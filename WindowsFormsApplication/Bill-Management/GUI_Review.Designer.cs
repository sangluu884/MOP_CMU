namespace WindowsFormsApplication.Bill_Management
{
    partial class GUI_Review
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
            this.crvReview = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReview
            // 
            this.crvReview.ActiveViewIndex = -1;
            this.crvReview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReview.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReview.Location = new System.Drawing.Point(0, 0);
            this.crvReview.Name = "crvReview";
            this.crvReview.Size = new System.Drawing.Size(949, 447);
            this.crvReview.TabIndex = 0;
            this.crvReview.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // GUI_Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 447);
            this.Controls.Add(this.crvReview);
            this.Name = "GUI_Review";
            this.Text = "GUI_Review";
            this.Load += new System.EventHandler(this.GUI_Review_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReview;
    }
}