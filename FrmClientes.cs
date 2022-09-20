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
    public partial class FrmClientes : Form
    {
        int opci;
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Gestion_VentaBDDataSet.Sp_RptClientes' Puede moverla o quitarla según sea necesario.
            this.Sp_RptClientesTableAdapter.Fill(this.Gestion_VentaBDDataSet.Sp_RptClientes, txtcad.Text, Convert.ToByte(opci));
            this.reportViewer1.RefreshReport();
        }

        private void rbNumdoc_CheckedChanged(object sender, EventArgs e)
        {
            opci = 0;
        }

        private void rbtelefono_CheckedChanged(object sender, EventArgs e)
        {
            opci = 1;
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            opci = 2;
        }
    }
}
