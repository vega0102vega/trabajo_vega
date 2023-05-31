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
    public partial class panel_de_acciones : Form
    {
        internal object lbl_Estado;
        public panel_de_acciones()
        {
            InitializeComponent();
        }

        private void ptb_personal_Click(object sender, EventArgs e)
        {
            Modulo_personal f3 = new Modulo_personal();
            f3.Show();
        }

        private void ptb_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptb_platos_Click(object sender, EventArgs e)
        {
            modulo_platos f1 = new modulo_platos();
            f1.Show();
        }

        private void ptb_clientes_Click(object sender, EventArgs e)
        {
            Cliente f2 = new Cliente();
            f2.Show();
        }
    }

    internal class Modulo_clientes
    {
        public Modulo_clientes()
        {
        }


    }
}
