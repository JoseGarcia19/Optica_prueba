using Sistema_Optica.Accesorios_Lentes;
using Sistema_Optica.Armazones_lentes;
using Sistema_Optica.Conexión;
using Sistema_Optica.Lentes_Contacto;
using Sistema_Optica.Lentes_Contacto_Color;
using Sistema_Optica.Micas_lentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Optica
{
   
    public partial class Inicio_administrador : Form
    {
        metodo m = new metodo();
        string nueva;
        public Inicio_administrador(string cadena_aux)
        {
            InitializeComponent();
            m.nombre = cadena_aux;
            label_nombreAdmin.Text =m.nombre;
            nueva = metodo.cadena_final(m);
            Agregar_usuario au = new Agregar_usuario(cadena_aux);
            Agregar_micas mica_nueva = new Agregar_micas(cadena_aux);
            
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrador cerrar_sesion = new Administrador();
            cerrar_sesion.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void atrásTemporalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrador ventana_inicio = new Administrador();
            ventana_inicio.ShowDialog();
            this.Close();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_usuario nuevo_usuario = new Agregar_usuario(m.nombre);
            nuevo_usuario.ShowDialog();
            //this.Close();
            
        }

        private void Inicio_administrador_Load(object sender, EventArgs e)
        {
         
        }

        private void label_nombreAdmin_Click(object sender, EventArgs e)
        {

        }

        private void label_nombreAdmin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void clienteEspecialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteNuevo aniadir_cliente = new ClienteNuevo(m.nombre);
            aniadir_cliente.ShowDialog();
            
        }

        private void micasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            Agregar_micas micas_nuevas = new Agregar_micas(m.nombre);
            micas_nuevas.ShowDialog();
        }

        private void armazonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_armazones aniadir_armazon = new Agregar_armazones(m.nombre);
            aniadir_armazon.ShowDialog();
        }

        private void accesoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Agregar_accesorios aniadir_accesorio = new Agregar_accesorios(m.nombre);
            aniadir_accesorio.ShowDialog();

        }

        private void esféricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LC_Esferico nuevo_lce = new LC_Esferico(nueva);
            nuevo_lce.ShowDialog();

        }

        private void tóricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LC_Torico lct = new LC_Torico(nueva);
            lct.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void deColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LC_Color lente_color = new LC_Color(nueva);
            lente_color.ShowDialog();/*Mostrar la pestaña*/
        }
    }
    public class metodo
    {
        public string nombre { get; set; }

        public static string cadena_final(metodo m)
        {
            return $"{m.nombre}";
        }
    }
}