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
    public class WRoles
    {
        ManagerBD managerBD;
        public WRoles() { 
            managerBD = new ManagerBD();
        }

        public bool listRoles(ref DataSet ds)
        {
            bool hayRegistros = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 4 });
            ds = managerBD.GetData("spuUsuario", sqlParameters.ToArray());
            if (ds.Tables[0].Rows.Count > 0)
            {
                hayRegistros = true;
            }
            return hayRegistros;
        }
    }
}
