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
using System.Text.RegularExpressions;

namespace Proyecto_de_gestion_de_ventas
{
    public partial class FrmProveedor : Form
    {
        void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListProvedor", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            da.Dispose();
        }
        public static bool validato(String NumDOc)
        {
            SqlDataAdapter da = new SqlDataAdapter("select RUC from Proveedor where RUC = '" + NumDOc + "'", Varpublic.cadconex);
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
        public FrmProveedor()
        {
            InitializeComponent();
        }
        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            cargartabla();
        }
        public static bool Email_Valido(String email)
        {
            String validando;
            validando = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, validando))
            {
                if (Regex.Replace(email, validando, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                TxtRa.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtRuc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtDirecc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                txtTe.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                txtIdPro.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                txtCorreo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                txtFax.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
                txtPaginaWeb.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
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
            TxtRa.Select();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtRa.Text != String.Empty && txtDirecc.Text != String.Empty && txtRuc.Text != String.Empty)
            {

                BtnAgregar.Enabled = true;
                if (Email_Valido(txtCorreo.Text))
                {

                    if ((txtTe.Text.Length) <= 9 && (txtTe.Text.Length) >= 9)
                    {
                            if (FrmProveedor.validato(txtRuc.Text) == false)
                            {
                            try
                            {
                                SqlDataAdapter da = new SqlDataAdapter("Sp_InsProvedor '" + TxtRa.Text.ToUpper()
                                + "','" + txtRuc.Text + "','" + txtDirecc.Text.ToUpper() + "','" +
                                txtTe.Text + "','" + txtCorreo.Text.Trim() + "','" + txtFax.Text + "','" + txtPaginaWeb.Text + "'", Varpublic.cadconex);
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
                            txtRuc.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese Correctamente el Numero");
                        txtTe.Clear();
                    }

                }
                else
                {
                    
                    

                    MessageBox.Show("Ingrese un Email Válido");
                    txtCorreo.Clear();
                }

            }
            else 
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtRa.Text != String.Empty && txtDirecc.Text != String.Empty && txtRuc.Text != String.Empty)
            {
                if (Email_Valido(txtCorreo.Text))
                {
                    MessageBox.Show("correo valido");

                    if ((txtTe.Text.Length) <= 9 && (txtTe.Text.Length) >= 9)
                    {
                        try
                        {
                            SqlDataAdapter da = new SqlDataAdapter("Sp_AcProvedor'" + Convert.ToInt32(txtIdPro.Text)
                            + "','" + TxtRa.Text.ToUpper() + "','" + txtRuc.Text + "','" +
                            txtDirecc.Text.ToUpper() + "','" + txtTe.Text + "','" + txtCorreo.Text.Trim() + "','" + txtFax.Text + "','" + txtPaginaWeb.Text + "'", Varpublic.cadconex);
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
                        txtTe.Clear();
                    }
                }
                else
                {
                    
                    MessageBox.Show(" Ingrese un Email Válido");
                    txtCorreo.Clear();
                }
            }
        }

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {
            txtRuc.MaxLength = 11;
        }

        private void txtTe_TextChanged(object sender, EventArgs e)
        {
            txtTe.MaxLength = 9;
        }

        private void txtFax_TextChanged(object sender, EventArgs e)
        {
            txtFax.MaxLength = 9;
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloNumeros(e);
        }

        private void txtTe_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloNumeros(e);
        }

        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloNumeros(e);
        }
    }
}
