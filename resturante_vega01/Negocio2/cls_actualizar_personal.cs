using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio2
{
    public class cls_actualizar_personal
    {
        public string getmsn3;
        private string str_id;
        private string str_Nombre;
        private string str_contacto;
        private string str_correo;
        private string str_Direccion;
        private string str_msn3;
        private string text1;
        private string text2;
        private string text3;
        private string text4;

        public cls_actualizar_personal(string text1, string text2, string text3, string text4)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
        }

        public cls_actualizar_personal(string str_ID, string str_NOMBRE, string str_CONTACTO, string str_CORREO, string str_DIRECCION)
        {
            this.str_id = str_ID;
            this.str_Nombre = str_NOMBRE;
            this.str_contacto = str_CONTACTO;
            this.str_correo = str_CORREO;
            this.str_Direccion = str_DIRECCION;

            if (str_id == "" || str_NOMBRE == "" || str_CONTACTO == "" || str_CORREO == "" || str_DIRECCION == "")
            {
                str_msn3 = "Debe ingresar toda la inofrmacion requerida";
            }
            else
            {
                cls_funciones_personal obj_actualizar = new cls_funciones_personal();
                obj_actualizar.fnt_Actualizarp(str_ID, str_NOMBRE, str_CONTACTO, str_DIRECCION);
                str_msn3 = "El cliente" + str_Nombre + "Ha sido actualizado";

            }
        }
    }
}

