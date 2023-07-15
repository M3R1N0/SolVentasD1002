using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusVenta.Helpers
{
    public enum Enums
    {
     
    }

    public enum EnumTipoVenta
    {
        UNIDAD = 1,
        GRANEL = 2 
    }

    public enum EnumTipoCatalogo
    {
        CATEGORIA = 1,
        PRESENTACION = 2,
        PROVEEDOR = 3,
        MARCA = 4
    }

    public enum TIPO_CACLULO
    {
        PRECIO_COMPRA = 1,
        GANANCIA = 2,
        PRECIO_VENTA = 3
    }

    public enum ESTATUS_STOCK
    {
        EN_USO = 1,
        EN_ESPERA = 2,
        AGOTADO = 3
    }

    public enum TIPO_CONSULTA_ENTRADA
    {
        ENTRADA_PRODUCTO,
        VALIDAR_STOCK
    }

    public enum TIPO_PAGO
    {
        CONTADO = 1,
        CREDITO = 2,
        COTIZACION = 3
    }

    public enum IMPRIMIR_REPORTE
    {
        SI = 1,
        NO = 2
    }

    public enum ESTADO_PAGO
    {
        PENDIENTE = 1,
        PAGADO = 2
    }

    public enum DESTINO_DOCUMENTO
    {
        VENTAS = 1,
        INGRESO = 2,
        EGRESO = 3,
    }

    public  enum TIPO_DOCUMENTO
    {
        TICKET = 1,
        REPORTE = 2
    }

  
}
