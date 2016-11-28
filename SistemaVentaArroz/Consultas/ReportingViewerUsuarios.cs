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
    public partial class ReportingViewerUsuarios : Form
    {
        public ReportingViewerUsuarios()
        {
            InitializeComponent();
        }

        private void ReportingViewerUsuarios_Load(object sender, EventArgs e)
        {

            this.ReportUsuariosViewer.RefreshReport();
        }

        private void ReportUsuariosViewer_Load(object sender, EventArgs e)
        {
            ReportUsuariosViewer.Reset();
            ReportUsuariosViewer.ProcessingMode = ProcessingMode.Local;
            ReportUsuariosViewer.LocalReport.ReportPath = @"C:\Users\Jose Gonzalez\Desktop\ProyectoFinal2\SistemaVentaArroz\SistemaVentaArroz\Reportes\ReporteUsuarios.rdlc";
            ReportDataSource source = new ReportDataSource("UsuariosDataSet",
            UsuarioBll.GetLista());
            ReportUsuariosViewer.LocalReport.DataSources.Add(source);
            this.ReportUsuariosViewer.LocalReport.Refresh();
        }
    }
}
