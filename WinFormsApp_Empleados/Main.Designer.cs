namespace WinFormsApp_Empleados
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btnEmpleados = new System.Windows.Forms.ToolStripButton();
            this.btnAreas = new System.Windows.Forms.ToolStripButton();
            this.btnUsuarios = new System.Windows.Forms.ToolStripButton();
            this.btnPerfil = new System.Windows.Forms.ToolStripButton();
            this.tmrTiempo = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStriplblLogo = new System.Windows.Forms.ToolStripLabel();
            this.toolStriplblEmpresa = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblFecha = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblUsuario = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnApagar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tltAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.toolStripMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEmpleados,
            this.btnAreas,
            this.btnUsuarios,
            this.btnPerfil});
            this.toolStripMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripMenu.Size = new System.Drawing.Size(301, 450);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Tag = "No";
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Font = new System.Drawing.Font("Palatino Linotype", 30F);
            this.btnEmpleados.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(300, 71);
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.ToolTipText = "Pulsa para gestionar empleados";
            this.btnEmpleados.Click += new System.EventHandler(this.toolStripEmpleados_Click);
            this.btnEmpleados.MouseLeave += new System.EventHandler(this.btnEmpleados_MouseLeave);
            this.btnEmpleados.MouseHover += new System.EventHandler(this.btnEmpleados_MouseHover);
            // 
            // btnAreas
            // 
            this.btnAreas.AutoSize = false;
            this.btnAreas.Font = new System.Drawing.Font("Palatino Linotype", 30F);
            this.btnAreas.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnAreas.Image = ((System.Drawing.Image)(resources.GetObject("btnAreas.Image")));
            this.btnAreas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAreas.Name = "btnAreas";
            this.btnAreas.Size = new System.Drawing.Size(157, 60);
            this.btnAreas.Text = "Áreas";
            this.btnAreas.ToolTipText = "Pulsa para gestionar áreas";
            this.btnAreas.Click += new System.EventHandler(this.btnAreas_Click);
            this.btnAreas.MouseLeave += new System.EventHandler(this.btnAreas_MouseLeave);
            this.btnAreas.MouseHover += new System.EventHandler(this.btnAreas_MouseHover);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Palatino Linotype", 30F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(248, 71);
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.ToolTipText = "Pulsa para gestionar usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnUsuarios.MouseLeave += new System.EventHandler(this.btnUsuarios_MouseLeave);
            this.btnUsuarios.MouseHover += new System.EventHandler(this.btnUsuarios_MouseHover);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Font = new System.Drawing.Font("Palatino Linotype", 30F);
            this.btnPerfil.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(168, 71);
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.ToolTipText = "Ver datos del perfil";
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            this.btnPerfil.MouseLeave += new System.EventHandler(this.btnPerfil_MouseLeave);
            this.btnPerfil.MouseHover += new System.EventHandler(this.btnPerfil_MouseHover);
            // 
            // tmrTiempo
            // 
            this.tmrTiempo.Enabled = true;
            this.tmrTiempo.Tick += new System.EventHandler(this.tmrTiempo_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStriplblLogo,
            this.toolStriplblEmpresa,
            this.toolStripSeparator3,
            this.lblFecha,
            this.toolStripSeparator2,
            this.lblUsuario});
            this.toolStrip1.Location = new System.Drawing.Point(301, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(720, 73);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStriplblLogo
            // 
            this.toolStriplblLogo.AutoSize = false;
            this.toolStriplblLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStriplblLogo.BackgroundImage")));
            this.toolStriplblLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStriplblLogo.Name = "toolStriplblLogo";
            this.toolStriplblLogo.Size = new System.Drawing.Size(70, 70);
            this.toolStriplblLogo.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStriplblEmpresa
            // 
            this.toolStriplblEmpresa.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStriplblEmpresa.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.toolStriplblEmpresa.Name = "toolStriplblEmpresa";
            this.toolStriplblEmpresa.Size = new System.Drawing.Size(247, 70);
            this.toolStriplblEmpresa.Text = "Industrias STARK";
            this.toolStriplblEmpresa.Click += new System.EventHandler(this.toolStriplblEmpresa_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 73);
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(76, 70);
            this.lblFecha.Text = "Fecha";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 73);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 70);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnApagar,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(301, 397);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(720, 53);
            this.toolStrip2.TabIndex = 23;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnApagar
            // 
            this.btnApagar.AutoSize = false;
            this.btnApagar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(50, 50);
            this.btnApagar.ToolTipText = "Pulsa para salir";
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 53);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.Crimson;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(149, 50);
            this.toolStripButton1.Text = "Cerrar Sesión";
            this.toolStripButton1.ToolTipText = "pulsa para cerrar sesión";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tltAyuda
            // 
            this.tltAyuda.IsBalloon = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1021, 450);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursos Humanos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btnEmpleados;
        private System.Windows.Forms.Timer tmrTiempo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStriplblLogo;
        private System.Windows.Forms.ToolStripLabel toolStriplblEmpresa;
        private System.Windows.Forms.ToolStripLabel lblFecha;
        private System.Windows.Forms.ToolStripButton btnAreas;
        private System.Windows.Forms.ToolStripButton btnUsuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblUsuario;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnApagar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnPerfil;
        private System.Windows.Forms.ToolTip tltAyuda;
    }
}

