using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public class Producto
    {
        public int Id { get; set; }                   //2 - 0
        public int IdCategoria { get; set; }          //3 - 1
        public int IdTipoPresentacion { get; set; }   //4 - 2
        public string codigo { get; set; }            //5 - 3
        public string Descripcion { get; set; }       //6 - 4
        public string Presentacion { get; set; }      //7 - 5
        public string seVendeA { get; set; }          //8 - 6
        public decimal precioMenudeo { get; set; }    //9 -7
        public decimal precioMMayoreo { get; set; }   //10-8
        public decimal APartirDe { get; set; }        //11-9
        public decimal precioMayoreo { get; set; }    //12-10
        public string usaInventario { get; set; }     //13-11
        public string stock { get; set; }             //14-12
        public decimal stockMinimo { get; set; }      //15-13
        public string Caducidad { get; set; }         //16-14
        public bool Estado { get; set; }              //17-15
        

        public string  Tipo_Presentacion { get; set; }//18-16
        public string  Tipo_Catalogo { get; set; }    //19-17
        public decimal? TotalUnidades { get; set; }   //20-18
        public string PresentacionMenudeo { get; set; } //21-19
        public decimal Peso { get; set; }              //22-20
    }
}
