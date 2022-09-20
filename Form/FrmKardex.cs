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
    public partial class FrmKardex : Form
    {

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
        void cargartablaEntrada()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_EntradaKardex'" + txtIdprod.Text + "'", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgventrada.DataSource = dt;
            da.Dispose();
        }
        void cargartablaSalida()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_SalidaKardex'" + txtIdprod.Text + "'", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSalida.DataSource = dt;
            da.Dispose();
        }
        void cargartabladeSalida()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_DetaSalidaKarxdex'" + txtIdprod.Text + "'", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSa.DataSource = dt;
            da.Dispose();
        }
        void cargartabladeEntrada()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_DeEntradaKardex'" + txtIdprod.Text + "'", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvde.DataSource = dt;
            da.Dispose();
        }

        public FrmKardex()
        {
            InitializeComponent();
        }
        public void StockMin()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_StockMin'"+ txtIdprod.Text + "'", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtstm.Text = Convert.ToString(dt.Rows[0]["Stock_Minimo"]);
            da.Dispose();
        }
        public void Stock()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_Stock'" + txtIdprod.Text + "'", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtstock.Text = Convert.ToString(dt.Rows[0]["stock"]);
            da.Dispose();
        }
        
        public void UltimoCosto()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Sp_UltiCos'" + txtIdprod.Text + "'", Varpublic.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtulti.Text = Convert.ToString(dt.Rows[0]["PrecioVenta"]);
                da.Dispose();
            }
            catch
            { 
            
            }
            

            
        }
        public void CostoPromedio()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Sp_CostoPro'" + txtIdprod.Text + "'", Varpublic.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtCp.Text = Convert.ToString(dt.Rows[0]["CostoTotal"]);
                da.Dispose();

            }
            catch
            { }

        }


        private void FrmKardex_Load(object sender, EventArgs e)
        {
            cargartabladeEntrada();
            cargartabladeSalida();
            
            rellenacomboProducto();
            cargartablaEntrada();
            cargartablaSalida();
            StockMin();
            Stock();
            UltimoCosto();
            CostoPromedio();
            try
            {

                double Total = 0;
                foreach (DataGridViewRow row in dgvde.Rows)
                {
                    Total += Convert.ToDouble(row.Cells[2].Value);
                }
                txtCanE.Text = Convert.ToString(Total);
            }
            catch
            {

            }

            try
            {

                double Total = 0;
                foreach (DataGridViewRow row in dgvSa.Rows)
                {
                    Total += Convert.ToDouble(row.Cells[2].Value);
                }
                txtCanS.Text = Convert.ToString(Total);
            }
            catch
            {

            }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                SqlDataAdapter da3 = new SqlDataAdapter("Select IdProducto from Productos where Nombre ='" + cmbProducto.Text + "'", Varpublic.cadconex);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                txtIdprod.Text = Convert.ToString(dt3.Rows[0]["IdProducto"]);
                da3.Dispose();
            }
            catch
            {
            }
            cargartablaEntrada();
            cargartablaSalida();
            StockMin();
            Stock();
            cargartabladeEntrada();
            cargartabladeSalida();
            UltimoCosto();
            CostoPromedio();

            try
            {

                double Total = 0;
                foreach (DataGridViewRow row in dgvde.Rows)
                {
                    Total += Convert.ToDouble(row.Cells[2].Value);
                }
                txtCanE.Text = Convert.ToString(Total);
            }
            catch
            {

            }

            try
            {

                double Total = 0;
                foreach (DataGridViewRow row in dgvSa.Rows)
                {
                    Total += Convert.ToDouble(row.Cells[2].Value);
                }
                txtCanS.Text = Convert.ToString(Total);
            }
            catch
            {

            }

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select IdProducto from kardex where IdProducto ='" + Convert.ToInt32(txtIdprod.Text) + "'", Varpublic.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    SqlDataAdapter da2 = new SqlDataAdapter("Sp_AcKardex'" + Convert.ToInt32(txtIdprod.Text) + "','" + txtCanE.Text + "','" + txtCanS.Text
                    + "','" + txtulti.Text + "','" + txtCp.Text + "','" + txtstock.Text + "','" + txtstm.Text + "'", Varpublic.cadconex);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    da2.Dispose();

                }
                else
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("Sp_insKardex '" + Convert.ToInt32(txtIdprod.Text) + "','" + txtCanE.Text + "','" + txtCanS.Text 
                    + "','" + txtulti.Text + "','" + txtCp.Text + "','" + txtstock.Text + "','" + txtstm.Text + "'", Varpublic.cadconex);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    da1.Dispose();


                }
                    da.Dispose();
            }
            catch
            {
            }

            try
            {

                int S, min;
                S = Convert.ToInt32(txtstock.Text);
                min = Convert.ToInt32(txtstm.Text);
                if (S <= min)
                {
                    MessageBox.Show("Se supero el Stock Min de: " + min, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                }

            }
            catch
            { 
            }

        }

                private void btnAc_Click(object sender, EventArgs e)
                {
             
                }
        
    }
}
