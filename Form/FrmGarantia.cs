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
    public partial class FrmGarantia : Form
    {
        Boolean Aprobacion;
        void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListGarantia", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            da.Dispose();
        }
        void cargartablaProductos()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_BuscaProducto'" + cmbTDB.Text + "','" + txtNDocB.Text + "'", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv2.DataSource = dt;
            dgv2.Columns[1].Visible = false;
            dgv2.Columns[2].Visible = false;
            da.Dispose();
        }
        public FrmGarantia()
        {
            InitializeComponent();
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
                if (ctrl is ComboBox)
                {
                    ComboBox cmb = ctrl as ComboBox;
                    cmb.SelectedIndex = -1;
                }
                if (ctrl is DateTimePicker)
                {
                    DateTimePicker dtp = ctrl as DateTimePicker;
                    dtp.ResetText();
                
                }
            }
            txtMD.Select();
        }


        private void FrmGarantia_Load(object sender, EventArgs e)
        {
            rdbApro.Checked = true;
            cargartabla();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtMD.Text != String.Empty && dtpGara.Text != String.Empty )
            {
                BtnAgregar.Enabled = true;
                try
                {

                    if (rdbApro.Checked == true)
                    {
                        Aprobacion = true;
                    }
                    else
                    {
                        Aprobacion = false;
                    }
                    SqlDataAdapter da = new SqlDataAdapter("Sp_InsGarantia '" + dtpGara.Value.ToString("MM-dd-yyy")
                    + "','" + txtMD.Text.ToUpper() + "','" + Aprobacion  + "','" + txtidventa.Text  + "','" + txtproducto.Text.ToUpper() + "','" + txtticket.Text + "'", Varpublic.cadconex);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    da.Dispose();
                    cargartabla();
                    MessageBox.Show("Registro insertado exitosamente");

                }

                catch
                {
                    MessageBox.Show("Ingresar los datos Correctamente");
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
            if (txtMD.Text != String.Empty )
            {
                BtnActualizar.Enabled = true;
                try
                {
                    if (rdbApro.Checked == true)
                    {
                        Aprobacion = true;
                    }
                    else
                    {
                        Aprobacion = false;
                    }
                    SqlDataAdapter da = new SqlDataAdapter("Sp_AcGarantia'" + txtIdGa.Text
                    + "','" + dtpGara.Text + "','" +
                    txtMD.Text.ToUpper() + "','" + Aprobacion + "'", Varpublic.cadconex);
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

        private void cmbTpDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Sp_BuscaProCliente '" + cmbTDB.Text + "','" + txtNDocB.Text + "'", Varpublic.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtIdcliente.Text = Convert.ToString(dt.Rows[0]["IdCliente"]);
                    txtCliente.Text = Convert.ToString(dt.Rows[0]["Nombre"]);
                    txtTPDoc.Text = Convert.ToString(dt.Rows[0]["Descripcion"]);
                    txtnumdoc.Text = Convert.ToString(dt.Rows[0]["NumDoc"]);
                    dtpFechaVenta.Text = Convert.ToString(dt.Rows[0]["FecVenta"]);

                }
                else
                {
                    MessageBox.Show("No Hay Datos Asociados", "Información", MessageBoxButtons.OK);
                }
            }
            catch
            {
            }
            cargartablaProductos();

            calculardiferencia();

            double a, b;
            a = Convert.ToDouble(txtmeses.Text);
            b = Convert.ToInt32(txtGaran.Text);
            if (a <= b)
            {
                lblaprobo.Text = "APROBO";

            }
            else {
                lblaprobo.Text = "NO APROBO";
            }
        }

        private void dgv2_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                txtidventa.Text = Convert.ToString(dgv2.CurrentRow.Cells[0].Value);
                txtproducto.Text = Convert.ToString(dgv2.CurrentRow.Cells[4].Value);
                txtGaran.Text = Convert.ToString(dgv2.CurrentRow.Cells[7].Value);
                

            }
            catch
            {
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                txtIdGa.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                dtpGara.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[1].Value);
                txtMD.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                rbdRechazado.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[3].Value);
                txtticket.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            }
            catch
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Sp_BusquedaGarantia '" + txtbuscar.Text + "'", Varpublic.cadconex);
                DataSet dt = new DataSet();
                da.Fill(dt, "NumDoc");
                this.dataGridView1.DataSource = dt.Tables[0];
                da.Dispose();
            }
            catch
            {
            }
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloLetras(e);
        }

        private void txtnumdoc_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtnumdoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloNumeros(e);
        }

        private void dtpFechaVenta_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void txtGaran_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmeses_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
        void calculardiferencia()
        {
            DateTime fechainicial = dtpFechaVenta.Value.Date;
            DateTime fechafinal = dtpGara.Value.Date;
            TimeSpan tSpan = fechafinal - fechainicial;
            int dias = tSpan.Days;
            double t;
            t = Math.Floor(dias * 0.0329);
            txtmeses.Text = Convert.ToString(t);
        
        }

        private void dtpGara_ValueChanged(object sender, EventArgs e)
        {
            calculardiferencia();
            double a, b;
            a = Convert.ToDouble(txtmeses.Text);
            b = Convert.ToInt32(txtGaran.Text);
            if (a <= b)
            {
                lblaprobo.Text = "APROBO";

            }
            else
            {
                lblaprobo.Text = "NO APROBO";
            }
        }
    }
}
