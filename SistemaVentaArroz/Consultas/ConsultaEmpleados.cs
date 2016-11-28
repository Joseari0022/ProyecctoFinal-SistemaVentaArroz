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

namespace SistemaVentaArroz.Consultas
{
    public partial class ConsultaEmpleados : Form
    {
        public ConsultaEmpleados()
        {
            InitializeComponent();
        }

        Utilidades u = new Utilidades();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarConsul() == true)
                BuscarSelecCombo();
        }
        public List<Entidades.Empleados> lista = new List<Empleados>();
        private void BuscarSelecCombo()
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = EmpleadoBll.GetListaId(u.String(FiltrotextBox.Text));
                }
                else
                {
                    lista = EmpleadoBll.GetLista();
                }
                ConsultaEmpleadodataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = EmpleadoBll.GetListaNombreEmpleado(FiltrotextBox.Text);
                }
                else
                {
                    lista = EmpleadoBll.GetLista();
                }
                ConsultaEmpleadodataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = EmpleadoBll.GetListaApellido(FiltrotextBox.Text);
                }
                else
                {
                    lista = EmpleadoBll.GetLista();
                }
                ConsultaEmpleadodataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 3)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = EmpleadoBll.GetListaCedula((FiltrotextBox.Text));
                }
                else
                {
                    lista = EmpleadoBll.GetLista();
                }
                ConsultaEmpleadodataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 4)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = EmpleadoBll.GetListaDireccion((FiltrotextBox.Text));
                }
                else
                {
                    lista = EmpleadoBll.GetLista();
                }
                ConsultaEmpleadodataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 5)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = EmpleadoBll.GetListaFechaEntrada(DesdeDateTimePicke.Value, HastadateTimePicker.Value);
                }
                else
                {
                    lista = EmpleadoBll.GetLista();
                }
                ConsultaEmpleadodataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 6)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = EmpleadoBll.GetListaTelefono(FiltrotextBox.Text);
                }
                else
                {
                    lista = EmpleadoBll.GetLista();
                }
                ConsultaEmpleadodataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 7)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = EmpleadoBll.GetListaCargo(FiltrotextBox.Text);
                }
                else
                {
                    lista = EmpleadoBll.GetLista();
                }
                ConsultaEmpleadodataGridView.DataSource = lista;
            }
        }

        private bool ValidarConsul()
        {
            if (FiltrarcomboBox.SelectedIndex == 5)
            {
                if (DesdeDateTimePicke.Value == HastadateTimePicker.Value)
                {
                    MessageBox.Show("Favor definir una fecha entre las fechas ");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingrese el campo");
                return true;
            }
            if (FiltrarcomboBox.SelectedIndex == 1 && EmpleadoBll.GetListaNombreEmpleado(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 2 && EmpleadoBll.GetListaApellido(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 3 && EmpleadoBll.GetListaCedula(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 4 && EmpleadoBll.GetListaDireccion(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 6 && EmpleadoBll.GetListaTelefono(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 7 && EmpleadoBll.GetListaCargo(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            BuscarerrorProvider.Clear();
            return true;
        }

        private void Cargar()
        {
            FiltrarcomboBox.Items.Insert(0, "EmpleadoId");
            FiltrarcomboBox.Items.Insert(1, "Nombre");
            FiltrarcomboBox.Items.Insert(2, "Apellido");
            FiltrarcomboBox.Items.Insert(3, "Cedula");
            FiltrarcomboBox.Items.Insert(4, "Direccion");
            FiltrarcomboBox.Items.Insert(5, "FechaEntrada");
            FiltrarcomboBox.Items.Insert(6, "Telefono");
            FiltrarcomboBox.Items.Insert(7, "Cargo");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            ConsultaEmpleadodataGridView.DataSource = EmpleadoBll.GetLista();
        }

        private void ConsultaEmpleados_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ReportingViewerEmpleados viewer = new ReportingViewerEmpleados();
            viewer.Show();
        }
    }
 }

