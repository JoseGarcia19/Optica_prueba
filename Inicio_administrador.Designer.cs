namespace Sistema_Optica
{
    partial class Inicio_administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_administrador));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteEspecialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.micasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.armazonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lentesDeContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esféricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tóricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_nombreAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.atrásToolStripMenuItem,
            this.minimizarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.clienteEspecialToolStripMenuItem,
            this.micasToolStripMenuItem,
            this.armazonesToolStripMenuItem,
            this.lentesDeContactoToolStripMenuItem,
            this.accesoriosToolStripMenuItem});
            this.agregarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.agregarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripMenuItem.Image")));
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.agregarToolStripMenuItem.Text = "Añadir";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuarioToolStripMenuItem.Text = "Vendedor";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // clienteEspecialToolStripMenuItem
            // 
            this.clienteEspecialToolStripMenuItem.Name = "clienteEspecialToolStripMenuItem";
            this.clienteEspecialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteEspecialToolStripMenuItem.Text = "Cliente";
            this.clienteEspecialToolStripMenuItem.Click += new System.EventHandler(this.clienteEspecialToolStripMenuItem_Click);
            // 
            // micasToolStripMenuItem
            // 
            this.micasToolStripMenuItem.Name = "micasToolStripMenuItem";
            this.micasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.micasToolStripMenuItem.Text = "Micas";
            this.micasToolStripMenuItem.Click += new System.EventHandler(this.micasToolStripMenuItem_Click);
            // 
            // armazonesToolStripMenuItem
            // 
            this.armazonesToolStripMenuItem.Name = "armazonesToolStripMenuItem";
            this.armazonesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.armazonesToolStripMenuItem.Text = "Armazones";
            this.armazonesToolStripMenuItem.Click += new System.EventHandler(this.armazonesToolStripMenuItem_Click);
            // 
            // lentesDeContactoToolStripMenuItem
            // 
            this.lentesDeContactoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esféricoToolStripMenuItem,
            this.tóricoToolStripMenuItem,
            this.deColorToolStripMenuItem});
            this.lentesDeContactoToolStripMenuItem.Name = "lentesDeContactoToolStripMenuItem";
            this.lentesDeContactoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lentesDeContactoToolStripMenuItem.Text = "Lentes de contacto";
            // 
            // esféricoToolStripMenuItem
            // 
            this.esféricoToolStripMenuItem.Name = "esféricoToolStripMenuItem";
            this.esféricoToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.esféricoToolStripMenuItem.Text = "Esférico";
            this.esféricoToolStripMenuItem.Click += new System.EventHandler(this.esféricoToolStripMenuItem_Click);
            // 
            // tóricoToolStripMenuItem
            // 
            this.tóricoToolStripMenuItem.Name = "tóricoToolStripMenuItem";
            this.tóricoToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.tóricoToolStripMenuItem.Text = "Tórico";
            this.tóricoToolStripMenuItem.Click += new System.EventHandler(this.tóricoToolStripMenuItem_Click);
            // 
            // deColorToolStripMenuItem
            // 
            this.deColorToolStripMenuItem.Name = "deColorToolStripMenuItem";
            this.deColorToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.deColorToolStripMenuItem.Text = "De color";
            this.deColorToolStripMenuItem.Click += new System.EventHandler(this.deColorToolStripMenuItem_Click);
            // 
            // accesoriosToolStripMenuItem
            // 
            this.accesoriosToolStripMenuItem.Name = "accesoriosToolStripMenuItem";
            this.accesoriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.accesoriosToolStripMenuItem.Text = "Accesorios";
            this.accesoriosToolStripMenuItem.Click += new System.EventHandler(this.accesoriosToolStripMenuItem_Click);
            // 
            // atrásToolStripMenuItem
            // 
            this.atrásToolStripMenuItem.Name = "atrásToolStripMenuItem";
            this.atrásToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.atrásToolStripMenuItem.Text = "Minimizar";
            this.atrásToolStripMenuItem.Click += new System.EventHandler(this.atrásToolStripMenuItem_Click);
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minimizarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("minimizarToolStripMenuItem.Image")));
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.minimizarToolStripMenuItem.Text = "Cerrar Sesión";
            this.minimizarToolStripMenuItem.Click += new System.EventHandler(this.minimizarToolStripMenuItem_Click);
            // 
            // label_nombreAdmin
            // 
            this.label_nombreAdmin.AutoSize = true;
            this.label_nombreAdmin.Location = new System.Drawing.Point(428, 279);
            this.label_nombreAdmin.Name = "label_nombreAdmin";
            this.label_nombreAdmin.Size = new System.Drawing.Size(75, 13);
            this.label_nombreAdmin.TabIndex = 10;
            this.label_nombreAdmin.Text = "Bienvenido(a):";
            this.label_nombreAdmin.TextChanged += new System.EventHandler(this.label_nombreAdmin_TextChanged);
            this.label_nombreAdmin.Click += new System.EventHandler(this.label_nombreAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_nombreAdmin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inicio_administrador";
            this.Text = "Inicio_adminsitrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_administrador_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteEspecialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem armazonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem micasToolStripMenuItem;
        private System.Windows.Forms.Label label_nombreAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem accesoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lentesDeContactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esféricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tóricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deColorToolStripMenuItem;
    }
}