using BLL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentaArroz;

namespace SistemaVentaArroz.Consultas
{
    public partial class ReportingViewerEntradasArroz : Form
    {
        public ReportingViewerEntradasArroz()
        {
            InitializeComponent();
        }

        private void RportingViewerEntradasArroz_Load(object sender, EventArgs e)
        {

            this.ReportEntradasArrozViewer.RefreshReport();
        }

        Utilidades u = new Utilidades();
        private void ReportEntradasArrozViewer_Load(object sender, EventArgs e)
        {
            ReportEntradasArrozViewer.Reset();
            ReportEntradasArrozViewer.ProcessingMode = ProcessingMode.Local;
            ReportEntradasArrozViewer.LocalReport.ReportPath = @"C:\Users\Jose Gonzalez\Desktop\ProyectoFinal2\SistemaVentaArroz\SistemaVentaArroz\Reportes\ReporteEntradaArroz.rdlc";
            ReportEntradasArrozViewer.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("EntradasArrozDataSet",
            EntradaArrozBll.GetLista());
            ReportEntradasArrozViewer.LocalReport.DataSources.Add(source);
            ReportEntradasArrozViewer.LocalReport.Refresh();
            ReportEntradasArrozViewer.Show();
            this.ReportEntradasArrozViewer.LocalReport.Refresh();
        }
    }
}
