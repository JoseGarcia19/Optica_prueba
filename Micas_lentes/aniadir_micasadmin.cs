using Sistema_Optica.Conexión;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Optica.Micas_lentes
{
    class aniadir_micasadmin:Conexion_bd
    {
        public string aniadir_micas(string mat_mica, string tipo_mica, string tipo_material, string trat_material, float precio, string nueva, string fecha)
        {
            conexion.Open();/*Abrir la conexión con la base de datos*/
            string cadena;/*Cadena que insertará los datos a la base de datos*/
            string devolver_cadena;


            /*cadena = "insert into vendedores(id_usuario,nombre,a_paterno,a_materno,edad,sexo,correo_electronico,nombre_usuario,contrasenia,admin_responsable)" +"values" +
                "('"+nombre+"','"+a_paterno+"','"+a_materno+"','"+edad+"','"+sexo+"','"+correo_electronico+"','"+nombre_usuario+"','"+contrasenia+"','"+admin_encargado+"'";
            */
            cadena = "insert into micas(material_mica,tipo_mica,tipo_material,trat_mica,precio,responsable,fecha) values " +
                "(@mat_mica,@tipo_mica,@tipo_material,@trat_material,@precio,@nueva,@fecha)";

            /*SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();*/
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime)).Value = fecha;
            comando.Parameters.AddWithValue("@mat_mica", mat_mica);
            comando.Parameters.AddWithValue("@tipo_mica", tipo_mica);
            comando.Parameters.AddWithValue("@tipo_material", tipo_material);
            comando.Parameters.AddWithValue("@trat_material", trat_material);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@nueva", nueva);
            comando.ExecuteNonQuery();

            devolver_cadena = "Conexión exitosa";
            conexion.Close();
            return devolver_cadena;
        }
    }
}
