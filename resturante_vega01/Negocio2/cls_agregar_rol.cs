using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio2
{
    public class cls_agregar_rol
    {
        private DataTable dt;
        public void fnt_CargarRo1()
        {
            cls_cargar_rol obj_Dt = new cls_cargar_rol();
            obj_Dt.fnt_CargarRol();
            this.dt = obj_Dt.getDt();
        }
        public DataTable getDt() { return dt; }
    }
}