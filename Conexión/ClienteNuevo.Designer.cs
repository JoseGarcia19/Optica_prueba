namespace Sistema_Optica.Conexión
{
    partial class ClienteNuevo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteNuevo));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.combo_Hipertenso = new System.Windows.Forms.ComboBox();
            this.combo_tipoCliente = new System.Windows.Forms.ComboBox();
            this.combo_Diabetico = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_ocupacion = new System.Windows.Forms.TextBox();
            this.combo_sexo = new System.Windows.Forms.ComboBox();
            this.txt_amaterno = new System.Windows.Forms.TextBox();
            this.txt_apaterno = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.fecha_paciente = new System.Windows.Forms.DateTimePicker();
            this.lbl_nombreadmin = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrásToolStripMenuItem,
            this.verClientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atrásToolStripMenuItem
            // 
            this.atrásToolStripMenuItem.Name = "atrásToolStripMenuItem";
            this.atrásToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.atrásToolStripMenuItem.Text = "Atrás";
            this.atrásToolStripMenuItem.Click += new System.EventHandler(this.atrásToolStripMenuItem_Click);
            // 
            // verClientesToolStripMenuItem
            // 
            this.verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
            this.verClientesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.verClientesToolStripMenuItem.Text = "Ver clientes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Agregar cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_edad);
            this.groupBox1.Controls.Add(this.combo_Hipertenso);
            this.groupBox1.Controls.Add(this.combo_tipoCliente);
            this.groupBox1.Controls.Add(this.combo_Diabetico);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_telefono);
            this.groupBox1.Controls.Add(this.txt_ocupacion);
            this.groupBox1.Controls.Add(this.combo_sexo);
            this.groupBox1.Controls.Add(this.txt_amaterno);
            this.groupBox1.Controls.Add(this.txt_apaterno);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Location = new System.Drawing.Point(308, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 416);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(201, 160);
            this.txt_edad.MaxLength = 3;
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(231, 20);
            this.txt_edad.TabIndex = 22;
            this.txt_edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_edad_KeyPress);
            // 
            // combo_Hipertenso
            // 
            this.combo_Hipertenso.FormattingEnabled = true;
            this.combo_Hipertenso.Items.AddRange(new object[] {
            "Si",
            "No\t\t"});
            this.combo_Hipertenso.Location = new System.Drawing.Point(202, 383);
            this.combo_Hipertenso.Name = "combo_Hipertenso";
            this.combo_Hipertenso.Size = new System.Drawing.Size(230, 21);
            this.combo_Hipertenso.TabIndex = 21;
            this.combo_Hipertenso.SelectedIndexChanged += new System.EventHandler(this.combo_Hipertenso_SelectedIndexChanged);
            // 
            // combo_tipoCliente
            // 
            this.combo_tipoCliente.FormattingEnabled = true;
            this.combo_tipoCliente.Items.AddRange(new object[] {
            "Nuevo",
            "Frecuente"});
            this.combo_tipoCliente.Location = new System.Drawing.Point(201, 274);
            this.combo_tipoCliente.Name = "combo_tipoCliente";
            this.combo_tipoCliente.Size = new System.Drawing.Size(230, 21);
            this.combo_tipoCliente.TabIndex = 20;
            this.combo_tipoCliente.SelectedIndexChanged += new System.EventHandler(this.combo_tipoCliente_SelectedIndexChanged);
            // 
            // combo_Diabetico
            // 
            this.combo_Diabetico.FormattingEnabled = true;
            this.combo_Diabetico.Items.AddRange(new object[] {
            "Si",
            "No\t\t"});
            this.combo_Diabetico.Location = new System.Drawing.Point(202, 347);
            this.combo_Diabetico.Name = "combo_Diabetico";
            this.combo_Diabetico.Size = new System.Drawing.Size(230, 21);
            this.combo_Diabetico.TabIndex = 19;
            this.combo_Diabetico.SelectedIndexChanged += new System.EventHandler(this.combo_Diabetico_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(119, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Hipertenso (a):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(128, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Diabético(a):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Número de teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tipo de cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ocupación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellido materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellido paterno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(202, 309);
            this.txt_telefono.MaxLength = 10;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(230, 20);
            this.txt_telefono.TabIndex = 7;
            this.txt_telefono.TextChanged += new System.EventHandler(this.txt_telefono_TextChanged);
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // txt_ocupacion
            // 
            this.txt_ocupacion.Location = new System.Drawing.Point(202, 234);
            this.txt_ocupacion.Name = "txt_ocupacion";
            this.txt_ocupacion.Size = new System.Drawing.Size(230, 20);
            this.txt_ocupacion.TabIndex = 5;
            // 
            // combo_sexo
            // 
            this.combo_sexo.FormattingEnabled = true;
            this.combo_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.combo_sexo.Location = new System.Drawing.Point(202, 195);
            this.combo_sexo.Name = "combo_sexo";
            this.combo_sexo.Size = new System.Drawing.Size(230, 21);
            this.combo_sexo.TabIndex = 4;
            this.combo_sexo.SelectedIndexChanged += new System.EventHandler(this.combo_sexo_SelectedIndexChanged);
            // 
            // txt_amaterno
            // 
            this.txt_amaterno.Location = new System.Drawing.Point(202, 118);
            this.txt_amaterno.Name = "txt_amaterno";
            this.txt_amaterno.Size = new System.Drawing.Size(230, 20);
            this.txt_amaterno.TabIndex = 2;
            // 
            // txt_apaterno
            // 
            this.txt_apaterno.Location = new System.Drawing.Point(202, 79);
            this.txt_apaterno.Name = "txt_apaterno";
            this.txt_apaterno.Size = new System.Drawing.Size(230, 20);
            this.txt_apaterno.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(202, 41);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(230, 20);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // fecha_paciente
            // 
            this.fecha_paciente.Location = new System.Drawing.Point(41, 406);
            this.fecha_paciente.Name = "fecha_paciente";
            this.fecha_paciente.Size = new System.Drawing.Size(224, 20);
            this.fecha_paciente.TabIndex = 17;
            this.fecha_paciente.Value = new System.DateTime(2020, 10, 9, 19, 37, 39, 0);
            // 
            // lbl_nombreadmin
            // 
            this.lbl_nombreadmin.AutoSize = true;
            this.lbl_nombreadmin.Location = new System.Drawing.Point(38, 374);
            this.lbl_nombreadmin.Name = "lbl_nombreadmin";
            this.lbl_nombreadmin.Size = new System.Drawing.Size(73, 13);
            this.lbl_nombreadmin.TabIndex = 18;
            this.lbl_nombreadmin.Text = "Administrador:";
            // 
            // ClienteNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 500);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_nombreadmin);
            this.Controls.Add(this.fecha_paciente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClienteNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteNuevo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atrásToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combo_Hipertenso;
        private System.Windows.Forms.ComboBox combo_tipoCliente;
        private System.Windows.Forms.ComboBox combo_Diabetico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_ocupacion;
        private System.Windows.Forms.ComboBox combo_sexo;
        private System.Windows.Forms.TextBox txt_amaterno;
        private System.Windows.Forms.TextBox txt_apaterno;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.ToolStripMenuItem verClientesToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker fecha_paciente;
        private System.Windows.Forms.Label lbl_nombreadmin;
    }
}