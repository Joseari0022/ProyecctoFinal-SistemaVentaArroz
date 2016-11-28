namespace SistemaVentaArroz.Consultas
{
    partial class ReportingViewerEmpleados
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
            this.ReportEmpleadosViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportEmpleadosViewer
            // 
            this.ReportEmpleadosViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportEmpleadosViewer.LocalReport.ReportEmbeddedResource = "SistemaVentaArroz.Reportes.ReporteEmpleados.rdlc";
            this.ReportEmpleadosViewer.Location = new System.Drawing.Point(0, 0);
            this.ReportEmpleadosViewer.Name = "ReportEmpleadosViewer";
            this.ReportEmpleadosViewer.Size = new System.Drawing.Size(978, 562);
            this.ReportEmpleadosViewer.TabIndex = 0;
            this.ReportEmpleadosViewer.Load += new System.EventHandler(this.ReportEmpleadosViewer_Load);
            // 
            // ReportingViewerEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 562);
            this.Controls.Add(this.ReportEmpleadosViewer);
            this.Name = "ReportingViewerEmpleados";
            this.Text = "ReportingViewerEmpleados";
            this.Load += new System.EventHandler(this.ReportingViewerEmpleados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportEmpleadosViewer;
    }
}