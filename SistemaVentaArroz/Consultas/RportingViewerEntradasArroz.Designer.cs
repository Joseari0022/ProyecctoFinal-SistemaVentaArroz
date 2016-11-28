namespace SistemaVentaArroz.Consultas
{
    partial class ReportingViewerEntradasArroz
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
            this.ReportEntradasArrozViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportEntradasArrozViewer
            // 
            this.ReportEntradasArrozViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportEntradasArrozViewer.LocalReport.ReportEmbeddedResource = "SistemaVentaArroz.Reportes.ReporteEntradaArroz.rdlc";
            this.ReportEntradasArrozViewer.Location = new System.Drawing.Point(0, 0);
            this.ReportEntradasArrozViewer.Name = "ReportEntradasArrozViewer";
            this.ReportEntradasArrozViewer.Size = new System.Drawing.Size(1002, 558);
            this.ReportEntradasArrozViewer.TabIndex = 0;
            this.ReportEntradasArrozViewer.Load += new System.EventHandler(this.ReportEntradasArrozViewer_Load);
            // 
            // ReportingViewerEntradasArroz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 558);
            this.Controls.Add(this.ReportEntradasArrozViewer);
            this.Name = "ReportingViewerEntradasArroz";
            this.Text = "ReportingViewerEntradasArroz";
            this.Load += new System.EventHandler(this.RportingViewerEntradasArroz_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportEntradasArrozViewer;
    }
}