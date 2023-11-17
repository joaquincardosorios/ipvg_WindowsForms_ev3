using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace UI
{
    public partial class Form1 : Form
    {
        private AlumnoBLL alumnoBLL;
        private MatriculaBLL matriculaBLL;
        private List<Alumno> alumnos;
        private int alumnoId;
        FormMatricula formMatricula;
        private List<Matricula> matriculas;

        public Form1()
        {
            InitializeComponent();
            alumnoBLL = new AlumnoBLL();
            alumnoId = 0;
            matriculaBLL = new MatriculaBLL();
            matriculas = new List<Matricula>();
            cargarAlumnos();
        }

        private void btnVerMatriculas_Click(object sender, EventArgs e)
        {
            if(dgvAlumnos.SelectedRows.Count == 1) 
            {
                int row = dgvAlumnos.SelectedCells[0].RowIndex;
                alumnoId = alumnos[row].AlumnoId;
                cargarMatriculas(alumnoId);

            } else
            {
                MessageBox.Show("Debes seleccionar un alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarAlumnos()
        {
            alumnos = alumnoBLL.GetAlumnos();
            if (alumnos != null)
            {
                foreach (Alumno a in alumnos)
                {
                    int n = dgvAlumnos.Rows.Add();
                    dgvAlumnos.Rows[n].Cells[0].Value = a.Persona.Run;
                    dgvAlumnos.Rows[n].Cells[1].Value = a.Persona.Apellido;
                    dgvAlumnos.Rows[n].Cells[2].Value = a.Persona.Nombre;
                    dgvAlumnos.Rows[n].Cells[3].Value = a.Persona.FechaNacimiento.ToString("dd-MM-yyyy");
                    dgvAlumnos.Rows[n].Cells[4].Value = a.CarreraActual;
                    dgvAlumnos.Rows[n].Cells[5].Value = a.FechaIngreso.ToString("dd-MM-yyyy");
                    dgvAlumnos.Rows[n].Cells[6].Value = a.EstadoAcademico;
                    dgvAlumnos.Rows[n].Cells[7].Value = a.Persona.EstadoCivil;
                    dgvAlumnos.Rows[n].Cells[8].Value = a.Persona.Direccion;

                }
            }
        }

        private void cargarMatriculas(int id)
        {
            matriculas = matriculaBLL.GetMatriculas(m => m.AlumnoId == id);
            dgvMatriculas.Rows.Clear();
            if (matriculas != null)
            {
                foreach (Matricula m in matriculas)
                {
                    int n = dgvMatriculas.Rows.Add();
                    dgvMatriculas.Rows[n].Cells[0].Value = m.Codigo;
                    dgvMatriculas.Rows[n].Cells[1].Value = m.Fecha.ToString("dd-MM-yyyy");
                    dgvMatriculas.Rows[n].Cells[2].Value = m.Carrera;
                    dgvMatriculas.Rows[n].Cells[3].Value = m.AnioMatricula;
                    dgvMatriculas.Rows[n].Cells[4].Value = m.SegmentoAcademico;
                }
            }
        }

        private void btnAgregarMatricula_Click(object sender, EventArgs e)
        {
            if(alumnoId != 0)
            {
                formMatricula = new FormMatricula(alumnoId);
                if (formMatricula.ShowDialog() == DialogResult.OK)
                {
                    this.cargarMatriculas(alumnoId);
                }
            } else
            {
                MessageBox.Show("Selecciona un alumno para poder crear su matricula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEditarMatricula_Click(object sender, EventArgs e)
        {
            if (dgvMatriculas.SelectedRows.Count == 1)
            {
                formMatricula = new FormMatricula(alumnoId);
                int row = dgvMatriculas.SelectedCells[0].RowIndex;
                Matricula matricula = matriculas[row];
                formMatricula = new FormMatricula(matricula, alumnoId);
                if (formMatricula.ShowDialog() == DialogResult.OK)
                {
                    this.cargarMatriculas(alumnoId);
                }
            } else
            {
                MessageBox.Show("Debes seleccionar una matricula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
