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
    public partial class Login : Form
    {
        Main Menu;
        CUsuario usuario;
        WUsuarios wUsuario;
        public Login()
        {
            InitializeComponent();
            usuario=new CUsuario();
            wUsuario=new WUsuarios();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCorreo.Text = string.Empty;
            txtContra.Text = string.Empty;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
        }

        private void ValidarUsuario()
        {
            if (!string.IsNullOrEmpty(txtCorreo.Text) && !string.IsNullOrEmpty(txtContra.Text))
            {
                if (ExisteConexion())
                {
                    CUsuario nuevo = new CUsuario();
                    {
                        nuevo.Correo = txtCorreo.Text;
                        nuevo.Contraseña = txtContra.Text;
                    }
                    DataSet userData = new DataSet();
                    if (wUsuario.ValidarUsuario(ref userData, nuevo))
                    {
                        prgBarra.Visible = true;
                        prgBarra.Maximum = 100;
                        tmrCarga.Start();

                        nuevo.pkUsuario = Convert.ToInt32(userData.Tables[0].Rows[0][0]);
                        nuevo.Nombre = Convert.ToString(userData.Tables[0].Rows[0][1]);
                        nuevo.Apellido = Convert.ToString(userData.Tables[0].Rows[0][2]);
                        nuevo.fkRol = Convert.ToInt32(userData.Tables[0].Rows[0][4]);
                        nuevo.Tema = Convert.ToString(userData.Tables[0].Rows[0][5]);
                        nuevo.Foto = Convert.ToInt32(userData.Tables[0].Rows[0][6]);
                        nuevo.ColorFoto = Convert.ToString(userData.Tables[0].Rows[0][7]);
                        SessionUser.SetUsuario(nuevo);
                    }
                    else
                    {
                        MessageBox.Show("Datos de acceso incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult = DialogResult.No;
                        txtCorreo.Text = "";
                        txtContra.Text = "";
                        txtCorreo.Focus();
                    }
                }
                else
                    MessageBox.Show("No hay conexión con el servidor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingresa los datos de acceso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private bool ExisteConexion()
        {
            bool existeConexion = false;
            existeConexion = wUsuario.ConnectionCheck();

            return existeConexion;
        }

        private void tmrCarga_Tick(object sender, EventArgs e)
        {
            if (prgBarra.Value == 100)
            {
                tmrCarga.Enabled = false;
                DialogResult = DialogResult.OK;
            }
            else
            {
                prgBarra.Value = prgBarra.Value + 1;
            }
        }

        private void txtContra_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keyascii = e.KeyData;
            switch (keyascii)
            {
                case Keys.Enter:
                    ValidarUsuario();
                    break;
                case Keys.Escape:
                    Application.Exit();
                    break;
            }
        }

        private void txtCorreo_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keyascii = e.KeyData;
            switch (keyascii)
            {
                case Keys.Escape:
                    Application.Exit();
                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            //Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
