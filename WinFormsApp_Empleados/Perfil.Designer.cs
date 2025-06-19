namespace WinFormsApp_Empleados
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.lblFoto = new System.Windows.Forms.Label();
            this.pnlPerfil = new System.Windows.Forms.Panel();
            this.imgFotoPerfil = new System.Windows.Forms.Label();
            this.imglFotos = new System.Windows.Forms.ImageList(this.components);
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.imgPerfil = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPicture4 = new System.Windows.Forms.Label();
            this.lblPicture3 = new System.Windows.Forms.Label();
            this.lblPicture2 = new System.Windows.Forms.Label();
            this.lblPicture = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlTema = new System.Windows.Forms.Panel();
            this.rdbDefault = new System.Windows.Forms.RadioButton();
            this.rdbOscuro = new System.Windows.Forms.RadioButton();
            this.rdbClaro = new System.Windows.Forms.RadioButton();
            this.lblTema = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.lblEditaFoto = new System.Windows.Forms.LinkLabel();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tltPerfil = new System.Windows.Forms.ToolTip(this.components);
            this.pnlPerfil.SuspendLayout();
            this.pnlImagen.SuspendLayout();
            this.pnlTema.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(394, 87);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(128, 29);
            this.lblFoto.TabIndex = 2;
            this.lblFoto.Tag = "N";
            this.lblFoto.Text = "Foto de perfil:";
            // 
            // pnlPerfil
            // 
            this.pnlPerfil.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlPerfil.Controls.Add(this.imgFotoPerfil);
            this.pnlPerfil.Controls.Add(this.pnlImagen);
            this.pnlPerfil.Controls.Add(this.pnlTema);
            this.pnlPerfil.Controls.Add(this.lblTema);
            this.pnlPerfil.Controls.Add(this.btnCancelar);
            this.pnlPerfil.Controls.Add(this.btnAplicar);
            this.pnlPerfil.Controls.Add(this.lblEditaFoto);
            this.pnlPerfil.Controls.Add(this.lblInfo2);
            this.pnlPerfil.Controls.Add(this.lblFoto);
            this.pnlPerfil.Controls.Add(this.lblRol);
            this.pnlPerfil.Controls.Add(this.lblCorreo);
            this.pnlPerfil.Controls.Add(this.lblApellido);
            this.pnlPerfil.Controls.Add(this.lblNombre);
            this.pnlPerfil.Controls.Add(this.lblInfo);
            this.pnlPerfil.Location = new System.Drawing.Point(68, 12);
            this.pnlPerfil.Name = "pnlPerfil";
            this.pnlPerfil.Size = new System.Drawing.Size(890, 691);
            this.pnlPerfil.TabIndex = 4;
            this.pnlPerfil.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPerfil_Paint);
            // 
            // imgFotoPerfil
            // 
            this.imgFotoPerfil.BackColor = System.Drawing.Color.White;
            this.imgFotoPerfil.ImageIndex = 0;
            this.imgFotoPerfil.ImageList = this.imglFotos;
            this.imgFotoPerfil.Location = new System.Drawing.Point(402, 119);
            this.imgFotoPerfil.Name = "imgFotoPerfil";
            this.imgFotoPerfil.Size = new System.Drawing.Size(188, 188);
            this.imgFotoPerfil.TabIndex = 30;
            // 
            // imglFotos
            // 
            this.imglFotos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglFotos.ImageStream")));
            this.imglFotos.TransparentColor = System.Drawing.Color.Transparent;
            this.imglFotos.Images.SetKeyName(0, "LogoHombre-removebg-preview.png");
            this.imglFotos.Images.SetKeyName(1, "LogoMujer-removebg-preview.png");
            this.imglFotos.Images.SetKeyName(2, "LogoHeli-removebg-preview.png");
            this.imglFotos.Images.SetKeyName(3, "LogoPingu-removebg-preview.png");
            // 
            // pnlImagen
            // 
            this.pnlImagen.BackColor = System.Drawing.Color.Silver;
            this.pnlImagen.Controls.Add(this.btnColor);
            this.pnlImagen.Controls.Add(this.panel1);
            this.pnlImagen.Controls.Add(this.label6);
            this.pnlImagen.Controls.Add(this.imgPerfil);
            this.pnlImagen.Controls.Add(this.label4);
            this.pnlImagen.Controls.Add(this.lblPicture4);
            this.pnlImagen.Controls.Add(this.lblPicture3);
            this.pnlImagen.Controls.Add(this.lblPicture2);
            this.pnlImagen.Controls.Add(this.lblPicture);
            this.pnlImagen.Controls.Add(this.lblImagen);
            this.pnlImagen.Controls.Add(this.btnCerrar);
            this.pnlImagen.Location = new System.Drawing.Point(126, 139);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Size = new System.Drawing.Size(675, 521);
            this.pnlImagen.TabIndex = 18;
            this.pnlImagen.Visible = false;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.White;
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnColor.Location = new System.Drawing.Point(237, 303);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(221, 35);
            this.btnColor.TabIndex = 29;
            this.btnColor.Tag = "N";
            this.btnColor.Text = "Color";
            this.tltPerfil.SetToolTip(this.btnColor, "Pulsa para elegir un color");
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(187, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 515);
            this.panel1.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 29);
            this.label6.TabIndex = 27;
            this.label6.Tag = "N";
            this.label6.Text = "Vista previa:";
            // 
            // imgPerfil
            // 
            this.imgPerfil.BackColor = System.Drawing.Color.White;
            this.imgPerfil.ImageIndex = 0;
            this.imgPerfil.ImageList = this.imglFotos;
            this.imgPerfil.Location = new System.Drawing.Point(15, 96);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.Size = new System.Drawing.Size(161, 152);
            this.imgPerfil.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 25;
            this.label4.Tag = "N";
            this.label4.Text = "Seleccionar color:";
            // 
            // lblPicture4
            // 
            this.lblPicture4.ImageIndex = 3;
            this.lblPicture4.ImageList = this.imglFotos;
            this.lblPicture4.Location = new System.Drawing.Point(559, 115);
            this.lblPicture4.Name = "lblPicture4";
            this.lblPicture4.Size = new System.Drawing.Size(110, 110);
            this.lblPicture4.TabIndex = 24;
            this.tltPerfil.SetToolTip(this.lblPicture4, "Click para elegir imagen");
            this.lblPicture4.Click += new System.EventHandler(this.lblPicture4_Click);
            // 
            // lblPicture3
            // 
            this.lblPicture3.ImageIndex = 2;
            this.lblPicture3.ImageList = this.imglFotos;
            this.lblPicture3.Location = new System.Drawing.Point(436, 115);
            this.lblPicture3.Name = "lblPicture3";
            this.lblPicture3.Size = new System.Drawing.Size(110, 110);
            this.lblPicture3.TabIndex = 23;
            this.tltPerfil.SetToolTip(this.lblPicture3, "Click para elegir imagen");
            this.lblPicture3.Click += new System.EventHandler(this.lblPicture3_Click);
            // 
            // lblPicture2
            // 
            this.lblPicture2.ImageIndex = 1;
            this.lblPicture2.ImageList = this.imglFotos;
            this.lblPicture2.Location = new System.Drawing.Point(322, 115);
            this.lblPicture2.Name = "lblPicture2";
            this.lblPicture2.Size = new System.Drawing.Size(110, 110);
            this.lblPicture2.TabIndex = 22;
            this.tltPerfil.SetToolTip(this.lblPicture2, "Click para elegir imagen");
            this.lblPicture2.Click += new System.EventHandler(this.lblPicture2_Click);
            // 
            // lblPicture
            // 
            this.lblPicture.ImageIndex = 0;
            this.lblPicture.ImageList = this.imglFotos;
            this.lblPicture.Location = new System.Drawing.Point(210, 115);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(110, 110);
            this.lblPicture.TabIndex = 21;
            this.tltPerfil.SetToolTip(this.lblPicture, "Click para elegir imagen");
            this.lblPicture.Click += new System.EventHandler(this.lblPicture_Click);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(223, 64);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(184, 29);
            this.lblImagen.TabIndex = 19;
            this.lblImagen.Tag = "N";
            this.lblImagen.Text = "Seleccionar imagen:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCerrar.Location = new System.Drawing.Point(370, 444);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(111, 46);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Tag = "N";
            this.btnCerrar.Text = "Cerrar";
            this.tltPerfil.SetToolTip(this.btnCerrar, "Pulsa para cerrar la edición");
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlTema
            // 
            this.pnlTema.Controls.Add(this.rdbDefault);
            this.pnlTema.Controls.Add(this.rdbOscuro);
            this.pnlTema.Controls.Add(this.rdbClaro);
            this.pnlTema.Location = new System.Drawing.Point(138, 442);
            this.pnlTema.Name = "pnlTema";
            this.pnlTema.Size = new System.Drawing.Size(405, 100);
            this.pnlTema.TabIndex = 17;
            // 
            // rdbDefault
            // 
            this.rdbDefault.AutoSize = true;
            this.rdbDefault.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDefault.Location = new System.Drawing.Point(25, 15);
            this.rdbDefault.Name = "rdbDefault";
            this.rdbDefault.Size = new System.Drawing.Size(96, 33);
            this.rdbDefault.TabIndex = 11;
            this.rdbDefault.TabStop = true;
            this.rdbDefault.Tag = "N";
            this.rdbDefault.Text = "Default";
            this.tltPerfil.SetToolTip(this.rdbDefault, "Elegir el tema clásico");
            this.rdbDefault.UseVisualStyleBackColor = true;
            this.rdbDefault.CheckedChanged += new System.EventHandler(this.rdbDefault_CheckedChanged);
            // 
            // rdbOscuro
            // 
            this.rdbOscuro.AutoSize = true;
            this.rdbOscuro.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOscuro.Location = new System.Drawing.Point(159, 15);
            this.rdbOscuro.Name = "rdbOscuro";
            this.rdbOscuro.Size = new System.Drawing.Size(93, 33);
            this.rdbOscuro.TabIndex = 12;
            this.rdbOscuro.TabStop = true;
            this.rdbOscuro.Tag = "N";
            this.rdbOscuro.Text = "Oscuro";
            this.tltPerfil.SetToolTip(this.rdbOscuro, "Elegir el tema oscuro");
            this.rdbOscuro.UseVisualStyleBackColor = true;
            this.rdbOscuro.CheckedChanged += new System.EventHandler(this.rdbOscuro_CheckedChanged);
            // 
            // rdbClaro
            // 
            this.rdbClaro.AutoSize = true;
            this.rdbClaro.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbClaro.Location = new System.Drawing.Point(284, 15);
            this.rdbClaro.Name = "rdbClaro";
            this.rdbClaro.Size = new System.Drawing.Size(79, 33);
            this.rdbClaro.TabIndex = 13;
            this.rdbClaro.TabStop = true;
            this.rdbClaro.Tag = "N";
            this.rdbClaro.Text = "Claro";
            this.tltPerfil.SetToolTip(this.rdbClaro, "Elegir el tema claro");
            this.rdbClaro.UseVisualStyleBackColor = true;
            this.rdbClaro.CheckedChanged += new System.EventHandler(this.rdbClaro_CheckedChanged);
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.Location = new System.Drawing.Point(42, 461);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(64, 29);
            this.lblTema.TabIndex = 14;
            this.lblTema.Tag = "N";
            this.lblTema.Text = "Tema:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(180, 617);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 43);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Tag = "N";
            this.btnCancelar.Text = "Cancelar";
            this.tltPerfil.SetToolTip(this.btnCancelar, "Pulsa para cancelar los cambios");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAplicar.Location = new System.Drawing.Point(408, 617);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(116, 43);
            this.btnAplicar.TabIndex = 9;
            this.btnAplicar.Tag = "N";
            this.btnAplicar.Text = "Aplicar";
            this.tltPerfil.SetToolTip(this.btnAplicar, "Pulsa para guardar los cambios");
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Visible = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // lblEditaFoto
            // 
            this.lblEditaFoto.AutoSize = true;
            this.lblEditaFoto.Location = new System.Drawing.Point(405, 314);
            this.lblEditaFoto.Name = "lblEditaFoto";
            this.lblEditaFoto.Size = new System.Drawing.Size(42, 16);
            this.lblEditaFoto.TabIndex = 3;
            this.lblEditaFoto.TabStop = true;
            this.lblEditaFoto.Text = "Editar";
            this.tltPerfil.SetToolTip(this.lblEditaFoto, "Pulda para editar la foto de perfil");
            this.lblEditaFoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEditaFoto_LinkClicked);
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblInfo2.Location = new System.Drawing.Point(40, 389);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(205, 38);
            this.lblInfo2.TabIndex = 8;
            this.lblInfo2.Tag = "N";
            this.lblInfo2.Text = "Personalización";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(42, 314);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(50, 29);
            this.lblRol.TabIndex = 7;
            this.lblRol.Tag = "N";
            this.lblRol.Text = "Rol: ";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(42, 246);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(78, 29);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Tag = "N";
            this.lblCorreo.Text = "Correo: ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(42, 183);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(87, 29);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Tag = "N";
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(42, 119);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 29);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Tag = "N";
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInfo.Location = new System.Drawing.Point(271, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(299, 38);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Tag = "N";
            this.lblInfo.Text = "Información del usuario";
            // 
            // tltPerfil
            // 
            this.tltPerfil.IsBalloon = true;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 715);
            this.Controls.Add(this.pnlPerfil);
            this.Name = "Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Perfil_Load);
            this.pnlPerfil.ResumeLayout(false);
            this.pnlPerfil.PerformLayout();
            this.pnlImagen.ResumeLayout(false);
            this.pnlImagen.PerformLayout();
            this.pnlTema.ResumeLayout(false);
            this.pnlTema.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.LinkLabel lblEditaFoto;
        private System.Windows.Forms.Panel pnlPerfil;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.RadioButton rdbClaro;
        private System.Windows.Forms.RadioButton rdbOscuro;
        private System.Windows.Forms.RadioButton rdbDefault;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Panel pnlTema;
        private System.Windows.Forms.Panel pnlImagen;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.ImageList imglFotos;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPicture4;
        private System.Windows.Forms.Label lblPicture3;
        private System.Windows.Forms.Label lblPicture2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label imgPerfil;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label imgFotoPerfil;
        private System.Windows.Forms.ToolTip tltPerfil;
    }
}