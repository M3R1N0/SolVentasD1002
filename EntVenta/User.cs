using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public class User
    {
        public int Id { get; set; }                 //2
        public string Nombre { get; set; }          //3
        public string Apellidos { get; set; }       //4
        public string Direccion { get; set; }       //5
        public byte[] Foto { get; set; }            //6
        public string NombreFoto { get; set; }      //7
        public string Usuario { get; set; }         //8
        public string Contraseña { get; set; }      //9
        public string Correo { get; set; }          //10
        public int RolID { get; set; }              //11
        public bool Estado { get; set; }            //12
                                                    
        public string Rol { get; set; }             //13

    }
}
