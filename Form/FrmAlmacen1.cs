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
    public partial class FrmAlmacen1 : Form
    {
        void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListAlmacen", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            da.Dispose();
        }
        public FrmAlmacen1()
        {
            InitializeComponent();
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
                txtDescripcion.Select();
            }
        }

        private void FrmAlmacen1_Load(object sender, EventArgs e)
        {
            cargartabla();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                txtIdAlmacen.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtDescripcion.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtUbicacion.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                txtTelefono.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                txtNumEstantes.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            }
            catch
            {
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != String.Empty && txtNumEstantes.Text != String.Empty && txtTelefono.Text != String.Empty)
            {
                BtnAgregar.Enabled = true;
                if ((txtTelefono.Text.Length) <= 9 && (txtTelefono.Text.Length) >= 9)
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter("SP_InsAlmacen '" + txtDescripcion.Text.ToUpper()
                        + "','" + txtUbicacion.Text.ToUpper() + "','" + txtTelefono.Text + "','" + Convert.ToInt32(txtNumEstantes.Text) + "'", Varpublic.cadconex);
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
                    MessageBox.Show("Ingrese Correctamente el Numero");
                    txtTelefono.Clear();
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != String.Empty && txtNumEstantes.Text != String.Empty && txtTelefono.Text != String.Empty)
            {

                BtnActualizar.Enabled = true;
                if ((txtTelefono.Text.Length) <= 9 && (txtTelefono.Text.Length) >= 9)
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter("Sp_AcAlmacen'" + txtIdAlmacen.Text
                        + "','" + txtDescripcion.Text.ToUpper() + "','" + txtUbicacion.Text.ToUpper() + "','" +
                        txtTelefono.Text + "','" + Convert.ToInt32(txtNumEstantes.Text) + "'", Varpublic.cadconex);
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
                    MessageBox.Show("Ingrese Correctamente el Numero");
                    txtTelefono.Clear();
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.MaxLength = 9;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloNumeros(e);
        }

        private void txtNumEstantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloNumeros(e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
