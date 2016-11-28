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
    public partial class ConsultaProductos : Form
    {
        public ConsultaProductos()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarConsul() == true)
                BuscarSelecCombo();
        }

        Utilidades U = new Utilidades();
        public List<Entidades.Productos> lista = new List<Productos>();
        private void BuscarSelecCombo()
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = ProductoBll.GetListaId(U.String(FiltrotextBox.Text));
                }
                else
                {
                    lista = ProductoBll.GetLista();
                }

                ConsultaProductostaGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = ProductoBll.GetListaNombreProducto(FiltrotextBox.Text);
                }
                else
                {
                    lista = ProductoBll.GetLista();
                }

                ConsultaProductostaGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = ProductoBll.GetListaDescripcionProducto(FiltrotextBox.Text);
                }
                else
                {
                    lista = ProductoBll.GetLista();
                }

                ConsultaProductostaGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 3)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = ProductoBll.GetListaFecha(DesdeDateTimePicke.Value, HastadateTimePicker.Value);
                }
                else
                {
                    lista = ProductoBll.GetLista();
                }

                ConsultaProductostaGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 4)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = ProductoBll.GetListaCantidadProducto(int.Parse(FiltrotextBox.Text));
                }
                else
                {
                    lista = ProductoBll.GetLista();
                }

                ConsultaProductostaGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 5)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = ProductoBll.GetListaPrecioProducto(int.Parse(FiltrotextBox.Text));
                }
                else
                {
                    lista = ProductoBll.GetLista();
                }
                ConsultaProductostaGridView.DataSource = lista;
            }
        }

        private bool ValidarConsul()
        {
            if (FiltrarcomboBox.SelectedIndex == 3)
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
            if (FiltrarcomboBox.SelectedIndex == 1 && ProductoBll.GetListaNombreProducto(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 2 && ProductoBll.GetListaDescripcionProducto(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 4 && ProductoBll.GetListaCantidadProducto(int.Parse(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 5 && ProductoBll.GetListaPrecioProducto(int.Parse(FiltrotextBox.Text)).Count == 0)
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
            ConsultaProductostaGridView.DataSource = ProductoBll.GetLista();
        }

        private void ConsultaProductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaArrozDbProductosDataSet.Productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.sistemaArrozDbProductosDataSet.Productos);
            Cargar();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ReportingViewerProductos viewer = new ReportingViewerProductos();
            viewer.Show();
        }
    }
}
