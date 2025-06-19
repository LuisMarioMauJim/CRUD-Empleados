using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp_Empleados.Model;

namespace WinFormsApp_Empleados.Presenter
{
    public class WAreas
    {
        ManagerBD managerBD;
        public WAreas()
        {
            managerBD=new ManagerBD();
        }
        public bool listAreas(ref DataSet ds)
        {
            bool hayRegistros = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 3 });
            ds = managerBD.GetData("spuEmpleados", sqlParameters.ToArray());
            if (ds.Tables[0].Rows.Count > 0)
            {
                hayRegistros = true;
            }
            return hayRegistros;
        }

        public bool insertArea(CArea area)
        {
            bool registrado = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 6 });

            sqlParameters.Add(new SqlParameter("@Descripcion", SqlDbType.NVarChar) { Value = area.Descripcion});

            registrado = managerBD.UpdateData("spuEmpleados", sqlParameters.ToArray());


            return registrado;
        }

        public bool updateArea(CArea area)

        {

            bool actualizado = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 7 });
            sqlParameters.Add(new SqlParameter("@pkArea", SqlDbType.Int) { Value = area.pkArea });
            sqlParameters.Add(new SqlParameter("@Descripcion", SqlDbType.NVarChar) { Value = area.Descripcion });

            actualizado = managerBD.UpdateData("spuEmpleados", sqlParameters.ToArray());


            return actualizado;
        }

        public bool deleteArea(CArea area)
        {
            bool eliminado = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 8 });
            sqlParameters.Add(new SqlParameter("@pkArea", SqlDbType.Int) { Value = area.pkArea });
            eliminado = managerBD.UpdateData("spuEmpleados", sqlParameters.ToArray());
            return eliminado;
        }
    }
}
