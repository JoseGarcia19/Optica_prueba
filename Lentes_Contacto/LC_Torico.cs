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
    public partial class LC_Torico : Form
    {
        metodo m = new metodo();
        string nueva;
        public LC_Torico(string cadena)
        { 
            InitializeComponent();
            m.nombre = cadena;
            lbl_nombreadmin.Text = "Sesión de: "+m.nombre;
            nueva = metodo.cadena_final(m);/*Cadena que almacena lo que recibe el label*/
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_esfera.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txt_esfera_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_cilindro_KeyPress(object sender, KeyPressEventArgs e)
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

        /*Código para que solo acepte enteros*/
        private void txt_eje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_existente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_existente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fecha, esfera_lct,esfera_comp,cilindro_comp, cilindro_lct, eje_lct,eje_comp, marca_lct, precio, existentes;
            float precio_lct, comprobar_e, comprobar_cil,calcular_validae,calcular_validacil;
            int existentes_lct,eje_ent;

            /*Comparar si las cajas no están vacías*/
            if(combo_esfera.Text=="" || txt_esfera.Text=="" || lbl_signocil.Text=="" || txt_cilindro.Text=="" || txt_eje.Text==""
                || txt_gradoeje.Text=="" || txt_marca.Text=="" || txt_precio.Text=="" || txt_existente.Text=="")
            {
                MessageBox.Show("Es necesario rellenar todos los campos");
            }

            else
            {
                fecha = fecha_lct.Value.ToLongDateString();/*Mandar la fecha*/
                esfera_lct = combo_esfera.Text + txt_esfera.Text;
                cilindro_lct = lbl_signocil.Text + txt_cilindro.Text;
                eje_lct = txt_eje.Text+txt_gradoeje.Text;
                marca_lct = txt_marca.Text;
                precio = txt_precio.Text;
                precio_lct = float.Parse(precio);
                existentes = txt_existente.Text;
                existentes_lct = int.Parse(existentes);

                /*Apartar elementos para hacer válida el alta:*/
                esfera_comp = txt_esfera.Text;
                comprobar_e = float.Parse(esfera_comp);/*Variable que voy a tomar para comparar validez de esfera*/
                cilindro_comp = txt_cilindro.Text;
                comprobar_cil = float.Parse(cilindro_comp);/*Variable que voy a tomar para comparar validez de cilindro*/
                eje_comp = txt_eje.Text;
                eje_ent = int.Parse(eje_comp);/*Variable que voy a tomar para comparar validez de eje*/

                /*Operaciones que harán las comparaciones correspondientes:*/
                calcular_validae = (comprobar_e * 100);
                calcular_validacil=(comprobar_cil*100);

                /*Condición que arrojará mensaje de error en caso de que el usuario ingrese una graduación que no sea
                 múltiplo de 0.25 (esfera y cilindro), y un eje menor a 0 o mayor a 180°*/
                if(calcular_validae%25!=0 || calcular_validacil%25!=0 || eje_ent<0 && eje_ent>180)
                {
                    MessageBox.Show("Valores no válidos");
                }

                else
                {
                    /*Objeto que servirá para mandar las cadenas que se añadirán a la tabla lc_toricos*/
                    aniacir_lctorico aniadir = new aniacir_lctorico();
                    aniadir.aniadir_lctorico(fecha, esfera_lct, cilindro_lct, eje_lct, marca_lct, precio_lct, existentes_lct,nueva);
                    MessageBox.Show("Parámetros agregados exitosamente");

                    combo_esfera.Text = "";
                    txt_esfera.Clear();
                    txt_cilindro.Clear();
                    txt_eje.Clear();
                    txt_gradoeje.Clear();
                    txt_marca.Clear();
                    txt_precio.Clear();
                    txt_existente.Clear();
                }

                
            }
        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

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
