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
    public partial class ConsultaUsuarios : Form
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarConsul() == true)
                BuscarSelecCombo();
        }

        Utilidades u = new Utilidades();
        public List<Entidades.Usuarios> lista = new List<Usuarios>();
        private void BuscarSelecCombo()
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = UsuarioBll.GetListaId(u.StringToint(FiltrotextBox.Text));
                }
                else
                {
                    lista = UsuarioBll.GetLista();
                }
                ConsultaUsuariosdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = UsuarioBll.GetListaNombreUsuario(FiltrotextBox.Text);
                }
                else
                {
                    lista = UsuarioBll.GetLista();
                }
                ConsultaUsuariosdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    lista = UsuarioBll.GetContrasena(FiltrotextBox.Text);
                }
                else
                {
                    lista = UsuarioBll.GetLista();
                }
                ConsultaUsuariosdataGridView.DataSource = lista;
            }
        }
        private bool ValidarConsul()
        {
            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingrese el campo");
                return true;
            }
            if (FiltrarcomboBox.SelectedIndex == 1 && UsuarioBll.GetListaNombreUsuario(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 2 && UsuarioBll.GetContrasena(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            BuscarerrorProvider.Clear();
            return true;
        }

        private void Cargar()
        {
            FiltrarcomboBox.Items.Insert(0, "UsuarioId");
            FiltrarcomboBox.Items.Insert(1, "Nombre");
            FiltrarcomboBox.Items.Insert(2, "Contraseña");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            ConsultaUsuariosdataGridView.DataSource = UsuarioBll.GetLista();
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ReportingViewerUsuarios viewer = new ReportingViewerUsuarios();
            viewer.Show();
        }
    }
}
