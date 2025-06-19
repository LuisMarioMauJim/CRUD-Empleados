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

namespace WinFormsApp_Empleados
{
    public partial class Main : Form
    {
        Empleados chEmpleados;
        Areas chAreas;
        Usuarios chUsuarios;
        Perfil chPerfil;
        CTema cTema;
        // private FilterInfoCollection Dispositivos;
        //private VideoCaptureDevice videoCaptureDevice
        public Main()
        {
            InitializeComponent();
            cTema = new CTema();
            Login frmAcceso = new Login();
            frmAcceso.ShowDialog();

            while (frmAcceso.DialogResult == DialogResult.No) 
            {
                frmAcceso.ShowDialog(this);
            }
        }

        private void toolStripEmpleados_Click(object sender, EventArgs e)
        {
            if(chEmpleados==null)
            {
                if (chAreas != null)
                {
                    chAreas.Close();
                }
                else if (chUsuarios != null)
                {
                    chUsuarios.Close();
                }
                else if (chPerfil != null)
                {
                    chPerfil.Close();
                }
                chEmpleados =new Empleados();
                chEmpleados.MdiParent = this;
                chEmpleados.FormClosed += new FormClosedEventHandler(chEmpleados_FormClosed);
                chEmpleados.Show();
                //Para hacer que otro form no se abra hasta que se cierre el actual
                //chEmpleados.mdiparent = this.parentform;
                //chsalarios.showdialog();

            }
            else
            {
                chEmpleados.Activate();
            }
            

        }

        private void chEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            chEmpleados = null;
        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString()+ "\nHora: "+ DateTime.Now.ToLongTimeString();
        }


        private void chAreas_FormClosed(object sender, FormClosedEventArgs e)
        {
            chAreas = null;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CUsuario usuarioLog = SessionUser.GetUsuario();
            if (usuarioLog != null)
            {
                cTema.setMain(this);
                cTema.SetTema(usuarioLog.Tema, this);
                string tipoUser = "";
                if (usuarioLog.fkRol == 1)
                {
                    tipoUser = "Admnistrador " + usuarioLog.Nombre;
                }
                else
                {
                    tipoUser = "Usuario " + usuarioLog.Nombre;
                    btnUsuarios.Visible = false;
                }
                lblUsuario.Text = tipoUser;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (chUsuarios == null)
            {
                if (chEmpleados != null)
                {
                    chEmpleados.Close();
                }
                else if (chAreas != null)
                {
                    chAreas.Close();
                }
                else if (chPerfil != null)
                {
                    chPerfil.Close();
                }
                chUsuarios = new Usuarios();
                chUsuarios.MdiParent = this;
                chUsuarios.FormClosed += new FormClosedEventHandler(chUsuarios_FormClosed);
                chUsuarios.Show();
            }
            else
            {
                chUsuarios.Activate();
            }
        }

        private void chUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            chUsuarios = null;
        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            if (chAreas == null)
            {
                if (chEmpleados != null)
                {
                    chEmpleados.Close();
                }else if(chUsuarios!=null){
                    chUsuarios.Close();
                }else if(chPerfil != null){
                    chPerfil.Close();
                }
                chAreas = new Areas();
                chAreas.MdiParent = this;
                chAreas.FormClosed += new FormClosedEventHandler(chAreas_FormClosed);
                chAreas.Show();
            }
            else
            {
                chAreas.Activate();
            }
        }

        private void toolStriplblEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnEmpleados_MouseHover(object sender, EventArgs e)
        {
            btnEmpleados.ForeColor= Color.Red;
        }

        private void btnEmpleados_MouseLeave(object sender, EventArgs e)
        {
            btnEmpleados.ForeColor = Color.CornflowerBlue;
        }

        private void btnAreas_MouseHover(object sender, EventArgs e)
        {
            btnAreas.ForeColor = Color.Red;
        }

        private void btnAreas_MouseLeave(object sender, EventArgs e)
        {
            btnAreas.ForeColor= Color.CornflowerBlue;
        }

        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.ForeColor = Color.Red;
        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.ForeColor=Color.CornflowerBlue;
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (chPerfil == null)
            {
                if (chEmpleados != null)
                {
                    chEmpleados.Close();
                }
                else if (chAreas != null)
                {
                    chAreas.Close();
                }
                else if (chUsuarios != null)
                {
                    chUsuarios.Close();
                }
                chPerfil = new Perfil();
                chPerfil.MdiParent = this;
                chPerfil.FormClosed += new FormClosedEventHandler(chPerfil_FormClosed);
                chPerfil.Show();
            }
            else
            {
                chPerfil.Activate();
            }
        }

        private void chPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            chPerfil = null;
        }

        private void btnPerfil_MouseHover(object sender, EventArgs e)
        {
            btnPerfil.ForeColor = Color.Red;
        }

        private void btnPerfil_MouseLeave(object sender, EventArgs e)
        {
            btnPerfil.ForeColor = Color.CornflowerBlue;
        }

        /*public void CargarDispositivos()
        {
            Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (CargarDispositivos.count > 0)
            {
                hayDispositivos = true;
                for(int i=0; i<CargarDispositivos().count; i++)
                {
                    cmbDispositivos.items.add(Dispositivos[i].name);
                }
            }
        }*/

        /* en un evento click de boton{
         {
            int i = cmbDispositivos.SelectedIndex;  //obtiene la opcion seleccionada
            string nombreVideo=Dispositivos[i].monikerString;  //monitorea
            videoCaptureDevice = new VideoCaptureDevice (nombreVideo);
            videocaptureDevice.NewFrame += new AForge.Video.NewFrameEventHandler(Captura);
            videocaptureDevice.Start();
        }
        */

        /*private void Captura(object sender, NewFrameEventArgs eventArgs)
         * {
         *  Bitmap imagen=(Bitmap))eventArgs.Frame.Clone();
         *  pictureBox1.Image = imagen;
         *  }*/

        /*en el evento FormClosed del formulario:
         * {
         *      if(videoCaptureDevice != null && videoCaptureDevice.IsRunning)
         *      {
         *          videoCaptureDevice.SignalToStop();
         *          videoCaptureDevice=null;
         *      }
         *    */

        /* En elvento click del boton 2 para hacer capturas:
         {
            if(videoCaptureDevice != null && videCaptureDevice.IsRunning)
            {
                pictureBox2.Image = pictureBox1.Image  
                pictureBox2.Image.Save("ruta"+"nombreArchivo"+".jpg", ImageFormat.Jpg); //para guardar (añadir libreria system.drawing)
            }
        }
        */
    }
}
//Para descargar recursos de imagenes: pixabay o fontawesome