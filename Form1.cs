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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrador ventana_administrador = new Administrador();
            ventana_administrador.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion_bd conexion = new Conexion_bd();
            string cadena1, cadena2;

            cadena1 = textBox1.Text;
            cadena2 = textBox2.Text;


            if (cadena1.Equals("") || cadena2.Equals(""))
            {
                MessageBox.Show("Es necesario rellenar los campos");
            }

            else
            {
                char delimitador = ',';
                string[] aux;
                string cadena;
                aux = conexion.acceder_usuario(cadena1, cadena2).Split(delimitador);
                if (aux[0].Equals("Correcto"))
                {
                    cadena = aux[1];
                    MessageBox.Show("Bienvenido");
                    Inicio_usuario login_usuario = new Inicio_usuario(cadena);
                    login_usuario.Show();
                    this.Close();
                }

                else if (conexion.acceder_usuario(cadena1, cadena2).Equals("Incorrecto"))
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = textBox2.Text;

            /*Condición para en caso de que esté o no esté seleccionado el checkbox:*/
            if(checkBox1.Checked)
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
            string text=textBox2.Text;
            textBox2.UseSystemPasswordChar = true;
            textBox2.Text = text;
        }
    }
}
