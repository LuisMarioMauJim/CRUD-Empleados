using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_Empleados.Model;
using WinFormsApp_Empleados.Presenter;

namespace WinFormsApp_Empleados
{
    public partial class Perfil : Form
    {
        CTema cTema;
        WUsuarios wusuarios;
        public Perfil()
        {
            InitializeComponent();
            cTema = new CTema();
            wusuarios = new WUsuarios();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Perfil_Load(object sender, EventArgs e)
        {

            CUsuario usuarioLog = SessionUser.GetUsuario();
            if (usuarioLog != null)
            {
                cTema.SetTema(usuarioLog.Tema, this);
                btnAplicar.ForeColor = Color.Black;
                btnCancelar.ForeColor = Color.Black;
                string rol;
                lblNombre.Text = lblNombre.Text + usuarioLog.Nombre;
                lblApellido.Text = lblApellido.Text + usuarioLog.Apellido;
                lblCorreo.Text=lblCorreo.Text+ usuarioLog.Correo;
                if (usuarioLog.fkRol == 1)
                    rol = "Administrador";
                else
                    rol = "Usuario";
                lblRol.Text = lblRol.Text + rol;
                //lblPrueba.Text = usuarioLog.Tema;
                switch (usuarioLog.Tema) {
                    case "Default":
                        rdbDefault.Checked = true; 
                    break;
                    case "Oscuro":
                        rdbOscuro.Checked = true; 
                    break;
                    case "Claro":
                        rdbClaro.Checked = true;
                    break;
                }
            }
            imgFotoPerfil.ImageIndex = usuarioLog.Foto;
            imgPerfil.ImageIndex = usuarioLog.Foto;
            if(usuarioLog.ColorFoto.Length == 8)
            {
                string hexColor = usuarioLog.ColorFoto;
                // Convertir la cadena hexadecimal en enteros
                int a = int.Parse(hexColor.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                int r = int.Parse(hexColor.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                int g = int.Parse(hexColor.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                int b = int.Parse(hexColor.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);

                // Crear el color usando Color.FromArgb
                Color color = Color.FromArgb(a, r, g, b);

                imgPerfil.BackColor = color;
                imgFotoPerfil.BackColor = color;
                colorDialog.Color = color;
                btnColor.BackColor = color;
            }
            else
            {
                imgPerfil.BackColor = Color.FromName(usuarioLog.ColorFoto);
                imgFotoPerfil.BackColor = Color.FromName(usuarioLog.ColorFoto);
                colorDialog.Color = Color.FromName(usuarioLog.ColorFoto);
                btnColor.BackColor = Color.FromName(usuarioLog.ColorFoto);
            }

        }

        private void rdbClaro_CheckedChanged(object sender, EventArgs e)
        {
            validarCambio(rdbClaro);
        }

        private void validarCambio(RadioButton rdb)
        {
            CUsuario usuarioLog = SessionUser.GetUsuario();
            if (usuarioLog != null)
            {
                if (usuarioLog.Tema != rdb.Text)
                {
                    btnAplicar.Visible = true;
                    btnCancelar.Visible = true;
                }
                else
                {
                    btnAplicar.Visible = false;
                    btnCancelar.Visible = false;
                }
            }
        }

        private void rdbOscuro_CheckedChanged(object sender, EventArgs e)
        {
            validarCambio(rdbOscuro);
        }

        private void rdbDefault_CheckedChanged(object sender, EventArgs e)
        {
            validarCambio(rdbDefault);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CUsuario usuarioLog = SessionUser.GetUsuario();
            switch (usuarioLog.Tema)
            {
                case "Default":
                    rdbDefault.Checked = true;
                    break;
                case "Oscuro":
                    rdbOscuro.Checked = true;
                    break;
                case "Claro":
                    rdbClaro.Checked = true;
                    break;
            }
        }

        private bool ExisteConexion() //verifica la disponiblidad de la conexion
        {
            bool existeConexion = false;
            existeConexion = wusuarios.ConnectionCheck();

            return existeConexion;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            CUsuario usuarioLog = SessionUser.GetUsuario();
            CUsuario actualizar = new CUsuario();
            {
                foreach (Control control in pnlTema.Controls)
                {
                    if (control is RadioButton radioButton && radioButton.Checked)
                    {
                        actualizar.Tema = radioButton.Text;
                    }
                }
                actualizar.pkUsuario = usuarioLog.pkUsuario;
                actualizar.Foto = imgFotoPerfil.ImageIndex;
                Color color = imgFotoPerfil.BackColor;
                actualizar.ColorFoto = color.Name;
                actualizar.Nombre = usuarioLog.Nombre;
                actualizar.Apellido = usuarioLog.Apellido;
                actualizar.Correo= usuarioLog.Correo;

            };
            if (wusuarios.updatePerfil(actualizar))
            {
                MessageBox.Show("Actualización exitosa: "+actualizar.Tema, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SessionUser.SetUsuario(actualizar);
                cTema.SetTema(actualizar.Tema, this);
                btnAplicar.Visible = false;
                btnCancelar.Visible = false;
                btnAplicar.ForeColor = Color.Black;
                btnCancelar.ForeColor = Color.Black;
                
            }
            else
            {
                MessageBox.Show("Actualización fallida, intente más tarde", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblPicture_Click(object sender, EventArgs e)
        {
            imgPerfil.ImageIndex=0;
            imgFotoPerfil.ImageIndex = 0;
        }

        private void lblPicture2_Click(object sender, EventArgs e)
        {
            imgPerfil.ImageIndex = 1;
            imgFotoPerfil.ImageIndex = 1;
            btnAplicar.Visible = true;
        }

        private void lblPicture3_Click(object sender, EventArgs e)
        {
            imgPerfil.ImageIndex = 2;
            imgFotoPerfil.ImageIndex = 2;
            btnAplicar.Visible = true;
        }

        private void lblPicture4_Click(object sender, EventArgs e)
        {
            imgPerfil.ImageIndex = 3;
            imgFotoPerfil.ImageIndex = 3;
            btnAplicar.Visible = true;
        }

        private void lblEditaFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlImagen.Visible = true;
            imgFotoPerfil.Visible = false;
            btnAplicar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;
                imgPerfil.BackColor = colorDialog.Color;
                imgFotoPerfil.BackColor = colorDialog.Color;
                btnAplicar.Visible= true;
            }
        }

        private void pnlPerfil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pnlImagen.Visible=false;
            imgFotoPerfil.Visible = true;
        }

        private void imgFotoPerfil_StyleChanged(object sender, EventArgs e)
        {
            btnAplicar.Visible = true;
        }
    }
}
