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
    public partial class Areas : Form
    {
        DataSet dsAreas;
        WAreas wAreas;
        WEmpleados wEmpleados;
        CTema cTema;
        public Areas()
        {
            InitializeComponent();
            wAreas = new WAreas();
            wEmpleados = new WEmpleados();
            cTema = new CTema();
        }

        private void Areas_Load(object sender, EventArgs e)
        {
            CUsuario usuarioLog = SessionUser.GetUsuario();
            if (usuarioLog != null)
            {
                cTema.SetTema(usuarioLog.Tema, this);
            }
            CargarAreas();
            txtDescripcion.Focus();
            txtDescripcion.Select();
        }

        private void CargarAreas()
        {
            if (ExisteConexion())
            {
                dsAreas = new DataSet();
                if (wAreas.listAreas(ref dsAreas))
                {
                    dtgListarAreas.DataSource = dsAreas.Tables[0];
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

        private bool ExisteConexion() //verifica la disponiblidad de la conexion
        {
            bool existeConexion = false;
            existeConexion = wEmpleados.ConnectionCheck();

            return existeConexion;
        }
        public void Limpiar()
        {
            txtClave.Text= string.Empty;
            txtDescripcion.Text= string.Empty;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
            btnRegistrar.Visible = true;
            txtDescripcion.Focus();
            limpiarValidacion();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dtgListarAreas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dtgListarAreas.CurrentRow;
            txtClave.Text = fila.Cells[0].Value.ToString();
            txtDescripcion.Text = fila.Cells[1].Value.ToString();
            btnActualizar.Visible = true;
            btnEliminar.Visible = true;
            btnRegistrar.Visible = false;
        }

        private void txtBuscarArea_TextChanged(object sender, EventArgs e)
        {
            dsAreas.Tables[0].DefaultView.RowFilter = "Descripcion like '%" + txtBuscarArea.Text + "%'";
            dtgListarAreas.DataSource = dsAreas.Tables[0].DefaultView;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            limpiarValidacion();
            if(ValidacionRequeridos())
            {
                CArea area = new CArea();
                {
                    area.Descripcion = txtDescripcion.Text;
                }
                if (wAreas.insertArea(area))
                {
                    MessageBox.Show("Registro exitoso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAreas();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Registro fallido, intente más tarde", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            limpiarValidacion();
            if(ValidacionRequeridos())
            {
                CArea actualizar = new CArea();
                {
                    actualizar.pkArea = Convert.ToInt32(txtClave.Text);
                    actualizar.Descripcion = txtDescripcion.Text;
                }
                if (wAreas.updateArea(actualizar))
                {
                    MessageBox.Show("Actualización exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAreas();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Actualización fallida, intente más tarde", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Desea eliminar el área de " + txtDescripcion.Text + " con clave: " + txtClave.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                CArea eliminar = new CArea();
                {
                    eliminar.pkArea = Convert.ToInt32(txtClave.Text);
                }
                if (wAreas.deleteArea(eliminar))
                {
                    MessageBox.Show("Eliminación exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAreas();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar, área ocupada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Limpiar();
            }
        }
        private void limpiarValidacion()
        {
            errorProvider.SetError(txtDescripcion, null);
        }

        public bool ValidacionRequeridos()
        {
            bool esRequerido = true;
            if(string.IsNullOrEmpty(txtDescripcion.Text))
            {
                errorProvider.SetError(txtDescripcion, "Requerido");
                esRequerido= false;
            }
            return esRequerido;
        }
        }
}
