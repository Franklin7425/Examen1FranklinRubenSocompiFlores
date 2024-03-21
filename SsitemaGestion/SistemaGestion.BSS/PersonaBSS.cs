using SistemaGestion.DAL;
using SistemaGestion.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.BSS
{
    public class PersonaBSS
    {
        PersonaDAL dal = new PersonaDAL();
        public DataTable ListarPersonasBss()
        {
            return dal.ListarPersonasDAL();
        }

        public void InsertarPersonasBss(Persona persona)
        {
            dal.InsertarPersonaDAL(persona);
        }

        public Persona ObtenerIdBss(int id)
        {
            return dal.ObtenerPersonaId(id);
        }

        public void EditarPersonaBss(Persona p)
        {
            dal.EditarPersonaDal(p);
        }

        public void EliminarPersonaBss(int id)
        {
            dal.EliminarPersonaDal(id);
        }
    }
}
