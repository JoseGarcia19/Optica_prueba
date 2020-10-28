namespace Sistema_Optica.Lentes_Contacto
{
    partial class LC_Torico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LC_Torico));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_signocil = new System.Windows.Forms.Label();
            this.txt_gradoeje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_eje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cilindro = new System.Windows.Forms.TextBox();
            this.txt_existente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_esfera = new System.Windows.Forms.TextBox();
            this.combo_esfera = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fecha_lct = new System.Windows.Forms.DateTimePicker();
            this.lbl_nombreadmin = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 2;
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
            this.verClientesToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.verClientesToolStripMenuItem.Text = "Ver disponibles";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_signocil);
            this.groupBox1.Controls.Add(this.txt_gradoeje);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_eje);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_cilindro);
            this.groupBox1.Controls.Add(this.txt_existente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_precio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_marca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_esfera);
            this.groupBox1.Controls.Add(this.combo_esfera);
            this.groupBox1.Location = new System.Drawing.Point(350, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 328);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lbl_signocil
            // 
            this.lbl_signocil.AutoSize = true;
            this.lbl_signocil.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signocil.Location = new System.Drawing.Point(177, 77);
            this.lbl_signocil.Name = "lbl_signocil";
            this.lbl_signocil.Size = new System.Drawing.Size(20, 27);
            this.lbl_signocil.TabIndex = 16;
            this.lbl_signocil.Text = "-";
            // 
            // txt_gradoeje
            // 
            this.txt_gradoeje.Enabled = false;
            this.txt_gradoeje.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gradoeje.Location = new System.Drawing.Point(257, 125);
            this.txt_gradoeje.Multiline = true;
            this.txt_gradoeje.Name = "txt_gradoeje";
            this.txt_gradoeje.Size = new System.Drawing.Size(53, 20);
            this.txt_gradoeje.TabIndex = 15;
            this.txt_gradoeje.Text = "°";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Eje:";
            // 
            // txt_eje
            // 
            this.txt_eje.Location = new System.Drawing.Point(151, 125);
            this.txt_eje.MaxLength = 3;
            this.txt_eje.Name = "txt_eje";
            this.txt_eje.Size = new System.Drawing.Size(100, 20);
            this.txt_eje.TabIndex = 13;
            this.txt_eje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_eje_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cilindro:";
            // 
            // txt_cilindro
            // 
            this.txt_cilindro.Location = new System.Drawing.Point(203, 84);
            this.txt_cilindro.MaxLength = 5;
            this.txt_cilindro.Multiline = true;
            this.txt_cilindro.Name = "txt_cilindro";
            this.txt_cilindro.Size = new System.Drawing.Size(107, 20);
            this.txt_cilindro.TabIndex = 10;
            this.txt_cilindro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cilindro_KeyPress);
            // 
            // txt_existente
            // 
            this.txt_existente.Location = new System.Drawing.Point(151, 273);
            this.txt_existente.MaxLength = 3;
            this.txt_existente.Name = "txt_existente";
            this.txt_existente.Size = new System.Drawing.Size(231, 20);
            this.txt_existente.TabIndex = 8;
            this.txt_existente.TextChanged += new System.EventHandler(this.txt_existente_TextChanged);
            this.txt_existente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_existente_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "En existencia:";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(151, 222);
            this.txt_precio.MaxLength = 6;
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(231, 20);
            this.txt_precio.TabIndex = 6;
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio:";
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(151, 170);
            this.txt_marca.MaxLength = 60;
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(231, 20);
            this.txt_marca.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Esfera:";
            // 
            // txt_esfera
            // 
            this.txt_esfera.Location = new System.Drawing.Point(210, 40);
            this.txt_esfera.MaxLength = 5;
            this.txt_esfera.Name = "txt_esfera";
            this.txt_esfera.Size = new System.Drawing.Size(100, 20);
            this.txt_esfera.TabIndex = 1;
            this.txt_esfera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_esfera_KeyPress);
            // 
            // combo_esfera
            // 
            this.combo_esfera.FormattingEnabled = true;
            this.combo_esfera.Items.AddRange(new object[] {
            "+",
            "-"});
            this.combo_esfera.Location = new System.Drawing.Point(151, 39);
            this.combo_esfera.Name = "combo_esfera";
            this.combo_esfera.Size = new System.Drawing.Size(53, 21);
            this.combo_esfera.TabIndex = 0;
            this.combo_esfera.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fecha_lct
            // 
            this.fecha_lct.Location = new System.Drawing.Point(70, 389);
            this.fecha_lct.Name = "fecha_lct";
            this.fecha_lct.Size = new System.Drawing.Size(221, 20);
            this.fecha_lct.TabIndex = 6;
            // 
            // lbl_nombreadmin
            // 
            this.lbl_nombreadmin.AutoSize = true;
            this.lbl_nombreadmin.Location = new System.Drawing.Point(12, 77);
            this.lbl_nombreadmin.Name = "lbl_nombreadmin";
            this.lbl_nombreadmin.Size = new System.Drawing.Size(72, 13);
            this.lbl_nombreadmin.TabIndex = 7;
            this.lbl_nombreadmin.Text = "Responsable:";
            // 
            // LC_Torico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 509);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_nombreadmin);
            this.Controls.Add(this.fecha_lct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LC_Torico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LC_Torico";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atrásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verClientesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_signocil;
        private System.Windows.Forms.TextBox txt_gradoeje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_eje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cilindro;
        private System.Windows.Forms.TextBox txt_existente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_esfera;
        private System.Windows.Forms.ComboBox combo_esfera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker fecha_lct;
        private System.Windows.Forms.Label lbl_nombreadmin;
    }
}