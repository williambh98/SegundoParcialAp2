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
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Trasacciones trasacciones = new Trasacciones();
            trasacciones.Tipo = "Credito";
            trasacciones.Monto = 200;
            trasacciones.Fecha = DateTime.Now;
            RepositorioBase<Trasacciones> repositorioBase = new RepositorioBase<Trasacciones>();
            Assert.IsTrue(repositorioBase.Guardar(trasacciones));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Trasacciones trasacciones = new Trasacciones();
            trasacciones.TrasaccionID = 1;
            trasacciones.Fecha = DateTime.Now;
            trasacciones.Tipo = "Efectivo";
            trasacciones.Monto = 1500;

            RepositorioBase<Trasacciones> repositorioBase = new RepositorioBase<Trasacciones>();
            Assert.IsTrue(repositorioBase.Modificar(trasacciones));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Trasacciones trasacciones = new Trasacciones();
            RepositorioBase<Trasacciones> repositorioBase = new RepositorioBase<Trasacciones>();
            trasacciones.TrasaccionID = 1;
            Assert.AreEqual(true, repositorioBase.Eliminar(trasacciones.TrasaccionID));
        }
    }
}