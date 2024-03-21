using SistemaGestion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaGestion.DAL
{
    public class PersonaDAL
    {
        public DataTable ListarPersonasDAL()
        {
            string consulta = "select * from persona";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarPersonaDAL(Persona persona)
        {
            string consulta = "insert into persona values('" + persona.Nombre + "' ," +
                                                         "'" + persona.Apellido + "' ," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public Persona ObtenerPersonaId(int id)
        {
            string consulta = "select * from persona where idpersona =" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Persona p = new Persona();
            if (tabla.Rows.Count > 0)
            {
                p.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Apellido = tabla.Rows[0]["apellido"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;

        }

        public void EditarPersonaDal(Persona p)
        {
            string consulta = "update persona set nombre='" + p.Nombre + "'," +
                                                 "apellido='" + p.Apellido + "'" +
                                           "where idpersona=" + p.IdPersona;

            conexion.Ejecutar(consulta);
        }

        public void EliminarPersonaDal(int id)
        {
            string consulta = "delete from persona where idpersona =" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
