using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio2
{
    public class cls_actualizar_cliente
    {
        private string str_id;
        private string str_Nombre;
        private string str_contacto;
        private string str_correo;
        private string str_Direccion;
        private string str_msn4;
        public cls_actualizar_cliente(string str_ID, string str_NOMBRE, string str_CONTACTO, string str_CORREO, string str_DIRECCION)
        {
            this.str_id = str_ID;
            this.str_Nombre = str_NOMBRE;
            this.str_contacto = str_CONTACTO;
            this.str_correo = str_CORREO;
            this.str_Direccion = str_DIRECCION;

            if (str_id == "" || str_NOMBRE == "" || str_contacto == "" || str_CORREO == "" || str_DIRECCION == "")
            {
                str_msn4 = "Debe ingresar toda la inofrmacion requerida";
            }
            else
            {
                cls_funciones_clientes obj_actualizar = new cls_funciones_clientes();
                obj_actualizar.fnt_actualizar(str_ID, str_NOMBRE, str_CONTACTO, str_correo, str_Direccion);
                str_msn4 = "El cliente" + str_Nombre + "Ha sido actualizado";

            }
        }
        public string getMns4() { return str_msn4; }
    }
}