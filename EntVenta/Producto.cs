using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public class Producto
    {
        public int Id { get; set; }                   //2 
        public int IdCategoria { get; set; }          //3
        public int IdTipoPresentacion { get; set; }   //4
        public string codigo { get; set; }            //5
        public string Descripcion { get; set; }       //6
        public string Presentacion { get; set; }      //7
        public string seVendeA { get; set; }          //8
        public decimal precioMenudeo { get; set; }    //9
        public decimal precioMMayoreo { get; set; }   //10
        public decimal APartirDe { get; set; }        //11
        public decimal precioMayoreo { get; set; }    //12
        public string usaInventario { get; set; }     //13
        public string stock { get; set; }             //14
        public decimal stockMinimo { get; set; }      //15
        public string Caducidad { get; set; }         //16
        public bool Estado { get; set; }              //17
        

        public string  Tipo_Presentacion { get; set; }
        public string  Tipo_Catalogo { get; set; }
        public decimal? TotalUnidades { get; set; }
        public string PresentacionMenudeo { get; set; }
        public decimal Peso { get; set; }
    }
}
