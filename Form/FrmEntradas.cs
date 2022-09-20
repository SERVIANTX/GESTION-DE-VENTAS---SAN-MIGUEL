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
    public partial class FrmEntradas : Form
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
        void rellenacomboProveedor()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListProvedor", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbProvedor.DataSource = dt;
            cmbProvedor.DisplayMember = "Rsocial";
            cmbProvedor.ValueMember = "IdProveedor";
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

        public FrmEntradas()
        {
            InitializeComponent();
        }

        private void FrmEntradas_Load(object sender, EventArgs e)
        {
            rellenacomboAlmacen();
            rellenacomboProveedor();
            rellenacomboProducto();

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].HeaderText = "IdProducto";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Cantidad";
            dataGridView1.Columns[3].HeaderText = "CostoProducto";
            dataGridView1.Columns[4].HeaderText = "PrecioVenta";
            dataGridView1.Columns[5].HeaderText = "StockMin";

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter ("Select IdProducto from Productos where Nombre ='" + cmbProducto.Text + "'", Varpublic.cadconex);
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
                SqlDataAdapter da = new SqlDataAdapter("Select PrecioVenta from Productos where IdProducto = '" + txtIdprod.Text + "'", Varpublic.cadconex);
               
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtprecio.Text = Convert.ToString(dt.Rows[0]["PrecioVenta"]);
                da.Dispose();
            }
            catch
            {
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtprecio.Text != String.Empty && txtcosto.Text != String.Empty)
            {
                if (MessageBox.Show("¿Seguro de agregar nuevo item al detalle?", "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridView1.Rows.Add(txtIdprod.Text, cmbProducto.Text, nudcantidad.Value, txtcosto.Text, txtprecio.Text, nudStockMin.Value);
                    cmbProducto.SelectedIndex = -1;
                    txtIdprod.Clear();
                    nudcantidad.Value = 1;
                    nudStockMin.Value = 1;
                    txtcosto.Clear();
                    txtprecio.Clear();
                    cmbProducto.Select();
                }
            }
            else
            {
                MessageBox.Show("Ingrese datos del Producto");
            }

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            int nNumdocEntrada;
            if (dataGridView1.RowCount > 0)
            {
                if (txtNumeroDoc.Text != String.Empty)
                {
                    try
                    {

                        SqlDataAdapter da = new SqlDataAdapter("SP_InsEntrada '" +
                        dtpFechaRegistro.Value.ToString("MM-dd-yyy") + "','" + Convert.ToInt32(cmbAlmacen.SelectedValue) + "','" + Convert.ToInt32(cmbProvedor.SelectedValue) + "','" +
                        txtNumeroDoc.Text + "','" + CmbTpDocEntrada.Text.ToUpper() + "'", Varpublic.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        da.Dispose();
                        //Se busca cabecera emitida en tabla docentrada
                        SqlDataAdapter da2 = new SqlDataAdapter("select top 1 * from Entradas order by IdEntrada desc", Varpublic.cadconex);
                        DataTable dt2 = new DataTable();
                        da2.Fill(dt2);
                        nNumdocEntrada = Convert.ToInt32(dt2.Rows[0]["IdEntrada"]);
                        da2.Dispose();
                        //Insertando Detalle de DocEntrada en la BD
                        int c;
                        for (c = 0; c <= dataGridView1.RowCount - 1; c++)
                        {
                            SqlDataAdapter da3 = new SqlDataAdapter("Sp_InsDetalleEntrada '" + nNumdocEntrada + "','" + dataGridView1.Rows[c].Cells[0].Value
                            + "','" + dataGridView1.Rows[c].Cells[2].Value + "','" + dataGridView1.Rows[c].Cells[3].Value + "','" + dataGridView1.Rows[c].Cells[4].Value + "','" + dataGridView1.Rows[c].Cells[5].Value + "'", Varpublic.cadconex);
                            DataTable dt3 = new DataTable();
                            da3.Fill(dt3);
                            da3.Dispose();

                        }
                        MessageBox.Show("Ingreso procesado", "Aviso");

                        dataGridView1.Rows.Clear();

                        cmbAlmacen.SelectedValue = 1;
                        cmbProvedor.SelectedValue = 1;
                        CmbTpDocEntrada.SelectedValue = 1;
                        txtNumeroDoc.Clear();
                        dtpFechaRegistro.ResetText();

                    }
                    catch
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese datos de La Entrada");
                }
                
            }
            else
            {
                MessageBox.Show("No se puede grabar ingreso," + Char.ConvertFromUtf32(13) + "No existen items o superó límite máximo de items por comprobante", "Aviso");
            }
        }

        private void cmbProvedor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtNumeroDoc_TextChanged(object sender, EventArgs e)
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

        private void txtNumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.NumerosDecimales(e);
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.NumerosDecimales(e);
        }

        private void CmbTpDocEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
           {
            


            SqlDataAdapter da = new SqlDataAdapter("Sp_NumB ", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string nume = Convert.ToString(dt.Rows[0]["numdoc"]);
            da.Dispose();

            string Mt;

            int c, k, l;
            k = nume.Length;
            if (k >=3)
            {
                
                string valor = "E";
                l =k - 2;
                c = l;
                Mt = nume.Substring(nume.Length - c, c);
                int x = Convert.ToInt32(Mt);
                x = x + 1;

                if (CmbTpDocEntrada.Text == "Entrada interna")
                {
                    txtNumeroDoc.Text = Convert.ToString(valor) + '-' + x;
                }
                else
                {
                    txtNumeroDoc.Text = null;
                }
            }
           
            }
            catch
            { }
        }
    }
}
