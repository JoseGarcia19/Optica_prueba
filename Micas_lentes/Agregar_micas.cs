using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Optica.Micas_lentes
{
    
    public partial class Agregar_micas : Form
    {

        string nueva;
        public Agregar_micas(string nombre_usuario)
        {
            InitializeComponent();
            label_responsable.Text = "Administrador responsable: "+nombre_usuario;
            nueva = nombre_usuario;
        }


        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string mat_mica, tipo_mica, tipo_material, trat_material, precio_s,fecha;
            float precio;

            /*Condición para en caso de que las cajas de texto estén vacías:*/
            if(combo_materialMica.Text=="" || combo_tipoMica.Text=="" || combo_material.Text=="" || txt_tratamientomica.Text==""
                || txt_precio.Text=="")
            {
                MessageBox.Show("Es necesario rellenar todos los campos");
            }

            else
            {
                fecha = fecha_ingreso.Value.ToLongDateString();
                mat_mica = combo_materialMica.Text;
                tipo_mica = combo_tipoMica.Text;
                tipo_material = combo_material.Text;
                trat_material = txt_tratamientomica.Text;
                precio_s = txt_precio.Text;
                precio = float.Parse(precio_s);

                aniadir_micasadmin agregar_micas = new aniadir_micasadmin();
                agregar_micas.aniadir_micas(mat_mica,tipo_mica,tipo_material,trat_material,precio,nueva,fecha);
                MessageBox.Show("Elementos agregados");

                combo_materialMica.Text = "";
                combo_tipoMica.Text = "";
                combo_material.Text = "";
                txt_tratamientomica.Text = "";
                txt_precio.Text = "";

            }
        }

        private void combo_materialMica_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_materialMica.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void combo_tipoMica_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_tipoMica.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void combo_material_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_material.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }

}
