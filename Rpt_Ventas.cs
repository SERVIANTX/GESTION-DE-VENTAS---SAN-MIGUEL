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
    public partial class Rpt_Ventas : Form
    {
        public Rpt_Ventas()
        {
            InitializeComponent();
        }

        private void Rpt_Ventas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.Gestion_VentaBDDataSet.EnforceConstraints = false;
            // TODO: esta línea de código carga datos en la tabla 'Gestion_VentaBDDataSet.Sp_RptVentasDetalladasFechas' Puede moverla o quitarla según sea necesario.
            this.Sp_RptVentasDetalladasFechasTableAdapter.Fill(this.Gestion_VentaBDDataSet.Sp_RptVentasDetalladasFechas, dtpIni.Value, dtpFin.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
