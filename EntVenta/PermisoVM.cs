using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntVenta
{
    public class PermisoVM
    {
        public class MenuVM
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public byte [] Icono { get; set; }
            public List<SubMenu> lstSubMenus { get; set; }
        }

        public class SubMenu
        {
            public int Id { get; set; }
            public int IdMenu { get; set; }
            public string Nombre { get; set; }
            public string NombreForm { get; set; }
            public byte[] Icono { get; set; }
        }

        public class Permiso
        {
            public int Id { get; set; }
            public int IdMenu { get; set; }
            public string Modulo { get; set; }
            public string Nombre { get; set; }
            public string NombreForm { get; set; }
            public byte[] Icono { get; set; }
            public bool Estado { get; set; }
        }

        public class PermisoLE
        {
            public int Id { get; set; }
            public int IdSubMenu { get; set; }
            public string Menu { get; set; }
            public string Nombre { get; set; }
            public int Lectura { get; set; }
            public int Escritura { get; set; }
            public bool Estado { get; set; }
        }
    }
}
