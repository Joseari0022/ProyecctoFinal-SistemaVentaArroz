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
    public partial class RegistrosEmpleados : Form
    {
        public RegistrosEmpleados()
        {
            InitializeComponent();
        }

        Utilidades u = new Utilidades();

        private void Idbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del usuario que desea buscar") && ValidarBuscar())
                LlenarEmpleado(EmpleadoBll.Buscar(u.StringToint(IdtextBox.Text)));
        }

        public void LlenarClase(Empleados e)
        {
            e.Nombres = NombretextBox.Text;
            e.Apellidos = ApellidotextBox.Text;
            e.Cedula = CedulatextBox.Text;
            e.Direccion = DirecciontextBox.Text;
            e.Telefono = TelefonotextBox.Text;
            e.Cargo = CargotextBox.Text;
            e.FechaEntrada = FechaEntradadateTimePicker.Value;
        }

        public void LlenarEmpleado(Empleados emp)
        {
            IdtextBox.Text = emp.EmpleadoId.ToString();
            NombretextBox.Text = emp.Nombres.ToString();
            ApellidotextBox.Text = emp.Apellidos.ToString();
            CedulatextBox.Text = emp.Cedula.ToString();
            DirecciontextBox.Text = emp.Direccion.ToString();
            TelefonotextBox.Text = emp.Telefono.ToString();
            CargotextBox.Text = emp.Cargo.ToString();
            FechaEntradadateTimePicker.Value = emp.FechaEntrada;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Empleados empleado = new Empleados();
            LlenarClase(empleado);
            if (ValidTex() && ValidarExistente(NombretextBox.Text))
            {
                EmpleadoBll.Guardar(empleado);
                MessageBox.Show("Guardado con exito!!!!");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del empleado que desea eliminar") && ValidarBuscar())
            {
                EmpleadoBll.Eliminar(u.StringToint(IdtextBox.Text));
                MessageBox.Show("Eliminado con exito!!!!");
            }
                
        }

        public bool ValidTex()
        {
            if (string.IsNullOrEmpty(NombretextBox.Text) && string.IsNullOrEmpty(DirecciontextBox.Text) && string.IsNullOrEmpty(TelefonotextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Ingrese el nombre");
                ApellidoerrorProvider.SetError(ApellidotextBox, "Ingrese el apellido");
                CedulaerrorProvider.SetError(CedulatextBox, "Ingrese la cedula");
                DireccionerrorProvider.SetError(DirecciontextBox, "Ingrese la direccion");
                errorProviderTelefono.SetError(TelefonotextBox, "Ingrese el telefono");
                CargoerrorProvider.SetError(CargotextBox, "Ingrese el cargo");

                MessageBox.Show("Llenar los campos");
            }
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Ingrese el nombre");
                return false;
            }
            if (string.IsNullOrEmpty(ApellidotextBox.Text))
            {
                NombreerrorProvider.Clear();
                ApellidoerrorProvider.SetError(ApellidotextBox, "Ingrese su apellido");
                return false;
            }
            if (string.IsNullOrEmpty(CargotextBox.Text))
            {
                NombreerrorProvider.Clear();
                ApellidoerrorProvider.Clear();
                CargoerrorProvider.SetError(CargotextBox, "Ingrese el cargo");
                return false;
            }
            if (string.IsNullOrEmpty(CedulatextBox.Text))
            {
                NombreerrorProvider.Clear();
                ApellidoerrorProvider.Clear();
                CargoerrorProvider.Clear();
                CedulaerrorProvider.SetError(CedulatextBox, "Ingrese la cedula");
            }
            if (string.IsNullOrEmpty(DirecciontextBox.Text))
            {
                NombreerrorProvider.Clear();
                ApellidoerrorProvider.Clear();
                DireccionerrorProvider.SetError(DirecciontextBox, "Ingrese la direccion");
                return false;
            }
            if (string.IsNullOrEmpty(TelefonotextBox.Text))
            {
                NombreerrorProvider.Clear();
                ApellidoerrorProvider.Clear();
                DireccionerrorProvider.Clear();
                errorProviderTelefono.SetError(TelefonotextBox, "Ingrese el telefono");
                return false;
            }
            return true;
        }

        private void Clear()
        {
            IdtextBox.Clear();
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            CedulatextBox.Clear();
            DirecciontextBox.Clear();
            TelefonotextBox.Clear();
            CargotextBox.Clear();
        }

        private bool ValidarExistente(string aux)
        {
            if (EmpleadoBll.GetListaNombreEmpleado(aux).Count() > 0)
            {
                MessageBox.Show("Este empleado existe....");
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
                MessageBox.Show("Este empleado no existe");
                return false;
            }
            return true;
        }
    }
}
