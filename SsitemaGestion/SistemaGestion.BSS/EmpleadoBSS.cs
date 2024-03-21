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
    public class EmpleadoBSS
    {
        EmpleadoDAL dal = new EmpleadoDAL();
        public DataTable ListarEmpleadosBss()
        {
            return dal.ListarEmpleadosDAL();
        }

        public void InsertarEmpleadosBss(Empleado empleado)
        {
            dal.InsertarEmpleadoDAL(empleado);
        }

        public Empleado ObtenerIdBss(int id)
        {
            return dal.ObtenerEmpleadoId(id);
        }

        public void EditarEmpleadoBss(Empleado e)
        {
            dal.EditarEmpleadoDal(e);
        }

        public void EliminarEmpleadoBss(int id)
        {
            dal.EliminarEmpleadoDal(id);
        }
    }
}
