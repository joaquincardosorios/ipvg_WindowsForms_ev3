using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DAL
{
    public class AlumnoDAL
    {
        public void AddAlumno(Alumno alumno)
        {

            using (InstituteDbContext db = new InstituteDbContext())
            {
                db.Alumno.Add(alumno);
                db.SaveChanges();
            }
        }

        public Alumno GetAlumno(int id)
        {
            using (InstituteDbContext db = new InstituteDbContext())
            {
                Alumno alumno = db.Alumno.FirstOrDefault(a => a.AlumnoId == id) ?? 
                    throw new InvalidOperationException("No se encontró el alumno.");
                return alumno;
            }
        }
        public List<Alumno> GetAlumnos()
        {
            using (InstituteDbContext db = new InstituteDbContext())
            {
                return db.Alumno.Include(a => a.Persona).ToList();
            }
        }

        public void DeleteAlumno(int id)
        {
            using (InstituteDbContext db = new InstituteDbContext())
            {
                Alumno alumnoToDelete = this.GetAlumno(id);
                db.Alumno.Remove(alumnoToDelete);
                db.SaveChanges();
            }
        }

        public void UpdateAlumnos(int id, Alumno updatedAlumno)
        {
            using (InstituteDbContext db = new InstituteDbContext())
            {
                Alumno alumnoToUpdate = this.GetAlumno(id);
                if (alumnoToUpdate != null)
                {
                    alumnoToUpdate.FechaIngreso = updatedAlumno.FechaIngreso;
                    alumnoToUpdate.CarreraActual = updatedAlumno.CarreraActual;
                    alumnoToUpdate.EstadoAcademico = updatedAlumno.EstadoAcademico;
                    db.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("El alumno no se encontró.");
                }
            }
        }
    }
}
