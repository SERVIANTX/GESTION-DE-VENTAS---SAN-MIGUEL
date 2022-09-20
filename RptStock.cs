using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_de_gestion_de_ventas
{
    public partial class RptStock : Form
    {
        
        public RptStock()
        {
            InitializeComponent();
        }

        private void RptStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Gestion_VentaBDDataSet.Sp_RptStock' Puede moverla o quitarla según sea necesario.
            this.Sp_RptStockTableAdapter.Fill(this.Gestion_VentaBDDataSet.Sp_RptStock);
            this.reportViewer1.RefreshReport();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
        }

        private void rbProductos_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtcad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        private void txtidproducto_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
