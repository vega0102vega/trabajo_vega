using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cls_funciones_personal
    {
        private string str_identificacion;
        private string str_Nombre;
        private string str_Contacto;
        private string str_Correo;


        public void fnt_Consultarp(string id)
        {
            string sql = "select Nombre, Contacto, Correo from tbl_personal where PKid= '" + id + "'";
            cls_conexion obj_conectar = new cls_conexion();
            obj_conectar.fnt_conectar();
            {
                MySqlCommand comando = new MySqlCommand(sql, obj_conectar.conex);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    str_Nombre = reader["Nombre"].ToString();
                    str_Contacto = reader["Contacto"].ToString();
                    str_Correo = reader["Correo"].ToString();
                    Console.WriteLine("Nombre: " + str_Nombre);
                }
            }
            obj_conectar.fnt_Desconectar();
        }

        public void fnt_guardarp(string id, string Nombre, string Contcato, string Correo)
        {
            cls_conexion obj_Conexion = new cls_conexion();
            obj_Conexion.fnt_conectar();
            string comando = "insert into tbl_personal values (@PKId,@Nombre,@Contacto,@Correo,)";
            MySqlCommand cmd = new MySqlCommand(comando, obj_Conexion.conex);
            cmd.Parameters.AddWithValue("@PKId", id);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Contacto", Contcato);
            cmd.Parameters.AddWithValue("@Correo", Correo);
            cmd.ExecuteNonQuery();
            obj_Conexion.fnt_Desconectar();
        }
        public void fnt_Actualizarp(string id, string nombre, string Contcato, string Correo)
        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string comando = "update tbl_personal set Nombre=@Nombre,Contacto= @Contacto, Correo=@Correo where PkId= @PKId";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@PKId", id);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Contacto", Contcato);
            cmd.Parameters.AddWithValue("@Correo", Correo);
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();

        }
        public string getNombre() { return this.str_Nombre; }

        public string getContacto() { return this.str_Contacto; }

        public string getcorreo() { return this.str_Correo; }


    }
}
