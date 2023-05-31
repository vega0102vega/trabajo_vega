
using Negocio2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;



namespace presentacion
{
    public partial class modulo_platos : Form
    {

        string ruta_directorio_Raiz;
        public modulo_platos()
        {
            InitializeComponent();
            fnt_cargarEstadoG();
            ruta_directorio_Raiz = Path.Combine(Application.StartupPath + "\\Imagenes");
            fnt_limpiar();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            ptb_Foto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            cls_agreagarplatos obj_agregarplatos = new cls_agreagarplatos(
                txt_Codigo.Text, txt_ingredientes.Text, txt_nombre.Text, txt_valor.Text, cbx_tipo.SelectedIndex + 1, cbx_estado.SelectedIndex + 1, aByte);
            MessageBox.Show("" + obj_agregarplatos.getMsn());
            fnt_limpiar();
        }

        private void bnt_guardar_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            ptb_Foto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            cls_agreagarplatos obj_agregarplatos = new cls_agreagarplatos(
                txt_Codigo.Text, txt_ingredientes.Text, txt_nombre.Text, txt_valor.Text, cbx_tipo.SelectedIndex + 1, cbx_estado.SelectedIndex + 1, aByte);
            MessageBox.Show("" + obj_agregarplatos.getMsn());
            fnt_limpiar();
        }

        private void fnt_limpiar()
        {
            txt_Codigo.Clear();
            txt_ingredientes.Clear();
            txt_nombre.Clear();
            txt_valor.Clear();
            ptb_Foto.Image = Image.FromFile(ruta_directorio_Raiz + "\\dieta-equilibrada.png");
            txt_Codigo.Focus();
        }
        private void bnt_limpiar_Click(object sender, EventArgs e)
        {
            fnt_limpiar();
        }


        private void fnt_Consultar(string cod)
        {
            cls_consulta_plato1 obj_consultar = new cls_consulta_plato1();
            obj_consultar.fnt_consultar(cod);
            ptb_Foto.Image = obj_consultar.getBmp();
            txt_nombre.Text = obj_consultar.getNombre();
            txt_ingredientes.Text = obj_consultar.getIngredientes();
            txt_valor.Text = obj_consultar.getValor();
            cbx_tipo.SelectedIndex = obj_consultar.getTipo() - 1;
            cbx_estado.SelectedIndex = obj_consultar.getEstado() - 1;
        }
        private void bnt_consultar_Click(object sender, EventArgs e)
        {
            fnt_Consultar(txt_Codigo.Text);
        }

        private void fnt_cargarEstadoG()
        {
            cls_cargar_estado1 obj_Dt = new cls_cargar_estado1();
            obj_Dt.fnt_CargarEstado1();
            cbx_estado.ValueMember = "PKCodigo";
            cbx_estado.DisplayMember = "Descripcion";
            cbx_estado.DataSource = obj_Dt.getDt();
        }

        private void bnt_actualizar_Click(object sender, EventArgs e)
        {
            cls_actulaiza_plato1 objactualizar = new cls_actulaiza_plato1(
           txt_Codigo.Text, txt_nombre.Text, txt_ingredientes.Text, txt_valor.Text, cbx_tipo.SelectedIndex + 1, cbx_estado.SelectedIndex + 1);
            MessageBox.Show("" + objactualizar.getMsn(), "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fnt_limpiar();
        }
        private void fnt_Cargartipo()
        {
            cls_cargar_tipo1 obj_Dt = new cls_cargar_tipo1();
            obj_Dt.fnt_CargarTipo1();
            cbx_tipo.ValueMember = "PKCodigo";
            cbx_tipo.DisplayMember = "Nombre";
            cbx_tipo.DataSource = obj_Dt.getDt();
        }
        private void ptb_Foto_Click(object sender, EventArgs e)
        {

            try
            {
                ruta_directorio_Raiz = Path.Combine(Application.StartupPath + "\\Foto");
                OpenFileDialog File = new OpenFileDialog();
                File.Filter = "Archivo JPG|*.jpg";

                if (File.ShowDialog() == DialogResult.OK)
                {
                    ptb_Foto.Image = Image.FromFile(File.FileName);
                }
            }
            catch { }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fnt_Cargartipo();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
