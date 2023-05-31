using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio2
{
    public class cls_agregar_personal
    {
        private string str_identificacion;
        private string str_nombres;
        private string str_contacto;
        private string str_correo;
        private string str_msn3;
        public cls_agregar_personal(string str_identificacion
            , string str_nombres, string str_contacto, string str_correo)
        {
            this.str_identificacion = str_identificacion;
            this.str_nombres = str_nombres;
            this.str_contacto = str_contacto;
            this.str_correo = str_correo;
            if (str_identificacion == "" || str_nombres == "" || str_contacto == "" || str_correo == "")
            {
                str_msn3 = "Debe ingresar la informacion solicitada";
            }
            else
            {
                cls_funciones_personal objGuardarCliente = new cls_funciones_personal();
                objGuardarCliente.fnt_guardarp(str_identificacion, str_nombres, str_contacto, str_correo);
                str_msn3 = " el plato " + str_nombres + " ha sido registrado ";
            }
        }
        public string getMsn() { return this.str_msn3; }

    }
}
