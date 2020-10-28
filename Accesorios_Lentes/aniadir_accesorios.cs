using Sistema_Optica.Conexión;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Optica.Accesorios_Lentes
{
    class aniadir_accesorios:Conexion_bd
    {
        public string aniadiraccesorios(string fecha,string nombre_acc,float precio_acc,int existentes,string responsable)
        {
            conexion.Open();
            string cadena;
            string devolver_cadena;

            cadena = "insert into accesorios(fecha,nombre_accesorio,precio_accesorio,cantidad_accesorios,responsable) values " +
               "(@fecha_alta,'" + nombre_acc + "','" + precio_acc + "','" + existentes + "','" + responsable + "')";

            SqlCommand comando = new SqlCommand(cadena,conexion);
            comando.Parameters.Add(new SqlParameter("@fecha_alta", SqlDbType.Date)).Value = fecha;
            comando.ExecuteNonQuery();
            devolver_cadena = "Conexión exitosa";
            conexion.Close();
            return devolver_cadena;
        }

        /*Método que va a llenar el grid:*/
        public void ver_accesorios(DataGridView grid)
        {
            string cadena;
            cadena = "select nombre_accesorio,precio_accesorio,cantidad_accesorios,responsable,convert (varchar,getdate(),103)fecha from accesorios;";
            SqlCommand enlazar = new SqlCommand(cadena, conexion);

            /*Variable tipo SqlDataAdapter:*/
            SqlDataAdapter da = new SqlDataAdapter(enlazar);/*Llena el grid*/

            DataTable dt = new DataTable();

            da.Fill(dt);
            DataView dv = new DataView();

            /*Objeto grid:*/
            grid.DataSource = dt;/*Igual a la tabla*/
        }

    }
}
