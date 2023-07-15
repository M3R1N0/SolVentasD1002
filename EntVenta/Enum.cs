using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public enum TIPO_ACTUALIZACION
    {
        AUMENTAR = 1,
        DISMINUIR = 2
    }
    public enum TIPO_CATALOGO
    {
        CATEGORIA = 1,
        MARCA = 2,
        PROVEEDOR = 3,
        PRESENTACION = 4
    }
    public enum CLIENTE_PROVEEDOR
    {
        CLIENTE = 1,
        PROVEEDOR = 2
    }
}
