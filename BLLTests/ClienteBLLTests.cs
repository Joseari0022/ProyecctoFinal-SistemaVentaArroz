using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class ClienteBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Clientes cl = new Clientes();
            Assert.IsTrue(ClienteBLL.Guardar(cl));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Clientes cl = new Clientes();
            Assert.IsTrue(ClienteBLL.Eliminar(cl));
        }

        [TestMethod()]
        public void EliminarTest1()
        {
            Clientes cl = new Clientes();
            Assert.IsTrue(ClienteBLL.Eliminar(cl));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNotNull(ClienteBLL.Buscar(1));
        }

        [TestMethod()]
        public void GetListaNombreClienteTest()
        {
            Assert.IsNotNull(ClienteBLL.GetListaNombreCliente("Jose"));
        }

        [TestMethod()]
        public void GetListaIdTest()
        {
            Assert.IsNotNull(ClienteBLL.GetLista(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(ClienteBLL.GetListaId());
        }

        [TestMethod()]
        public void GetListaApellidoTest()
        {
            Assert.IsNotNull(ClienteBLL.GetListaApellido("Paredes"));
        }

        [TestMethod()]
        public void GetListaEdadTest()
        {
            Assert.IsNotNull(ClienteBLL.GetListaEdad("10"));
        }

        [TestMethod()]
        public void GetListaCedulaTest()
        {
            Assert.IsNotNull(ClienteBLL.GetListaCedula("40224241463"));
        }

        [TestMethod()]
        public void GetListaDireccionTest()
        {
            Assert.IsNotNull(ClienteBLL.GetListaDireccion("El factor"));
        }

        [TestMethod()]
        public void GetListaTelefonoTest()
        {
            Assert.IsNotNull(ClienteBLL.GetListaTelefono("8494584125"));
        }

        [TestMethod()]
        public void GetListaFechaTest()
        {
            Assert.Fail();
        }
    }
}