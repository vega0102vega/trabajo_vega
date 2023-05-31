using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio2
{
    public class cls_Consultar_Cliente
    {

        private Bitmap bmp;
        private string str_identificacion; // igual esta; son variables innecesarias
        private string str_Nombres;
        private string str_Contacto;
        private string str_Correo;
        private string str_Direccion;

        public void fnt_ConsultarC(string identificacion)
        {
            cls_funciones_clientes obj_consultar = new cls_funciones_clientes();
            obj_consultar.fnt_ConsultarC(identificacion);
            this.str_Nombres = obj_consultar.getnombres();
            this.str_Contacto = obj_consultar.getcontacto();
            this.str_Correo = obj_consultar.getcorreo();
            this.str_Direccion = obj_consultar.getdireccion();

        }

        public Bitmap getBmp() { return bmp; }
        public string getnombre() { return this.str_Nombres; }
        public string getcontacto() { return this.str_Contacto; }
        public string getcorreo() { return this.str_Correo; }
        public string getdireccion() { return this.str_Direccion; }
    }
}

