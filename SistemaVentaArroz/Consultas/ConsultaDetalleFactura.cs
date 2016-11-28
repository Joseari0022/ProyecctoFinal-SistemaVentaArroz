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
using Entidades;
using SistemaVentaArroz;

namespace SistemaVentaArroz.Consultas
{
    public partial class ConsultaDetalleFactura : Form
    {
        public ConsultaDetalleFactura()
        {
            InitializeComponent();
        }

        Utilidades u = new Utilidades();
        DetalleFacturas dfl = new DetalleFacturas();
        public object ConsultaGrupodataGridView { get; private set; }

        private void Idbutton_Click(object sender, EventArgs e)
        {
            BuscaId(DetalleFacturaBll.Buscar(u.StringToint(FiltrotextBox.Text)));
        }

        private void BuscaId(DetalleFacturas detf)
        {
            var dft = DetalleFacturaBll.Buscar(u.StringToint(FiltrotextBox.Text));
            FiltrotextBox.Text = detf.FacturaId.ToString();
            ClienteIdtextBox.Text = detf.ClienteId.ToString();
            ConsultaDetalleFacturadataGridView.DataSource = null;
            ConsultaDetalleFacturadataGridView.DataSource = detf.Productos;
        }

        private void Llenar(string aux)
        {
            var df = DetalleFacturaBll.GetListaIdCliente(int.Parse(FiltrotextBox.Text));
            FiltrotextBox.Text = dfl.ClienteId.ToString();
            ConsultaDetalleFacturadataGridView.DataSource = null;
            ConsultaDetalleFacturadataGridView.DataSource = dfl.Productos;
        }

        private void LlenarFiltro()
        {
            FiltrarcomboBox.Items.Insert(0, "FacturaId");
            FiltrarcomboBox.Items.Insert(1, "ClienteId");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = " Id";
            ConsultaDetalleFacturadataGridView.DataSource = DetalleFacturaBll.GetLista();
        }

        private void ConsultaDetalleFactura_Load(object sender, EventArgs e)
        {
            LlenarFiltro();
        }
    }
}
