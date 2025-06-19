using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp_Empleados.Model;

namespace WinFormsApp_Empleados.Presenter
{
    internal class WEmpleados
    {
        ManagerBD managerBD;

        public WEmpleados()
        {
            managerBD = new ManagerBD();
        }
        public bool insertEmpleado(CEmpleado empleado)

        {

            bool registrado = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 1 });

            sqlParameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar) { Value = empleado.Nombre });
            sqlParameters.Add(new SqlParameter("@Apellidos", SqlDbType.NVarChar) { Value = empleado.Apellido });
            sqlParameters.Add(new SqlParameter("@Telefono", SqlDbType.NVarChar) { Value = empleado.Telefono });
            sqlParameters.Add(new SqlParameter("@Direccion", SqlDbType.NVarChar) { Value = empleado.Direccion });
            sqlParameters.Add(new SqlParameter("@Correo", SqlDbType.NVarChar) { Value = empleado.Correo });
            sqlParameters.Add(new SqlParameter("@fkArea", SqlDbType.Int) { Value = empleado.fkArea });
            //sqlParameters.Add(new SqlParameter("@CP", SqlDbType.NVarChar) { Value = empleado.CP });
            
            registrado = managerBD.UpdateData("spuEmpleados", sqlParameters.ToArray());


            return registrado;
        }
        public bool listEmpleados(ref DataSet ds)
        {
            bool hayRegistros = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 2 });
            ds = managerBD.GetData("spuEmpleados", sqlParameters.ToArray());
            if (ds.Tables[0].Rows.Count > 0)
            {
                hayRegistros = true;
            }
            return hayRegistros;
        }

        public bool ConnectionCheck() //verifica la disponiblididad de la conexion
        {
            bool conexionDisponible = false;
            SqlConnection connection = managerBD.GetConnection();
            if (connection.State == ConnectionState.Open)
                conexionDisponible = true;

            return conexionDisponible;
        }

        public bool updateEmpleado(CEmpleado empleado)

        {

            bool actualizado = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 4 });
            sqlParameters.Add(new SqlParameter("@pkEmpleado", SqlDbType.Int) { Value = empleado.pkempleado });
            sqlParameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar) { Value = empleado.Nombre });
            sqlParameters.Add(new SqlParameter("@Apellidos", SqlDbType.NVarChar) { Value = empleado.Apellido });
            sqlParameters.Add(new SqlParameter("@Telefono", SqlDbType.NVarChar) { Value = empleado.Telefono });
            sqlParameters.Add(new SqlParameter("@Direccion", SqlDbType.NVarChar) { Value = empleado.Direccion });
            sqlParameters.Add(new SqlParameter("@Correo", SqlDbType.NVarChar) { Value = empleado.Correo });
            sqlParameters.Add(new SqlParameter("@fkArea", SqlDbType.Int) { Value = empleado.fkArea });
            //sqlParameters.Add(new SqlParameter("@CP", SqlDbType.NVarChar) { Value = empleado.CP });

            actualizado = managerBD.UpdateData("spuEmpleados", sqlParameters.ToArray());


            return actualizado;
        }

        public bool deleteEmpleado(CEmpleado empleado)
        {
            bool eliminado = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 5 });
            sqlParameters.Add(new SqlParameter("@pkEmpleado", SqlDbType.Int) { Value = empleado.pkempleado });
            eliminado = managerBD.UpdateData("spuEmpleados", sqlParameters.ToArray());
            return eliminado;
        }
    }
}
