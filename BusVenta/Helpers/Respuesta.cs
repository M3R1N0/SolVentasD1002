using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusVenta.Helpers
{
  public  class Respuesta
    {
        public string Mensaje { get; set; }
        public string TipoMensaje { get; set; }
        public Object Data { get; set; }
        public int Exito { get; set; }

        public Respuesta() { }

        public Respuesta(int Exito)
        {
            this.Exito = Exito;
        }

        public Respuesta(int Exito, string TipoMensaje, string Mensaje)
        {
            this.Exito = Exito;
            this.Mensaje = Mensaje;
            this.TipoMensaje = TipoMensaje;
        }

        public Respuesta(int Exito, string TipoMensaje, string Mensaje, Object Data)
        {
            this.Exito = Exito;
            this.Mensaje = Mensaje;
            this.TipoMensaje = TipoMensaje;
            this.Data = Data;
        }
    }
}
