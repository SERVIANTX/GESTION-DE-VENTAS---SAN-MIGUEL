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
    public partial class FrmProductos : Form
    {
        void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListProductos", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv1.DataSource = dt;
            da.Dispose();
        }
        void rellenacomboAlmacen()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listAlmacen", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbAlmacen.DataSource = dt;
            cmbAlmacen.DisplayMember = "Ubicacion";
            cmbAlmacen.ValueMember = "IdAlmacen";
            da.Dispose();
        }
        void cargartablaubicacion()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListUbicacion", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv3.DataSource = dt;
            dgv3.Columns[0].Visible = false;
            da.Dispose();
        }

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cargartablaubicacion();
            rellenacomboAlmacen();
            cargartabla();
            dataGridView2.ColumnCount = 5;
            dataGridView2.Columns[0].HeaderText = "IdAlmacen";
            dataGridView2.Columns[1].HeaderText = "Ubicacion";
            dataGridView2.Columns[2].HeaderText = "Fila";
            dataGridView2.Columns[3].HeaderText = "Estante";
            dataGridView2.Columns[4].HeaderText = "Columna";
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("¿Seguro de agregar nuevo item al detalle?", "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                dataGridView2.Rows.Add(txtIdAlmacen.Text, cmbAlmacen.Text, txtFila.Text, txtEstante.Text,txtColumna.Text);
                cmbAlmacen.SelectedIndex = -1;
                txtIdAlmacen.Clear();
                txtFila.Clear();
                txtEstante.Clear();
                txtColumna.Clear();
                cmbAlmacen.Select();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int nNumdocEntrada;
            if (dataGridView2.RowCount > 0)
            {
                try
                {

                    SqlDataAdapter da = new SqlDataAdapter("SP_InsProductos '" + txtNombre.Text.ToUpper() + "','" + txtMarca.Text.ToUpper() + "'", Varpublic.cadconex);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    da.Dispose();
                    //Se busca cabecera emitida en tabla docentrada
                    SqlDataAdapter da2 = new SqlDataAdapter("select top 1 * from Productos order by IdProducto desc", Varpublic.cadconex);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    nNumdocEntrada = Convert.ToInt32(dt2.Rows[0]["IdProducto"]);
                    da2.Dispose();
                    //Insertando Detalle de DocEntrada en la BD
                    int c;
                    for (c = 0; c <= dataGridView2.RowCount - 1; c++)
                    {
                        SqlDataAdapter da3 = new SqlDataAdapter("Sp_InsDetalleUbicacion '" + nNumdocEntrada + "','" + dataGridView2.Rows[c].Cells[0].Value
                        + "','" + dataGridView2.Rows[c].Cells[2].Value + "','" + dataGridView2.Rows[c].Cells[3].Value + "','" + dataGridView2.Rows[c].Cells[4].Value + "'", Varpublic.cadconex);
                        DataTable dt3 = new DataTable();
                        da3.Fill(dt3);
                        da3.Dispose();

                    }
                    MessageBox.Show("Ingreso procesado", "Aviso");
                    dataGridView2.Rows.Clear();
                    cargartabla();
                    cargartablaubicacion();

                    MessageBoxButtons botones = MessageBoxButtons.OK;
                    DialogResult dr = MessageBox.Show("Producto Registrado, Registrar la Entrada", "Registrar Doc. Entrada", botones, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Form f4 = new FrmEntradas();
                        f4.Show();
                    }


                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("No se puede grabar ingreso," + Char.ConvertFromUtf32(13) + "No existen items o superó límite máximo de items por comprobante", "Aviso");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != String.Empty && txtMarca.Text != String.Empty)
            {
                BtnActualizar.Enabled = true;
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("Sp_AcProductos '" + txtIdProducto.Text
                    + "','" + txtNombre.Text.ToUpper() + "','" + txtMarca.Text.ToUpper() + "'", Varpublic.cadconex);
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

        private void dataGridView1_CurrentCellChanged_1(object sender, EventArgs e)
        {
            try
            {
                txtIdProducto.Text = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);
                txtNombre.Text = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                txtMarca.Text = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);
            }
            catch
            {
            }
        }

        private void cmbAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select IdAlmacen from Almacen where Ubicacion ='" + cmbAlmacen.Text + "'", Varpublic.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtIdAlmacen.Text = Convert.ToString(dt.Rows[0]["IdAlmacen"]);
                da.Dispose();
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Sp_BusquedaUbicacion '" + txtb.Text + "'", Varpublic.cadconex);
                DataSet dt = new DataSet();
                da.Fill(dt, "UbicacionProducto");
                this.dgv3.DataSource = dt.Tables[0];
                da.Dispose();
            }
            catch
            {
            }
        }

        private void txtEstante_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloNumeros(e);
        }

        private void txtFila_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloNumeros(e);
        }

        private void txtColumna_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloNumeros(e);
        }

        private void btnNuevoP_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
                txtNombre.Select();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
            {
                if (MessageBox.Show("¿Seguro de eliminar item seleccionado a comprobante?",
                "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("No existen items para eliminar", "Aviso",
                    MessageBoxButtons.YesNo);
                }
            }
        }
    }
}
