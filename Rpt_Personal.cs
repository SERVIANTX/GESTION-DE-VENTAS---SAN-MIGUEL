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
    public partial class Rpt_Personal : Form
    {
        int opci;
        public Rpt_Personal()
        {
            InitializeComponent();
        }

        private void Rpt_Personal_Load(object sender, EventArgs e)
        {
            

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'Gestion_VentaBDDataSet.Sp_RptPersonal' Puede moverla o quitarla según sea necesario.
            this.Sp_RptPersonalTableAdapter.Fill(this.Gestion_VentaBDDataSet.Sp_RptPersonal, txtcad.Text, Convert.ToByte(opci));
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
