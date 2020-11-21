using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusVenta
{
   public static class Formato_FolioVenta
    {
        public static string FormatoFolio(string numero, int cantidad)
        {
            string _numero = null;
            string _cantidadCeros = null;

            _numero = numero.Trim(' ');
            _cantidadCeros = "0";

            for (int i = 1; i <= cantidad; i++)
            {
                _cantidadCeros += "0";
            }

            return _cantidadCeros.Substring(0, cantidad - numero.Length) + numero;
        }
    }
}
