using Sistema_Optica.Conexión;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Optica.Vendedores
{
    class Vendedores_registrador:Conexion_bd
    {
        /*Creamos dentro objeto de tipo datagridview*/
        public void llenargrid(DataGridView grid)
        {
            string cadena;
            cadena = "select nombre,a_paterno,a_materno,edad,sexo,correo_electronico,nombre_usuario,contrasenia,admin_responsable,fecha_vendedor from vendedores";
            /*Hago la conexión con la base de datos*/
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
