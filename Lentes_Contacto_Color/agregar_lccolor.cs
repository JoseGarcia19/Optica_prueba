using Sistema_Optica.Conexión;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Optica.Lentes_Contacto_Color
{
    class agregar_lccolor:Conexion_bd
    {
        public string agregar_lcc(string fecha, string graduacion, string color, string marca, float precio, int existentes, string responsable)
        {
            conexion.Open();/*Abrir la conexión con la base de datos*/
            string cadena;/*Cadena que insertará los datos a la base de datos*/
            string devolver_cadena;

            /*La variable cadena contendrá la sentencia sql que inserta los datos a la bd:*/
            cadena = "insert into lc_color(fecha_agregado,graduacion_lcc,color_lcc,marca_lcc,precio_lcc,existentes_lcc,responsable) values " +
              "(@fecha_alta,@graduacion_lcc,@color_lcc,@marca_lcc,@precio_lcc,@existentes,@responsable)";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.Add(new SqlParameter("@fecha_alta", SqlDbType.Date)).Value = fecha;
            comando.Parameters.AddWithValue("@graduacion_lcc", graduacion);
            comando.Parameters.AddWithValue("@color_lcc", color);
            comando.Parameters.AddWithValue("@marca_lcc", marca);
            comando.Parameters.AddWithValue("@precio_lcc", precio);
            comando.Parameters.AddWithValue("@existentes", existentes);
            comando.Parameters.AddWithValue("@responsable", responsable);
            comando.ExecuteNonQuery();


            devolver_cadena = "Conexión exitosa";
            conexion.Close();
            return devolver_cadena;
        }
    }
}
