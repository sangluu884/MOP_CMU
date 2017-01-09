namespace WindowsFormsApplication.Statistic_Management
{
    partial class GUI_ReviewsStatistic
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
            this.cachedCrystalReportBranchOffice1 = new WindowsFormsApplication.CachedCrystalReportBranchOffice();
            this.crvStatistic = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvStatistic
            // 
            this.crvStatistic.ActiveViewIndex = -1;
            this.crvStatistic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvStatistic.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvStatistic.Location = new System.Drawing.Point(0, 0);
            this.crvStatistic.Name = "crvStatistic";
            this.crvStatistic.Size = new System.Drawing.Size(679, 463);
            this.crvStatistic.TabIndex = 0;
            this.crvStatistic.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // GUI_ReviewsStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 463);
            this.Controls.Add(this.crvStatistic);
            this.Name = "GUI_ReviewsStatistic";
            this.Text = "GUI_ReviewsStatistic";
            this.Load += new System.EventHandler(this.GUI_PrintReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CachedCrystalReportBranchOffice cachedCrystalReportBranchOffice1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvStatistic;
    }
}