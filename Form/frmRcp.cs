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
using SimpleCrypto;
using System.Runtime.InteropServices;

namespace Proyecto_de_gestion_de_ventas
{
    public partial class frmRcp : Form
    {
        //drag from
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        public frmRcp()
        {
            InitializeComponent();
        }
        private void btnrecuperar_Click(object sender, EventArgs e)
        {
           
            string usuario = txtusuario.Text.Trim();
            string correo = txtcorreo.Text.Trim();
            string user, email; 

            SqlDataAdapter da = new SqlDataAdapter("Sp_recuperar '" + usuario + "','" + correo + "'", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                user = Convert.ToString(dt.Rows[0]["usuario"]);
                email = Convert.ToString(dt.Rows[0]["Correo"]);
                int Idpersonal = Convert.ToInt32(dt.Rows[0]["IdPersonal"]);
                
                ICryptoService cryptoService = new PBKDF2();

                string contraseñaNueva = RandomPassword.Generate(5,PasswordGroup.Lowercase,PasswordGroup.Uppercase,PasswordGroup.Numeric);

                string salt = cryptoService.GenerateSalt();

                string contraseñaEncriptada = cryptoService.Compute(contraseñaNueva);
                
                    var mailService = new SystemSupportMail();
                    mailService.sendMail(
                        subject: "Sistema: Solicitud de recuperación de contraseña",
                        body: "Hola," + user + "\nTu solicitud para recuper tu contraseña ha sido aceptada.\n" +
                        "Tu contraseña actual es:  " + contraseñaNueva + "\nSe le recomienda cambiar la contraseña una vez ingresado al sistema. ",
                        recipientMail: new List<string> { email }
                        );
                MessageBox.Show("Tu solicitud ha sido aceptada verifica tu correo:  " + email, "Solicitud Aceptada", MessageBoxButtons.OK);

                try
                {
                    SqlDataAdapter da2 = new SqlDataAdapter("Sp_RecuperarContra'" + Idpersonal + "','" + salt + "','" + contraseñaEncriptada + "'", Varpublic.cadconex);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    da2.Dispose();
                    
                }
                catch
                { 
                }
            }
            else
            {
                MessageBox.Show("Usuario no existente", "Advertencia", MessageBoxButtons.OK);
            
            }
            da.Dispose();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmRcp_Load(object sender, EventArgs e)
        {

        }

        private void frmRcp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
