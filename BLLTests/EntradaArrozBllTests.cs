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
    public class EntradaArrozBllTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            EntradasArroz u = new EntradasArroz();
            Assert.IsNotNull(EntradaArrozBll.Guardar(u));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            EntradasArroz u = new EntradasArroz();
            Assert.IsTrue(EntradaArrozBll.Eliminar(u));
        }

        [TestMethod()]
        public void EliminarTest1()
        {
            EntradasArroz u = new EntradasArroz();
            Assert.IsTrue(EntradaArrozBll.Eliminar(u));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNotNull(EntradaArrozBll.Buscar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(EntradaArrozBll.GetLista());
        }

        [TestMethod()]
        public void GetListaIdTest()
        {
            Assert.IsNotNull(EntradaArrozBll.GetLista());
        }

        [TestMethod()]
        public void GetListaNombreClienteTest()
        {
            Assert.IsNotNull(EntradaArrozBll.GetListaNombreCliente("Jose"));
        }

        [TestMethod()]
        public void GetListaTipoArrozTest()
        {
            Assert.IsNotNull(EntradaArrozBll.GetListaTipoArroz("Quisqueya"));
        }

        [TestMethod()]
        public void GetListaCantidadTest()
        {
            Assert.IsNotNull(EntradaArrozBll.GetListaCantidad(1));
        }

        [TestMethod()]
        public void GetListaPrecioTest()
        {
            Assert.IsNotNull(EntradaArrozBll.GetListaPrecio(1));
        }

        [TestMethod()]
        public void GetListaHumedadTest()
        {
            Assert.IsNotNull(EntradaArrozBll.GetListaHumedad("Seco"));
        }

        [TestMethod()]
        public void GetListaFechaEntradaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaGuardaAlmacenTest()
        {
            Assert.IsNotNull(EntradaArrozBll.GetListaGuardaAlmacen("Jose Alfonso"));
        }

        [TestMethod()]
        public void GetListaCargoTest()
        {
            Assert.IsNotNull(EntradaArrozBll.GetListaCargo("Guarda Almacen"));
        }
    }
}