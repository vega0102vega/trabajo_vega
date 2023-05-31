using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cls_cargar_tipo
    {
        private DataTable dt;
        public void fnt_cargarTipo()
        {

            string sql = "select PKCodigo,Nombre from tbl_tipo";


            try
            {
                cls_conexion objConecta = new cls_conexion();
                objConecta.fnt_conectar();
                MySqlCommand comando = new MySqlCommand(sql, objConecta.conex);
                dt = new DataTable();
                MySqlDataAdapter Data = new MySqlDataAdapter(comando);
                Data.Fill(dt);
                objConecta.fnt_Desconectar();

            }
            catch (Exception)
            {

            }
        }
        public DataTable getDt() { return dt; }
    }
}