using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MatriculaDAL
    {
        public bool AddMatricula(Matricula matricula)
        {
            using (InstituteDbContext db = new InstituteDbContext())
            {
                db.Matricula.Add(matricula);
                int rows = db.SaveChanges();
                if (rows == 0) { return false; }
                return true;
            }
        }
        public Matricula GetMatricula(int id)
        {
            using (InstituteDbContext db = new InstituteDbContext())
            {
                return db.Matricula.FirstOrDefault(x => x.MatriculaId == id);
            }
        }

        public List<Matricula> GetMatriculas(Func<Matricula, bool> condition = null)
        {
            using (InstituteDbContext db = new InstituteDbContext())
            {
                IQueryable<Matricula> query = db.Matricula;

                if (condition != null)
                {
                    query = query.Where(condition).AsQueryable(); ;
                }

                return query.ToList();
            }
        }

        public bool DeleteMatricula(int id)
        {
            using (InstituteDbContext db = new InstituteDbContext())
            {
                Matricula matriculaToDelete = this.GetMatricula(id);
                db.Matricula.Remove(matriculaToDelete);
                int rows = db.SaveChanges();
                if (rows == 0) { return false; }
                return true;
            }
        }
        public bool UpdateMatricula(Matricula updatedMatricula)
        {
            using (InstituteDbContext db = new InstituteDbContext())
            {
                Matricula matriculaToUpdate = this.GetMatricula(updatedMatricula.MatriculaId);
                if (matriculaToUpdate != null)
                {
                    matriculaToUpdate.Codigo = updatedMatricula.Codigo;
                    matriculaToUpdate.Fecha = updatedMatricula.Fecha;
                    matriculaToUpdate.Carrera = updatedMatricula.Carrera;
                    matriculaToUpdate.AnioMatricula = updatedMatricula.AnioMatricula;
                    matriculaToUpdate.SegmentoAcademico = updatedMatricula.SegmentoAcademico;
                    db.Matricula.AddOrUpdate(matriculaToUpdate);
                    int rows = db.SaveChanges();
                    if (rows == 0) { return false; }
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
