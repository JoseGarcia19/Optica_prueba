using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Optica.Conexión
{
    public partial class ClienteNuevo : Form
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
        public ClienteNuevo(string agregar_usuario)
        {
            metodo m = new metodo();
            InitializeComponent();
            lbl_nombreadmin.Text = "Administrador responsable:" + agregar_usuario;
            m.cadena = agregar_usuario;
            nueva = metodo.valor_cadena(m);
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre, a_paterno, a_materno, sexo,edad_nueva, ocupacion,tipo_cliente,telefono,diabetico,hipertenso,fecha_alta;
            int edad;
            if(txt_nombre.Text=="" || txt_apaterno.Text=="" || txt_apaterno.Text == "" || txt_edad.Text==""
                || combo_sexo.Text=="" || txt_ocupacion.Text=="" || combo_tipoCliente.Text=="" || txt_telefono.Text==""
                || combo_Diabetico.Text=="" || combo_Hipertenso.Text=="")
            {
                MessageBox.Show("Es necesario rellenar todos los campos");
            
            }

            else
            {
                fecha_alta = fecha_paciente.Value.ToLongDateString();
                nombre = txt_nombre.Text;
                a_paterno = txt_apaterno.Text;
                a_materno = txt_amaterno.Text;
                edad_nueva = txt_edad.Text;
                edad = int.Parse(edad_nueva);
                sexo = combo_sexo.Text;
                ocupacion = txt_ocupacion.Text;
                tipo_cliente = combo_tipoCliente.Text;
                telefono = txt_telefono.Text;
                diabetico = combo_Diabetico.Text;
                hipertenso = combo_Hipertenso.Text;

                aniadir_clienteadmin agregar_cliente = new aniadir_clienteadmin();
                /*Enviar esta cantidad de argumentos al método que insertará las cosas a la base de datos:*/
                agregar_cliente.aniadir_cliente(fecha_alta,nombre,a_paterno,a_materno,edad,sexo,ocupacion,tipo_cliente,telefono,diabetico,hipertenso,nueva);
                MessageBox.Show("Datos agregados");

                txt_nombre.Text = "";
                txt_apaterno.Text = "";
                txt_amaterno.Text = "";
                txt_edad.Text = "";
                combo_sexo.Text = "";
                txt_ocupacion.Text = "";
                combo_tipoCliente.Text = "";
                txt_telefono.Text = "";
                combo_Diabetico.Text = "";
                combo_Hipertenso.Text = "";
            }
        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }   
        }

        private void combo_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_sexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void combo_tipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_tipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void combo_Diabetico_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_Diabetico.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void combo_Hipertenso_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_Hipertenso.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
