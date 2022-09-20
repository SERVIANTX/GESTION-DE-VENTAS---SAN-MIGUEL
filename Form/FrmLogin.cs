using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCrypto;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Common.Cache;

namespace Proyecto_de_gestion_de_ventas
{
    public partial class FrmLogin : Form
    {

        //drag from
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO") {
                if (txtContra.Text != "CONTRASEÑA") {
                    string persona;
                    string password;
                    string nivel;
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter("Sp_login '" + txtUsuario.Text + "'", Varpublic.cadconex);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        persona = Convert.ToString(dt.Rows[0]["salt"]);
                        password = Convert.ToString(dt.Rows[0]["password"]);
                        da.Dispose();

                        ICryptoService cryptoService = new PBKDF2();
                        string contraseñaincriptada = cryptoService.Compute(txtContra.Text, persona);

                        SqlDataAdapter da2 = new SqlDataAdapter("Sp_login '" + txtUsuario.Text + "'", Varpublic.cadconex);
                        DataTable dt2 = new DataTable();
                        da2.Fill(dt2);
                        UserLoginCache.IdUser= Convert.ToInt32(dt2.Rows[0]["IdPersonal"]);
                        UserLoginCache.Nombre= Convert.ToString(dt2.Rows[0]["Nombre"]);
                        UserLoginCache.Apellido = Convert.ToString(dt2.Rows[0]["Apellido"]);
                        UserLoginCache.Telefono = Convert.ToString(dt2.Rows[0]["Telefono"]);
                        UserLoginCache.Correo = Convert.ToString(dt2.Rows[0]["Correo"]);
                        UserLoginCache.usuario = Convert.ToString(dt2.Rows[0]["usuario"]);
                        
                        da2.Dispose();

                        if (cryptoService.Compare(password, contraseñaincriptada))
                        {
                            SqlDataAdapter da1 = new SqlDataAdapter("Sp_LoginNV '" + txtUsuario.Text + "'", Varpublic.cadconex);
                            DataTable dt1 = new DataTable();
                            da1.Fill(dt1);
                            nivel = Convert.ToString(dt1.Rows[0]["descripcion"]);
                            UserLoginCache.NIvels = Convert.ToString(dt1.Rows[0]["descripcion"]);
                            da1.Dispose();

                            this.Hide();
                            frmbienvenida welcome = new frmbienvenida();
                            welcome.ShowDialog();
                            Form f1 = new FrmAdmin();
                                f1.Show();
                                f1.FormClosed += logout;
                                


                        }
                        else
                        {
                            msgError("Usuario o Contraseña Incorrecta, Vuelva A Intentar");
                            txtUsuario.Text = "";
                            txtContra.Text = "";
                            txtUsuario.Focus();

                        }
                    }
                    catch
                    { }
                }
                else msgError("Porfavor Ingresar Contraseña");
            }
            else msgError("Porfavor Ingresar Usuario");

            
        }

        public void AnyMethod()
        {
            if (UserLoginCache.NIvels == Cargos.Administrador)
            { 
            
            }
            if (UserLoginCache.NIvels == Cargos.Usuario)
            { 
            
            }
        
        
        }

        private void msgError(string msg)
        {
            lblerrormessage.Text = "       " + msg;
            lblerrormessage.Visible = true;
        }
        private void logout(object sender, FormClosedEventArgs e)
        {
            txtContra.Clear();
            txtUsuario.Clear();
            lblerrormessage.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            label1.Select();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "CONTRASEÑA")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.LightGray;
                txtContra.UseSystemPasswordChar = true;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "CONTRASEÑA";
                txtContra.ForeColor = Color.DimGray;
                txtContra.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverpassword = new frmRcp();
            recoverpassword.ShowDialog();
        }
    }
}
