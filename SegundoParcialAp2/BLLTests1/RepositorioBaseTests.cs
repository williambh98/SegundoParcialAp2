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
            trasacciones.TrasaccionID = 1;

            RepositorioBase<Trasacciones> repositorioBase = new RepositorioBase<Trasacciones>();
            Assert.IsTrue(repositorioBase.Guardar(trasacciones));
        }
    }
}