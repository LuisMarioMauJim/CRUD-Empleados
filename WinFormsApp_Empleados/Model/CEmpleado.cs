using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_Empleados.Model
{
    public class CEmpleado
    {
        public int pkempleado {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public int fkArea { get; set; }
        //public string CP { get; set; }


    }
}
