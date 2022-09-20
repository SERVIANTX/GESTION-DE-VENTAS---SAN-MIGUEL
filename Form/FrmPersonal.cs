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
using System.Linq.Expressions;
using SimpleCrypto;
using System.Text.RegularExpressions;

namespace Proyecto_de_gestion_de_ventas
{
    
    public partial class FrmPersonal : Form
    {
        Boolean sexo;
        void cargartabla()
        {

            SqlDataAdapter da = new SqlDataAdapter("SP_ListPersonal", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            da.Dispose();
        }
        void rellenacombo()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_listNivelSeguridad", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbNivelSeg.DataSource = dt;
            cmbNivelSeg.DisplayMember = "descripcion";
            cmbNivelSeg.ValueMember = "IdNivelSeguridad";
            da.Dispose();
        }
        void rellenacmbTpDoc()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_listTipoDoc", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbTpDoc.DataSource = dt;
            cmbTpDoc.DisplayMember = "descripcion";
            cmbTpDoc.ValueMember = "IdTipoDoc";
            da.Dispose();
        }
        public static bool validato(String NumDOc)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select NumDoc from Personal where Numdoc = '" + NumDOc + "'", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Documento ya existente","Advertencia",MessageBoxButtons.OK);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool validarUsuario(String usuario)
        {
            SqlDataAdapter da = new SqlDataAdapter("select usuario from Personal where usuario = '" + usuario + "'", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Usuario existente,Ingrese otro Usuario","Advertencia",MessageBoxButtons.OK);
                return true;
            }
            else
            {
                return false;
            }
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
        public FrmPersonal()
        {
            InitializeComponent();
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            cmbHorario.SelectedItem = 1;
            rdbM.Checked = true;
            rellenacmbTpDoc();
            rellenacombo();
            cargartabla();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            
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
            rdbM.Checked = true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ICryptoService cryptoService = new PBKDF2();

            //GENERAR ALGORITMO DE INCRIPTACION
            string salt = cryptoService.GenerateSalt();
            string contraseñaincriptada = cryptoService.Compute(txtPassword.Text);

            if (txtNombres.Text != String.Empty && txtApellidos.Text != String.Empty && txtTelefono.Text != String.Empty)
            {
                if (Email_Valido(txtemail.Text))
                {
                    BtnAgregar.Enabled = true;
                    if ((txtTelefono.Text.Length) <= 9 && (txtTelefono.Text.Length) >= 9)
                    {
                        if (FrmPersonal.validato(txtNumDoc.Text) == false)
                        {
                            if (FrmPersonal.validarUsuario(txtusuario.Text) == false)
                            {
                                try
                                {
                                    if (rdbM.Checked == true)
                                    {
                                        sexo = true;
                                    }
                                    else
                                    {
                                        sexo = false;
                                    }

                                    SqlDataAdapter da = new SqlDataAdapter("SP_InsPersonal '" + txtNombres.Text.ToUpper()
                                    + "','" + txtApellidos.Text.ToUpper() + "','" + txtTelefono.Text + "','" + sexo +
                                    "','" + txtCarg.Text.ToUpper() + "','" + txtNumDoc.Text + "','" + txtusuario.Text.ToUpper() + "','" + contraseñaincriptada + "','" + Convert.ToInt32(cmbNivelSeg.SelectedValue) +
                                    "','" + Convert.ToInt32(cmbTpDoc.SelectedValue) + "','" + txtSalario.Text + "','" + cmbHorario.Text.ToUpper() + "','" + salt + "','" + txtemail.Text.Trim() + "'", Varpublic.cadconex);
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
                                txtusuario.Clear();
                            
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
                        txtTelefono.Clear();
                    }
                }
                else
                {



                    MessageBox.Show("Ingrese un Email Válido");
                    txtemail.Clear();
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void txtNumDoc_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.MaxLength = 9;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text != String.Empty && txtApellidos.Text != String.Empty && txtTelefono.Text != String.Empty)
            {
                BtnAgregar.Enabled = true;
                if ((txtTelefono.Text.Length) <= 9 && (txtTelefono.Text.Length) >= 9)
                {
                    try
                    {

                        if (rdbM.Checked == true)
                    {
                        sexo = true;
                    }
                    else
                    {
                        sexo = false;
                    }
                    SqlDataAdapter da = new SqlDataAdapter("SP_AcPersonal'" + Convert.ToInt32(txtIdPer.Text) + "','" + txtNombres.Text.ToUpper() + "','" + txtApellidos.Text.ToUpper() + "','" +
                    txtTelefono.Text + "','" + sexo + "','" + txtCarg.Text.ToUpper() + "','" + txtNumDoc.Text.ToUpper() + "','" + txtusuario.Text.ToUpper() + "','" + Convert.ToInt32(cmbNivelSeg.SelectedValue) + 
                    "','" + Convert.ToInt32(cmbTpDoc.SelectedValue) + "','" + txtSalario.Text + "','" + cmbHorario.Text + "','" + txtemail.Text.Trim() + "'", Varpublic.cadconex);
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

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloLetras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloNumeros(e);
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloNumeros(e);
        }

        private void txtCarg_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloLetras(e);
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.NumerosDecimales(e);
        }

        private void dataGridView1_CurrentCellChanged_1(object sender, EventArgs e)
        {
            try
            {
                txtIdPer.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtNombres.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtApellidos.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                txtTelefono.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                txtCarg.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                txtNumDoc.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
                txtusuario.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
                cmbNivelSeg.SelectedValue = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
                cmbTpDoc.SelectedValue = Convert.ToString(dataGridView1.CurrentRow.Cells[10].Value);
                txtSalario.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[12].Value);
                cmbHorario.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[13].Value);
                txtemail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[14].Value);


            }
            catch
            {
            }
        }
    }
}
