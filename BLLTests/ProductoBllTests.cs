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
    public class ProductoBllTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Productos p = new Productos();
            Assert.IsTrue(ProductoBll.Guardar(p));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Productos p = new Productos();
            Assert.IsTrue(ProductoBll.Eliminar(p));
        }

        [TestMethod()]
        public void EliminarTest1()
        {
            Productos p = new Productos();
            Assert.IsTrue(ProductoBll.Eliminar(p));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNull(ProductoBll.Buscar(1));
            //Assert.IsNotNull(UsuarioBll.Buscar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(ProductoBll.GetLista());
        }

        [TestMethod()]
        public void GetListaNombreProductoTest()
        {
            Assert.IsNotNull(ProductoBll.GetListaNombreProducto("Arroz"));
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsNotNull(ProductoBll.GetLista());
        }

        [TestMethod()]
        public void GetListaDescripcionProductoTest()
        {
            Assert.IsNotNull(ProductoBll.GetListaDescripcionProducto("25 libras"));
        }

        [TestMethod()]
        public void GetListaCantidadProductoTest()
        {
            Assert.IsNotNull(ProductoBll.GetListaCantidadProducto(2));
        }

        [TestMethod()]
        public void GetListaPrecioProductoTest()
        {
            Assert.IsNotNull(ProductoBll.GetListaPrecioProducto(2500));
        }

        [TestMethod()]
        public void GetListaFechaTest()
        {
            //Assert.IsNotNull(ProductoBll.GetListaFecha(DateTime.Today));
        }
    }
}