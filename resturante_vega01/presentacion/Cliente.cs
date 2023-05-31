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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }
        private void fnt_limpiar_clientes()
        {
            txt_identificacion.Clear();
            txt_nombres_clientes.Clear();
            txt_contacto_cliente.Clear();
            txt_correo_cliente.Clear();
            txt_direccion.Clear();
            txt_identificacion.Focus();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cls_agregar_clientes obj_agregar_cliente = new cls_agregar_clientes(
                txt_identificacion.Text, txt_nombres_clientes.Text, txt_contacto_cliente.Text, txt_correo_cliente.Text, txt_direccion.Text);
            MessageBox.Show("" + obj_agregar_cliente.getMsn());
               fnt_limpiar_clientes();
        }

        private void bnt_limpiar_Click(object sender, EventArgs e)
        {
            fnt_limpiar_clientes();
        }

        private void fnt_ConsultarC(string identificacion)
        {
            cls_Consultar_Cliente obj_consultarC = new cls_Consultar_Cliente();
            obj_consultarC.fnt_ConsultarC(identificacion);
            txt_nombres_clientes.Text = obj_consultarC.getnombre();
            txt_contacto_cliente.Text = obj_consultarC.getcontacto();
            txt_correo_cliente.Text = obj_consultarC.getcorreo();
            txt_direccion.Text = obj_consultarC.getdireccion();


        }
        private void bnt_consultar_Click(object sender, EventArgs e)
        {
            fnt_ConsultarC(txt_identificacion.Text);
        }

        private void bnt_actualizar_Click(object sender, EventArgs e)
        {
            cls_actualizar_cliente objactualizar = new cls_actualizar_cliente(
             txt_identificacion.Text, txt_nombres_clientes.Text, txt_contacto_cliente.Text, txt_correo_cliente.Text, txt_direccion.Text);
            MessageBox.Show("" + objactualizar.getMns4(), "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fnt_limpiar_clientes();
        }
    }
}
