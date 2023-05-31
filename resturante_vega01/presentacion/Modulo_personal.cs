using Negocio2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class Modulo_personal : Form
    {
        private object identificacion_personal;
        private string str_nombre_personal;
        private int str_correo_personal;
        private string str_contacto_personal;
        private string str_identificacion_personal;
        public Modulo_personal()
        {
            InitializeComponent();
        }

        private void fnt_limpiarp()
        {
            txt_identificacion_personal.Clear();
            txt_nombre_personal.Clear();
            txt_contacto_personal.Clear();
            txt_correo_personal.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cls_agregar_personal obj_agregarplatos = new cls_agregar_personal(
           txt_identificacion_personal.Text, txt_nombre_personal.Text, txt_contacto_personal.Text, txt_correo_personal.Text);
            MessageBox.Show("" + obj_agregarplatos.getMsn());
            fnt_limpiarp();
        }

        private void bnt_limpiar_Click(object sender, EventArgs e)
        {
            fnt_limpiarp();
        }

        private void fnt_Consultarp(string id)
        {
            cls_Consultar_personal obj_consultar = new cls_Consultar_personal();
            obj_consultar.fnt_Consultarp(id);

            txt_nombre_personal.Text = obj_consultar.getnombre();
            txt_contacto_personal.Text = obj_consultar.getcontacto();
            txt_correo_personal.Text = obj_consultar.getcorreo();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fnt_Consultarp(txt_identificacion_personal.Text);
        }

        private void bnt_actualizar_Click(object sender, EventArgs e)
        {
            cls_actualizar_personal objactualizar = new cls_actualizar_personal(
         txt_identificacion_personal.Text, txt_nombre_personal.Text, txt_contacto_personal.Text, txt_correo_personal.Text);
            MessageBox.Show("" + objactualizar.getmsn3, "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fnt_limpiarp();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getidentificacion() { return this.str_identificacion_personal; }
        public string getNombre() { return this.str_nombre_personal; }
        public string getcontacto() { return this.str_contacto_personal; }
        public int getcorreo() { return this.str_correo_personal; }
    }
}
