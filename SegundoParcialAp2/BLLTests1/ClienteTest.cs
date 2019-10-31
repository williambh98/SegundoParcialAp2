using BLL;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLTests1
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Clientes clientes = new Clientes();
            clientes.Nombre = "Pedro";
            clientes.Balance = 200;
            RepositorioBase<Clientes> repositorioBase = new RepositorioBase<Clientes>();
            Assert.IsTrue(repositorioBase.Guardar(clientes));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Clientes clientes = new Clientes();
            clientes.ClienteID = 1;
            clientes.Nombre = "William";
            clientes.Balance = 1000;
          
            RepositorioBase<Clientes> repositorioBase = new RepositorioBase<Clientes>();
            Assert.IsTrue(repositorioBase.Modificar(clientes));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Clientes clientes = new Clientes();
            RepositorioBase<Clientes> repositorioBase = new RepositorioBase<Clientes>();
            clientes.ClienteID = 1;
            Assert.AreEqual(true, repositorioBase.Eliminar(clientes.ClienteID));
        }
    }
}
