using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonaDAL
    {
        public void AddPersona(Persona persona)
        {
            using (InstituteDbContext db = new InstituteDbContext())
            {
                db.Persona.Add(persona);
                db.SaveChanges();
            }
        }

        public Persona GetPersona(int id)
        {
            using(InstituteDbContext db = new InstituteDbContext())
            {
                Persona persona = db.Persona.FirstOrDefault( x => x.PersonaId == id);
                if (persona == null)
                {
                    throw new InvalidOperationException("La persona no se encontró.");
                }
                return persona;
            }
        }


        public List<Persona> GetPersonas()
        {
            using (InstituteDbContext db = new InstituteDbContext())
            {
                return db.Persona.ToList();
            }
        }
        public void DeletePersona(string run)
        {
            using (InstituteDbContext db = new InstituteDbContext())
            {
                Persona p = db.Persona.FirstOrDefault(x => x.Run == run);
                if (p != null)
                {
                    db.Persona.Remove(p);
                    db.SaveChanges();
                } else
                {
                    throw new InvalidOperationException("La persona no se encontró.");
                }
            }
        }

        public void UpdatePersona(string run, Persona updatedPersona)
        {
            using (InstituteDbContext db = new InstituteDbContext())
            {
                Persona personaToUpdate = db.Persona.FirstOrDefault(p => p.Run == run);
                if (personaToUpdate != null)
                {
                    personaToUpdate.Run = updatedPersona.Run;
                    personaToUpdate.Nombre = updatedPersona.Nombre;
                    personaToUpdate.Apellido = updatedPersona.Apellido;
                    personaToUpdate.FechaNacimiento = updatedPersona.FechaNacimiento;
                    personaToUpdate.Direccion = updatedPersona.Direccion;
                    personaToUpdate.EstadoCivil = updatedPersona.EstadoCivil;
                    db.SaveChanges ();
                } else
                {
                    throw new InvalidOperationException("La persona no se encontró.");
                }
            }
        }
    }
}
