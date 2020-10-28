using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Optica.Armazones_lentes
{
    public partial class Agregar_armazones : Form
    {
        string nueva;
        public class metodo
        {
            public string cadena { get; set; }
            public static string valor_cadena(metodo m)
            {
                return $"{m.cadena}";
            }
        }
        public Agregar_armazones(string agregar_usuario)
        {
            metodo m = new metodo();
            InitializeComponent();
            lbl_nombreadmin.Text = "Administrador responsable:" + agregar_usuario;
            m.cadena = agregar_usuario;
            nueva = metodo.valor_cadena(m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*fecha,tipo_arm,responsable*/
            string fecha,marca_arm, modelo_arm, material_arm, tipo_arm, precio, cant;
            float precio_arm;
            int cant_arm;
        
            /*Condición para en caso de que las cajas de texto estén vacías:*/
            if(txt_marcaArmazon.Text=="" || txt_modeloarmazon.Text=="" || combo_materialArmazon.Text=="" || tipo_armazon.Text=="" || txt_precio.Text=="" || txt_existentes.Text=="")
            {
                MessageBox.Show("Es necesario rellenar todos los campos");
            }

            else
            {
                /*Guardar lo que contengan las cajas de texto en su respectiva variable*/
                fecha = fecha_armazon.Value.ToLongDateString();/**/    
                marca_arm = txt_marcaArmazon.Text;
                modelo_arm = txt_modeloarmazon.Text;
                material_arm = combo_materialArmazon.Text;
                tipo_arm = tipo_armazon.Text;/**/
                precio = txt_precio.Text;
                precio_arm = float.Parse(precio);
                cant = txt_existentes.Text;
                cant_arm = int.Parse(cant);
              
                aniadir_armazon agregar_arm = new aniadir_armazon();
                agregar_arm.aniadirarmazon(fecha,marca_arm,modelo_arm,material_arm,tipo_arm,precio_arm,cant_arm,nueva);
                MessageBox.Show("Armazón agregada exitosamente");
                txt_marcaArmazon.Text="";
                txt_modeloarmazon.Text = "";
                tipo_armazon.Text = "";
                combo_materialArmazon.Text = "";
                txt_precio.Text = "";
                txt_existentes.Text = "";

            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
