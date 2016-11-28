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
            if (validarId("Favor ingresar el id del detalle factura que desea buscar") && ValidarBuscar())
                Pasar(DetalleFacturaBll.Buscar(u.StringToint(IdtextBox.Text)));
        }

        private void Pasar(DetalleFacturas df)
        {
            var g = DetalleFacturaBll.Buscar(u.StringToint(IdtextBox.Text));
            IdtextBox.Text = df.FacturaId.ToString();
            IdClientetextBox.Text = df.ClienteId.ToString();
            ProductosdataGridView.DataSource = null;
            ProductosdataGridView.DataSource = df.Productos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del cliente que desea buscar") && ValidarBuscar())
                Pasar2(ClienteBLL.Buscar(u.StringToint(IdClientetextBox.Text)));
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

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del empleado que desea eliminar") && ValidarBuscar())
            {
                DetalleFacturaBll.Eliminar(u.StringToint(IdtextBox.Text));
                MessageBox.Show("Cliente Eliminado");
            }
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

        public bool ValidTex()
        {
            if (string.IsNullOrEmpty(NombretextBox.Text) && string.IsNullOrEmpty(IdClientetextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Ingrese el nombre");
                IdClienteerrorProvider.SetError(IdClientetextBox, "Ingrese el id");
                MessageBox.Show("Llenar los campos");
            }
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Ingrese el nombre");
                return false;
            }
            if (string.IsNullOrEmpty(IdClientetextBox.Text))
            {
                NombreerrorProvider.Clear();
                IdClienteerrorProvider.SetError(IdClientetextBox, "Ingrese su apellido");
                return false;
            }
            return true;
        }

        private bool ValidarExistente(int aux)
        {
            if (DetalleFacturaBll.GetListaId(aux).Count() > 0)
            {
                MessageBox.Show("Este cliente existe....");
                return false;
            }
            else
            {
                return true;
            }
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
            if (DetalleFacturaBll.Buscar(u.StringToint(IdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }
            return true;
        }

        private bool ValidarBuscar2()
        {
            if (ClienteBLL.Buscar(u.StringToint(IdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }
            return true;
        }
    }
}
