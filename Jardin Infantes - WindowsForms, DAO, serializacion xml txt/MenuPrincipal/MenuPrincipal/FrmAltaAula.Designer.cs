namespace MenuPrincipal
{
    partial class FrmAltaAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaAula));
            this.lstProfesores = new System.Windows.Forms.ListBox();
            this.btnAgregarProfe = new System.Windows.Forms.Button();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.lstAulaNueva = new System.Windows.Forms.ListBox();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.cmbColorSala = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.btnAltaAula = new System.Windows.Forms.Button();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstProfesores
            // 
            this.lstProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProfesores.FormattingEnabled = true;
            this.lstProfesores.ItemHeight = 25;
            this.lstProfesores.Location = new System.Drawing.Point(574, 12);
            this.lstProfesores.Name = "lstProfesores";
            this.lstProfesores.Size = new System.Drawing.Size(414, 204);
            this.lstProfesores.TabIndex = 0;
            // 
            // btnAgregarProfe
            // 
            this.btnAgregarProfe.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProfe.Image")));
            this.btnAgregarProfe.Location = new System.Drawing.Point(457, 12);
            this.btnAgregarProfe.Name = "btnAgregarProfe";
            this.btnAgregarProfe.Size = new System.Drawing.Size(111, 63);
            this.btnAgregarProfe.TabIndex = 1;
            this.btnAgregarProfe.UseVisualStyleBackColor = true;
            this.btnAgregarProfe.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.ItemHeight = 25;
            this.lstAlumnos.Location = new System.Drawing.Point(574, 236);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(415, 479);
            this.lstAlumnos.TabIndex = 2;
            // 
            // lstAulaNueva
            // 
            this.lstAulaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAulaNueva.FormattingEnabled = true;
            this.lstAulaNueva.ItemHeight = 25;
            this.lstAulaNueva.Location = new System.Drawing.Point(12, 152);
            this.lstAulaNueva.Name = "lstAulaNueva";
            this.lstAulaNueva.Size = new System.Drawing.Size(439, 654);
            this.lstAulaNueva.TabIndex = 3;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarAlumno.Image")));
            this.btnAgregarAlumno.Location = new System.Drawing.Point(457, 496);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(111, 73);
            this.btnAgregarAlumno.TabIndex = 4;
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // cmbColorSala
            // 
            this.cmbColorSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColorSala.FormattingEnabled = true;
            this.cmbColorSala.Location = new System.Drawing.Point(83, 72);
            this.cmbColorSala.Name = "cmbColorSala";
            this.cmbColorSala.Size = new System.Drawing.Size(121, 37);
            this.cmbColorSala.TabIndex = 6;
            // 
            // cmbTurno
            // 
            this.cmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(330, 72);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(121, 37);
            this.cmbTurno.TabIndex = 7;
            // 
            // btnAltaAula
            // 
            this.btnAltaAula.Location = new System.Drawing.Point(574, 739);
            this.btnAltaAula.Name = "btnAltaAula";
            this.btnAltaAula.Size = new System.Drawing.Size(414, 67);
            this.btnAltaAula.TabIndex = 8;
            this.btnAltaAula.Text = "Crear aula";
            this.btnAltaAula.UseVisualStyleBackColor = true;
            this.btnAltaAula.Click += new System.EventHandler(this.btnAltaAula_Click);
            // 
            // txtDocente
            // 
            this.txtDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocente.Location = new System.Drawing.Point(135, 12);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(316, 35);
            this.txtDocente.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "SALA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "TURNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "DOCENTE";
            // 
            // FrmAltaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1021, 826);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocente);
            this.Controls.Add(this.btnAltaAula);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.cmbColorSala);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.lstAulaNueva);
            this.Controls.Add(this.lstAlumnos);
            this.Controls.Add(this.btnAgregarProfe);
            this.Controls.Add(this.lstProfesores);
            this.Name = "FrmAltaAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Aula";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAltaAula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProfesores;
        private System.Windows.Forms.Button btnAgregarProfe;
        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.ListBox lstAulaNueva;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.ComboBox cmbColorSala;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Button btnAltaAula;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}