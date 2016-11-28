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
    public partial class ReportingViewerDetalleFactura : Form
    {
        public ReportingViewerDetalleFactura()
        {
            InitializeComponent();
        }

        private void ReportingViewerDetalleFactura_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
