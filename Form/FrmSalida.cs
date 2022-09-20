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
    public partial class FrmSalida : Form
    {
       
        void rellenacomboAlmacen()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListAlmacen", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbAlmacen.DataSource = dt;
            cmbAlmacen.DisplayMember = "Ubicacion";
            cmbAlmacen.ValueMember = "IdAlmacen";
            da.Dispose();
        }
        void rellenacomboProducto()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListProductos", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbProducto.DataSource = dt;
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "IdProducto";
            da.Dispose();
        }
        public FrmSalida()
        {
            InitializeComponent();
        }

        private void FrmSalida_Load(object sender, EventArgs e)
        {
            rellenacomboAlmacen();
            rellenacomboProducto();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].HeaderText = "IdProducto";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Cantidad";
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select IdProducto from Productos where Nombre ='" + cmbProducto.Text + "'", Varpublic.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtIdprod.Text = Convert.ToString(dt.Rows[0]["IdProducto"]);
                da.Dispose();
            }
            catch
            {
            }
        }

        private void txtIdprod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select Cantidad from Productos where IdProducto = '" + txtIdprod.Text + "'", Varpublic.cadconex);

                DataTable dt = new DataTable();
                da.Fill(dt);
                nudcantidad.Text = Convert.ToString(dt.Rows[0]["Cantidad"]);
                da.Dispose();
            }
            catch
            {
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Seguro de agregar nuevo item al detalle?", "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView1.Rows.Add(txtIdprod.Text, cmbProducto.Text, nudcantidad.Value);
                cmbProducto.SelectedIndex = -1;
                txtIdprod.Clear();
                nudcantidad.Value = 1;
                cmbProducto.Select();
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            int nNumdocEntrada;
            if (dataGridView1.RowCount > 0)
            {
                if (txtmotivo.Text != String.Empty && txtNumdoc.Text != String.Empty)
                {
                    try
                    {

                        SqlDataAdapter da = new SqlDataAdapter("Sp_InsSalida '" +
                        dtpFechaSalida.Value.ToString("MM-dd-yyy") + "','" + txtNumdoc.Text + "','" + Convert.ToInt32(cmbAlmacen.SelectedValue) + "','" +
                        txtmotivo.Text.ToUpper() + "','" + cmbtpdocsalida.Text.ToUpper() + "'", Varpublic.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        da.Dispose();
                        //Se busca cabecera emitida en tabla docentrada
                        SqlDataAdapter da2 = new SqlDataAdapter("select top 1 * from Salida order by IdSalida desc", Varpublic.cadconex);
                        DataTable dt2 = new DataTable();
                        da2.Fill(dt2);
                        nNumdocEntrada = Convert.ToInt32(dt2.Rows[0]["IdSalida"]);
                        da2.Dispose();
                        //Insertando Detalle de DocEntrada en la BD
                        int c;
                        for (c = 0; c <= dataGridView1.RowCount - 1; c++)
                        {
                            SqlDataAdapter da3 = new SqlDataAdapter("SP_InsDetalleSalida '" + Convert.ToInt32(dataGridView1.Rows[c].Cells[0].Value)
                            + "','" + nNumdocEntrada + "','" + dataGridView1.Rows[c].Cells[2].Value + "'", Varpublic.cadconex);
                            DataTable dt3 = new DataTable();
                            da3.Fill(dt3);
                            da3.Dispose();

                        }
                        MessageBox.Show("Ingreso procesado", "Aviso");
                        dataGridView1.Rows.Clear();
                        dtpFechaSalida.ResetText();
                        cmbAlmacen.SelectedValue = 1;
                        cmbtpdocsalida.SelectedValue = 1;
                        txtNumdoc.Clear();
                        txtmotivo.Clear();

                    }
                    catch
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese datos de La Salida");
                }
            }
            else
            {
                MessageBox.Show("No se puede grabar ingreso," + Char.ConvertFromUtf32(13) + "No existen items o superó límite máximo de items por comprobante", "Aviso");
            }
        }

        private void txtNumdoc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                if (MessageBox.Show("¿Seguro de eliminar item seleccionado a comprobante?",
                "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("No existen items para eliminar", "Aviso",
                    MessageBoxButtons.YesNo);
                }
            }
        }

        private void txtNumdoc_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtmotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloLetras(e);
        }

        private void cmbtpdocsalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Sp_NumS ", Varpublic.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string nume = Convert.ToString(dt.Rows[0]["Numdoc"]);
                da.Dispose();
                string Mt;
                int c, k, l;
                k = nume.Length;
                if (k >= 3)
                {

                    string valor = "S";
                    l = k - 2;
                    c = l;
                    Mt = nume.Substring(nume.Length - c, c);
                    int x = Convert.ToInt32(Mt);
                    x = x + 1;

                    if (cmbtpdocsalida.Text == "Salida interna")
                    {
                        txtNumdoc.Text = Convert.ToString(valor) + '-' + x;
                    }
                    else
                    {
                        txtNumdoc.Text = null;
                    }
                }

            }
            catch
            { }
        }
    }
}
