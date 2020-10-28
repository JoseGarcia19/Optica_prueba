using Sistema_Optica.Conexión;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sistema_Optica
{
    public partial class Administrador : Form
    {
        public string cadena_nueva;
        public Administrador()
        {
            InitializeComponent();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ventana_principal = new Form1();
            ventana_principal.Show();
            this.Close();
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
            
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Conexion_bd conn = new Conexion_bd();
            
            string cadena1, cadena2;
            string[] aux;
            /*Inicio_administrador principal_admin = new Inicio_administrador();
            principal_admin.Show();
            this.Close();*/
            /*SqlConnection conexion = new SqlConnection("server=LAPTOP-TLNF7K9K\\SQLEXPRESS ; database=base1 ; integrated security = true");
            conexion.Open();
            MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
            conexion.Close();*/
            cadena1 = textBox1.Text;
            cadena2 = textBox2.Text;
            
            
            if(cadena1.Equals("") || cadena2.Equals(""))
            {
                MessageBox.Show("Es necesario rellenar los campos");
            }

            else
            {
                char delimitador = ',';
                
                //aux = conn.acceder(textBox1.Text, textBox2.Text).Split(delimitador);
                aux = conn.acceder(textBox1.Text,textBox2.Text).Split(delimitador);
                

                //if(conn.acceder(cadena1,cadena2).Equals("Correcto"))
                if (aux[0].Equals("Correcto"))
                {
                    cadena_nueva = aux[1];
                    MessageBox.Show("Bienvenido ");
                    Inicio_administrador login_administrador = new Inicio_administrador(cadena_nueva);
                    //login_administrador.bienvenida(cadena_nueva);
                    //Agregar_usuario admin_responsable = new Agregar_usuario(aux[1], aux[2], aux[3]);
                    login_administrador.Show();
                    this.Close();
                }

               else if(conn.acceder(cadena1,cadena2).Equals("Incorrecto"))
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = textBox2.Text;

            /*Condición para en caso de que esté o no esté seleccionado el checkbox:*/
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = text;
            }

            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox2.Text = text;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            textBox2.UseSystemPasswordChar = true;
            textBox2.Text = text;
        }
    }
}
