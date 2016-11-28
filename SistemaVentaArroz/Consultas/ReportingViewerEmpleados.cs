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

namespace SistemaVentaArroz.Consultas
{
    public partial class ReportingViewerEmpleados : Form
    {
        public ReportingViewerEmpleados()
        {
            InitializeComponent();
        }

        private void ReportingViewerEmpleados_Load(object sender, EventArgs e)
        {

            this.ReportEmpleadosViewer.RefreshReport();
        }

        private void ReportEmpleadosViewer_Load(object sender, EventArgs e)
        {
            ReportEmpleadosViewer.Reset();
            ReportEmpleadosViewer.ProcessingMode = ProcessingMode.Local;
            ReportEmpleadosViewer.LocalReport.ReportPath = @"C:\Users\Jose Gonzalez\Desktop\ProyectoFinal2\SistemaVentaArroz\SistemaVentaArroz\Reportes\ReporteEmpleados.rdlc";
            ReportDataSource source = new ReportDataSource("EmpleadosDataSet",
            EmpleadoBll.GetLista());
            ReportEmpleadosViewer.LocalReport.DataSources.Add(source);
            this.ReportEmpleadosViewer.LocalReport.Refresh();
        }
    }
}
