using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Common.Cache;

namespace Proyecto_de_gestion_de_ventas
{
    public partial class FrmAdmin : Form
    {
        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //constructor
        public FrmAdmin()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 40);
            panelMenu.Controls.Add(leftBorderBtn);
            //from
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        //structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }
        private void LoadUserData() 
        {
            lblnombre.Text = UserLoginCache.Nombre +' '+ UserLoginCache.Apellido;
            lbltelefono.Text = UserLoginCache.Telefono;
            lblcorreo.Text = UserLoginCache.Correo;
            lblnv.Text = UserLoginCache.NIvels;
            lblusuario.Text = UserLoginCache.usuario;
            
        }


        //metodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                disableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //izquierda borde boton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //iconos de formulario hijo
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }

        }

        private void disableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }

        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            LoadUserData();
            //permisos
            if (UserLoginCache.NIvels == Cargos.Usuario)
            {
                
                btnAlmacen.Enabled = false;
                btnsucursal.Enabled = false;
                btnproveedor.Enabled = false;
                btnentrada.Enabled = false;
                btnsalida.Enabled = false;
                btnNivelS.Enabled = false;
                btntpdoc.Enabled = false;
                btnpersonal.Enabled = false;
                btnreportes.Enabled = false;

            }
            if (UserLoginCache.NIvels == Cargos.Almacen)
            {

                btnpersonal.Enabled = false;
                btnproveedor.Enabled = false;
                btncliente.Enabled = false;
                btnventa.Enabled = false;
                btngarantia.Enabled = false;
                btnNivelS.Enabled = false;
                btntpdoc.Enabled = false;
                btnpersonal.Enabled = false;
                btnrptcliente.Enabled = false;
                btnrptpersonal.Enabled = false;
                btnrptproductos.Enabled = false;
                btnrptventas.Enabled = false;

            }
            OpenChildForm(new inicio());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FrmProductos());
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FrmAlmacen1());
        }

        private void btnsucursal_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FrmSucursal());
        }

        private void btnpersonal_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FrmPersonal());
        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FrmProveedor());
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FrmCliente());
        }

        private void btnentrada_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FrmEntradas());
        }

        private void btnsalida_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FrmSalida());
        }

        private void btngarantia_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FrmGarantia());
            
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FrmVenta());
        }

        private void btnkardex_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FrmKardex());
        }

        private void btntpdoc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FrmTpDoc());
        }

        private void btnNivelS_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FrmNivelSeguridad());
        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Reset();
            OpenChildForm(new inicio());
        }
        private void Reset()
        {
            disableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.SlateBlue;
            lblTitleChildForm.Text = "Home";

        }
        //drag from
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas cerrar la sesion de la aplicación?", "Advertencia",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Deseas cerrar la aplicación?", "Advertencia",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            submenureportes.Visible = true;
        }

        private void btnrptpersonal_Click(object sender, EventArgs e)
        {
            submenureportes.Visible = false;
            OpenChildForm(new Rpt_Personal());
        }

        private void btnrptcliente_Click(object sender, EventArgs e)
        {
            submenureportes.Visible = false;
            OpenChildForm(new FrmClientes());
        }

        private void btnrptventas_Click(object sender, EventArgs e)
        {
            submenureportes.Visible = false;
            OpenChildForm(new Rpt_Ventas());
        }

        private void btnrptsock_Click(object sender, EventArgs e)
        {
        }

        private void btnrptproductos_Click(object sender, EventArgs e)
        {
            submenureportes.Visible = false;
            OpenChildForm(new Rpt_Productos());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            submenureportes.Visible = false;
            OpenChildForm(new RptStock());
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
