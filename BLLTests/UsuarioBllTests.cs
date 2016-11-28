using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class UsuarioBllTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Usuarios u = new Usuarios();
            Assert.IsNotNull(UsuarioBll.Guardar(u));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Usuarios u = new Usuarios();
            Assert.IsTrue(UsuarioBll.Eliminar(u));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNotNull(UsuarioBll.Buscar(1));
        }

        [TestMethod()]
        public void EliminarTest1()
        {
            Usuarios u = new Usuarios();
            Assert.IsTrue(UsuarioBll.Eliminar(u));
        }

        [TestMethod()]
        public void GetListaNombreUsuarioTest()
        {
            Assert.IsNotNull(UsuarioBll.GetListaNombreUsuario("Jose"));
        }

        [TestMethod()]
        public void GetContrasenaTest()
        {
            Assert.IsNotNull(UsuarioBll.GetContrasena("12324"));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(UsuarioBll.GetLista());
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsNotNull(UsuarioBll.GetListaId(1));
        }
    }
}