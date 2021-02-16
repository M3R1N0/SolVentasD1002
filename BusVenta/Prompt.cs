using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusVenta
{
    public static class Prompt
    {
        public static string ShowDialog()
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "CONFIGURACIÓN",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 22, Text = "KG POR CAJA:" };
            textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
            textLabel.Size = new System.Drawing.Size(120, 18);
            textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            TextBox textBox = new TextBox() { Left = 170, Top = 20, Width = 100 };
            textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
            textBox.Size = new System.Drawing.Size(120, 18);

            Label textLabel2 = new Label() { Left = 50, Top = 62, Text = "$ POR CAJA:" };
            textLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
            textLabel2.Size = new System.Drawing.Size(130, 18);
            textLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            TextBox textBox2 = new TextBox() { Left = 170, Top = 60, Width = 100 };
            textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
            textBox2.Size = new System.Drawing.Size(120, 18);


            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox2);
            prompt.Controls.Add(textLabel2);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text + ":" +textBox2.Text : "" ;
        }
    }
}
