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
    public class BusOpenCloseBox
    {
        public int getMovOpenCloseBox(string serial, int idusuario)
        {
            int resultado = new DatOpenCloseBox().GetOpenCloseMovDetail(serial, idusuario);
            return resultado;
        }

        public void AddOpenCloseBoxDetail(OpenCloseBox o)
        {
            int filasAfectadas = new DatOpenCloseBox().insertOpenBoxDetail(o);
            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrio un error al insertar los datos");
            }
        }

        public List<OpenCloseBox> showMovBoxBySerial(string serial)
        {
            DataTable dt = new DatOpenCloseBox().SelectDetailOpenClose(serial);
            List<OpenCloseBox> lst = new List<OpenCloseBox>();

            foreach (DataRow dataRow in dt.Rows)
            {
                OpenCloseBox o = new OpenCloseBox();
                User u = new User();
                Box b = new Box();

                u.Nombre = dataRow["Nombre"].ToString();
                u.Usuario = dataRow["Usuario"].ToString(); ;

                o.UsuarioId = u;

                //o.UsuarioId.Usuario = dataRow["Usuario"].ToString();
                //o.UsuarioId.NombreApellido = dataRow["Nombre_Apellido"].ToString();
                lst.Add(o);
            }
            return lst;
        }

        public void EditarEfectivoInicial(decimal saldo, int cajaId)
        {
            new DatOpenCloseBox().InsertarEfectivoInicial(saldo, cajaId);
        }

        public void CerrarCaja(int idCaja, DateTime cierre, DateTime fin)
        {
            new DatOpenCloseBox().CerrarCaja(idCaja, cierre, fin);
        }
    }
}
