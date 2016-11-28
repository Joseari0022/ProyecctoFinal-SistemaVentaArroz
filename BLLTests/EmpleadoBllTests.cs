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
    public class EmpleadoBllTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Empleados em = new Empleados();
            Assert.IsTrue(EmpleadoBll.Guardar(em));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Empleados em = new Empleados();
            Assert.IsTrue(EmpleadoBll.Eliminar(em));
        }

        [TestMethod()]
        public void EliminarTest1()
        {
            Empleados em = new Empleados();
            Assert.IsTrue(EmpleadoBll.Eliminar(em));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNotNull(EmpleadoBll.Buscar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(EmpleadoBll.GetLista());
        }

        [TestMethod()]
        public void GetListaIdTest()
        {
            Assert.IsNotNull(EmpleadoBll.GetLista());
        }

        [TestMethod()]
        public void GetListaNombreEmpleadoTest()
        {
            Assert.IsNotNull(EmpleadoBll.GetListaNombreEmpleado("Jose"));
        }

        [TestMethod()]
        public void GetListaApellidoTest()
        {
            Assert.IsNotNull(EmpleadoBll.GetListaApellido("Paredes"));
        }

        [TestMethod()]
        public void GetListaCedulaTest()
        {
            Assert.IsNotNull(EmpleadoBll.GetListaCedula("40224241463"));
        }

        [TestMethod()]
        public void GetListaDireccionTest()
        {
            Assert.IsNotNull(EmpleadoBll.GetListaDireccion("El factor"));
        }

        [TestMethod()]
        public void GetListaTelefonoTest()
        {
            Assert.IsNotNull(EmpleadoBll.GetListaTelefono("8494584125"));
        }

        [TestMethod()]
        public void GetListaFechaEntradaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaCargoTest()
        {
            Assert.Fail();
        }
    }
}