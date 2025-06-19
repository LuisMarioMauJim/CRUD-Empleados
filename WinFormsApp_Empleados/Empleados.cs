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
    public partial class Empleados : Form
    {
        WEmpleados wEmpleados; //Se crea una variable de la clase
        WAreas wAreas;
        DataSet dsEmpleados;
        CTema cTema;
        public Empleados()
        {
            InitializeComponent();
            wEmpleados=new WEmpleados(); //Se crea el objeto de la variable de la casa
            wAreas = new WAreas();
            cTema = new CTema();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            CUsuario usuarioLog = SessionUser.GetUsuario();
            if (usuarioLog != null)
            {
                cTema.SetTema(usuarioLog.Tema, this);
            }
            CargarEmpleados();
            CargarAreas();
            txtNombre.Focus();
            txtNombre.Select();
            
        }

        private void CargarAreas()
        {
            if(ExisteConexion())
            {
                DataSet dsAreas = new DataSet();
                if (wAreas.listAreas(ref dsAreas))
                {
                    DataTable table =new DataTable();
                    table = dsAreas.Tables[0];

                    DataRow row = table.NewRow();
                    row["Descripcion"] = "Seleccione";
                    table.Rows.InsertAt(row, 0);

                    cmbAreas.DisplayMember = "Descripcion";
                    cmbAreas.ValueMember = "pkArea";
                    cmbAreas.DataSource = table;
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

        private void CargarEmpleados()
        {
            if(ExisteConexion())
            {
                dsEmpleados = new DataSet();
                if (wEmpleados.listEmpleados(ref dsEmpleados))
                {
                    dtgListarEmpleados.DataSource= dsEmpleados.Tables[0];

                    //ocultar columna de datagridview
                    dtgListarEmpleados.Columns[7].Visible = false;
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
            existeConexion = wEmpleados.ConnectionCheck();

            return existeConexion;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dsEmpleados.Tables[0].DefaultView.RowFilter = "Nombre like '%" + txtBuscar.Text + "%'";
            dtgListarEmpleados.DataSource = dsEmpleados.Tables[0].DefaultView;
        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            limpiarValidacion();
            if(ValidacionRequeridos())
            {
                CEmpleado nuevo = new CEmpleado();
                {
                    nuevo.Nombre = txtNombre.Text;
                    nuevo.Apellido = txtApellidos.Text;
                    nuevo.Telefono = txtTelefono.Text;
                    nuevo.Direccion = txtDireccion.Text;
                    nuevo.Correo = txtCorreo.Text;
                    nuevo.fkArea = Convert.ToInt32(cmbAreas.SelectedValue);
                };
                if (wEmpleados.insertEmpleado(nuevo))
                {
                    MessageBox.Show("Registro exitoso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEmpleados();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Registro fallido, intente más tarde", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void limpiarValidacion()
        {
            errorProvider.SetError(txtNombre, null);
            errorProvider.SetError(txtApellidos, null);
            errorProvider.SetError(txtTelefono, null);
            errorProvider.SetError(txtDireccion, null);
            errorProvider.SetError(txtCorreo, null);
            errorProvider.SetError(cmbAreas,null);
        }

        public bool ValidacionRequeridos()
        {
            bool esRequerido = true;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "Requerido");
                esRequerido= false;
            }
            if(string.IsNullOrEmpty(txtApellidos.Text))
            {
                errorProvider.SetError(txtApellidos, "Requerido");
                esRequerido = false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text) || txtTelefono.Text.Length!=10 || txtTelefono.Text.Any(char.IsDigit)==false)
            {
                errorProvider.SetError(txtTelefono, "Requerido");
                esRequerido = false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                errorProvider.SetError(txtDireccion, "Requerido");
                esRequerido = false;
            }
            if (string.IsNullOrEmpty(txtCorreo.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text, @"^[^\s]+@[^@s]+\.[^@\s]+$"))
            {
                errorProvider.SetError(txtCorreo, "Requerido");
                esRequerido = false;
            }
            if (cmbAreas.SelectedIndex == 0)
            {
                errorProvider.SetError(cmbAreas, "Seleccione un área");
                esRequerido = false;
            }

            return esRequerido;
        }
        private void dtgListarEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dtgListarEmpleados.CurrentRow;
            txtClave.Text = fila.Cells[0].Value.ToString();
            //String[] nombreCompleto = fila.Cells[1].Value.ToString().Split(' ');
            //txtNombre.Text = nombreCompleto[0];
            //txtApellidos.Text= nombreCompleto[1];
            txtNombre.Text= fila.Cells[1].Value.ToString();
            txtApellidos.Text = fila.Cells[2].Value.ToString();
            txtTelefono.Text = fila.Cells[3].Value.ToString();
            txtDireccion.Text = fila.Cells[4].Value.ToString();
            txtCorreo.Text= fila.Cells[5].Value.ToString();
            cmbAreas.SelectedValue = Convert.ToInt32(fila.Cells[7].Value);
            btnActualizar.Visible = true;
            btnEliminar.Visible = true;
            btnRegistrar.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            limpiarValidacion();
            if (ValidacionRequeridos())
            {
                CEmpleado actualizar = new CEmpleado();
                {
                    actualizar.pkempleado = Convert.ToInt32(txtClave.Text);
                    actualizar.Nombre = txtNombre.Text;
                    actualizar.Apellido = txtApellidos.Text;
                    actualizar.Telefono = txtTelefono.Text;
                    actualizar.Direccion = txtDireccion.Text;
                    actualizar.Correo = txtCorreo.Text;
                    actualizar.fkArea = Convert.ToInt32(cmbAreas.SelectedValue);
                };
                if (wEmpleados.updateEmpleado(actualizar))
                {
                    MessageBox.Show("Actualización exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEmpleados();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Actualización fallida, intente más tarde", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Limpiar()
        {
            txtClave.Text = string.Empty; //Forma correcta
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            cmbAreas.SelectedIndex = 0;
            btnActualizar.Visible= false;
            btnEliminar.Visible= false;
            btnRegistrar.Visible = true;
            txtNombre.Focus();
            limpiarValidacion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Desea eliminar al empleado " + txtNombre.Text + " con clave: "+txtClave.Text+"?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                CEmpleado eliminar = new CEmpleado();
                {
                    eliminar.pkempleado = Convert.ToInt32(txtClave.Text);
                }
                if (wEmpleados.deleteEmpleado(eliminar))
                {
                    MessageBox.Show("Eliminación exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEmpleados();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
