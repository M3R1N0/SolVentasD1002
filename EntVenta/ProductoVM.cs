using System;


namespace EntVenta
{
    public class ProductoVM
    {
        public int Id { get; set; }                             //0
        public int IdCategoria { get; set; }                    //1
        public int idPresentacion { get; set; }                 //2
        public string codigo { get; set; }                      //3
        public string Clave { get; set; }                       //4
        public string Articulo { get; set; }                    //5
        public string Detalle { get; set; }                     //6
        public decimal PrecioCompra { get; set; }               //7
        public decimal Precio { get; set; }                     //8
        public decimal PrecioMayoreo { get; set; }              //9
        public decimal A_Partir_De { get; set; }                //10
        public string TipoVenta { get; set; }                   //11
        public bool UsaInventario { get; set; }                 //12
        public decimal Stock { get; set; }                      //13
        public decimal StockMinimo { get; set; }                //14
        public decimal UnidadesPorPresentacion { get; set; }    //15
        public DateTime Caducidad { get; set; }                 //16
        public decimal Peso { get; set; }                       //17
        public DateTime UltimaActualizacion { get; set; }       //18
        public bool Activo { get; set; }                        //19
                                                                //
        public int IdProductoU { get; set; }                    //20
        public int IdPresentacionU { get; set; }                //21
        public string CodigoU { get; set; }                     //22
        public decimal PrecioCompraU { get; set; }              //23
        public decimal PrecioU { get; set; }                    //24
        public decimal PrecioMayoreoU { get; set; }             //25
        public decimal A_Partir_DeU { get; set; }               //26
                                                                //
        public int IdProveedor { get; set; }                    //27
        public int IdMarca { get; set; }                        //28
                                                                //
        public string Presentacion { get; set; }                //29
        public decimal Ganancia { get; set; }                   //30
        public decimal GananciaU { get; set; }                  //31
        public string Venta { get; set; }                       //32
        public decimal Cantidad { get; set; }                   //33
                                                                //
        public string Proveedor { get; set; }                   //34
        public string Marca { get; set; }                       //35
        public string Categoria { get; set; }                   //36
    }
}
