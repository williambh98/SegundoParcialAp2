using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public class Metodo
    {
        public static int ToInt(string valor)
        {
            int retorno = 0;
            int.TryParse(valor, out retorno);

            return retorno;
        }

        public static List<Trasacciones> SegTransacciones()
        {
            Expression<Func<Trasacciones, bool>> filtro = p => true;
            RepositorioBase<Trasacciones> repositorio = new RepositorioBase<Trasacciones>();
            List<Trasacciones> list = new List<Trasacciones>();

            list = repositorio.GetList(filtro);

            return list;
        }
    }
}
