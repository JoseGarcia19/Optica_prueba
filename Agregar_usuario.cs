using Sistema_Optica.Conexión;
using Sistema_Optica.Vendedores;
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
    public partial class Agregar_usuario : Form
    {
        /*Objeto de la clase Vendedores_registrador, que rellenará el grid*/
        Vendedores_registrador ver_vendedores = new Vendedores_registrador();
        string nueva;
        public class metodo
        {
            public string cadena { get; set; }
            public static string valor_cadena(metodo m)
            {
                return $"{m.cadena}";
            }
        }
        public Agregar_usuario(string agregar_usuario)
        {
            
            metodo m = new metodo();
            InitializeComponent();
            label_adminresponsable.Text = "Administrador responsable:"+agregar_usuario;
            m.cadena = agregar_usuario;
            nueva = metodo.valor_cadena(m);
            vendedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            
        }
        
       

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            //Inicio_administrador ventana_principal = new Inicio_administrador(cadena);
            //ventana_principal.Show();
            this.Close();
        }

        
        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio_administrador ventana_principal = new Inicio_administrador(nueva);
            ventana_principal.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*Evento load del formulario*/
        private void Agregar_usuario_Load(object sender, EventArgs e)
        {
            /*Objeto de la clase Vendedores_registrador para poder jalar los métodos*/
            
            ver_vendedores.llenargrid(vendedor);

        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void verUsuariosRegistradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String nombre, a_paterno, a_materno, edad_previa, sexo, correo, n_usuario, password,fecha;
            int edad;
            if (txt_nombre.Text == "" || txt_apaterno.Text == "" || txt_amaterno.Text == "" || txt_edad.Text == "" || comboBox1.Text == ""
                || txt_nombreusuario.Text == "" || txt_contrasenia.Text == "")
            {
                MessageBox.Show("Es necesario rellenar todos los campos");
            }

            else
            {
                fecha = fecha_vendedor.Value.ToLongDateString();
                nombre = txt_nombre.Text;
                a_paterno = txt_apaterno.Text;
                a_materno = txt_amaterno.Text;
                edad_previa = txt_edad.Text;
                edad = int.Parse(edad_previa);
                sexo = comboBox1.Text;
                correo = txt_correoelecronico.Text;
                n_usuario = txt_nombreusuario.Text;
                password = txt_contrasenia.Text;
                       

                Conexion_bd aniadir_usuario = new Conexion_bd();
                aniadir_usuario.agregar_usuario(fecha,nombre, a_paterno, a_materno, edad, sexo, correo, n_usuario, password,nueva);

                MessageBox.Show("Datos agregados");
                //MessageBox.Show(aniadir_usuario.agregar_usuario(nombre, a_paterno, a_materno, edad, sexo, correo, n_usuario, password));

                txt_nombre.Text = "";
                txt_apaterno.Text = "";
                txt_amaterno.Text = "";
                txt_edad.Text = "";
                comboBox1.Text = "";
                txt_correoelecronico.Text = "";
                txt_nombreusuario.Text = "";
                txt_contrasenia.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //vendedor.Columns["nombre"].HeaderText = "Nombre";
            vendedor.Columns["nombre"].HeaderText="Nombre";
                

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
