using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_Empleados.Model
{
    internal class SessionUser
    {
        static CUsuario usuarioActual;
        
        public static void SetUsuario(CUsuario usuario)
        {
            usuarioActual = usuario;
        }

        public static CUsuario GetUsuario()
        {
            return usuarioActual;
        }
    }
}
