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
    public partial class FrmAnulacion : Form
    {
        int IdEntrada;
        void cargartablaProductos()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_BuscaProductoV'" + cmbTDB.Text + "','" + txtNDocB.Text + "'", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            txtidVenta.Text = Convert.ToString(dt.Rows[0]["IdVenta"]);
            txtidpro.Text = Convert.ToString(dt.Rows[0]["IdProducto"]);
            txtnombrep.Text = Convert.ToString(dt.Rows[0]["Nombre"]);
            txtcan.Text = Convert.ToString(dt.Rows[0]["Cantidad"]);
            txtidalmacen.Text = Convert.ToString(dt.Rows[0]["Ubicacion"]);
            da.Dispose();
        }

        public FrmAnulacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargartablaProductos();
            dataGridView2.ColumnCount = 6;
            dataGridView2.Columns[0].HeaderText = "IdProducto";
            dataGridView2.Columns[1].HeaderText = "Nombre";
            dataGridView2.Columns[2].HeaderText = "Cantidad";
            dataGridView2.Columns[3].HeaderText = "CostoProducto";
            dataGridView2.Columns[4].HeaderText = "PrecioVenta";
            dataGridView2.Columns[5].HeaderText = "StockMin";
        }


        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                txtidpro.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                txtnombrep.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                txtcan.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            }
            catch
            {
            }
        }

        private void txtidpro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Sp_Encontrar'" + txtidpro.Text + "'", Varpublic.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtstockmin.Text = Convert.ToString(dt.Rows[0]["StockMin"]);
                txtcosto.Text = Convert.ToString(dt.Rows[0]["ProdCosto"]);
                txtprecio.Text = Convert.ToString(dt.Rows[0]["PrecioVenta"]);
                IdEntrada = Convert.ToInt32(dt.Rows[0]["IdEntrada"]);

                da.Dispose();
            }
            catch
            { }
        }

        private void btnAnularp_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txtidpro.Text, txtnombrep.Text, txtcan.Text, txtcosto.Text, txtprecio.Text, txtstockmin.Text);
            
            txtidpro.Clear();
            txtnombrep.Clear();
            txtcan.Clear();
            txtcosto.Clear();
            txtprecio.Clear();
            txtstockmin.Clear();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            int nNumdocEntrada;
            if (dataGridView2.RowCount > 0)
            {
               
                    //try
                    //{
                    DateTime today = DateTime.Today;
                    String Tipo = "DEVOLUCION";
                    int ubi;
                    int proveedor;
                    SqlDataAdapter da9 = new SqlDataAdapter("select IdAlmacen from Almacen a where a.Ubicacion = '" + txtidalmacen.Text + "'", Varpublic.cadconex);
                    DataTable dt9 = new DataTable();
                    da9.Fill(dt9);
                    ubi = Convert.ToInt32(dt9.Rows[0]["IdAlmacen"]);
                    da9.Dispose();

                    SqlDataAdapter da5 = new SqlDataAdapter("select IdProveedor from Entradas a where IdEntrada = '" + IdEntrada + "'", Varpublic.cadconex);
                    DataTable dt5 = new DataTable();
                    da5.Fill(dt5);
                    proveedor = Convert.ToInt32(dt5.Rows[0]["IdProveedor"]);
                    da5.Dispose();

                    SqlDataAdapter da = new SqlDataAdapter("SP_InsEntrada '" +
                        today.ToString("MM-dd-yyy") + "','" + ubi + "','" + proveedor + "','" +
                        txtNDocB + "','" + Tipo + "'", Varpublic.cadconex);
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
                        for (c = 0; c <= dataGridView2.RowCount - 1; c++)
                        {
                            SqlDataAdapter da3 = new SqlDataAdapter("Sp_InsDetalleEntrada '" + nNumdocEntrada + "','" + dataGridView2.Rows[c].Cells[0].Value
                            + "','" + dataGridView2.Rows[c].Cells[2].Value + "','" + dataGridView2.Rows[c].Cells[3].Value + "','" + dataGridView2.Rows[c].Cells[4].Value + "','" + dataGridView2.Rows[c].Cells[5].Value + "'", Varpublic.cadconex);
                            DataTable dt3 = new DataTable();
                            da3.Fill(dt3);
                            da3.Dispose();

                        }
                MessageBox.Show("VENTA ANULADA", "FINALIZADO", MessageBoxButtons.OK);
                        dataGridView2.Rows.Clear();
                        dataGridView1.Rows.Clear();

                        txtidVenta.Clear();
                        txtidalmacen.Clear();
                        cmbTDB.SelectedValue = 0;
                    txtNDocB.Clear();

                    //}
                    //catch
                    //{
                    //}
                

            }
            else
            {
                MessageBox.Show("No se puede grabar ingreso," + Char.ConvertFromUtf32(13) + "No existen items o superó límite máximo de items por comprobante", "Aviso");
            }
        }
    }
}

