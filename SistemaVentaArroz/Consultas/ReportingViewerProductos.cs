using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Microsoft.Reporting.WinForms;

namespace SistemaVentaArroz.Consultas
{
    public partial class ReportingViewerProductos : Form
    {
        public ReportingViewerProductos()
        {
            InitializeComponent();
        }

        private void ReportingViewerProductos_Load(object sender, EventArgs e)
        {

            this.ReportProductosViewer.RefreshReport();
        }

        private void ReportProductosViewer_Load(object sender, EventArgs e)
        {
            ReportProductosViewer.Reset();
            ReportProductosViewer.ProcessingMode = ProcessingMode.Local;
            ReportProductosViewer.LocalReport.ReportPath = @"C:\Users\Jose Gonzalez\Desktop\ProyectoFinal2\SistemaVentaArroz\SistemaVentaArroz\Reportes\ReporteProductos.rdlc";
            ReportDataSource source = new ReportDataSource("ProductosDataSet",
            ProductoBll.GetLista());
            ReportProductosViewer.LocalReport.DataSources.Add(source);
            this.ReportProductosViewer.LocalReport.Refresh();
        }
    }
}
