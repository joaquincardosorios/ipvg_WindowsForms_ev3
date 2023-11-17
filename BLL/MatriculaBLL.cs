using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class MatriculaBLL
    {
        private MatriculaDAL matriculaDAL;
        public MatriculaBLL()
        {
            matriculaDAL = new MatriculaDAL();
        }

        public List<Matricula> GetMatriculas(Func<Matricula, bool> condition = null)
        {
            return matriculaDAL.GetMatriculas(condition);
        }

        public Matricula GetMatricula(int id)
        {
            return matriculaDAL.GetMatricula(id);
        }
        public void DeleteMatricula(int id)
        {
            if(!matriculaDAL.DeleteMatricula(id))
            {
                throw new Exception("No se ha podido eliminar la matricula");
            }
        }
        public void UpdateMatricula(Matricula matricula)
        {
            validarMatricula(matricula);
            if (!matriculaDAL.UpdateMatricula(matricula))
            {
                throw new Exception("No se ha podido modificar la matricula");
            }
        }
        public void addMatricula(Matricula matricula)
        {
            validarMatricula(matricula);
            if (!matriculaDAL.AddMatricula(matricula))
            {
                throw new Exception("No se ha podido agregar la nueva matricula");
            }
        }
        private void validarMatricula(Matricula matricula)
        {
            if (matricula.Codigo.Length > 5)
            {
                throw new Exception("Código no puede tener más de 5 caracteres");
            }
            if (matricula.Carrera.Length > 50)
            {
                throw new Exception("Código no puede tener más de 50 caracteres");
            }
            if (matricula.SegmentoAcademico.Length > 50)
            {
                throw new Exception("Código no puede tener más de 50 caracteres");
            }
        }

    }
}
