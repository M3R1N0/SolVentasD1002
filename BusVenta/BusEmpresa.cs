using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusVenta
{
   public class BusEmpresa
    {
        public void Agregar_Empresa(Empresa e)
        {
            int filasAfectadas = new DatEmpresa().Agregar_Empresa(e);
            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrio un error al insertar");
            }
        }

        public void Actualizar_Empresa(Empresa e)
        {
            int filasAfectadas = new DatEmpresa().EditarEmpresa(e);
            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrio un error al insertar");
            }
        }

        public Empresa ObtenerEmpresa()
        {
            DataRow dtEmpresa = new DatEmpresa().MostraEmpresa();
        
            Empresa e = new Empresa();
            e.Id = Convert.ToInt32( dtEmpresa["Id_Empresa"] );
            e.Nombre = dtEmpresa["Empresa"].ToString();
            e.Logo = (byte[])(dtEmpresa["Logo"]);
            e.Impuesto = dtEmpresa["Impuesto"].ToString();
            e.Porcentaje = Convert.ToDecimal( dtEmpresa["Porcentaje_Impuesto"] );
            e.Moneda = dtEmpresa["Moneda"].ToString();
            e.Usa_Impuestos = dtEmpresa["Maneja_Impuesto"].ToString();
            e.Busqueda = dtEmpresa["Modo_Busqueda"].ToString();
            e.RutaBackup = dtEmpresa["Ruta_CopiaSeguridad"].ToString();
            e.Pais = dtEmpresa["Pais"].ToString();
            e.FrecuenciaBackup = Convert.ToInt32(dtEmpresa["Frecuencia_Respaldo"]);
            e.CorreoEnvio = dtEmpresa["Correo_EnvioReporte"].ToString();
            return e;
        }
    }
}
