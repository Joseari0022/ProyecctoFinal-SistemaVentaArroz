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
            LlenarEmpleado(EmpleadoBll.Buscar(u.String(IdtextBox.Text)));
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
            EmpleadoBll.Guardar(empleado);
            Clear();
            MessageBox.Show("Guardado con exito!!!!");
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            EmpleadoBll.Eliminar(u.String(IdtextBox.Text));
            MessageBox.Show("Eliminado con exito!!!!");
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
    }
}
