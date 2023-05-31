using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cls_funciones_clientes
    {

        private Bitmap bmp;
        private string str_identificacion;
        private string str_nombres;
        private string str_contacto;
        private string str_correo;
        private string str_direccion;
        private byte[] by_imagen;



        //funcion Consultar ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void fnt_ConsultarC(string identificacion)
        {
            String sql = "select Nombre, Contacto , Correo, Direccion from tbl_clientes where PKId = '" + identificacion + "'";
            cls_conexion obj_conectar = new cls_conexion();
            obj_conectar.fnt_conectar();

            {
                MySqlCommand comando = new MySqlCommand(sql, obj_conectar.conex);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    str_nombres = reader["Nombre"].ToString();
                    str_contacto = reader["Contacto"].ToString();
                    str_correo = reader["Correo"].ToString();
                    str_direccion = reader["Direccion"].ToString();
                    Console.WriteLine("Nombre: " + str_nombres);
                }

            }
            obj_conectar.fnt_Desconectar();
        }
        public void fnt_guardarC(string Id, string Nombres, string contcato, string correo, string direccion)
        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string comando = "Insert into tbl_clientes values (@Nombre,@Contacto,@Correo,@Direccion,@PKId)";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@Nombre", Nombres);
            cmd.Parameters.AddWithValue("@Contacto", contcato);
            cmd.Parameters.AddWithValue("@Correo", correo);
            cmd.Parameters.AddWithValue("@Direccion", direccion);
            cmd.Parameters.AddWithValue("@PKId", Id);
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();
        }
        public void fnt_actualizar(string Id, string nombres, string contacto, string correo, string direccion)
        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string comando = "update tbl_clientes set Nombre=@Nombre,Contacto=@Contacto,Correo=@Correo, Direccion=@Direccion where PkId=@PKId";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@Nombre", nombres);
            cmd.Parameters.AddWithValue("@Contacto", contacto);
            cmd.Parameters.AddWithValue("@Correo", correo);
            cmd.Parameters.AddWithValue("@Direccion", direccion);
            cmd.Parameters.AddWithValue("@PKId", Id);
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();

        }
        public string getnombres() { return this.str_nombres; }

        public string getcontacto() { return this.str_contacto; }

        public string getcorreo() { return this.str_correo; }

        public string getdireccion() { return this.str_direccion; }

    }
}
