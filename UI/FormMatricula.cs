using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace UI
{
    public partial class FormMatricula : Form
    {
        private Matricula currentMatricula;
        private MatriculaBLL matriculaBLL;
        private int idAlumno;

        public FormMatricula(int id)
        {
            InitializeComponent();
            matriculaBLL = new MatriculaBLL();
            idAlumno = id;
        }
        public FormMatricula(Matricula matricula, int id)
        {
            InitializeComponent();
            matriculaBLL = new MatriculaBLL();
            currentMatricula = matricula;
            idAlumno = id;
            CargarDatosMatricula();
        }

        private void CargarDatosMatricula()
        {
            txt_codigo.Text = currentMatricula.Codigo;
            dtp_fecha.Value = currentMatricula.Fecha;
            txt_carrera.Text = currentMatricula.Carrera;
            txt_anio_matricula.Text = currentMatricula.AnioMatricula.ToString();
            txt_segmento_academico.Text = currentMatricula.SegmentoAcademico;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string codigo = txt_codigo.Text.Trim();
            System.DateTime fecha = dtp_fecha.Value.Date;
            string carrera = txt_carrera.Text;
            string anioMatricula =txt_anio_matricula.Text.Trim();
            string segmentoAcademico = txt_segmento_academico.Text.Trim();

            try
            {
                ValidarDatos(codigo, fecha, carrera, anioMatricula, segmentoAcademico);
                if (currentMatricula != null)
                {
                    currentMatricula.Codigo = codigo;
                    currentMatricula.Fecha = fecha;
                    currentMatricula.Carrera = carrera;
                    currentMatricula.AnioMatricula = int.Parse(anioMatricula);
                    currentMatricula.SegmentoAcademico = segmentoAcademico;
                    matriculaBLL.UpdateMatricula(currentMatricula);
                }
                else
                {
                    Matricula newMatricula = new Matricula
                    {
                        Codigo = codigo,
                        Fecha = fecha,
                        Carrera = carrera,
                        AnioMatricula = int.Parse(anioMatricula),
                        SegmentoAcademico = segmentoAcademico,
                        AlumnoId = idAlumno
                    };
                    matriculaBLL.addMatricula(newMatricula);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void ValidarDatos(string codigo, System.DateTime fecha, string carrera, 
            string anioMatricula, string segmentoAcademico)
        {
            if (string.IsNullOrEmpty(codigo))
            {
                throw new Exception("El código es obligatorio");
            }
            if (fecha < DateTime.Today)
            {
                throw new Exception("La fecha no puede ser anterior a hoy");
            }
            if (string.IsNullOrEmpty(carrera))
            {
                throw new Exception("La carrera es obligatoria");
            }
            if (!int.TryParse(anioMatricula, out int anioMatriculaInt))
            {
                throw new Exception("El año de matricula deber ser un numero entero");
            }
            else if (int.Parse(anioMatricula) < DateTime.Now.Year)
            {
                throw new Exception("El año de matricula no puede ser menor a el año actual");
            }
            if (string.IsNullOrEmpty(segmentoAcademico))
            {
                throw new Exception("El segmento academico es obligatorio");
            }
            
            
        }
    }
}
