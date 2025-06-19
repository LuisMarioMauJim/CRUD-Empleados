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
    internal class WUsuarios
    {
        ManagerBD managerBD;

        public WUsuarios()
        {
            managerBD = new ManagerBD();
        }

        public bool insertUsuario(CUsuario usuario)
        {
            bool registrado = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 1 });

            sqlParameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar) { Value = usuario.Nombre });
            sqlParameters.Add(new SqlParameter("@Apellido", SqlDbType.NVarChar) { Value = usuario.Apellido });
            sqlParameters.Add(new SqlParameter("@Correo", SqlDbType.NVarChar) { Value = usuario.Correo });
            sqlParameters.Add(new SqlParameter("@Contraseña", SqlDbType.NVarChar) { Value = usuario.Contraseña });
            sqlParameters.Add(new SqlParameter("@fkRol", SqlDbType.Int) { Value = usuario.fkRol });

            registrado = managerBD.UpdateData("spuUsuario", sqlParameters.ToArray());


            return registrado;
        }

        public bool listUsuarios(ref DataSet ds)
        {
            bool hayRegistros = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 3 });
            ds = managerBD.GetData("spuUsuario", sqlParameters.ToArray());
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

        public bool updateUsuario(CUsuario usuario)

        {

            bool actualizado = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 5 });
            sqlParameters.Add(new SqlParameter("@pkUsuario", SqlDbType.Int) { Value = usuario.pkUsuario });
            sqlParameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar) { Value = usuario.Nombre });
            sqlParameters.Add(new SqlParameter("@Apellido", SqlDbType.NVarChar) { Value = usuario.Apellido });
            sqlParameters.Add(new SqlParameter("@Correo", SqlDbType.NVarChar) { Value = usuario.Correo });
            sqlParameters.Add(new SqlParameter("@Contraseña", SqlDbType.NVarChar) { Value = usuario.Contraseña });
            sqlParameters.Add(new SqlParameter("@fkRol", SqlDbType.Int) { Value = usuario.fkRol });

            actualizado = managerBD.UpdateData("spuUsuario", sqlParameters.ToArray());


            return actualizado;
        }

        public bool deleteUsuario(CUsuario usuario)
        {
            bool eliminado = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 6 });
            sqlParameters.Add(new SqlParameter("@pkUsuario", SqlDbType.Int) { Value = usuario.pkUsuario});
            eliminado = managerBD.UpdateData("spuUsuario", sqlParameters.ToArray());
            return eliminado;
        }

        public bool ValidarUsuario(ref DataSet ds, CUsuario nuevo)
        {
            bool hayRegistro = false;

            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 2 });
            sqlParameters.Add(new SqlParameter("@Correo", SqlDbType.NVarChar) { Value = nuevo.Correo });
            sqlParameters.Add(new SqlParameter("@Contraseña", SqlDbType.NVarChar) { Value = nuevo.Contraseña });
            ds = managerBD.GetData("spuUsuario", sqlParameters.ToArray());
            if (ds.Tables[0].Rows.Count > 0) //revisar
            {
                hayRegistro = true;
            }
            return hayRegistro;
        }

        public bool updatePerfil(CUsuario usuario)
        {
            bool actualizado = false;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@opcion", SqlDbType.Int) { Value = 7 });
            sqlParameters.Add(new SqlParameter("@pkUsuario", SqlDbType.Int) { Value = usuario.pkUsuario });
            sqlParameters.Add(new SqlParameter("@Tema", SqlDbType.NVarChar) { Value = usuario.Tema });
            sqlParameters.Add(new SqlParameter("@Foto", SqlDbType.Int) { Value = usuario.Foto });
            sqlParameters.Add(new SqlParameter("@ColorFoto", SqlDbType.NVarChar) { Value = usuario.ColorFoto });

            actualizado = managerBD.UpdateData("spuUsuario", sqlParameters.ToArray());


            return actualizado;
        }
    }
}
