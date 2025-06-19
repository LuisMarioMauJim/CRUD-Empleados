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
    public partial class Usuarios : Form
    {
        DataSet dsUsuarios;
        WUsuarios wusuarios;
        WRoles wRoles;
        CTema cTema;
        public Usuarios()
        {
            InitializeComponent();
            wusuarios=new WUsuarios();
            wRoles=new WRoles();
            cTema = new CTema();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Desea eliminar al usuario " + txtNombre.Text + " con clave: " + txtClave.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                CUsuario eliminar = new CUsuario();
                {
                    eliminar.pkUsuario = Convert.ToInt32(txtClave.Text);
                }
                if (wusuarios.deleteUsuario(eliminar))
                {
                    MessageBox.Show("Eliminación exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Eliminación fallida, intente más tarde", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Limpiar();
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CUsuario usuarioLog = SessionUser.GetUsuario();
            if (usuarioLog != null)
            {
                cTema.SetTema(usuarioLog.Tema, this);
            }
            CargarUsuarios();
            CargarRoles();
            txtNombre.Select();
        }

        private void CargarUsuarios()
        {
            if (ExisteConexion())
            {
                dsUsuarios = new DataSet();
                if (wusuarios.listUsuarios(ref dsUsuarios))
                {
                    dtgListarUsuarios.DataSource = dsUsuarios.Tables[0];

                    //ocultar columna de datagridview
                    dtgListarUsuarios.Columns[5].Visible = false;
                    dtgListarUsuarios.Columns[4].Visible = false;
                }
                else
                {
                    MessageBox.Show("No hay registros", "Información", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No hay conexion con el servidor", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteConexion() //verifica la disponiblidad de la conexion
        {
            bool existeConexion = false;
            existeConexion = wusuarios.ConnectionCheck();

            return existeConexion;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dsUsuarios.Tables[0].DefaultView.RowFilter = "Nombre like '%" + txtBuscar.Text + "%'";
            dtgListarUsuarios.DataSource = dsUsuarios.Tables[0].DefaultView;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            limpiarValidacion();
            if (ValidacionRequeridos())
            {
                if(txtContra.Text==txtConfirmaContra.Text)
                {
                    CUsuario nuevo = new CUsuario();
                    {
                        nuevo.Nombre = txtNombre.Text;
                        nuevo.Apellido = txtApellidos.Text;
                        nuevo.Correo = txtCorreo.Text;
                        nuevo.Contraseña = txtContra.Text;
                        nuevo.fkRol = Convert.ToInt32(cmbRoles.SelectedValue);
                    };
                    if (wusuarios.insertUsuario(nuevo))
                    {
                        MessageBox.Show("Registro exitoso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarUsuarios();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Registro fallido, intente más tarde", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    errorProvider.SetError(txtConfirmaContra, "Verifica la contraseña");
                }
            }
        }
        private void limpiarValidacion()
        {
            errorProvider.SetError(txtNombre, null);
            errorProvider.SetError(txtApellidos, null);
            errorProvider.SetError(txtCorreo, null);
            errorProvider.SetError(txtContra, null);
            errorProvider.SetError(txtConfirmaContra, null);
            errorProvider.SetError(cmbRoles, null);
        }

        public bool ValidacionRequeridos()
        {
            bool esRequerido = true;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "Requerido");
                esRequerido = false;
            }
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                errorProvider.SetError(txtApellidos, "Requerido");
                esRequerido = false;
            }
            if (string.IsNullOrEmpty(txtCorreo.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text,@"^[^\s]+@[^@s]+\.[^@\s]+$"))
            {
                errorProvider.SetError(txtCorreo, "Requerido");
                esRequerido = false;
            }
            if (string.IsNullOrEmpty(txtContra.Text))
            {
                errorProvider.SetError(txtContra, "Requerido");
                esRequerido = false;
            }
            if (string.IsNullOrEmpty(txtConfirmaContra.Text))
            {
                errorProvider.SetError(txtConfirmaContra, "Requerido");
                esRequerido = false;
            }
            if (cmbRoles.SelectedIndex == 0)
            {
                errorProvider.SetError(cmbRoles, "Seleccione un rol");
                esRequerido = false;
            }

            return esRequerido;
        }

        public void Limpiar()
        {
            txtClave.Text = string.Empty; //Forma correcta
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtCorreo.Text = "";
            txtContra.Text = "";
            txtConfirmaContra.Text= string.Empty;
            cmbRoles.SelectedIndex = 0;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
            btnRegistrar.Visible = true;
            txtNombre.Focus();
            limpiarValidacion();
        }

        private void CargarRoles()
        {
            if (ExisteConexion())
            {
                DataSet dsRoles = new DataSet();
                if (wRoles.listRoles(ref dsRoles))
                {
                    DataTable table = new DataTable();
                    table = dsRoles.Tables[0];

                    DataRow row = table.NewRow();
                    row["Descripcion"] = "Seleccione";
                    table.Rows.InsertAt(row, 0);

                    cmbRoles.DisplayMember = "Descripcion";
                    cmbRoles.ValueMember = "pkRol";
                    cmbRoles.DataSource = table;
                }
                else
                {
                    MessageBox.Show("No hay registro de áreas", "Información", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No hay conexion con el servidor", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            limpiarValidacion();
            if (ValidacionRequeridos())
            {
                if(txtContra.Text==txtConfirmaContra.Text)
                {
                    CUsuario actualizar = new CUsuario();
                    {
                        actualizar.pkUsuario = Convert.ToInt32(txtClave.Text);
                        actualizar.Nombre = txtNombre.Text;
                        actualizar.Apellido = txtApellidos.Text;
                        actualizar.Correo = txtCorreo.Text;
                        actualizar.Contraseña = txtContra.Text;
                        actualizar.fkRol = Convert.ToInt32(cmbRoles.SelectedValue);
                    };
                    if (wusuarios.updateUsuario(actualizar))
                    {
                        MessageBox.Show("Actualización exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarUsuarios();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Actualización fallida, intente más tarde", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    errorProvider.SetError(txtConfirmaContra, "Verifica la contraseña");
                }
            }
        }

        private void dtgListarUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dtgListarUsuarios.CurrentRow;
            txtClave.Text = fila.Cells[0].Value.ToString();
            txtNombre.Text = fila.Cells[1].Value.ToString();
            txtApellidos.Text = fila.Cells[2].Value.ToString();
            txtCorreo.Text = fila.Cells[3].Value.ToString();
            txtContra.Text = fila.Cells[4].Value.ToString();
            cmbRoles.SelectedValue = Convert.ToInt32(fila.Cells[5].Value);
            btnActualizar.Visible = true;
            btnEliminar.Visible = true;
            btnRegistrar.Visible = false;
            txtNombre.Focus();
        }
    }
}
