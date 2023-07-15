using BusVenta;
using BusVenta.Helpers;
using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            pbLogo.Image = DatEmpresa.ObtenerLogoEmpresa();
            pb1.Size = pb2.Size = pb3.Size = pb4.Size = new Size(0, 0);
            timer1.Start();
            timerInicial.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pb1.Size = new Size(pb1.Width + 2, pb1.Height + 2);
            pb1.Location = new Point(pb1.Location.X-1, pb1.Location.Y-1);
            if (pb1.Width == 24) { timer3.Start(); }
            else if (pb1.Width == 50) { timer1.Stop(); timer2.Start(); }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pb1.Size = new Size(pb1.Width - 2, pb1.Height - 2);
            pb1.Location = new Point(pb1.Location.X + 1, pb1.Location.Y + 1);
            if (pb1.Width == 0) { timer2.Stop(); }
            //else if (pb1.Width == 50) { timer1.Stop(); timer2.Start(); }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pb2.Size = new Size(pb2.Width + 2, pb2.Height + 2);
            pb2.Location = new Point(pb2.Location.X - 1, pb2.Location.Y - 1);
            if (pb2.Width == 24) { timer5.Start(); }
            else if (pb2.Width == 50) { timer3.Stop(); timer4.Start(); }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pb2.Size = new Size(pb2.Width - 2, pb2.Height - 2);
            pb2.Location = new Point(pb2.Location.X + 1, pb2.Location.Y + 1);
            if (pb2.Width == 0) { timer4.Stop(); }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pb3.Size = new Size(pb3.Width + 2, pb3.Height + 2);
            pb3.Location = new Point(pb3.Location.X - 1, pb3.Location.Y - 1);
            if (pb3.Width == 24) { timer7.Start(); }
            else if (pb3.Width == 50) { timer5.Stop(); timer6.Start(); }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pb3.Size = new Size(pb3.Width - 2, pb3.Height - 2);
            pb3.Location = new Point(pb3.Location.X + 1, pb3.Location.Y + 1);
            if (pb3.Width == 0) { timer6.Stop(); }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pb4.Size = new Size(pb4.Width + 2, pb4.Height + 2);
            pb4.Location = new Point(pb4.Location.X - 1, pb4.Location.Y - 1);
            if (pb4.Width == 50) { timer7.Stop(); timer8.Start(); timer1.Start(); }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pb4.Size = new Size(pb4.Width - 2, pb4.Height - 2);
            pb4.Location = new Point(pb4.Location.X + 1, pb4.Location.Y + 1);
            if (pb4.Width == 0) { timer8.Stop(); }
        }

        private int contador = 0;
        private void timerInicial_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            contador++;
           
            if (contador == 30)
            {
                timerInicial.Stop();
                timerFinal.Start();
            }
        }

        private void timerFinal_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                this.Hide();
                timerFinal.Stop();
                DialogResult result = MessageBox.Show("¿Desea aperturar la caja?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    frmAperturaCaja caja = new frmAperturaCaja();
                    caja.ShowDialog();
                }
                else
                {

                    string serialPC = Sistema.ObenterSerialPC();
                    var caja = CajaDAL.ObtenerCaja(serialPC);

                    OpenCloseBox open = new OpenCloseBox();
                    open.FechaInicio = DateTime.Now;
                    open.FechaFin = DateTime.Now;
                    open.FechaCierre = DateTime.Now;
                    open.Ingresos = 0;
                    open.Egresos = 0;
                    open.Saldo = 0;
                    open.IdUsuario = BusUser.ObtenerUsuario_Loggeado().Id;
                    open.TotalCalculado = 0;
                    open.TotalReal = 0;
                    open.Estado = true;
                    open.Diferencia = 0;
                    open.IdCaja = caja.Id;

                    BusOpenCloseBox.AddOpenCloseBoxDetail(open);
                    frmPrincipal frm = new frmPrincipal();
                    frm.ShowDialog();
                }

                this.Dispose();
            }
        }
    }
}
