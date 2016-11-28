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
    public partial class ConsultaEntradaArroz : Form
    {
        public ConsultaEntradaArroz()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarConsul() == true)
                BuscarSelecCombo();
        }

        Utilidades u = new Utilidades();
        public List<Entidades.EntradasArroz> lista = new List<EntradasArroz>();
        private void BuscarSelecCombo()
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = EntradaArrozBll.GetListaId(u.StringToint(FiltrotextBox.Text));
                }
                else
                {
                    lista = EntradaArrozBll.GetLista();
                }
                ConsultaEntradaArrozdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = EntradaArrozBll.GetListaNombreCliente(FiltrotextBox.Text);
                }
                else
                {
                    lista = EntradaArrozBll.GetLista();
                }
                ConsultaEntradaArrozdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = EntradaArrozBll.GetListaTipoArroz(FiltrotextBox.Text);
                }
                else
                {
                    lista = EntradaArrozBll.GetLista();
                }
                ConsultaEntradaArrozdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 3)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = EntradaArrozBll.GetListaCantidad((int.Parse(FiltrotextBox.Text)));
                }
                else
                {
                    lista = EntradaArrozBll.GetLista();
                }
                ConsultaEntradaArrozdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 4)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = EntradaArrozBll.GetListaPrecio((int.Parse(FiltrotextBox.Text)));
                }
                else
                {
                    lista = EntradaArrozBll.GetLista();
                }
                ConsultaEntradaArrozdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 5)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = EntradaArrozBll.GetListaHumedad(FiltrotextBox.Text);
                }
                else
                {
                    lista = EntradaArrozBll.GetLista();
                }
                ConsultaEntradaArrozdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 6)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = EntradaArrozBll.GetListaFechaEntrada(DesdeDateTimePicke.Value, HastadateTimePicker.Value);
                }
                else
                {
                    lista = EntradaArrozBll.GetLista();
                }
                ConsultaEntradaArrozdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 7)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = EntradaArrozBll.GetListaGuardaAlmacen(FiltrotextBox.Text);
                }
                else
                {
                    lista = EntradaArrozBll.GetLista();
                }
                ConsultaEntradaArrozdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 8)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = EntradaArrozBll.GetListaCargo(FiltrotextBox.Text);
                }
                else
                {
                    lista = EntradaArrozBll.GetLista();
                }
                ConsultaEntradaArrozdataGridView.DataSource = lista;
            }
        }

        private bool ValidarConsul()
        {
            if (FiltrarcomboBox.SelectedIndex == 6)
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
            if (FiltrarcomboBox.SelectedIndex == 1 && EntradaArrozBll.GetListaNombreCliente(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 2 && EntradaArrozBll.GetListaTipoArroz(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 3 && EntradaArrozBll.GetListaCantidad(int.Parse(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 4 && EntradaArrozBll.GetListaPrecio(int.Parse(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 5 && EntradaArrozBll.GetListaHumedad(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 7 && EntradaArrozBll.GetListaGuardaAlmacen(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 8 && EntradaArrozBll.GetListaCargo(FiltrotextBox.Text).Count == 0)
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
            ConsultaEntradaArrozdataGridView.DataSource = EntradaArrozBll.GetLista();
        }

        private void ConsultaEntradaArroz_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ReportingViewerEntradasArroz  viewer = new ReportingViewerEntradasArroz();
            viewer.Show();
        }
    }
}
