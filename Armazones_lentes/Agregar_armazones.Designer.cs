namespace Sistema_Optica.Armazones_lentes
{
    partial class Agregar_armazones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_armazones));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tipo_armazon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_existentes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.combo_materialArmazon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_modeloarmazon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_marcaArmazon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fecha_armazon = new System.Windows.Forms.DateTimePicker();
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
            this.agregarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tipo_armazon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_existentes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_precio);
            this.groupBox1.Controls.Add(this.combo_materialArmazon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_modeloarmazon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_marcaArmazon);
            this.groupBox1.Location = new System.Drawing.Point(331, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 336);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // tipo_armazon
            // 
            this.tipo_armazon.Location = new System.Drawing.Point(184, 189);
            this.tipo_armazon.Name = "tipo_armazon";
            this.tipo_armazon.Size = new System.Drawing.Size(188, 20);
            this.tipo_armazon.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo de armazón:";
            // 
            // txt_existentes
            // 
            this.txt_existentes.Location = new System.Drawing.Point(184, 289);
            this.txt_existentes.Name = "txt_existentes";
            this.txt_existentes.Size = new System.Drawing.Size(188, 20);
            this.txt_existentes.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad en existencia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio:";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(184, 241);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(188, 20);
            this.txt_precio.TabIndex = 6;
            // 
            // combo_materialArmazon
            // 
            this.combo_materialArmazon.FormattingEnabled = true;
            this.combo_materialArmazon.Items.AddRange(new object[] {
            "Acetato",
            "Plástico",
            "Monel",
            "Berilio",
            "Titanio",
            "Acero Inoxidable",
            "Aluminio",
            "Madera/Cuerno/Hueso",
            "Oro",
            "Plata",
            "Cuero",
            "Piedras y Cristales"});
            this.combo_materialArmazon.Location = new System.Drawing.Point(184, 143);
            this.combo_materialArmazon.Name = "combo_materialArmazon";
            this.combo_materialArmazon.Size = new System.Drawing.Size(188, 21);
            this.combo_materialArmazon.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Material del armazón:";
            // 
            // txt_modeloarmazon
            // 
            this.txt_modeloarmazon.Location = new System.Drawing.Point(184, 93);
            this.txt_modeloarmazon.Name = "txt_modeloarmazon";
            this.txt_modeloarmazon.Size = new System.Drawing.Size(188, 20);
            this.txt_modeloarmazon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca del armazón:";
            // 
            // txt_marcaArmazon
            // 
            this.txt_marcaArmazon.Location = new System.Drawing.Point(184, 44);
            this.txt_marcaArmazon.Name = "txt_marcaArmazon";
            this.txt_marcaArmazon.Size = new System.Drawing.Size(188, 20);
            this.txt_marcaArmazon.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // fecha_armazon
            // 
            this.fecha_armazon.Location = new System.Drawing.Point(23, 355);
            this.fecha_armazon.Name = "fecha_armazon";
            this.fecha_armazon.Size = new System.Drawing.Size(289, 20);
            this.fecha_armazon.TabIndex = 15;
            // 
            // lbl_nombreadmin
            // 
            this.lbl_nombreadmin.AutoSize = true;
            this.lbl_nombreadmin.Location = new System.Drawing.Point(20, 65);
            this.lbl_nombreadmin.Name = "lbl_nombreadmin";
            this.lbl_nombreadmin.Size = new System.Drawing.Size(73, 13);
            this.lbl_nombreadmin.TabIndex = 16;
            this.lbl_nombreadmin.Text = "Administrador:";
            // 
            // Agregar_armazones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_nombreadmin);
            this.Controls.Add(this.fecha_armazon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Agregar_armazones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar_armazones";
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
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combo_materialArmazon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_modeloarmazon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_marcaArmazon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_existentes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tipo_armazon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fecha_armazon;
        private System.Windows.Forms.Label lbl_nombreadmin;
    }
}