using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmLicencia : Form
    {
        public frmLicencia()
        {
            InitializeComponent();
        }

        string serialPC;
        private void frmLicencia_Load(object sender, EventArgs e)
        {
            ManagementObject mos = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
            serialPC = mos.Properties["SerialNumber"].Value.ToString().Trim();
        }
    }
}
