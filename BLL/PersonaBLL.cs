using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class PersonaBLL
    {
        private PersonaDAL personaDAL;
        public PersonaBLL()
        {
            personaDAL = new PersonaDAL();
        }

        public List<Persona> GetPersonas()
        {
            return personaDAL.GetPersonas();
        }

        public Persona GetPersona(int id)
        {
            return personaDAL.GetPersona(id);
        }

    }
}
