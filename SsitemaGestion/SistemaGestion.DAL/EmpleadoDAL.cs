using SistemaGestion.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.DAL
{
    public class EmpleadoDAL
    {
        public DataTable ListarEmpleadosDAL()
        {
            string consulta = "select * from empleado";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarEmpleadoDAL(Empleado empleado)
        {
            string consulta = "insert into empleado values(" +empleado.IdPersona + " ," +
                                                         "'" + empleado.Puesto + "' ," +
                                                         "" + empleado.Salario + " ," +
                                                         "'" + empleado.FechaContratacion.ToString("yyyy-MM-dd HH:mm:ss") + "' )";
            conexion.Ejecutar(consulta);
        }

        public Empleado ObtenerEmpleadoId(int id)
        {
            string consulta = "select * from empleado where idempleado =" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Empleado e = new Empleado();
            if (tabla.Rows.Count > 0)
            {
                e.IdEmpleado = Convert.ToInt32(tabla.Rows[0]["idempleado"]);
                e.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                e.Puesto = tabla.Rows[0]["puesto"].ToString();
                e.Salario = Convert.ToDecimal( tabla.Rows[0]["salario"].ToString());
                e.FechaContratacion = Convert.ToDateTime(tabla.Rows[0]["fechacontratacion"]);
            }
            return e;

        }

        public void EditarEmpleadoDal(Empleado e)
        {
            string consulta = "update empleado set idpersona='" + e.IdPersona + "'," +
                                                 "puesto='" + e.Puesto + "'," +
                                                 "salario = " + e.Salario + ", " +
                                                "fechacontratacion= '" + e.FechaContratacion.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                                           "where idempleado=" + e.IdEmpleado;

            conexion.Ejecutar(consulta);
        }

        public void EliminarEmpleadoDal(int id)
        {
            string consulta = "delete from empleado where idempleado =" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
