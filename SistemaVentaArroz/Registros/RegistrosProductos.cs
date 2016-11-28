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
            if (validarId("Favor ingresar el id del usuario que desea buscar") && ValidarBuscar())
                LlenarProducto(ProductoBll.Buscar(u.StringToint(IdtextBox.Text)));
        }

        public void LlenarProducto(Productos producto)
        {
            //Clientes cli = new Clientes;
            var pd = ProductoBll.Buscar(u.StringToint(IdtextBox.Text));
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
            if (ValidTextB() && ValidarExistente(NombretextBox.Text))
            {
                ProductoBll.Guardar(producto);
                MessageBox.Show("Guardado con exito!!!!");
            }     
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del cliente que desea eliminar") && ValidarBuscar())
            {
                ProductoBll.Eliminar(u.StringToint(IdtextBox.Text));
                MessageBox.Show("Usuario Eliminado");
            }
        }

        private bool ValidarExistente(string aux)
        {
            if (UsuarioBll.GetListaNombreUsuario(aux).Count() > 0)
            {
                MessageBox.Show("Este usuario existe....");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidTextB()
        {
            if (string.IsNullOrEmpty(NombretextBox.Text) && (string.IsNullOrEmpty(DescripciontextBox.Text) && string.IsNullOrEmpty(CantidadtextBox.Text)))
            {
                NombreerrorProvider.SetError(NombretextBox, "Ingrese el nombre");
                DescripcionerrorProvider.SetError(DescripciontextBox, "Ingrese la descripcion");
                CantidaderrorProvider.SetError(CantidadtextBox, "Ingrese cantidad");
                PrecioerrorProvider.SetError(PreciotextBox, "Ingrese el precio");
                MessageBox.Show("Llenar todos los campos");
            }
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Ingrese el nombre");
                return false;
            }
            if (string.IsNullOrEmpty(CantidadtextBox.Text))
            {
                NombreerrorProvider.Clear();
                CantidaderrorProvider.SetError(CantidadtextBox, "Ingrese cantidad");
                return false;
            }
            if (string.IsNullOrEmpty(PreciotextBox.Text))
            {
                NombreerrorProvider.Clear();
                CantidaderrorProvider.Clear();
                PrecioerrorProvider.SetError(PreciotextBox, "ingrese el precio");
                return false;
            }
            if (string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                NombreerrorProvider.Clear();
                CantidaderrorProvider.Clear();
                PrecioerrorProvider.Clear();
                DescripcionerrorProvider.SetError(DescripciontextBox, "Ingrese la humeda");
                return false;
            }
            
            return true;
        }

        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(IdtextBox.Text))
            {
                IderrorProvider.SetError(IdtextBox, "Ingresar el ID");
                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidarBuscar()
        {
            if (UsuarioBll.Buscar(u.StringToint(IdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }
            return true;
        }

        private bool ValidarExiste(string aux)
        {
            if (UsuarioBll.GetListaNombreUsuario(aux).Count() > 0)
            {
                MessageBox.Show("Este nombre de Usuario ya existe, favor intentar con otro nombre de usario...");
                return false;
            }
            return true;
        }
    }
}
