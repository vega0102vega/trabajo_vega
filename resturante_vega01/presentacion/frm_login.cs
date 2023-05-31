using Negocio2;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void bnt_login_Click(object sender, EventArgs e)
        {
            fnt_Login(txt_usuario.Text, txt_contraseña.Text);
        }

        private void fnt_Login(string user, String contraseña)
        {
            cls_login obj_login = new cls_login(user, contraseña);
            MessageBox.Show("" + obj_login.getRol());
            if (obj_login.getRol() == "Administrador")
            {

                panel_de_acciones obj_Adm = new panel_de_acciones();
                obj_Adm.Visible = true;
                obj_Adm.lbl_Encargado.Text = obj_login.getNombre();
                obj_Adm.lbl_EstadoUser.Text = obj_login.getEstado();
                obj_Adm.lbl_Rol.Text = obj_login.getRol();
                Visible = false;

            }
            cls_login obj_login2 = new cls_login(user, contraseña);
            MessageBox.Show("" + obj_login.getRol());
            if (obj_login.getRol() == "Cajer@")

            {
                panel_de_acciones obj_cajero = new panel_de_acciones();
                obj_cajero.Visible = true;
                obj_cajero.lbl_Encargado.Text = obj_login.getNombre();
                obj_cajero.lbl_EstadoUser.Text = obj_login.getEstado();
                obj_cajero.lbl_Rol.Text = obj_login.getRol();
                Visible = false;

            }
            if (obj_login.getRol() == "Domiciliario")
            {
                panel_de_acciones obj_inventario = new panel_de_acciones();
                obj_inventario.Visible = true;
                obj_inventario.lbl_Encargado.Text = obj_login.getNombre();
                obj_inventario.lbl_EstadoUser.Text = obj_login.getEstado();
                obj_inventario.lbl_Rol.Text = obj_login.getRol();
                Visible = false;
            }
        }

        private void bnt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_registrar_Click(object sender, EventArgs e)
        {

        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }

}
