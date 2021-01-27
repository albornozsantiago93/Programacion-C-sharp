namespace MenuPrincipal
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDePadreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoDeDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionPorAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionTotalDelJardinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lstInforme = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeDocenteToolStripMenuItem,
            this.altaNoDocenteToolStripMenuItem,
            this.altaAlumnoToolStripMenuItem,
            this.altaDeAulaToolStripMenuItem,
            this.buscarAlumnoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // altaDeDocenteToolStripMenuItem
            // 
            this.altaDeDocenteToolStripMenuItem.Name = "altaDeDocenteToolStripMenuItem";
            this.altaDeDocenteToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.altaDeDocenteToolStripMenuItem.Text = "Alta de docente";
            this.altaDeDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaDeDocenteToolStripMenuItem_Click);
            // 
            // altaNoDocenteToolStripMenuItem
            // 
            this.altaNoDocenteToolStripMenuItem.Name = "altaNoDocenteToolStripMenuItem";
            this.altaNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.altaNoDocenteToolStripMenuItem.Text = "Alta no docente";
            this.altaNoDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaNoDocenteToolStripMenuItem_Click);
            // 
            // altaAlumnoToolStripMenuItem
            // 
            this.altaAlumnoToolStripMenuItem.Name = "altaAlumnoToolStripMenuItem";
            this.altaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.altaAlumnoToolStripMenuItem.Text = "Alta de alumno";
            this.altaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaAlumnoToolStripMenuItem_Click);
            // 
            // altaDeAulaToolStripMenuItem
            // 
            this.altaDeAulaToolStripMenuItem.Name = "altaDeAulaToolStripMenuItem";
            this.altaDeAulaToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.altaDeAulaToolStripMenuItem.Text = "Alta de aula";
            this.altaDeAulaToolStripMenuItem.Click += new System.EventHandler(this.altaDeAulaToolStripMenuItem_Click);
            // 
            // buscarAlumnoToolStripMenuItem
            // 
            this.buscarAlumnoToolStripMenuItem.Name = "buscarAlumnoToolStripMenuItem";
            this.buscarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.buscarAlumnoToolStripMenuItem.Text = "Buscar alumno";
            this.buscarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.buscarAlumnoToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionDePadreToolStripMenuItem,
            this.sueldoDeDocenteToolStripMenuItem,
            this.recaudacionPorAulaToolStripMenuItem,
            this.recaudacionTotalDelJardinToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // informacionDePadreToolStripMenuItem
            // 
            this.informacionDePadreToolStripMenuItem.Name = "informacionDePadreToolStripMenuItem";
            this.informacionDePadreToolStripMenuItem.Size = new System.Drawing.Size(314, 30);
            this.informacionDePadreToolStripMenuItem.Text = "Informacion de padre";
            this.informacionDePadreToolStripMenuItem.Click += new System.EventHandler(this.informacionDePadreToolStripMenuItem_Click);
            // 
            // sueldoDeDocenteToolStripMenuItem
            // 
            this.sueldoDeDocenteToolStripMenuItem.Name = "sueldoDeDocenteToolStripMenuItem";
            this.sueldoDeDocenteToolStripMenuItem.Size = new System.Drawing.Size(314, 30);
            this.sueldoDeDocenteToolStripMenuItem.Text = "Sueldo de docente";
            this.sueldoDeDocenteToolStripMenuItem.Click += new System.EventHandler(this.sueldoDeDocenteToolStripMenuItem_Click);
            // 
            // recaudacionPorAulaToolStripMenuItem
            // 
            this.recaudacionPorAulaToolStripMenuItem.Name = "recaudacionPorAulaToolStripMenuItem";
            this.recaudacionPorAulaToolStripMenuItem.Size = new System.Drawing.Size(314, 30);
            this.recaudacionPorAulaToolStripMenuItem.Text = "Recaudacion por aula";
            this.recaudacionPorAulaToolStripMenuItem.Click += new System.EventHandler(this.recaudacionPorAulaToolStripMenuItem_Click);
            // 
            // recaudacionTotalDelJardinToolStripMenuItem
            // 
            this.recaudacionTotalDelJardinToolStripMenuItem.Name = "recaudacionTotalDelJardinToolStripMenuItem";
            this.recaudacionTotalDelJardinToolStripMenuItem.Size = new System.Drawing.Size(314, 30);
            this.recaudacionTotalDelJardinToolStripMenuItem.Text = "Recaudacion total del jardin";
            this.recaudacionTotalDelJardinToolStripMenuItem.Click += new System.EventHandler(this.recaudacionTotalDelJardinToolStripMenuItem_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(739, 0);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(175, 33);
            this.btnCargar.TabIndex = 20;
            this.btnCargar.Text = "Cargar datos";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lstInforme
            // 
            this.lstInforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lstInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInforme.FormattingEnabled = true;
            this.lstInforme.ItemHeight = 25;
            this.lstInforme.Location = new System.Drawing.Point(12, 42);
            this.lstInforme.Name = "lstInforme";
            this.lstInforme.Size = new System.Drawing.Size(902, 654);
            this.lstInforme.TabIndex = 22;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(930, 704);
            this.Controls.Add(this.lstInforme);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionDePadreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoDeDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionPorAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionTotalDelJardinToolStripMenuItem;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListBox lstInforme;
        private System.Windows.Forms.ToolStripMenuItem buscarAlumnoToolStripMenuItem;
    }
}

