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
    public partial class FrmSucursal : Form
    {
        void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListSucursal", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            da.Dispose();
        }
        public FrmSucursal()
        {
            InitializeComponent();
        }

        private void FormSucursal_Load(object sender, EventArgs e)
        {
            cargartabla();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            
                try
                {
                    txtIdsucursal.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                    txtubi.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                    txtTel.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                }
                catch
                {
                }
            
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
            }
            txtubi.Select();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtubi.Text != String.Empty && txtTel.Text != String.Empty)
            {
                BtnAgregar.Enabled = true;

                if ((txtTel.Text.Length) <= 9 && (txtTel.Text.Length) >= 9)
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter("SP_InsSucursal '" + txtubi.Text.ToUpper()
                        + "','" + txtTel.Text + "'", Varpublic.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        da.Dispose();
                        MessageBox.Show("Registro insertado exitosamente La sucursal");

                        string desc = "PEQUEÑO";
                        int num = 10;
                       
                            SqlDataAdapter da1 = new SqlDataAdapter("SP_InsAlmacen '" + desc
                               + "','" + txtubi.Text.ToUpper() + "','" + txtTel.Text + "','" + num + "'", Varpublic.cadconex);
                            DataTable dt2 = new DataTable();
                            da1.Fill(dt2);
                            da1.Dispose();
                            cargartabla();
                            MessageBox.Show("Se Registro Correctamente El Almacen");
                        
                    }
                    catch
                    {
                        MessageBox.Show("Error, no se insertó registro");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (txtubi.Text != String.Empty && txtTel.Text != String.Empty)
            {
                BtnActualizar.Enabled = true;
                if ((txtTel.Text.Length) <= 9 && (txtTel.Text.Length) >= 9)
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter("Sp_AcSucursal'" + txtubi.Text.ToUpper()
                        + "','" + txtTel.Text + "','" + Convert.ToInt32(txtIdsucursal.Text) + "'", Varpublic.cadconex);
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
            }
            else
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            txtTel.MaxLength = 9;
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloNumeros(e);
        }
    }
}
