using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;
using SistemaVentaArroz;

namespace SistemaVentaArroz.Registros
{
    public partial class RegistrosEntradaArroz : Form
    {
        public RegistrosEntradaArroz()
        {
            InitializeComponent();
        }

        Utilidades u = new Utilidades();

        private void IdBuscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del usuario que desea buscar") && ValidarBuscar())
                Llenarentrada(EntradaArrozBll.Buscar(u.StringToint(IdtextBox.Text)));
        }

        private void Llenarentrada(EntradasArroz ea)
        {
            IdtextBox.Text = ea.EntradaArrozId.ToString();
            NombreClientetextBox.Text = ea.NombresClientes.ToString();
            TipoArrozcomboBox.SelectedItem = ea.TipoArroz.ToString();
            CantidadtextBox.Text = ea.Cantidad.ToString();
            PreciotextBox.Text = ea.Precio.ToString();
            HumedadtextBox.Text = ea.Humedad.ToString();
            NombreGuardaAlmacentextBox.Text = ea.AutorizadaGuardaAlmacen.ToString();
            CargotextBox.Text = ea.Cargo.ToString();
            FechaEntradadateTimePicker.Value = ea.FechaEntrada;
        }

        private void IdClientebutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del cliente que desea buscar") && ValidarBuscar2())
                LlenarClase2(ClienteBLL.Buscar(u.StringToint(IdClientetextBox.Text)));
        }

        private void LlenarClase2(Clientes cli)
        {
            NombreClientetextBox.Text = cli.NombreCliente.ToString();
        }

        private void IdGuardaAlmacenbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del empleado que desea buscar") && ValidarBuscar3())
                LlenarClase3(EmpleadoBll.Buscar(u.StringToint(IdGuardaAlmacentextBox.Text)));
        }

        private void LlenarClase3(Empleados empl)
        {
            NombreGuardaAlmacentextBox.Text = empl.Nombres.ToString();
            CargotextBox.Text = empl.Cargo.ToString();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            IdtextBox.Clear();
            IdClientetextBox.Clear();
            IdGuardaAlmacentextBox.Clear();
            NombreClientetextBox.Clear();
            NombreGuardaAlmacentextBox.Clear();
            CargotextBox.Clear();
            CantidadtextBox.Clear();
            PreciotextBox.Clear();
            HumedadtextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            EntradasArroz entradaarroz = new EntradasArroz();
            LlenarCla(entradaarroz);
            EntradaArrozBll.Guardar(entradaarroz);
            MessageBox.Show("Guardado con exito!!!!");
        }

        private void LlenarCla(EntradasArroz eta)
        {
            eta.NombresClientes = NombreClientetextBox.Text;
            eta.TipoArroz = TipoArrozcomboBox.SelectedItem.ToString();
            eta.Cantidad = int.Parse(CantidadtextBox.Text);
            eta.Precio = int.Parse(PreciotextBox.Text);
            eta.Humedad = HumedadtextBox.Text;
            eta.AutorizadaGuardaAlmacen = NombreGuardaAlmacentextBox.Text;
            eta.Cargo = CargotextBox.Text;
            eta.FechaEntrada = FechaEntradadateTimePicker.Value;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del cliente que desea eliminar") && ValidarBuscar())
            {
                EntradaArrozBll.Eliminar(u.StringToint(IdtextBox.Text));
                MessageBox.Show("Eliminado con exito!!!!");
            }
        }

        public bool ValidTextB()
        {
            if (string.IsNullOrEmpty(NombreClientetextBox.Text) && string.IsNullOrEmpty(CantidadtextBox.Text) && string.IsNullOrEmpty(HumedadtextBox.Text))
            {
                NombreClienteerrorProvider.SetError(NombreClientetextBox, "Ingrese el nombre");
                CantidaderrorProvider.SetError(CantidadtextBox, "Ingrese cantidad");
                PrecioerrorProvider.SetError(PreciotextBox, "Ingrese el precio");
                HumedaderrorProvider.SetError(HumedadtextBox, "Ingrese la humedad");
                MessageBox.Show("Llenar todos los campos");
            }
            if (string.IsNullOrEmpty(NombreClientetextBox.Text))
            {
                NombreClienteerrorProvider.SetError(NombreClientetextBox, "Ingrese el nombre");
                return false;
            }
            if (string.IsNullOrEmpty(CantidadtextBox.Text))
            {
                NombreClienteerrorProvider.Clear();
                CantidaderrorProvider.SetError(CantidadtextBox, "Ingrese cantidad");
                return false;
            }
            if (string.IsNullOrEmpty(PreciotextBox.Text))
            {
                NombreClienteerrorProvider.Clear();
                CantidaderrorProvider.Clear();
                PrecioerrorProvider.SetError(PreciotextBox, "ingrese el precio");
                return false;
            }
            if (string.IsNullOrEmpty(HumedadtextBox.Text))
            {
                NombreClienteerrorProvider.Clear();
                CantidaderrorProvider.Clear();
                PrecioerrorProvider.Clear();
                HumedaderrorProvider.SetError(HumedadtextBox, "Ingrese la humeda");
                return false;
            }
            if (string.IsNullOrEmpty(HumedadtextBox.Text))
            {
                NombreClienteerrorProvider.Clear();
                CantidaderrorProvider.Clear();
                PrecioerrorProvider.Clear();
                HumedaderrorProvider.Clear()
;                NombreAutorizadaerrorProvider.SetError(NombreGuardaAlmacentextBox, "Ingrese el empleado");
                return false;
            }
            return true;
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
            if (EmpleadoBll.Buscar(u.StringToint(IdtextBox.Text)) == null)
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

        private bool ValidarBuscar3()
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
