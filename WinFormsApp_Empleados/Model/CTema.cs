using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_Empleados.Model
{
    internal class CTema
    {
        public Color colorFondo { get; set; }
        public Color colorLetra { get; set; }
        public Color colorElementos { get; set; }

        static Form Main { get; set; }
        public CTema() { }

        public void SetTema(string Tema, Form Interfaz)
        {
            switch (Tema)
            {
                case "Default":
                    colorFondo = Color.MediumPurple;
                    colorLetra = Color.Black;
                    colorElementos = Color.Thistle;
                break;
                case "Oscuro":
                    colorFondo = Color.Black;
                    colorElementos = Color.Silver;
                    colorLetra = Color.White;
                break;
                case "Claro":
                    colorFondo = Color.LightBlue;
                    colorElementos = Color.Thistle;
                    colorLetra = Color.Black;
                    break;
            }
            Interfaz.BackColor = colorFondo;
            Interfaz.ForeColor = colorLetra;

            foreach(Control c in Interfaz.Controls)
            {
                if(c is Label && (c.Tag == null || c.Tag.ToString() != "N"))
                {
                    c.ForeColor = colorLetra;
                }
                if(c is GroupBox)
                {
                    c.BackColor = colorElementos;
                    c.ForeColor = Color.Black;
                }
            }
            Main.BackColor = colorFondo;
            Main.ForeColor = colorLetra;
            foreach (Control c in Main.Controls)
            {
                if (c is ToolStrip)
                {
                    if (Tema == "Default")
                    {
                        colorFondo = Color.LightGray;
                    }
                    c.BackColor = colorFondo;
                    c.ForeColor = colorLetra;
                    if (Tema == "Default" && (c.Tag != null && c.Tag.ToString() == "No"))
                    {
                        c.BackColor = Color.MidnightBlue;
                    }
                }
                if (c is GroupBox)
                {
                    c.BackColor = colorElementos;
                    c.ForeColor = Color.Black;
                }
            }
            
        }

        public void setMain(Form main)
        {
            Main = main;
        }
    }
}
