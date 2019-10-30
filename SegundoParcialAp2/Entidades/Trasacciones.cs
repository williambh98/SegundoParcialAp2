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

        public decimal Tipo { get; set; }

        public decimal Monto { get; set; }

        public DateTime Fecha { get; set; }

        Trasacciones()
        {
            this.TrasaccionID = 0;
            this.Tipo = 0;
            this.Monto = 0;
            this.Fecha = DateTime.Now;
        }

        public Trasacciones(int trasaccionID, decimal tipo, decimal monto, DateTime fecha)
        {
            TrasaccionID = trasaccionID;
            Tipo = tipo;
            Monto = monto;
            Fecha = fecha;
        }
    }
}
