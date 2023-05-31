namespace pryLuna_Clinica
{
    partial class frmMédicos
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
            this.mrcRegistroM = new System.Windows.Forms.GroupBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblNombreM = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.cmbEspecialidadM = new System.Windows.Forms.ComboBox();
            this.btnRegistrarM = new System.Windows.Forms.Button();
            this.mrcConsultas = new System.Windows.Forms.GroupBox();
            this.lblEspecialidadC = new System.Windows.Forms.Label();
            this.cmbEspecialidadC = new System.Windows.Forms.ComboBox();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcRegistroM.SuspendLayout();
            this.mrcConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcRegistroM
            // 
            this.mrcRegistroM.Controls.Add(this.lblEspecialidad);
            this.mrcRegistroM.Controls.Add(this.lblNombreM);
            this.mrcRegistroM.Controls.Add(this.lblMatricula);
            this.mrcRegistroM.Controls.Add(this.txtMatricula);
            this.mrcRegistroM.Controls.Add(this.txtNombreM);
            this.mrcRegistroM.Controls.Add(this.cmbEspecialidadM);
            this.mrcRegistroM.Controls.Add(this.btnRegistrarM);
            this.mrcRegistroM.Location = new System.Drawing.Point(12, 12);
            this.mrcRegistroM.Name = "mrcRegistroM";
            this.mrcRegistroM.Size = new System.Drawing.Size(358, 138);
            this.mrcRegistroM.TabIndex = 10;
            this.mrcRegistroM.TabStop = false;
            this.mrcRegistroM.Text = "Médico";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(17, 99);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 13;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblNombreM
            // 
            this.lblNombreM.AutoSize = true;
            this.lblNombreM.Location = new System.Drawing.Point(40, 63);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(44, 13);
            this.lblNombreM.TabIndex = 12;
            this.lblNombreM.Text = "Nombre";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(34, 27);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula.TabIndex = 11;
            this.lblMatricula.Text = "Matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(90, 24);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 7;
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(90, 60);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(121, 20);
            this.txtNombreM.TabIndex = 6;
            // 
            // cmbEspecialidadM
            // 
            this.cmbEspecialidadM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidadM.FormattingEnabled = true;
            this.cmbEspecialidadM.Location = new System.Drawing.Point(90, 96);
            this.cmbEspecialidadM.Name = "cmbEspecialidadM";
            this.cmbEspecialidadM.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidadM.TabIndex = 3;
            // 
            // btnRegistrarM
            // 
            this.btnRegistrarM.Location = new System.Drawing.Point(277, 109);
            this.btnRegistrarM.Name = "btnRegistrarM";
            this.btnRegistrarM.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarM.TabIndex = 5;
            this.btnRegistrarM.Text = "Registrar";
            this.btnRegistrarM.UseVisualStyleBackColor = true;
            this.btnRegistrarM.Click += new System.EventHandler(this.btnRegistrarM_Click);
            // 
            // mrcConsultas
            // 
            this.mrcConsultas.Controls.Add(this.lblEspecialidadC);
            this.mrcConsultas.Controls.Add(this.cmbEspecialidadC);
            this.mrcConsultas.Controls.Add(this.dgvConsultas);
            this.mrcConsultas.Location = new System.Drawing.Point(12, 156);
            this.mrcConsultas.Name = "mrcConsultas";
            this.mrcConsultas.Size = new System.Drawing.Size(428, 218);
            this.mrcConsultas.TabIndex = 9;
            this.mrcConsultas.TabStop = false;
            this.mrcConsultas.Text = "Consultas";
            // 
            // lblEspecialidadC
            // 
            this.lblEspecialidadC.AutoSize = true;
            this.lblEspecialidadC.Location = new System.Drawing.Point(6, 16);
            this.lblEspecialidadC.Name = "lblEspecialidadC";
            this.lblEspecialidadC.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidadC.TabIndex = 15;
            this.lblEspecialidadC.Text = "Especialidad";
            // 
            // cmbEspecialidadC
            // 
            this.cmbEspecialidadC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidadC.FormattingEnabled = true;
            this.cmbEspecialidadC.Location = new System.Drawing.Point(79, 13);
            this.cmbEspecialidadC.Name = "cmbEspecialidadC";
            this.cmbEspecialidadC.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidadC.TabIndex = 14;
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula,
            this.nombre,
            this.especialidad});
            this.dgvConsultas.Location = new System.Drawing.Point(6, 40);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersVisible = false;
            this.dgvConsultas.Size = new System.Drawing.Size(416, 172);
            this.dgvConsultas.TabIndex = 0;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // especialidad
            // 
            this.especialidad.HeaderText = "Especialidad";
            this.especialidad.Name = "especialidad";
            this.especialidad.ReadOnly = true;
            // 
            // frmMédicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 386);
            this.Controls.Add(this.mrcRegistroM);
            this.Controls.Add(this.mrcConsultas);
            this.Name = "frmMédicos";
            this.Text = "Registros Médicos";
            this.Load += new System.EventHandler(this.frmMédicos_Load);
            this.mrcRegistroM.ResumeLayout(false);
            this.mrcRegistroM.PerformLayout();
            this.mrcConsultas.ResumeLayout(false);
            this.mrcConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcRegistroM;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblNombreM;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.ComboBox cmbEspecialidadM;
        private System.Windows.Forms.Button btnRegistrarM;
        private System.Windows.Forms.GroupBox mrcConsultas;
        private System.Windows.Forms.Label lblEspecialidadC;
        private System.Windows.Forms.ComboBox cmbEspecialidadC;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
    }
}