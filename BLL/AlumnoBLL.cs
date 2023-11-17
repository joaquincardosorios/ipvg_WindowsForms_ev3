using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class AlumnoBLL   
    {
        private AlumnoDAL alumnoDAL;
        public AlumnoBLL()
        {
            alumnoDAL = new AlumnoDAL();
        }
        
        public List<Alumno> GetAlumnos()
        {
            return alumnoDAL.GetAlumnos();
        }

        public Alumno GetAlumno(int id)
        {
            return alumnoDAL.GetAlumno(id);
        }
    }
}
