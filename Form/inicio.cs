using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_gestion_de_ventas
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh.mm.ss");
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
