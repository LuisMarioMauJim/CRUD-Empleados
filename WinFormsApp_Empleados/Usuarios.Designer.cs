namespace WinFormsApp_Empleados
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.grpUsuarios = new System.Windows.Forms.GroupBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lblConfirmaContra = new System.Windows.Forms.Label();
            this.txtConfirmaContra = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtgListarUsuarios = new System.Windows.Forms.DataGridView();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.Silver;
            this.lblEmpresa.Location = new System.Drawing.Point(1083, 17);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(226, 37);
            this.lblEmpresa.TabIndex = 23;
            this.lblEmpresa.Tag = "N";
            this.lblEmpresa.Text = "Industrias STARK";
            // 
            // grpUsuarios
            // 
            this.grpUsuarios.BackColor = System.Drawing.Color.Thistle;
            this.grpUsuarios.Controls.Add(this.lblRol);
            this.grpUsuarios.Controls.Add(this.cmbRoles);
            this.grpUsuarios.Controls.Add(this.lblConfirmaContra);
            this.grpUsuarios.Controls.Add(this.txtConfirmaContra);
            this.grpUsuarios.Controls.Add(this.btnEliminar);
            this.grpUsuarios.Controls.Add(this.txtClave);
            this.grpUsuarios.Controls.Add(this.lblClave);
            this.grpUsuarios.Controls.Add(this.btnActualizar);
            this.grpUsuarios.Controls.Add(this.btnCancelar);
            this.grpUsuarios.Controls.Add(this.btnRegistrar);
            this.grpUsuarios.Controls.Add(this.lblApellido);
            this.grpUsuarios.Controls.Add(this.lblContra);
            this.grpUsuarios.Controls.Add(this.lblCorreo);
            this.grpUsuarios.Controls.Add(this.lblNombre);
            this.grpUsuarios.Controls.Add(this.txtCorreo);
            this.grpUsuarios.Controls.Add(this.txtContra);
            this.grpUsuarios.Controls.Add(this.txtApellidos);
            this.grpUsuarios.Controls.Add(this.txtNombre);
            this.grpUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grpUsuarios.ForeColor = System.Drawing.SystemColors.MenuText;
            this.grpUsuarios.Location = new System.Drawing.Point(10, 20);
            this.grpUsuarios.Name = "grpUsuarios";
            this.grpUsuarios.Size = new System.Drawing.Size(350, 683);
            this.grpUsuarios.TabIndex = 22;
            this.grpUsuarios.TabStop = false;
            this.grpUsuarios.Text = "Registro de usuarios";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblRol.Location = new System.Drawing.Point(36, 498);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(56, 29);
            this.lblRol.TabIndex = 34;
            this.lblRol.Text = "Rol:";
            // 
            // cmbRoles
            // 
            this.cmbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(40, 530);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(242, 37);
            this.cmbRoles.TabIndex = 6;
            // 
            // lblConfirmaContra
            // 
            this.lblConfirmaContra.AutoSize = true;
            this.lblConfirmaContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblConfirmaContra.Location = new System.Drawing.Point(35, 419);
            this.lblConfirmaContra.Name = "lblConfirmaContra";
            this.lblConfirmaContra.Size = new System.Drawing.Size(265, 29);
            this.lblConfirmaContra.TabIndex = 32;
            this.lblConfirmaContra.Text = "Confirma la contraseña:";
            // 
            // txtConfirmaContra
            // 
            this.txtConfirmaContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtConfirmaContra.Location = new System.Drawing.Point(38, 450);
            this.txtConfirmaContra.Name = "txtConfirmaContra";
            this.txtConfirmaContra.PasswordChar = '*';
            this.txtConfirmaContra.Size = new System.Drawing.Size(242, 34);
            this.txtConfirmaContra.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEliminar.Location = new System.Drawing.Point(228, 47);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 43);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtClave.Location = new System.Drawing.Point(119, 50);
            this.txtClave.Name = "txtClave";
            this.txtClave.ReadOnly = true;
            this.txtClave.Size = new System.Drawing.Size(99, 34);
            this.txtClave.TabIndex = 0;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblClave.Location = new System.Drawing.Point(33, 50);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(80, 29);
            this.lblClave.TabIndex = 30;
            this.lblClave.Text = "Clave:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnActualizar.Location = new System.Drawing.Point(181, 621);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(116, 43);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(36, 621);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 43);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegistrar.Location = new System.Drawing.Point(181, 621);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(116, 43);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblApellido.Location = new System.Drawing.Point(33, 180);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(108, 29);
            this.lblApellido.TabIndex = 26;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblContra.Location = new System.Drawing.Point(33, 338);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(142, 29);
            this.lblContra.TabIndex = 25;
            this.lblContra.Text = "Contraseña:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCorreo.Location = new System.Drawing.Point(33, 258);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(94, 29);
            this.lblCorreo.TabIndex = 23;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNombre.Location = new System.Drawing.Point(33, 99);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 29);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCorreo.Location = new System.Drawing.Point(36, 290);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(242, 34);
            this.txtCorreo.TabIndex = 3;
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtContra.Location = new System.Drawing.Point(36, 369);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(242, 34);
            this.txtContra.TabIndex = 4;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtApellidos.Location = new System.Drawing.Point(36, 212);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(242, 34);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtNombre.Location = new System.Drawing.Point(36, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 34);
            this.txtNombre.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBuscar.Location = new System.Drawing.Point(379, 55);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(178, 29);
            this.lblBuscar.TabIndex = 19;
            this.lblBuscar.Text = "Buscar usuario:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBuscar.ForeColor = System.Drawing.Color.IndianRed;
            this.txtBuscar.Location = new System.Drawing.Point(563, 52);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(494, 34);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dtgListarUsuarios
            // 
            this.dtgListarUsuarios.AllowUserToAddRows = false;
            this.dtgListarUsuarios.AllowUserToDeleteRows = false;
            this.dtgListarUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgListarUsuarios.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgListarUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListarUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListarUsuarios.Location = new System.Drawing.Point(371, 119);
            this.dtgListarUsuarios.Name = "dtgListarUsuarios";
            this.dtgListarUsuarios.ReadOnly = true;
            this.dtgListarUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dtgListarUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgListarUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgListarUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgListarUsuarios.RowTemplate.Height = 24;
            this.dtgListarUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListarUsuarios.Size = new System.Drawing.Size(1020, 493);
            this.dtgListarUsuarios.TabIndex = 21;
            this.dtgListarUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListarUsuarios_CellClick);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(1315, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(76, 77);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 24;
            this.imgLogo.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1400, 715);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.grpUsuarios);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dtgListarUsuarios);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.grpUsuarios.ResumeLayout(false);
            this.grpUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.GroupBox grpUsuarios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dtgListarUsuarios;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblConfirmaContra;
        private System.Windows.Forms.TextBox txtConfirmaContra;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRoles;
    }
}