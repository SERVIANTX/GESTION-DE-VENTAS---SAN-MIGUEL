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
    public partial class FrmCliente : Form
    {
        void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListCliente", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[6].Visible = false;
            da.Dispose();
        }
        void rellenacombo()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_ListTipoDoc", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbTpDoc.DataSource = dt;
            cmbTpDoc.DisplayMember = "Descripcion";
            cmbTpDoc.ValueMember = "IdTipoDoc";
            da.Dispose();
        }
        public static bool validato(String NumDOc)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select NumDoc from Cliente where Numdoc = '" +NumDOc+"'", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Documento ya existente");
                return true;
            }
            else
            {
                return false;
            }
        }

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            rellenacombo();
            cargartabla();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {

                txtIdCliente.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtNombres.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtApellidos.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                txtNumDoc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                txtDireccion.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                txtNumeroTel.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                cmbTpDoc.SelectedValue = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
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
                if (ctrl is ComboBox)
                {
                    ComboBox cmb = ctrl as ComboBox;
                    cmb.SelectedIndex = -1;
                }
            }
            txtNombres.Select();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text != String.Empty && txtApellidos.Text != String.Empty && txtNumDoc.Text != String.Empty)
            {

                BtnAgregar.Enabled = true;
                if ((txtNumeroTel.Text.Length) <= 9 && (txtNumeroTel.Text.Length) >= 9)
                {
                    if (FrmCliente.validato(txtNumDoc.Text) == false)
                    {

                        try
                        {
                            SqlDataAdapter da = new SqlDataAdapter("SP_InsCliente '" + txtNombres.Text.ToUpper()
                            + "','" + txtApellidos.Text.ToUpper() + "','" + txtNumDoc.Text + "','" +
                            txtDireccion.Text.ToUpper() + "','" + txtNumeroTel.Text + "','" + Convert.ToInt32(cmbTpDoc.SelectedValue) + "'", Varpublic.cadconex);
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
                        txtNumDoc.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese Correctamente el Numero");
                    txtNumeroTel.Clear();
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos");
            }
        }


        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text != String.Empty && txtApellidos.Text != String.Empty && txtNumDoc.Text != String.Empty)
            {

                BtnActualizar.Enabled = true;
                if ((txtNumeroTel.Text.Length) <= 9 && (txtNumeroTel.Text.Length) >= 9)
                {
                        try
                        {
                            SqlDataAdapter da = new SqlDataAdapter("Sp_AcCliente'" + Convert.ToInt32(txtIdCliente.Text)
                            + "','" + txtNombres.Text.ToUpper() + "','" + txtApellidos.Text.ToUpper() + "','" +
                            txtNumDoc.Text + "','" + txtDireccion.Text.ToUpper() + "','" + txtNumeroTel.Text + "','" + cmbTpDoc.SelectedValue + "'", Varpublic.cadconex);
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
                    txtNumeroTel.Clear();
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void txtNumeroTel_TextChanged(object sender, EventArgs e)
        {
            txtNumeroTel.MaxLength = 9;
        }

        private void txtNumDoc_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbTpDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumDoc.Clear();
            txtNumDoc.Select();
            int a;
            a = Convert.ToInt32(cmbTpDoc.SelectedIndex);
            if (a == 0)
            {
                txtNumDoc.MaxLength = 8;
            }
            else if (a == 1)
            {
                txtNumDoc.MaxLength = 12;
            }
            else if (a == 2)
            {
                txtNumDoc.MaxLength = 11;
            }
            else if (a == 3)
            {
                txtNumDoc.MaxLength = 12;
            }
            else { }
        }

        private void txtNumeroTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloNumeros(e);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloLetras(e);
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloNumeros(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloLetras(e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
