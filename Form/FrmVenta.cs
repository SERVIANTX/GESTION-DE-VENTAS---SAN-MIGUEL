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
using System.Drawing.Printing;

namespace Proyecto_de_gestion_de_ventas
{
    public partial class FrmVenta : Form
    {
        void rellenacomboTpDoc()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_listTipoDoc", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbTpDoc.DataSource = dt;
            cmbTpDoc.DisplayMember = "descripcion";
            cmbTpDoc.ValueMember = "IdTipoDoc";
            da.Dispose();
        }
        void rellenacomboPersonal()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_ListPersonalVenta", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbPersonal.DataSource = dt;
            CmbPersonal.DisplayMember = "vendedor";
            CmbPersonal.ValueMember = "IdPersonal";
            da.Dispose();
        }
        void rellenacomboSucursal()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_listSucursal", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbSucursal.DataSource = dt;
            CmbSucursal.DisplayMember = "Ubicacion";
            CmbSucursal.ValueMember = "IdSucursal";
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
            cmbProducto.SelectedIndex = -1;
            da.Dispose();
        }


        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            rellenacomboPersonal();
            rellenacomboSucursal();
            rellenacomboTpDoc();
            rellenacomboProducto();
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].HeaderText = "IdProducto";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Cantidad";
            dataGridView1.Columns[3].HeaderText = "PrecioUnitario";
            dataGridView1.Columns[4].HeaderText = "SubTotal";
            dataGridView1.Columns[5].HeaderText = "Garantia";
            dataGridView1.Columns[6].HeaderText = "Meses";
            dataGridView1.Columns[7].HeaderText = "NumSerie";

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(txtstock.Text);
            b = Convert.ToInt32(nudcantidad.Value);
            if (b <= a)
            {
                if (txtMGarantia.Text != String.Empty && txtsubTotal.Text != String.Empty)
                {
                    if (MessageBox.Show("¿Seguro de agregar nuevo item al detalle?", "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Add(txtIdprod.Text, cmbProducto.Text, nudcantidad.Value, txtprecioVenta.Text, txtsubTotal.Text, cmbGarantia.Text, txtMGarantia.Text,txtNumserie.Text);
                        cmbProducto.SelectedIndex = -1;
                        txtIdprod.Clear();
                        nudcantidad.Value = 1;
                        cmbProducto.Select();
                        txtNumserie.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese datos del Producto");
                }
            }
            else 
            {
               MessageBox.Show("No hay stock suficientes", "Alerta de Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    double Total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Total += Convert.ToDouble(row.Cells[4].Value);
            }
            txtimporte.Text = Convert.ToString(Total);

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int nNumdocEntrada;
            int nNumdocsalida;
            if (dataGridView1.RowCount > 0)
            {
                if (txtNDocB.Text != String.Empty && txtimporte.Text != String.Empty)
                {
                    try
                    {

                        SqlDataAdapter da = new SqlDataAdapter("SP_InsVenta '" +
                       Convert.ToInt32(txtIdcliente.Text) + "','" + Convert.ToInt32(CmbPersonal.SelectedValue) + "','" + cmbTDB.Text.ToUpper() + "','" +
                        txtNDocB.Text + "','" + Convert.ToInt32(CmbSucursal.SelectedValue) + "','" + dtpFechaVenta.Value.ToString("MM-dd-yyy") + "','" + txtimporte.Text + "'", Varpublic.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        da.Dispose();
                        //Se busca cabecera emitida en tabla venta
                        SqlDataAdapter da2 = new SqlDataAdapter("select top 1 * from Venta order by IdVenta desc", Varpublic.cadconex);
                        DataTable dt2 = new DataTable();
                        da2.Fill(dt2);
                        nNumdocEntrada = Convert.ToInt32(dt2.Rows[0]["IdVenta"]);
                        da2.Dispose();
                        //Insertando Detalle de venta en la BD
                        int c;
                        for (c = 0; c <= dataGridView1.RowCount - 1; c++)
                        {
                            SqlDataAdapter da3 = new SqlDataAdapter("SP_InsDetalleVenta '" + nNumdocEntrada + "','" + dataGridView1.Rows[c].Cells[0].Value
                            + "','" + dataGridView1.Rows[c].Cells[2].Value + "','" + dataGridView1.Rows[c].Cells[3].Value + "','" + dataGridView1.Rows[c].Cells[4].Value + "','" + dataGridView1.Rows[c].Cells[5].Value +
                            "','" + dataGridView1.Rows[c].Cells[6].Value + "','" + dataGridView1.Rows[c].Cells[7].Value + "'", Varpublic.cadconex);
                            DataTable dt3 = new DataTable();
                            da3.Fill(dt3);
                            da3.Dispose();


                        }
                        MessageBox.Show("Ingreso procesado", "Aviso");

                        string mot = "VENTA";
                           int ubi;
                    //datos para ingresar a salida
                    SqlDataAdapter da9 = new SqlDataAdapter("select IdAlmacen from Almacen a where a.Ubicacion = '" + CmbSucursal.Text.ToUpper() + "'", Varpublic.cadconex);
                    DataTable dt9 = new DataTable();
                    da9.Fill(dt9);
                    ubi = Convert.ToInt32(dt9.Rows[0]["IdAlmacen"]);
                    da9.Dispose();

                        string tpdoc = cmbTDB.Text.ToUpper();

                        SqlDataAdapter da4 = new SqlDataAdapter("Sp_InsSalida '" +
                            dtpFechaVenta.Value.ToString("MM-dd-yyy") + "','" + txtNDocB.Text + "','" + ubi + "','" +
                            mot + "','" + tpdoc + "'", Varpublic.cadconex);
                        DataTable dt1 = new DataTable();
                        da4.Fill(dt1);
                        da4.Dispose();
                        //Se busca cabecera emitida en tabla docSalida
                        SqlDataAdapter da5 = new SqlDataAdapter("select top 1 * from Salida order by IdSalida desc", Varpublic.cadconex);
                        DataTable dt5 = new DataTable();
                        da5.Fill(dt5);
                        nNumdocsalida = Convert.ToInt32(dt5.Rows[0]["IdSalida"]);
                        da5.Dispose();
                        //Insertando Detalle de DocSalida en la BD
                        for (c = 0; c <= dataGridView1.RowCount - 1; c++)
                        {
                            SqlDataAdapter da6 = new SqlDataAdapter("SP_InsDetalleSalida '" + Convert.ToInt32(dataGridView1.Rows[c].Cells[0].Value)
                            + "','" + nNumdocsalida + "','" + dataGridView1.Rows[c].Cells[2].Value + "'", Varpublic.cadconex);
                            DataTable dt6 = new DataTable();
                            da6.Fill(dt6);
                            da6.Dispose();

                        }
                        MessageBox.Show("Salida Registrada", "Aviso");

                        dataGridView1.Rows.Clear();

                        txtNumdoc.Clear();
                        txtprecioVenta.Clear();
                        txtsubTotal.Clear();
                        txtimporte.Clear();
                        txtNDocB.Clear();
                        cmbProducto.SelectedIndex = -1;

                    }
                    catch
                    {
                    }
                }
                else 
                {
                    MessageBox.Show("Ingrese datos de la venta");
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

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudcantidad.Value = 1;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Sp_Stock '" + cmbProducto.SelectedValue + "'", Varpublic.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtstock.Text = Convert.ToString(dt.Rows[0]["Stock"]);
                da.Dispose();
            }
            catch
            {

            }
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Sp_UltiCos '" + cmbProducto.SelectedValue + "'", Varpublic.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtprecioVenta.Text = Convert.ToString(dt.Rows[0]["PrecioVenta"]);
                da.Dispose();
            }
            catch
            {

            }

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

            double a, b, c = 0;
            a = Convert.ToDouble(nudcantidad.Value);
            b = Convert.ToDouble(txtprecioVenta.Text);
            c = a * b;
            txtsubTotal.Text = c.ToString();

        }

        private void txtIdprod_TextChanged(object sender, EventArgs e)
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

        private void cmbTpDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumdoc.Clear();
            txtNumdoc.Select();
            int a;
            a = Convert.ToInt32(cmbTpDoc.SelectedIndex);
            if (a == 0)
            {
                txtNumdoc.MaxLength = 8;
            }
            else if (a == 1)
            {
                txtNumdoc.MaxLength = 12;
            }
            else if (a == 2)
            {
                txtNumdoc.MaxLength = 11;
            }
            else if (a == 3)
            {
                txtNumdoc.MaxLength = 12;
            }
            else { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_BuscaClientexDocumento '" + cmbTpDoc.SelectedValue + "','" + txtNumdoc.Text + "'", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtCliente.Text = Convert.ToString(dt.Rows[0]["Nombre"]);
                txtIdcliente.Text = Convert.ToString(dt.Rows[0]["IdCliente"]);
            }
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show("Desea registrar al Cliente", "Cliente no registrado", botones, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    Form f4 = new FrmCliente();
                    f4.Show();
                }
                
            }

            da.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloLetras(e);
        }

        private void txtNumdoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.SoloNumeros(e);
        }

        private void txtimporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.NumerosDecimales(e);
        }

        private void txtprecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtsubTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALIDAR.NumerosDecimales(e);
        }

        private void txtNDocB_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void nudcantidad_ValueChanged(object sender, EventArgs e)
        {
            
            double a, b, c = 0;
                a = Convert.ToDouble(nudcantidad.Value);
                b = Convert.ToDouble(txtprecioVenta.Text);
                c = a * b;
                txtsubTotal.Text = c.ToString();
        }

        private void CmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbTDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTDB.Text == "Boleta")
                {
                    SqlDataAdapter da = new SqlDataAdapter("Sp_NumBoleta ", Varpublic.cadconex);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    string nume = Convert.ToString(dt.Rows[0]["Numdoc"]);
                    da.Dispose();
                    string Mt;
                    int c, k, l;
                    k = nume.Length;
                    if (k >= 5)
                    {

                        string valor = "1";
                        valor = valor.PadLeft(3, '0');
                        l = k - 4;
                        c = l;
                        Mt = nume.Substring(nume.Length - c, c);
                        int x = Convert.ToInt32(Mt);
                        x = x + 1;
                        
                        txtNDocB.Text = Convert.ToString(valor) + '-' + x;
                    }
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("Sp_NumFactura ", Varpublic.cadconex);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    string nume = Convert.ToString(dt.Rows[0]["Numdoc"]);
                    da.Dispose();
                    string Mt;
                    int c, k, l;
                    k = nume.Length;
                    if (k >= 5)
                    {

                        string valor = "1";
                        valor = valor.PadLeft(3, '0');
                        l = k - 4;
                        c = l;
                        Mt = nume.Substring(nume.Length - c, c);
                        int x = Convert.ToInt32(Mt);
                        x = x + 1;

                        txtNDocB.Text = Convert.ToString(valor) + '-' + x;
                    }
                }
            }
            catch
            { }
        }

        private void imprimir(object sender, PrintPageEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Deseas anular una venta?", "Anulación de Venta", botones, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Form f4 = new FrmAnulacion();
                f4.Show();
            
            }
        }
    }
}
