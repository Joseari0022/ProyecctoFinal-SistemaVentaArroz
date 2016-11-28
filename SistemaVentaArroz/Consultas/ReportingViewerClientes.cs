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
using BLL;

namespace SistemaVentaArroz.Consultas
{
    public partial class ReportingViewerClientes : Form
    {
        public ReportingViewerClientes()
        {
            InitializeComponent();
        }

        private void ReportingViewerClientes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Jose Gonzalez\Desktop\ProyectoFinal2\SistemaVentaArroz\SistemaVentaArroz\Reportes\ReporteClientes.rdlc";
            ReportDataSource source = new ReportDataSource("ClientesDataSet",
            ClienteBLL.GetListaId());
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.LocalReport.Refresh();
        }
    }
}
