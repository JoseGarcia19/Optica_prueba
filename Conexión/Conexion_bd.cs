using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Data;
using System.Windows.Forms;

namespace Sistema_Optica.Conexión
{
    

    class Conexion_bd
    {
        
        protected SqlConnection conexion;
        public static string evaluadora="Fail", cadena, nombre_admin,apellido_p,apellido_m,completo;
        public static string nombre_user, apellido_p_u, apellido_m_u;
        public static void nueva()
        {

        }

        public Conexion_bd()
        {
            conexion = new SqlConnection("server=LAPTOP-TLNF7K9K\\SQLEXPRESS ; database=Optica ; integrated security = true");

            
        }
        
        
        public string acceder(string nombre_usuario,string contrasenia)
        {
            /*conexion.Open();
            conexion.Close();
            return "Nombre de usuario:_"+nombre_usuario+"\n"+"Contraseña:_"+contrasenia;*/
            int b=0;
            string acceso = "",password="";
            try
            {
                this.conexion.Open();

                cadena = "select id_admin,nombre,a_paterno,a_materno,edad,sexo,correo_electronico,nombre_usuario,contrasenia from administrador";
                   //+ "where nombre_usuario=@nombre_usuario and contrasenia=@contrasenia";
                  

                SqlCommand comando = new SqlCommand(cadena, conexion);
                

                /*Vaciar el registro en un objeto para poder verlos*/
                SqlDataReader registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    Session_ID.Set_ID_Session(int.Parse(registro["id_admin"].ToString()));
                    acceso = registro["nombre_usuario"].ToString();
                    password = registro["contrasenia"].ToString();
                    
                    nombre_admin = registro["nombre"].ToString();
                    apellido_p = registro["a_paterno"].ToString();
                    apellido_m = registro["a_materno"].ToString();

                    if (registro["nombre_usuario"].ToString() == nombre_usuario && registro["contrasenia"].ToString() == contrasenia)
                    {
                        b = 1;
                        break;
                    }

                }


                if (b == 1)
                {
                    completo = nombre_admin +" "+ apellido_p +" "+ apellido_m;
                    evaluadora = "Correcto"+","/*+nombre_admin+","+apellido_p+","+apellido_m*/+completo;
                }

                else if(b==0)
                {
                    evaluadora = "Incorrecto";
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error" + ex.Message);
            }

            finally
            {
                this.conexion.Close();
            }
            
            return evaluadora;
            
        }
        
       
        /*Método para acceder como usuario:*/
        public string acceder_usuario(string nombre_usuario, string contrasenia)
        {
            /*conexion.Open();
            conexion.Close();
            return "Nombre de usuario:_"+nombre_usuario+"\n"+"Contraseña:_"+contrasenia;*/
            int b = 0;
            string acceso = "", password = "";
            try
            {
                this.conexion.Open();
                
                cadena = "select id_usuario,nombre,a_paterno,a_materno,edad,sexo,correo_electronico,nombre_usuario,contrasenia from vendedores"
                    /*+ "where nombre_usuario=('"+nombre_usuario+ "') and contrasenia=('" + contrasenia + "')"*/;
                
                
                SqlCommand comando = new SqlCommand(cadena, conexion);


                /*Vaciar el registro en un objeto para poder verlos*/
                SqlDataReader registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    Session_ID.Set_ID_Session(int.Parse(registro["id_usuario"].ToString()));
                    acceso = registro["nombre_usuario"].ToString();
                    password = registro["contrasenia"].ToString();
                    nombre_user = registro["nombre"].ToString();
                    apellido_p_u = registro["a_paterno"].ToString();
                    apellido_m_u = registro["a_materno"].ToString();

                    if (acceso.ToString() == nombre_usuario && password.ToString() == contrasenia)
                    {
                        b = 1;
                        break;
                    }

                }


                if (b == 1)
                {
                    evaluadora = "Correcto"+','+nombre_user;
                }

                else if (b == 0)
                {
                    evaluadora = "Incorrecto";
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error" + ex.Message);
            }

            finally
            {
                this.conexion.Close();
            }

            return evaluadora;

        }
        /*Método para mostrar los datos:*/
        public string ver_datos_Admin(string nom_usuario)
        {
            string nombre, datos_persona="";
            try
            {
                this.conexion.Open();/*Abrir la conexión con la base de datos*/

                cadena = "select nombre from administrador";

                SqlCommand juntar = new SqlCommand(cadena,conexion);

                SqlDataReader registro = juntar.ExecuteReader();

                while(registro.Read())
                {
                    Session_ID.Set_ID_Session(int.Parse(registro["id_admin"].ToString()));
                    nombre=registro["nombre"].ToString();
                    datos_persona = nombre;
                }
            }
            catch (Exception)
            {

                
            }

            return datos_persona;
        }
        /**/
        public string agregar_usuario(string fecha,string nombre,string a_paterno, string a_materno,int edad,string sexo,string correo_electronico,string nombre_usuario, string contrasenia,string admin_encargado)
        {
            
            conexion.Open();/*Abrir la conexión con la base de datos*/
            string cadena;/*Cadena que insertará los datos a la base de datos*/
            string devolver_cadena;


            cadena = "insert into vendedores(fecha_vendedor,nombre,a_paterno,a_materno,edad,sexo,correo_electronico,nombre_usuario,contrasenia,admin_responsable) values " +
                "(@fecha_alta,'" + nombre + "','" + a_paterno + "','" + a_materno + "','"+edad+"','"+sexo+"','"+correo_electronico+ "','" + nombre_usuario + "','" + contrasenia + "','" + admin_encargado + "')";

            
            /*SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();*/
            SqlCommand comando2 = new SqlCommand(cadena, conexion);
            comando2.Parameters.Add(new SqlParameter("@fecha_alta", SqlDbType.Date)).Value = fecha;
            comando2.ExecuteNonQuery();
            devolver_cadena = "Conexión exitosa";
            conexion.Close();
            return devolver_cadena;
        }
    }

   

}
