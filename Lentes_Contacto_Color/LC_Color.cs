using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Optica.Lentes_Contacto_Color
{
    public partial class LC_Color : Form
    {
        metodo m = new metodo();
        string nueva;
        public LC_Color(string cadena)
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

        private void txt_graduacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Condición para que solo reciba números enteros*/
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

        private void txt_existentes_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Condición para que solo reciba números enteros*/
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha, graduacion, color, marca,precio_l,existente_l,graduacion_numero;
            float precio,multiplo, grad_evalua;
            int existentes;

            /*Condición para en caso de que las cajas de texto estén vacías*/
            if(combo_signograd.Text=="" || txt_graduacion.Text=="" || txt_color.Text=="" || txt_marca.Text==""
                || txt_precio.Text=="" || txt_existentes.Text=="")
            {
                MessageBox.Show("Es necesario rellenar todos los campos");
            }

            else
            {
                fecha = date_fecha.Value.ToLongDateString();
                graduacion = combo_signograd.Text + txt_graduacion.Text;
                graduacion_numero = txt_graduacion.Text;/*Contendrá el número que le pongamos*/
                color = txt_color.Text;
                marca = txt_marca.Text;
                precio_l = txt_precio.Text;
                precio = float.Parse(precio_l);
                existente_l = txt_existentes.Text;
                existentes = int.Parse(existente_l);
                
                /*Evaluar que el valor agregado sea múltiplo de 0.25:*/
                grad_evalua = float.Parse(graduacion_numero);
                multiplo = (grad_evalua * 100);

                if(multiplo%25!=0)
                {
                    MessageBox.Show("Graduación no válida");
                }

                else
                {
                    agregar_lccolor aniadir_lcc = new agregar_lccolor();
                    aniadir_lcc.agregar_lcc(fecha, graduacion, color, marca, precio, existentes, nueva);
                    MessageBox.Show("Agregado exitosamente");

                    combo_signograd.Text = "";
                    txt_graduacion.Text = "";
                    txt_color.Text = "";
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
