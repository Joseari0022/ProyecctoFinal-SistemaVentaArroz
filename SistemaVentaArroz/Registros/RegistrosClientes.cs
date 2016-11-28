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
    public partial class RegistrosClientes : Form
    {
        public RegistrosClientes()
        {
            InitializeComponent();
        }

        Utilidades u = new Utilidades();
        private void Idbutton_Click(object sender, EventArgs e)
        {
            LlenarCliente(ClienteBLL.Buscar(u.String(IdtextBox.Text)));
        }

        public void LlenarCliente(Clientes cliente)
        {
            IdtextBox.Text = cliente.ClienteId.ToString();
            NombretextBox.Text = cliente.NombreCliente.ToString();
            ApellidotextBox.Text = cliente.ApellidoCliente.ToString();
            EdadtextBox.Text = cliente.EdadCliente.ToString();
            DirecciontextBox.Text = cliente.DireccionCliente.ToString();
            CedulatextBox.Text = cliente.CedulaCliente.ToString();
            TelefonotextBox.Text = cliente.TelefonoCliente.ToString();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            EdadtextBox.Clear();
            CedulatextBox.Clear();
            DirecciontextBox.Clear();
            TelefonotextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            LlenaClase(cliente);
            if (ValidTex() && ValidarExistente(NombretextBox.Text))
            {
                ClienteBLL.Guardar(cliente);
                MessageBox.Show("Guardado con exito!!!!");
            }
        }

        public void LlenaClase(Clientes c)
        {
            c.NombreCliente = NombretextBox.Text;
            c.ApellidoCliente = ApellidotextBox.Text;
            c.EdadCliente = EdadtextBox.Text;
            c.DireccionCliente = DirecciontextBox.Text;
            c.CedulaCliente = CedulatextBox.Text;
            c.TelefonoCliente = TelefonotextBox.Text;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            ClienteBLL.Eliminar(u.String(IdtextBox.Text));
            MessageBox.Show("Usuario Eliminado");
        }

        public bool ValidTex()
        {
            if (string.IsNullOrEmpty(NombretextBox.Text) && string.IsNullOrEmpty(DirecciontextBox.Text) && string.IsNullOrEmpty(TelefonotextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Ingrese el nombre");
                ApellidoerrorProvider.SetError(ApellidotextBox, "Ingrese el apellido");
                EdaderrorProvider.SetError(EdadtextBox, "Ingrese su edad");
                CedulaerrorProvider.SetError(CedulatextBox, "Ingrese la cedula");
                DireccionerrorProvider.SetError(DirecciontextBox, "Ingrese la direccion");
                TelefonoerrorProvider.SetError(TelefonotextBox, "Ingrese el telefono");
                
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
            if (string.IsNullOrEmpty(EdadtextBox.Text))
            {
                NombreerrorProvider.Clear();
                ApellidoerrorProvider.Clear();
                EdaderrorProvider.SetError(EdadtextBox, "Ingrese la edad");
                return false;
            }
            if (string.IsNullOrEmpty(CedulatextBox.Text))
            {
                NombreerrorProvider.Clear();
                ApellidoerrorProvider.Clear();
                EdaderrorProvider.Clear();
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
                TelefonoerrorProvider.SetError(TelefonotextBox, "Ingrese el telefono");
                return false;
            }
            return true;
        }

        private bool ValidarExistente(string aux)
        {
            if (ClienteBLL.GetListaNombreCliente(aux).Count() > 0)
            {
                MessageBox.Show("Este usuario existe....");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
