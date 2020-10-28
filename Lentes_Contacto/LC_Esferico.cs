using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Optica.Lentes_Contacto
{
    public partial class LC_Esferico : Form
    {
        metodo m = new metodo();
        string nueva;
        public LC_Esferico(string cadena)
        {
            InitializeComponent();
            m.nombre = cadena;
            lbl_nombreadmin.Text = "Sesión de: " + m.nombre;
            nueva = metodo.cadena_final(m);/*Cadena que almacena lo que recibe el label*/
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_signograd.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /*Método para que solo acepte un punto*/
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fecha, graduacion, signo_graduacion, marca_lce,precio, existentes, graduacion_listo;
            float precio_conv,grad_evalua,multiplo;
            int existentes_lce;

            if(combo_signograd.Text=="" || txt_graduacion.Text=="" || txt_marca.Text=="" || txt_precio.Text=="" || txt_existentes.Text=="")
            {
                MessageBox.Show("Es necesario rellenar todos los campos");
            }

            else 
            {
                /*Pasar lo que contengan las cajas de texto a las respectivas variables*/
                fecha=date_fecha.Value.ToLongDateString();
                signo_graduacion = combo_signograd.Text;
                graduacion = txt_graduacion.Text;
                marca_lce = txt_marca.Text;
                precio = txt_precio.Text;
                existentes = txt_existentes.Text;
                /*Convertidos a flotante y a entero:*/
                precio_conv = float.Parse(precio);
                existentes_lce = int.Parse(existentes);
                graduacion_listo = signo_graduacion + graduacion;

                /*Evaluar que el valor agregado sea múltiplo de 0.25:*/
                grad_evalua=float.Parse(graduacion);
                multiplo = (grad_evalua * 100);

                if(multiplo%25!=0)
                {
                    MessageBox.Show("Graduación inexistente");
                }

                else
                {
                    aniadir_lcesferico agregar_lce = new aniadir_lcesferico();
                    agregar_lce.aniadir_lc(fecha, graduacion_listo, marca_lce, precio_conv, existentes_lce,nueva);
                    MessageBox.Show("Elemento agregado exitosamente");
                    combo_signograd.Text = "";
                    txt_graduacion.Text = "";
                    txt_marca.Text = "";
                    txt_precio.Text = "";
                    txt_existentes.Text = "";
                }
                
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

}
