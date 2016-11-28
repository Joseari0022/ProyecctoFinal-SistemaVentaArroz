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
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarConsul() == true)
                BuscarSelecCombo();
        }

        Utilidades U = new Utilidades();
        public List<Clientes> lista = new List<Clientes>();
        private void BuscarSelecCombo()
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = ClienteBLL.GetLista(U.StringToint(FiltrotextBox.Text));
                }
                else
                {
                    lista = ClienteBLL.GetListaId();
                }

                ConsultaClientedataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = ClienteBLL.GetListaNombreCliente(FiltrotextBox.Text);
                }
                else
                {
                    lista = ClienteBLL.GetListaId();
                }

                ConsultaClientedataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = ClienteBLL.GetListaApellido(FiltrotextBox.Text);
                }
                else
                {
                    lista = ClienteBLL.GetListaId();
                }

                ConsultaClientedataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 3)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = ClienteBLL.GetListaEdad(FiltrotextBox.Text);
                }
                else
                {
                    lista = ClienteBLL.GetListaId();
                }

                ConsultaClientedataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 4)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = ClienteBLL.GetListaCedula(FiltrotextBox.Text);
                }
                else
                {
                    lista = ClienteBLL.GetListaId();
                }

                ConsultaClientedataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 5)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = ClienteBLL.GetListaDireccion(FiltrotextBox.Text);
                }
                else
                {
                    lista = ClienteBLL.GetListaId();
                }

                ConsultaClientedataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 6)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = ClienteBLL.GetListaTelefono(FiltrotextBox.Text);
                }
                else
                {
                    lista = ClienteBLL.GetListaId();
                }

                ConsultaClientedataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 7)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    //lista = ClienteBLL.//GetListaEmail(FiltrotextBox.Text);
                }
                else
                {
                    lista = ClienteBLL.GetListaId();
                }

                ConsultaClientedataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 8)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                   // lista = ClienteBLL.//GetListaSexo(FiltrotextBox.Text);
                }
                else
                {
                    lista = ClienteBLL.GetListaId();
                }

                ConsultaClientedataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 9)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = ClienteBLL.GetListaFecha(DesdeDateTimePicke.Value, HastadateTimePicker.Value);
                }
                else
                {
                    lista = ClienteBLL.GetListaId();
                }

                ConsultaClientedataGridView.DataSource = lista;
            }
        }

        private bool ValidarConsul()
        {
            if (FiltrarcomboBox.SelectedIndex == 9)
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
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingrese el campo....");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 1 && ClienteBLL.GetListaNombreCliente(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 2 && ClienteBLL.GetListaApellido(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 3 && ClienteBLL.GetListaEdad(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 4 && ClienteBLL.GetListaCedula(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 5 && ClienteBLL.GetListaDireccion(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 6 && ClienteBLL.GetListaTelefono(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 0 && ClienteBLL.GetLista(U.StringToint(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            BuscarerrorProvider.Clear();
            return true;
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            CargarFiltro();
        }

        private void CargarFiltro()
        {
            FiltrarcomboBox.Items.Insert(0, "ClienteId");
            FiltrarcomboBox.Items.Insert(1, "Nombre");
            FiltrarcomboBox.Items.Insert(2, "Apellido");
            FiltrarcomboBox.Items.Insert(3, "Edad");
            FiltrarcomboBox.Items.Insert(4, "Cedula");
            FiltrarcomboBox.Items.Insert(5, "Direccion");
            FiltrarcomboBox.Items.Insert(6, "Telefono");
            FiltrarcomboBox.Items.Insert(7, "Email");
            FiltrarcomboBox.Items.Insert(8, "Sexo");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            ConsultaClientedataGridView.DataSource = ClienteBLL.GetListaId();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ReportingViewerClientes viewer = new ReportingViewerClientes();
            viewer.Show();
        }
    }
}
