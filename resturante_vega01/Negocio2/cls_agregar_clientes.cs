using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio2
{
    public class cls_agregar_clientes
    {
        private string str_identificacion;
        private string str_nombres;
        private string str_contacto;
        private string str_correo;
        private string str_direccion;
        private byte[] by_Foto;
        private string str_msn2;


        public cls_agregar_clientes(string str_identificacion
            , string str_nombres, string str_contacto, string str_correo, string str_direccion)
        {
            this.str_identificacion = str_identificacion;
            this.str_nombres = str_nombres;
            this.str_contacto = str_contacto;
            this.str_correo = str_correo;
            this.str_direccion = str_direccion;

            if (str_identificacion == "" || str_nombres == "" || str_contacto == "" || str_correo == "" || str_direccion == "")
            {
                str_msn2 = "Debe ingresar la informacion solicitada";
            }
            else
            {
                cls_funciones_clientes objGuardarCliente = new cls_funciones_clientes();
                objGuardarCliente.fnt_guardarC(str_identificacion, str_nombres, str_contacto, str_correo, str_direccion
                  );
                str_msn2 = " el cliente " + str_nombres + " ha sido registrado ";
            }
        }
        public string getMsn() { return this.str_msn2; }
    }
}


