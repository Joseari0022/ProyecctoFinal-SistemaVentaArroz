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
            Llenarentrada(EntradaArrozBll.Buscar(u.String(IdtextBox.Text)));
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
            LlenarClase2(ClienteBLL.Buscar(u.String(IdClientetextBox.Text)));
        }

        private void LlenarClase2(Clientes cli)
        {
            NombreClientetextBox.Text = cli.NombreCliente.ToString();
        }

        private void IdGuardaAlmacenbutton_Click(object sender, EventArgs e)
        {
            LlenarClase3(EmpleadoBll.Buscar(u.String(IdGuardaAlmacentextBox.Text)));
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
            EntradaArrozBll.Eliminar(u.String(IdtextBox.Text));
            MessageBox.Show("Eliminado con exito!!!!");
        }
    }
}
