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

namespace SistemaVentaArroz
{
    public partial class Iniciar_Sesion : Form
    {
        public Iniciar_Sesion()
        {
            InitializeComponent();
        }

        Principal p = new Principal();
        private void IniciarSesionbutton_Click(object sender, EventArgs e)
        {
            if (ValidarSesion() == DialogResult.OK)
            {
                this.Visible = false;
                p.Show();
            }
        }

        public bool ValidarUsuario()
        {
            if (UsuarioBll.GetListaNombreUsuario(UsuariotextBox.Text).Count() == 0)
            {
                MessageBox.Show("Usuario incorrecto o no registrado");
                return false;
            }
            return true;
        }

        public bool ValidarContrasena()
        {
            if (UsuarioBll.GetContrasena(ContraseñatextBox.Text).Count() == 0)
            {
                MessageBox.Show("Contraseña incorrecta");
                return false;
            }
            return true;
        }

        public bool ValidTextB()
        {
            if (string.IsNullOrEmpty(UsuariotextBox.Text) && string.IsNullOrEmpty(ContraseñatextBox.Text))
            {
                UsuarioerrorProvider.SetError(UsuariotextBox, "Ingrese el usuario");
                ContrasenaerrorProvider.SetError(ContraseñatextBox, "Ingrese contraseña");
                MessageBox.Show("Llenar todos los campos");
            }
            if (string.IsNullOrEmpty(UsuariotextBox.Text))
            {
                UsuarioerrorProvider.SetError(UsuariotextBox, "Ingrese el usuario por favor");
                return false;
            }
            if (string.IsNullOrEmpty(ContraseñatextBox.Text))
            {
                UsuarioerrorProvider.Clear();
                ContrasenaerrorProvider.SetError(ContraseñatextBox, "Ingrese contraseña por favor");
                return false;
            }
            return true;
        }

        public DialogResult ValidarSesion()
        {
            if (ValidTextB() == true && ValidarUsuario() == true && ValidarContrasena() == true)
            {
                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }

        private void MostrarContrasenacheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MostrarContrasenacheckBox.Checked == true)
            {
                if (ContraseñatextBox.PasswordChar == '*')
                {
                    ContraseñatextBox.PasswordChar = '\0';
                }
            }
            else
            {
                ContraseñatextBox.PasswordChar = '*';
            }
        }
    }
}
