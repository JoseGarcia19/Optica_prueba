using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Optica.Accesorios_Lentes
{
    public partial class Agregar_accesorios : Form
    {
        aniadir_accesorios mostrar_accesorios = new aniadir_accesorios();/*Objeto de tipo aniadir_accesorios*/

        string nueva;
        public class metodo
        {
            public string cadena { get; set; }
            public static string valor_cadena(metodo m)
            {
                return $"{m.cadena}";
            }
        }
        public Agregar_accesorios(string agregar_usuario)
        {
            metodo m = new metodo();
            InitializeComponent();
            lbl_nombreadmin.Text = "Administrador responsable:" + agregar_usuario;
            m.cadena = agregar_usuario;
            nueva = metodo.valor_cadena(m);
            accesorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre_accesorio, precio_accesorio, cantidad_accesorios,fecha;
            float precio_acc;
            int cantidad_acc;
            
            /*Condición para en caso de que las cajas de texto estén vacías:*/
            if (txt_nombrearticulo.Text=="" || txt_precio.Text=="" || txt_disponibles.Text=="")
            {
                MessageBox.Show("Es necesario rellenar todos los campos");
                
            }

            else
            {
                fecha = fecha_agregado.Value.ToLongDateString();
                nombre_accesorio = txt_nombrearticulo.Text;
                precio_accesorio = txt_precio.Text;
                precio_acc = float.Parse(precio_accesorio);
                cantidad_accesorios = txt_disponibles.Text;
                cantidad_acc = int.Parse(cantidad_accesorios);
                aniadir_accesorios nuevo_acc = new aniadir_accesorios();
                nuevo_acc.aniadiraccesorios(fecha,nombre_accesorio, precio_acc, cantidad_acc,nueva);
                MessageBox.Show("Elementos agregados");
                
                /*Se limpian las cajas de texto que contienen lo que vamos a mandar a la base de datos:*/
                txt_nombrearticulo.Text = "";
                txt_precio.Text = "";
                txt_disponibles.Text = "";

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void accesorios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Agregar_accesorios_Load(object sender, EventArgs e)
        {
            mostrar_accesorios.ver_accesorios(accesorios);
        }
    }
}
