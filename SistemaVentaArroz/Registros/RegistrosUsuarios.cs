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
    public partial class RegistrosUsuarios : Form
    {
        public RegistrosUsuarios()
        {
            InitializeComponent();
        }

        Utilidades u = new Utilidades();
        private void Idbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del usuario que desea buscar") && ValidarBuscar())
                LlenarUsuario(UsuarioBll.Buscar(u.StringToint(IdtextBox.Text)));
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del usuario que desea buscar") && ValidarBuscar())
                LlenarUsuario(UsuarioBll.Buscar(u.StringToint(IdtextBox.Text)));
        }

        private void LlenarUsuario(Usuarios usuario)
        {
            IdtextBox.Text = usuario.UsuarioId.ToString();
            NombretextBox.Text = usuario.NombreUsuario;
            ContrasenatextBox.Text = usuario.ContrasenaUsuario;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            LlenarClase(usuario);
            if (ValidTextB() && ValidarExistente(NombretextBox.Text))
            {
                UsuarioBll.Guardar(usuario);
                MessageBox.Show("Guardado con exito!!!!");
            }
        }

        public void LlenarClase(Usuarios u)
        {
            u.NombreUsuario = NombretextBox.Text;
            u.ContrasenaUsuario = ContrasenatextBox.Text;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del usuario que desea eliminar") && ValidarBuscar())
            {
                UsuarioBll.Eliminar(u.StringToint(IdtextBox.Text));
                MessageBox.Show("Usuario Eliminado");
            }
        }

        public bool ValidTextB()
        {
            if (string.IsNullOrEmpty(NombretextBox.Text) && string.IsNullOrEmpty(ContrasenatextBox.Text) && string.IsNullOrEmpty(ConfirmarContrasenatextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Ingrese el nombre");
                ContrasenaerrorProvider.SetError(ContrasenatextBox, "Ingrese contraseña");
                ConfirmarContrasenaerrorProvider.SetError(ConfirmarContrasenatextBox, "La contraseña no coincide");
                MessageBox.Show("Llenar todos los campos");
            }
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Ingrese el nombre");
                return false;
            }
            if (string.IsNullOrEmpty(ContrasenatextBox.Text))
            {
                NombreerrorProvider.Clear();
                ContrasenaerrorProvider.SetError(ContrasenatextBox, "Ingrese contraseña");
                return false;
            }
            if (string.IsNullOrEmpty(ConfirmarContrasenatextBox.Text))
            {
                NombreerrorProvider.Clear();
                ContrasenaerrorProvider.Clear();
                ConfirmarContrasenaerrorProvider.SetError(ConfirmarContrasenatextBox, "Confirmar contraseña ");
                return false;
            }
            if (ContrasenatextBox.Text != ConfirmarContrasenatextBox.Text)
            {
                NombreerrorProvider.Clear();
                ContrasenaerrorProvider.Clear();
                ConfirmarContrasenaerrorProvider.Clear();
                ConfirmarContrasenaerrorProvider.SetError(ConfirmarContrasenatextBox, "La contraseña no coincide");
                return false;
            }
            return true;
        }

        private bool ValidarExistente(string aux)
        {
            if (UsuarioBll.GetListaNombreUsuario(aux).Count() > 0)
            {
                MessageBox.Show("Este usuario existe....");
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
            if (UsuarioBll.Buscar(u.StringToint(IdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }
            return true;
        }

        private bool ValidarExiste(string aux)
        {
            if (UsuarioBll.GetListaNombreUsuario(aux).Count() > 0)
            {
                MessageBox.Show("Este nombre de Usuario ya existe, favor intentar con otro nombre de usario...");
                return false;
            }
            return true;
        }
    }
}
