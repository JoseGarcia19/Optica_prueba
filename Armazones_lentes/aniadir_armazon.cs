using Sistema_Optica.Conexión;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Optica.Armazones_lentes
{
    class aniadir_armazon:Conexion_bd/*Establecer conexión con el método que se conecta con la base de datos*/
    {
        public string aniadirarmazon(string fecha,string marca_arm,string modelo_arm,string material_arm,string tipo_arm,float precio_arm,int cant_arm,string responsable)
        {
            conexion.Open();/*Abrir la conexión con la base de datos*/
            string cadena;
            string devolver_cadena;

            cadena = "insert into armazones(fecha,marca_armazon,modelo_armazon,material_armazon,precio,cantidad_armazones,tipo_armazon,responsable) values " +
               "(@fecha,@marca_arm,@modelo_arm,@material_arm,@precio_arm,@cant_arm,@tipo_arm,@responsable)";

            SqlCommand comando = new SqlCommand(cadena,conexion);
            comando.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Date)).Value = fecha;
            comando.Parameters.AddWithValue("@marca_arm", marca_arm);
            comando.Parameters.AddWithValue("@modelo_arm", modelo_arm);
            comando.Parameters.AddWithValue("@material_arm", material_arm);
            comando.Parameters.AddWithValue("@precio_arm", precio_arm);
            comando.Parameters.AddWithValue("@cant_arm", cant_arm);
            comando.Parameters.AddWithValue("@tipo_arm", tipo_arm);
            comando.Parameters.AddWithValue("@responsable", responsable);
            comando.ExecuteNonQuery();
            devolver_cadena = "Conexión exitosa";
            conexion.Close();
            return devolver_cadena;
        }
    }
}
