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

namespace SistemaVentaArroz
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosUsuarios ru = new Registros.RegistrosUsuarios();
            ru.MdiParent = this;
            ru.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosClientes rc = new Registros.RegistrosClientes();
            rc.MdiParent = this;
            rc.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosEmpleados re = new Registros.RegistrosEmpleados();
            re.MdiParent = this;
            re.Show();
        }

        private void entradaArrozToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosEntradaArroz rea = new Registros.RegistrosEntradaArroz();
            rea.MdiParent = this;
            rea.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosProductos rp = new Registros.RegistrosProductos();
            rp.MdiParent = this;
            rp.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaUsuarios cu = new Consultas.ConsultaUsuarios();
            cu.MdiParent = this;
            cu.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaClientes cc = new Consultas.ConsultaClientes();
            cc.MdiParent = this;
            cc.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaEmpleados ce = new Consultas.ConsultaEmpleados();
            ce.MdiParent = this;
            ce.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaProductos cp = new Consultas.ConsultaProductos();
            cp.MdiParent = this;
            cp.Show();
        }

        private void entradaArrozToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaEntradaArroz cae = new Consultas.ConsultaEntradaArroz();
            cae.MdiParent = this;
            cae.Show(); 
        }

        private void detalleFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistroDetalleFactura rdf = new Registros.RegistroDetalleFactura();
            rdf.MdiParent = this;
            rdf.Show();
        }

        private void detalleFacturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaDetalleFactura cdf = new Consultas.ConsultaDetalleFactura();
            cdf.MdiParent = this;
            cdf.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
