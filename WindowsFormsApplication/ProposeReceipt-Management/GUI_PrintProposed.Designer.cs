namespace WindowsFormsApplication.ProposeReceipt_Management
{
    partial class GUI_PrintProposed
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
            this.crv_ProposedView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_ProposedView
            // 
            this.crv_ProposedView.ActiveViewIndex = -1;
            this.crv_ProposedView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_ProposedView.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_ProposedView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_ProposedView.Location = new System.Drawing.Point(0, 0);
            this.crv_ProposedView.Name = "crv_ProposedView";
            this.crv_ProposedView.Size = new System.Drawing.Size(730, 413);
            this.crv_ProposedView.TabIndex = 0;
            this.crv_ProposedView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // GUI_PrintProposed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 413);
            this.Controls.Add(this.crv_ProposedView);
            this.Name = "GUI_PrintProposed";
            this.Text = "GUI_PrintProposed";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_ProposedView;
    }
}