namespace UI
{
    partial class FormMatricula
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
            this.gb_matricula = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_segmento_academico = new System.Windows.Forms.TextBox();
            this.lbl_segmento_academico = new System.Windows.Forms.Label();
            this.txt_anio_matricula = new System.Windows.Forms.TextBox();
            this.lbl_anio_matricula = new System.Windows.Forms.Label();
            this.txt_carrera = new System.Windows.Forms.TextBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.gb_matricula.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_matricula
            // 
            this.gb_matricula.Controls.Add(this.btn_guardar);
            this.gb_matricula.Controls.Add(this.dtp_fecha);
            this.gb_matricula.Controls.Add(this.txt_segmento_academico);
            this.gb_matricula.Controls.Add(this.lbl_segmento_academico);
            this.gb_matricula.Controls.Add(this.txt_anio_matricula);
            this.gb_matricula.Controls.Add(this.lbl_anio_matricula);
            this.gb_matricula.Controls.Add(this.txt_carrera);
            this.gb_matricula.Controls.Add(this.lblCarrera);
            this.gb_matricula.Controls.Add(this.lbl_fecha);
            this.gb_matricula.Controls.Add(this.txt_codigo);
            this.gb_matricula.Controls.Add(this.lbl_codigo);
            this.gb_matricula.Location = new System.Drawing.Point(12, 12);
            this.gb_matricula.Name = "gb_matricula";
            this.gb_matricula.Size = new System.Drawing.Size(192, 354);
            this.gb_matricula.TabIndex = 0;
            this.gb_matricula.TabStop = false;
            this.gb_matricula.Text = "Crea o Edita una Matricula";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(10, 302);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(165, 35);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar Cambios";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(10, 97);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(165, 20);
            this.dtp_fecha.TabIndex = 2;
            // 
            // txt_segmento_academico
            // 
            this.txt_segmento_academico.Location = new System.Drawing.Point(10, 262);
            this.txt_segmento_academico.Name = "txt_segmento_academico";
            this.txt_segmento_academico.Size = new System.Drawing.Size(165, 20);
            this.txt_segmento_academico.TabIndex = 5;
            // 
            // lbl_segmento_academico
            // 
            this.lbl_segmento_academico.AutoSize = true;
            this.lbl_segmento_academico.Location = new System.Drawing.Point(7, 242);
            this.lbl_segmento_academico.Name = "lbl_segmento_academico";
            this.lbl_segmento_academico.Size = new System.Drawing.Size(113, 13);
            this.lbl_segmento_academico.TabIndex = 0;
            this.lbl_segmento_academico.Text = "Segmento académico:";
            // 
            // txt_anio_matricula
            // 
            this.txt_anio_matricula.Location = new System.Drawing.Point(10, 208);
            this.txt_anio_matricula.Name = "txt_anio_matricula";
            this.txt_anio_matricula.Size = new System.Drawing.Size(165, 20);
            this.txt_anio_matricula.TabIndex = 4;
            // 
            // lbl_anio_matricula
            // 
            this.lbl_anio_matricula.AutoSize = true;
            this.lbl_anio_matricula.Location = new System.Drawing.Point(7, 188);
            this.lbl_anio_matricula.Name = "lbl_anio_matricula";
            this.lbl_anio_matricula.Size = new System.Drawing.Size(75, 13);
            this.lbl_anio_matricula.TabIndex = 0;
            this.lbl_anio_matricula.Text = "Año Matricula:";
            // 
            // txt_carrera
            // 
            this.txt_carrera.Location = new System.Drawing.Point(10, 153);
            this.txt_carrera.Name = "txt_carrera";
            this.txt_carrera.Size = new System.Drawing.Size(165, 20);
            this.txt_carrera.TabIndex = 3;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(7, 133);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(44, 13);
            this.lblCarrera.TabIndex = 0;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(7, 80);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(40, 13);
            this.lbl_fecha.TabIndex = 0;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(10, 49);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(165, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(7, 29);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(43, 13);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Código;";
            // 
            // FormMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 376);
            this.Controls.Add(this.gb_matricula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matriculas";
            this.gb_matricula.ResumeLayout(false);
            this.gb_matricula.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_matricula;
        private System.Windows.Forms.TextBox txt_segmento_academico;
        private System.Windows.Forms.Label lbl_segmento_academico;
        private System.Windows.Forms.TextBox txt_anio_matricula;
        private System.Windows.Forms.Label lbl_anio_matricula;
        private System.Windows.Forms.TextBox txt_carrera;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Button btn_guardar;
    }
}