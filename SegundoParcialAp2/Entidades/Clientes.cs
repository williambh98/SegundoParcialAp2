using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Clientes
    {
        [Key]

        public int ClienteID { get; set; }

        public string Nombre { get; set; }

        public decimal Balance { get; set; }

        Clientes()
        {
            this.ClienteID = 0;
            this.Nombre = string.Empty;
            this.Balance = 0;
        }

        public Clientes(int clienteID, string nombre, decimal balance)
        {
            ClienteID = clienteID;
            Nombre = nombre;
            Balance = balance;
        }
    }
}
