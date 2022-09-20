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
    public partial class FrmNivelSeguridad : Form
    {
        void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListNivelSeguridad", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            da.Dispose();
        }
        public FrmNivelSeguridad()
        {
            InitializeComponent();
        }

        private void FrmNivelSeguridad_Load(object sender, EventArgs e)
        {
            cargartabla();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
                txtDescrip.Select();
            }
        }    

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
                try
                {
                    txtIdNive.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                    txtDescrip.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                }
                catch
                {
                }
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDescrip.Text != String.Empty)
            {
                BtnAgregar.Enabled = true;
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("Sp_InsNivelSeguridad '" + txtDescrip.Text.ToUpper()
                    + "'", Varpublic.cadconex);
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
            if (txtDescrip.Text != String.Empty)
            {
                BtnActualizar.Enabled = true;
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("Sp_AcNivelSeguridad'" + txtIdNive.Text
                    + "','" + txtDescrip.Text.ToUpper() + "'", Varpublic.cadconex);
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
            else
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void txtDescrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloLetras(e);
        }
    }
}
