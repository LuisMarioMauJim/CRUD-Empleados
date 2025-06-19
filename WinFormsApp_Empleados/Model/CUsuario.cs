using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_Empleados.Model
{
    public class CUsuario
    {
        public int pkUsuario { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public int fkRol { get; set; }
        public string Tema { get; set;}
        public int Foto { get; set; }
        public string ColorFoto { get; set; }
    }
}
