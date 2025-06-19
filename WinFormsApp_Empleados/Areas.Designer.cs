namespace WinFormsApp_Empleados
{
    partial class Areas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Areas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblBuscarArea = new System.Windows.Forms.Label();
            this.txtBuscarArea = new System.Windows.Forms.TextBox();
            this.dtgListarAreas = new System.Windows.Forms.DataGridView();
            this.grpArea = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarAreas)).BeginInit();
            this.grpArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.Khaki;
            this.lblEmpresa.Location = new System.Drawing.Point(1098, 15);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(226, 37);
            this.lblEmpresa.TabIndex = 20;
            this.lblEmpresa.Text = "Industrias STARK";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(1330, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(76, 77);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 19;
            this.imgLogo.TabStop = false;
            // 
            // lblBuscarArea
            // 
            this.lblBuscarArea.AutoSize = true;
            this.lblBuscarArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBuscarArea.Location = new System.Drawing.Point(383, 70);
            this.lblBuscarArea.Name = "lblBuscarArea";
            this.lblBuscarArea.Size = new System.Drawing.Size(161, 29);
            this.lblBuscarArea.TabIndex = 21;
            this.lblBuscarArea.Text = "Buscar Áreas:";
            // 
            // txtBuscarArea
            // 
            this.txtBuscarArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBuscarArea.ForeColor = System.Drawing.Color.IndianRed;
            this.txtBuscarArea.Location = new System.Drawing.Point(550, 67);
            this.txtBuscarArea.Name = "txtBuscarArea";
            this.txtBuscarArea.Size = new System.Drawing.Size(532, 34);
            this.txtBuscarArea.TabIndex = 5;
            this.txtBuscarArea.TextChanged += new System.EventHandler(this.txtBuscarArea_TextChanged);
            // 
            // dtgListarAreas
            // 
            this.dtgListarAreas.AllowUserToAddRows = false;
            this.dtgListarAreas.AllowUserToDeleteRows = false;
            this.dtgListarAreas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgListarAreas.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgListarAreas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListarAreas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListarAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListarAreas.Location = new System.Drawing.Point(386, 130);
            this.dtgListarAreas.Name = "dtgListarAreas";
            this.dtgListarAreas.ReadOnly = true;
            this.dtgListarAreas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dtgListarAreas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgListarAreas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgListarAreas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgListarAreas.RowTemplate.Height = 24;
            this.dtgListarAreas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListarAreas.Size = new System.Drawing.Size(1020, 493);
            this.dtgListarAreas.TabIndex = 7;
            this.dtgListarAreas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListarAreas_CellClick);
            // 
            // grpArea
            // 
            this.grpArea.BackColor = System.Drawing.Color.Khaki;
            this.grpArea.Controls.Add(this.btnEliminar);
            this.grpArea.Controls.Add(this.txtClave);
            this.grpArea.Controls.Add(this.lblClave);
            this.grpArea.Controls.Add(this.btnActualizar);
            this.grpArea.Controls.Add(this.btnCancelar);
            this.grpArea.Controls.Add(this.btnRegistrar);
            this.grpArea.Controls.Add(this.lblDescripcion);
            this.grpArea.Controls.Add(this.txtDescripcion);
            this.grpArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grpArea.ForeColor = System.Drawing.SystemColors.MenuText;
            this.grpArea.Location = new System.Drawing.Point(12, 70);
            this.grpArea.Name = "grpArea";
            this.grpArea.Size = new System.Drawing.Size(350, 308);
            this.grpArea.TabIndex = 25;
            this.grpArea.TabStop = false;
            this.grpArea.Text = "Registro de áreas:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEliminar.Location = new System.Drawing.Point(228, 47);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 43);
            this.btnEliminar.TabIndex = 4;
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
            this.btnActualizar.Location = new System.Drawing.Point(183, 228);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(116, 43);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(38, 228);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 43);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegistrar.Location = new System.Drawing.Point(183, 228);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(116, 43);
            this.btnRegistrar.TabIndex = 27;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDescripcion.Location = new System.Drawing.Point(33, 104);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(147, 29);
            this.lblDescripcion.TabIndex = 21;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDescripcion.Location = new System.Drawing.Point(38, 157);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(286, 34);
            this.txtDescripcion.TabIndex = 1;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1418, 746);
            this.Controls.Add(this.grpArea);
            this.Controls.Add(this.lblBuscarArea);
            this.Controls.Add(this.txtBuscarArea);
            this.Controls.Add(this.dtgListarAreas);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.imgLogo);
            this.Name = "Areas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Areas";
            this.Load += new System.EventHandler(this.Areas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarAreas)).EndInit();
            this.grpArea.ResumeLayout(false);
            this.grpArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblBuscarArea;
        private System.Windows.Forms.TextBox txtBuscarArea;
        private System.Windows.Forms.DataGridView dtgListarAreas;
        private System.Windows.Forms.GroupBox grpArea;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}