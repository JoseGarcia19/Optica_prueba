using Sistema_Optica.Conexión;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Optica.Lentes_Contacto
{
    class aniacir_lctorico:Conexion_bd
    {
        /*Recibir los argumentos del form LC_Torico en esta función.*/
        public string aniadir_lctorico(string fecha,string esfera_lct,string cilindro_lct,string eje_lct,string marca_lct,float precio_lct,int existentes_lct,string responsable)
        {
            conexion.Open();/*Abrir la conexión con la base de datos*/
            string cadena;/*Cadena que insertará los datos a la base de datos*/
            string devolver_cadena;

            cadena = "insert into lc_torico(fecha_lct,esfera_lct,cilindro_lct,eje_lct,marca_lct,precio,cant_existente,responsable) values " +
               "(@fecha_alta,@esfera,@cilindro,@eje,@marca,@precio,@existentes,@responsable)";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.Add(new SqlParameter("@fecha_alta", SqlDbType.Date)).Value = fecha;
            comando.Parameters.AddWithValue("@esfera", esfera_lct);
            comando.Parameters.AddWithValue("@cilindro", cilindro_lct);
            comando.Parameters.AddWithValue("@eje", eje_lct);
            comando.Parameters.AddWithValue("@marca", marca_lct);
            comando.Parameters.AddWithValue("@precio", precio_lct);
            comando.Parameters.AddWithValue("@existentes", existentes_lct);
            comando.Parameters.AddWithValue("@responsable", responsable);
            comando.ExecuteNonQuery();

            devolver_cadena = "Conexión exitosa";
            conexion.Close();
            return devolver_cadena;
            
        }
    }
}
