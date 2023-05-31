using Datos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio2
{
    public class cls_Consultar_personal
    {
        private Bitmap bmp;
        string str_identificacion;
        string str_nombre;
        string str_contacto;
        string str_correo;
        public void fnt_Consultarp(string identificacion)
        {
            cls_funciones_personal obj_consultarP = new cls_funciones_personal();
            obj_consultarP.fnt_Consultarp(identificacion);
            this.str_nombre = obj_consultarP.getNombre();
            this.str_contacto = obj_consultarP.getContacto();
            this.str_correo = obj_consultarP.getcorreo();
            
        }
        public Bitmap getBmp() { return bmp; }
        public string getnombre() { return this.str_nombre; }
        public string getcontacto() { return this.str_contacto; }
        public string getcorreo() { return this.str_correo; }
      
    }
}
