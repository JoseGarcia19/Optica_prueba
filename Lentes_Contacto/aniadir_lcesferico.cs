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
    class aniadir_lcesferico:Conexion_bd
    {
        public string aniadir_lc(string fecha_lc,string graduacion_listo,string marca_lce,float precio,int existentes,string responsable)
        {
            conexion.Open();/*Abrir la conexión con la base de datos*/
            string cadena;/*Cadena que insertará los datos a la base de datos*/
            string devolver_cadena;

            cadena = "insert into lc_esferico(fecha_agregado,graduacion_lente,marca_lce,precio_lce,existentes_lce,responsable) values " +
               "(@fecha_alta,@graduacion,@marca,@precio,@existente,@responsable)";

            SqlCommand comando = new SqlCommand(cadena,conexion);
            comando.Parameters.Add(new SqlParameter("@fecha_alta", SqlDbType.Date)).Value = fecha_lc;
            comando.Parameters.AddWithValue("@graduacion", graduacion_listo);
            comando.Parameters.AddWithValue("@marca", marca_lce);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@existente", existentes);
            comando.Parameters.AddWithValue("@responsable", responsable);
            comando.ExecuteNonQuery();

            devolver_cadena = "Conexión exitosa";
            conexion.Close();
            return devolver_cadena;
        }
    }
}
