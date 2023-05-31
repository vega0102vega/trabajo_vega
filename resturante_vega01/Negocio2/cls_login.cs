using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio2
{
    public class cls_login
    {
        private string str_nombre;
        private string str_estado;
        private string str_rol;
        private string str_msn;
        public cls_login(string user, string password)
        {
            if (user == "" || password == "")
            {
                this.str_msn = "Ingrese la información requerida";
            }
            else
            {
                Datos.cls_login obj_Login = new Datos.cls_login();
                obj_Login.fnt_ConsultarU(user, password);
                this.str_estado = obj_Login.getEstado();
                this.str_nombre = obj_Login.getNombre();
                this.str_rol = obj_Login.getRol();
                this.str_msn = obj_Login.getMsn();
            }
        }
        public string getNombre() { return this.str_nombre; }
        public string getEstado() { return this.str_estado; }
        public string getRol() { return this.str_rol; }
        public string getMsn() { return this.str_msn; }
    }
}