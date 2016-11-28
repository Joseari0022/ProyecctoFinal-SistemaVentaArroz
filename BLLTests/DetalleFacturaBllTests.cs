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
    public class DetalleFacturaBllTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            DetalleFacturas u = new DetalleFacturas();
            Assert.IsNotNull(DetalleFacturaBll.Guardar(u));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNotNull(DetalleFacturaBll.Buscar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(DetalleFacturaBll.GetListaId(1));
        }

        [TestMethod()]
        public void GetListaIdTest()
        {
            Assert.IsNotNull(DetalleFacturaBll.GetListaId(1));
        }

        [TestMethod()]
        public void GetListaIdClienteTest()
        {
            Assert.IsNotNull(DetalleFacturaBll.GetListaIdCliente(1));
        }
    }
}