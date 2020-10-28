namespace Sistema_Optica.Micas_lentes
{
    partial class Agregar_micas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.micasAgregadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_tipoMica = new System.Windows.Forms.ComboBox();
            this.combo_materialMica = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combo_material = new System.Windows.Forms.ComboBox();
            this.txt_tratamientomica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label_responsable = new System.Windows.Forms.Label();
            this.fecha_ingreso = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.mostrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.agregarToolStripMenuItem.Text = "Atrás";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.micasAgregadasToolStripMenuItem});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // micasAgregadasToolStripMenuItem
            // 
            this.micasAgregadasToolStripMenuItem.Name = "micasAgregadasToolStripMenuItem";
            this.micasAgregadasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.micasAgregadasToolStripMenuItem.Text = "Materiales agregados";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_tipoMica);
            this.groupBox1.Controls.Add(this.combo_materialMica);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(394, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 164);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // combo_tipoMica
            // 
            this.combo_tipoMica.FormattingEnabled = true;
            this.combo_tipoMica.Items.AddRange(new object[] {
            "Monofocal",
            "Bifocal L-28",
            "Bifocal Younger",
            "Bifocal Progresivo",
            "Trifocal"});
            this.combo_tipoMica.Location = new System.Drawing.Point(130, 112);
            this.combo_tipoMica.Name = "combo_tipoMica";
            this.combo_tipoMica.Size = new System.Drawing.Size(203, 21);
            this.combo_tipoMica.TabIndex = 11;
            this.combo_tipoMica.SelectedIndexChanged += new System.EventHandler(this.combo_tipoMica_SelectedIndexChanged);
            // 
            // combo_materialMica
            // 
            this.combo_materialMica.FormattingEnabled = true;
            this.combo_materialMica.Items.AddRange(new object[] {
            "CR",
            "Policarbonato",
            "Vidrio"});
            this.combo_materialMica.Location = new System.Drawing.Point(130, 52);
            this.combo_materialMica.Name = "combo_materialMica";
            this.combo_materialMica.Size = new System.Drawing.Size(203, 21);
            this.combo_materialMica.TabIndex = 10;
            this.combo_materialMica.SelectedIndexChanged += new System.EventHandler(this.combo_materialMica_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo de la mica:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Material de la mica:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combo_material);
            this.groupBox2.Controls.Add(this.txt_tratamientomica);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_precio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(394, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 202);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // combo_material
            // 
            this.combo_material.FormattingEnabled = true;
            this.combo_material.Items.AddRange(new object[] {
            "Terminado",
            "Maquilado"});
            this.combo_material.Location = new System.Drawing.Point(130, 50);
            this.combo_material.Name = "combo_material";
            this.combo_material.Size = new System.Drawing.Size(203, 21);
            this.combo_material.TabIndex = 13;
            this.combo_material.SelectedIndexChanged += new System.EventHandler(this.combo_material_SelectedIndexChanged);
            // 
            // txt_tratamientomica
            // 
            this.txt_tratamientomica.Location = new System.Drawing.Point(130, 108);
            this.txt_tratamientomica.Name = "txt_tratamientomica";
            this.txt_tratamientomica.Size = new System.Drawing.Size(203, 20);
            this.txt_tratamientomica.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio:";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(130, 159);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(203, 20);
            this.txt_precio.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tratamiento de la mica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de material:";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(524, 442);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(85, 39);
            this.button13.TabIndex = 13;
            this.button13.Text = "Añadir";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label_responsable
            // 
            this.label_responsable.AutoSize = true;
            this.label_responsable.Location = new System.Drawing.Point(12, 165);
            this.label_responsable.Name = "label_responsable";
            this.label_responsable.Size = new System.Drawing.Size(72, 13);
            this.label_responsable.TabIndex = 14;
            this.label_responsable.Text = "Responsable:";
            // 
            // fecha_ingreso
            // 
            this.fecha_ingreso.Location = new System.Drawing.Point(15, 281);
            this.fecha_ingreso.Name = "fecha_ingreso";
            this.fecha_ingreso.Size = new System.Drawing.Size(208, 20);
            this.fecha_ingreso.TabIndex = 15;
            // 
            // Agregar_micas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 530);
            this.ControlBox = false;
            this.Controls.Add(this.fecha_ingreso);
            this.Controls.Add(this.label_responsable);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Agregar_micas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar_micas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem micasAgregadasToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_tratamientomica;
        private System.Windows.Forms.ComboBox combo_material;
        private System.Windows.Forms.ComboBox combo_tipoMica;
        private System.Windows.Forms.ComboBox combo_materialMica;
        private System.Windows.Forms.Label label_responsable;
        private System.Windows.Forms.DateTimePicker fecha_ingreso;
    }
}