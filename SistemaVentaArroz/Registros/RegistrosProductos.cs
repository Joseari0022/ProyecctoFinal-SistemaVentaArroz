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
    public partial class RegistrosProductos : Form
    {
        public RegistrosProductos()
        {
            InitializeComponent();
        }

        Utilidades u = new Utilidades();
        private void Idbutton_Click(object sender, EventArgs e)
        {
            LlenarProducto(ProductoBll.Buscar(u.String(IdtextBox.Text)));
        }

        public void LlenarProducto(Productos producto)
        {
            //Clientes cli = new Clientes;
            var pd = ProductoBll.Buscar(u.String(IdtextBox.Text));
            IdtextBox.Text = producto.ProductoId.ToString();
            NombretextBox.Text = producto.Nombre.ToString();
            DescripciontextBox.Text = producto.Descripcion.ToString();
            PreciotextBox.Text = producto.Precio.ToString();
            CantidadtextBox.Text = producto.Cantidad.ToString();
            producto.FechaEntrega = FechaDateTimePicke.Value;
            FacturadataGridView.DataSource = null;
            FacturadataGridView.DataSource = producto.DetalleFacturas;
        }

        public void LlenarClase(Productos p)
        {
            p.Nombre = NombretextBox.Text;
            p.Descripcion = DescripciontextBox.Text;
            p.Precio = Convert.ToInt32(PreciotextBox.Text);
            p.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
            p.FechaEntrega = FechaDateTimePicke.Value;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            NombretextBox.Clear();
            DescripciontextBox.Clear();
            CantidadtextBox.Clear();
            PreciotextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            LlenarClase(producto);
            ProductoBll.Guardar(producto);
            MessageBox.Show("Guardado con exito!!!!");
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            ProductoBll.Eliminar(u.String(IdtextBox.Text));
            MessageBox.Show("Usuario Eliminado");
        }
    }
}
