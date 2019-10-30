using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<Trasacciones> trasacciones { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
