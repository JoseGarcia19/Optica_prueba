using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Optica.Conexión
{
    class aniadir_clienteadmin:Conexion_bd
    {
        
        public string aniadir_cliente(string fecha_alta,string nombre,string a_paterno,string a_materno,int edad,string sexo,string ocupacion,string tipo_cliente,string telefono,string diabetico,string hipertenso,string responsable)
        {
            conexion.Open();/*Abrir la conexión con la base de datos*/
            string cadena;/*Cadena que insertará los datos a la base de datos*/
            string devolver_cadena;


            /*cadena = "insert into vendedores(id_usuario,nombre,a_paterno,a_materno,edad,sexo,correo_electronico,nombre_usuario,contrasenia,admin_responsable)" +"values" +
                "('"+nombre+"','"+a_paterno+"','"+a_materno+"','"+edad+"','"+sexo+"','"+correo_electronico+"','"+nombre_usuario+"','"+contrasenia+"','"+admin_encargado+"'";
            */
            cadena = "insert into clientes(fecha_alta,nombre_cliente,apellido_p,apellido_m,edad,sexo,ocupacion_cliente,tipo_cliente,telefono,diabetico,hipertenso,responsable) values " +
                "(@fecha_alta,@nombre,'" + a_paterno + "','" + a_materno + "','" + edad + "','" + sexo + "','" + ocupacion + "','" + tipo_cliente + "','" +telefono+"','" + diabetico + "','" + hipertenso + "','"+responsable+"')";


            
            /*SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();*/
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.Add(new SqlParameter("@fecha_alta", SqlDbType.Date)).Value = fecha_alta;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();

           
            devolver_cadena = "Conexión exitosa";
            conexion.Close();
            return devolver_cadena;
            
        }
    }
}
