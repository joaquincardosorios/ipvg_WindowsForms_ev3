namespace UI
{
    partial class Form1
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
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnVerMatriculas = new System.Windows.Forms.Button();
            this.btnAgregarMatricula = new System.Windows.Forms.Button();
            this.btnEditarMatricula = new System.Windows.Forms.Button();
            this.dgvMatriculas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegmentoAcademico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Run = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarreraActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoAcademico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Run,
            this.Apellidos,
            this.Nombres,
            this.FNacimiento,
            this.CarreraActual,
            this.FIngreso,
            this.EstadoAcademico,
            this.EstadoCivil,
            this.Direccion});
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 12);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.Size = new System.Drawing.Size(727, 221);
            this.dgvAlumnos.TabIndex = 0;
            // 
            // btnVerMatriculas
            // 
            this.btnVerMatriculas.Location = new System.Drawing.Point(12, 241);
            this.btnVerMatriculas.Name = "btnVerMatriculas";
            this.btnVerMatriculas.Size = new System.Drawing.Size(145, 50);
            this.btnVerMatriculas.TabIndex = 1;
            this.btnVerMatriculas.Text = "Mostrar Matriculas";
            this.btnVerMatriculas.UseVisualStyleBackColor = true;
            this.btnVerMatriculas.Click += new System.EventHandler(this.btnVerMatriculas_Click);
            // 
            // btnAgregarMatricula
            // 
            this.btnAgregarMatricula.Location = new System.Drawing.Point(594, 310);
            this.btnAgregarMatricula.Name = "btnAgregarMatricula";
            this.btnAgregarMatricula.Size = new System.Drawing.Size(145, 51);
            this.btnAgregarMatricula.TabIndex = 2;
            this.btnAgregarMatricula.Text = "Agregar Matricula";
            this.btnAgregarMatricula.UseVisualStyleBackColor = true;
            this.btnAgregarMatricula.Click += new System.EventHandler(this.btnAgregarMatricula_Click);
            // 
            // btnEditarMatricula
            // 
            this.btnEditarMatricula.Location = new System.Drawing.Point(594, 383);
            this.btnEditarMatricula.Name = "btnEditarMatricula";
            this.btnEditarMatricula.Size = new System.Drawing.Size(145, 51);
            this.btnEditarMatricula.TabIndex = 3;
            this.btnEditarMatricula.Text = "Editar Matricula";
            this.btnEditarMatricula.UseVisualStyleBackColor = true;
            this.btnEditarMatricula.Click += new System.EventHandler(this.btnEditarMatricula_Click);
            // 
            // dgvMatriculas
            // 
            this.dgvMatriculas.AllowUserToDeleteRows = false;
            this.dgvMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Fecha,
            this.Carrera,
            this.AnioMatricula,
            this.SegmentoAcademico});
            this.dgvMatriculas.Location = new System.Drawing.Point(12, 297);
            this.dgvMatriculas.Name = "dgvMatriculas";
            this.dgvMatriculas.Size = new System.Drawing.Size(544, 150);
            this.dgvMatriculas.TabIndex = 4;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            // 
            // AnioMatricula
            // 
            this.AnioMatricula.HeaderText = "Año Matricula";
            this.AnioMatricula.Name = "AnioMatricula";
            this.AnioMatricula.ReadOnly = true;
            // 
            // SegmentoAcademico
            // 
            this.SegmentoAcademico.HeaderText = "Segmento Academico";
            this.SegmentoAcademico.Name = "SegmentoAcademico";
            this.SegmentoAcademico.ReadOnly = true;
            // 
            // Run
            // 
            this.Run.HeaderText = "Run";
            this.Run.Name = "Run";
            this.Run.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // FNacimiento
            // 
            this.FNacimiento.HeaderText = "F. de Nacimiento";
            this.FNacimiento.Name = "FNacimiento";
            this.FNacimiento.ReadOnly = true;
            // 
            // CarreraActual
            // 
            this.CarreraActual.HeaderText = "Carrera Actual";
            this.CarreraActual.Name = "CarreraActual";
            this.CarreraActual.ReadOnly = true;
            // 
            // FIngreso
            // 
            this.FIngreso.HeaderText = "F. Ingreso";
            this.FIngreso.Name = "FIngreso";
            this.FIngreso.ReadOnly = true;
            // 
            // EstadoAcademico
            // 
            this.EstadoAcademico.HeaderText = "Estado Academico";
            this.EstadoAcademico.Name = "EstadoAcademico";
            this.EstadoAcademico.ReadOnly = true;
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.HeaderText = "Estado Civil";
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 467);
            this.Controls.Add(this.dgvMatriculas);
            this.Controls.Add(this.btnEditarMatricula);
            this.Controls.Add(this.btnAgregarMatricula);
            this.Controls.Add(this.btnVerMatriculas);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "Form1";
            this.Text = "Registro de Matrículas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnVerMatriculas;
        private System.Windows.Forms.Button btnAgregarMatricula;
        private System.Windows.Forms.Button btnEditarMatricula;
        private System.Windows.Forms.DataGridView dgvMatriculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegmentoAcademico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Run;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn FNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarreraActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoAcademico;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
    }
}

