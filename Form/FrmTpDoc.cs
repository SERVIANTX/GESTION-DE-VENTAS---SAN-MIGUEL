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
    public partial class FrmTpDoc : Form
    {
        void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_ListTipoDoc", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            da.Dispose();
        }
        public FrmTpDoc()
        {
            InitializeComponent();
        }

        private void FrmTpDoc_Load(object sender, EventArgs e)
        {
            cargartabla();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
                try
                {
                    txtTpDoc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                    txtDesc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                }
                catch
                {
                }
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
                txtDesc.Select();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != String.Empty)
            {

                BtnAgregar.Enabled = true;
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SP_InsTipoDoc '" + txtDesc.Text.ToUpper() + "'", Varpublic.cadconex);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    da.Dispose();
                    cargartabla();
                    MessageBox.Show("Registro insertado exitosamente");
                }
                catch
                {
                    MessageBox.Show("Error, no se insertó registro");
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_AcTipoDoc'" + txtTpDoc.Text
                + "','" + txtDesc.Text.ToUpper() + "'", Varpublic.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                cargartabla();
                MessageBox.Show("Registro actualizado exitosamente");
            }
            catch
            {
                MessageBox.Show("Error, no se actualizó registro");
            }
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloLetras(e);
        }
    }
}
