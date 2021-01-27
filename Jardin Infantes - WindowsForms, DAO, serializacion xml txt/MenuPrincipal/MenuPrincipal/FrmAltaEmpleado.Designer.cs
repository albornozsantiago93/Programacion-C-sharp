namespace MenuPrincipal
{
    partial class FrmAltaEmpleado
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.lblHoraIngreso = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHoraSalida = new System.Windows.Forms.TextBox();
            this.txtHoraIngreso = new System.Windows.Forms.TextBox();
            this.cmbCargoEmpleado = new System.Windows.Forms.ComboBox();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnDarAlta = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 29);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBase.Location = new System.Drawing.Point(31, 95);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(162, 29);
            this.lblSalarioBase.TabIndex = 2;
            this.lblSalarioBase.Text = "Salario Base";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(401, 95);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(84, 29);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "Cargo";
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSalida.Location = new System.Drawing.Point(401, 25);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(150, 29);
            this.lblHoraSalida.TabIndex = 4;
            this.lblHoraSalida.Text = "Hora Salida";
            // 
            // lblHoraIngreso
            // 
            this.lblHoraIngreso.AutoSize = true;
            this.lblHoraIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraIngreso.Location = new System.Drawing.Point(31, 25);
            this.lblHoraIngreso.Name = "lblHoraIngreso";
            this.lblHoraIngreso.Size = new System.Drawing.Size(164, 29);
            this.lblHoraIngreso.TabIndex = 5;
            this.lblHoraIngreso.Text = "Hora Ingreso";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(401, 118);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(72, 29);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo";
            this.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(31, 118);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(52, 29);
            this.lblDni.TabIndex = 7;
            this.lblDni.Text = "Dni";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(401, 32);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(110, 29);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtHoraSalida);
            this.panel1.Controls.Add(this.txtHoraIngreso);
            this.panel1.Controls.Add(this.cmbCargoEmpleado);
            this.panel1.Controls.Add(this.txtSalarioBase);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.lblSalarioBase);
            this.panel1.Controls.Add(this.lblHoraIngreso);
            this.panel1.Controls.Add(this.lblHoraSalida);
            this.panel1.Location = new System.Drawing.Point(35, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 163);
            this.panel1.TabIndex = 9;
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraSalida.Location = new System.Drawing.Point(557, 25);
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(88, 35);
            this.txtHoraSalida.TabIndex = 6;
            // 
            // txtHoraIngreso
            // 
            this.txtHoraIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraIngreso.Location = new System.Drawing.Point(199, 19);
            this.txtHoraIngreso.Name = "txtHoraIngreso";
            this.txtHoraIngreso.Size = new System.Drawing.Size(96, 35);
            this.txtHoraIngreso.TabIndex = 5;
            // 
            // cmbCargoEmpleado
            // 
            this.cmbCargoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargoEmpleado.FormattingEnabled = true;
            this.cmbCargoEmpleado.Location = new System.Drawing.Point(517, 92);
            this.cmbCargoEmpleado.Name = "cmbCargoEmpleado";
            this.cmbCargoEmpleado.Size = new System.Drawing.Size(193, 37);
            this.cmbCargoEmpleado.TabIndex = 8;
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Enabled = false;
            this.txtSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBase.Location = new System.Drawing.Point(199, 89);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(177, 35);
            this.txtSalarioBase.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbSexo);
            this.panel2.Controls.Add(this.txtDni);
            this.panel2.Controls.Add(this.txtApellido);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.lblApellido);
            this.panel2.Controls.Add(this.lblSexo);
            this.panel2.Controls.Add(this.lblDni);
            this.panel2.Location = new System.Drawing.Point(35, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 213);
            this.panel2.TabIndex = 10;
            // 
            // cmbSexo
            // 
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(517, 110);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(193, 37);
            this.cmbSexo.TabIndex = 4;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(144, 118);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(193, 35);
            this.txtDni.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(517, 26);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(193, 35);
            this.txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(144, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(193, 35);
            this.txtNombre.TabIndex = 1;
            // 
            // btnDarAlta
            // 
            this.btnDarAlta.Location = new System.Drawing.Point(534, 481);
            this.btnDarAlta.Name = "btnDarAlta";
            this.btnDarAlta.Size = new System.Drawing.Size(247, 62);
            this.btnDarAlta.TabIndex = 9;
            this.btnDarAlta.Text = "Dar de alta";
            this.btnDarAlta.UseVisualStyleBackColor = true;
            this.btnDarAlta.Click += new System.EventHandler(this.btnDarAlta_Click);
            // 
            // FrmAltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(811, 578);
            this.Controls.Add(this.btnDarAlta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAltaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Empleado";
            this.Load += new System.EventHandler(this.FrmMenuAltaEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.Label lblHoraIngreso;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnDarAlta;
        private System.Windows.Forms.ComboBox cmbCargoEmpleado;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox txtHoraSalida;
        private System.Windows.Forms.TextBox txtHoraIngreso;
    }
}