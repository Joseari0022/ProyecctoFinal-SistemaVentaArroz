﻿namespace SistemaVentaArroz.Consultas
{
    partial class ReportingViewerUsuarios
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
            this.ReportUsuariosViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportUsuariosViewer
            // 
            this.ReportUsuariosViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportUsuariosViewer.LocalReport.ReportEmbeddedResource = "SistemaVentaArroz.Reportes.ReporteUsuarios.rdlc";
            this.ReportUsuariosViewer.Location = new System.Drawing.Point(0, 0);
            this.ReportUsuariosViewer.Name = "ReportUsuariosViewer";
            this.ReportUsuariosViewer.Size = new System.Drawing.Size(981, 553);
            this.ReportUsuariosViewer.TabIndex = 0;
            this.ReportUsuariosViewer.Load += new System.EventHandler(this.ReportUsuariosViewer_Load);
            // 
            // ReportingViewerUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.ReportUsuariosViewer);
            this.Name = "ReportingViewerUsuarios";
            this.Text = "ReportingViewerUsuarios";
            this.Load += new System.EventHandler(this.ReportingViewerUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportUsuariosViewer;
    }
}