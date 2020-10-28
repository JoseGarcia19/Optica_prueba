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
    public partial class Inicio_usuario : Form
    {
        metodo2 m = new metodo2();
        string nueva;
        public Inicio_usuario(string cadena)
        {
            InitializeComponent();
            label_usuario.Text = "Bienvenido(a): "+cadena;
            m.nombre = cadena;
            nueva = metodo2.cadena_final(m);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void clienteEspecialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atrásTemporalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ventana_inicio = new Form1();
            ventana_inicio.Show();
            this.Close();
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 inicio_usuario = new Form1();
            inicio_usuario.Show();
            this.Close();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteNuevo cliente = new ClienteNuevo(m.nombre);
            cliente.ShowDialog();
        }
    }

    public class metodo2
    {
        public string nombre { get; set; }

        public static string cadena_final(metodo2 m)
        {
            return $"{m.nombre}";
        }
    }
}
