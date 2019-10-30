using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Trasacciones
    {
        [Key]
        public int TrasaccionID { get; set; }

        public string Tipo { get; set; }

        public decimal Monto { get; set; }

        public DateTime Fecha { get; set; }

       public Trasacciones()
        {
            this.TrasaccionID = 0;
            this.Tipo = string.Empty;
            this.Monto = 0;
            this.Fecha = DateTime.Now;
        }

        public Trasacciones(int trasaccionID, string tipo, decimal monto, DateTime fecha)
        {
            TrasaccionID = trasaccionID;
            Tipo = tipo;
            Monto = monto;
            Fecha = fecha;
        }
    }
}
