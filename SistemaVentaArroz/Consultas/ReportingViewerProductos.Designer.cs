namespace SistemaVentaArroz.Consultas
{
    partial class ReportingViewerProductos
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
            this.ReportProductosViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportProductosViewer
            // 
            this.ReportProductosViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportProductosViewer.LocalReport.ReportEmbeddedResource = "SistemaVentaArroz.Reportes.ReporteProductos.rdlc";
            this.ReportProductosViewer.Location = new System.Drawing.Point(0, 0);
            this.ReportProductosViewer.Name = "ReportProductosViewer";
            this.ReportProductosViewer.Size = new System.Drawing.Size(1016, 557);
            this.ReportProductosViewer.TabIndex = 0;
            this.ReportProductosViewer.Load += new System.EventHandler(this.ReportProductosViewer_Load);
            // 
            // ReportingViewerProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 557);
            this.Controls.Add(this.ReportProductosViewer);
            this.Name = "ReportingViewerProductos";
            this.Text = "ReportingViewerProductos";
            this.Load += new System.EventHandler(this.ReportingViewerProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportProductosViewer;
    }
}