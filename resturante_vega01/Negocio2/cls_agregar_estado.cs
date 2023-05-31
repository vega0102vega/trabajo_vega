using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio2
{
    public class cls_agregar_estado
    {
        private DataTable dt;
        public void fnt_CargarEstado()
        {
            cls_cargar_estado obj_Dt = new cls_cargar_estado();
            obj_Dt.fnt_CargarEstado();
            this.dt = obj_Dt.getDt();
        }
        public DataTable getDt() { return dt; }
    }
}
