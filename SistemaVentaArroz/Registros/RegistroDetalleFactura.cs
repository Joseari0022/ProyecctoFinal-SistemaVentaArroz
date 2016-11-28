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

namespace SistemaVentaArroz.Registros
{
    public partial class RegistroDetalleFactura : Form
    {
        public RegistroDetalleFactura()
        {
            InitializeComponent();
        }

        Utilidades u = new Utilidades();
        DetalleFacturas df = new DetalleFacturas();
        private void Idbutton_Click(object sender, EventArgs e)
        {
            Pasar(DetalleFacturaBll.Buscar(u.String(IdtextBox.Text)));
        }

        private void Pasar(DetalleFacturas df)
        {
            var g = DetalleFacturaBll.Buscar(u.String(IdtextBox.Text));
            IdtextBox.Text = df.FacturaId.ToString();
            IdClientetextBox.Text = df.ClienteId.ToString();
            ProductosdataGridView.DataSource = null;
            ProductosdataGridView.DataSource = df.Productos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pasar2(ClienteBLL.Buscar(u.String(IdClientetextBox.Text)));
        }

        private void Pasar2(Clientes cli)
        {
            NombretextBox.Text = cli.NombreCliente.ToString();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            //Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            LlenarClase(df);
            DetalleFacturaBll.Guardar(df);
            MessageBox.Show("Guardado con exito!!!");
        }

        private void LlenarClase(DetalleFacturas dfl)
        {
            dfl.ClienteId = int.Parse(IdClientetextBox.Text);
            dfl.FechaVenta = FechaVentadateTimePicker.Value;
        }

        private void LlenarCombo()
        {
            ProductocomboBox.DataSource = ProductoBll.GetLista();
            ProductocomboBox.ValueMember = "ProductoId";
            ProductocomboBox.DisplayMember = "Nombre";
        }

        private void NombreClientecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void RegistroDetalleFactura_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            df.Productos.Add(new Productos((int)ProductocomboBox.SelectedValue, ProductocomboBox.Text));
            ProductosdataGridView.DataSource = null;
            ProductosdataGridView.DataSource = df.Productos;
        }

        
    }
}
