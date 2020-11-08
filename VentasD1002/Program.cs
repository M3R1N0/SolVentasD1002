using DatVentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new frmLogin());
            // Application.Run(new frmMenuPrincipal());
            //Application.Run(new frmUsuarioAutorizado());
            // Application.Run(new frmProductos());
            //Application.Run(new Reportes.frmInventario());
            //  Application.Run(new frmEncriptar());
            //pplication.Run(new frmAperturaCaja());
            //Application.Run(new frmInventarioKardex());
            // Application.Run(new frmInstalacionServidor());
             Application.Run(new frmCliente());
        }
    }
}
