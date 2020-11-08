using BusVenta;
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
    public partial class frmNotificaciones : Form
    {
        public frmNotificaciones()
        {
            InitializeComponent();
        }

        public void Notificacion_VencimientoProducto()
        {
            try
            {
                int Cantidad = new BusProducto().Productos_Vencidos();
                Label b = new Label();
                Panel p1 = new Panel();
                Panel p2 = new Panel();
                PictureBox I1 = new PictureBox();
                PictureBox I2 = new PictureBox();
                Label L = new Label();

                b.Text = "Tienes Productos Vencidos";
                b.Name = Cantidad.ToString();
                b.Size = new System.Drawing.Size(430, 35);
                b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10);
                b.BackColor = Color.Transparent;
                b.ForeColor = Color.Black;
                b.Dock = DockStyle.Top;
                b.TextAlign = ContentAlignment.MiddleLeft;

                L.Text = "(" + Cantidad.ToString() + ") Producto(s) Vencido(s)";
                L.Name = Cantidad.ToString();
                L.Size = new System.Drawing.Size(430, 18);
                L.Font = new System.Drawing.Font("Microsoft Sans Serif", 10);
                L.BackColor = Color.Transparent;
                L.ForeColor = Color.Gray;
                L.Dock = DockStyle.Fill;
                L.TextAlign = ContentAlignment.MiddleLeft;

                I2.BackgroundImage = Properties.Resources.warning;
                I2.BackgroundImageLayout = ImageLayout.Zoom;
                I2.Size = new System.Drawing.Size(18, 18);
                I2.Dock = DockStyle.Left;

                p1.Size = new System.Drawing.Size(430, 67);
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Dock = DockStyle.Top;
                p1.BackColor = Color.White;

                p2.Size = new System.Drawing.Size(287, 22);
                p2.Dock = DockStyle.Top;
                p2.BackColor = Color.Transparent;

                I1.BackgroundImage = Properties.Resources.calendario;
                I1.BackgroundImageLayout = ImageLayout.Zoom;
                I1.Size = new System.Drawing.Size(90, 69);
                I1.Dock = DockStyle.Left;
                I1.BackColor = Color.Transparent;


                p1.Controls.Add(b);
                p1.Controls.Add(I1);
                p1.Controls.Add(p2);
                p2.Controls.Add(I2);
                p2.Controls.Add(L);

                p2.BringToFront();
                b.SendToBack();
                I1.SendToBack();
                L.BringToFront();


                pnlContenedor.Controls.Add(p1);
                //pnlContenedor.SendToBack();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar la notificacion de productos"+ ex.Message, "Notificacion Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmNotificaciones_Load(object sender, EventArgs e)
        {
            Notificacion_VencimientoProducto();
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
