namespace WindowsFormsApplication.BranchOfficeReceipt_Management
{
    partial class GUI_PrintBranch
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
            this.crvBranchOffice = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvBranchOffice
            // 
            this.crvBranchOffice.ActiveViewIndex = -1;
            this.crvBranchOffice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBranchOffice.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBranchOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvBranchOffice.Location = new System.Drawing.Point(0, 0);
            this.crvBranchOffice.Name = "crvBranchOffice";
            this.crvBranchOffice.Size = new System.Drawing.Size(922, 417);
            this.crvBranchOffice.TabIndex = 0;
            this.crvBranchOffice.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // GUI_PrintBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 417);
            this.Controls.Add(this.crvBranchOffice);
            this.Name = "GUI_PrintBranch";
            this.Text = "GUI_PrintBranch";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBranchOffice;
    }
}