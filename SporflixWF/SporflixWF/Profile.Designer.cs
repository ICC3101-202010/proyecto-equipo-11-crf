namespace Spotflix
{
    partial class Profile
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.bAtrasProfile = new System.Windows.Forms.Button();
            this.tNombreProfile = new System.Windows.Forms.TextBox();
            this.panelImagenPerfil = new System.Windows.Forms.Panel();
            this.bEditProfile = new System.Windows.Forms.Button();
            this.bUserOptions = new System.Windows.Forms.Button();
            this.pIntroProfile = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bVerUsuario = new System.Windows.Forms.Button();
            this.bAtrasIntroProfile = new System.Windows.Forms.Button();
            this.labelPlaylist = new System.Windows.Forms.Label();
            this.labelFollowers = new System.Windows.Forms.Label();
            this.labelFollowing = new System.Windows.Forms.Label();
            this.pEditarProfile = new System.Windows.Forms.Panel();
            this.panelEditarNombre = new System.Windows.Forms.Panel();
            this.bCambiarEditar = new System.Windows.Forms.Button();
            this.checkBoxPublica = new System.Windows.Forms.CheckBox();
            this.checkBoxPrivada = new System.Windows.Forms.CheckBox();
            this.LabelIngresarNuevo = new System.Windows.Forms.Label();
            this.textBoxIngresarNuevo = new System.Windows.Forms.TextBox();
            this.bEditarProfile = new System.Windows.Forms.Button();
            this.buttonAtrasEditarProfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEditarProfile = new System.Windows.Forms.ComboBox();
            this.panelOpcionesUsuario = new System.Windows.Forms.Panel();
            this.panelCambiarOpcionesUsuario = new System.Windows.Forms.Panel();
            this.labelInsertTitle = new System.Windows.Forms.Label();
            this.textBoxNombreCancion = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelPremium = new System.Windows.Forms.Label();
            this.buttonUpdateOpciones = new System.Windows.Forms.Button();
            this.bAtrasCambiarOpciones = new System.Windows.Forms.Button();
            this.labelCambio = new System.Windows.Forms.Label();
            this.checkBoxNo = new System.Windows.Forms.CheckBox();
            this.checkBoxSi = new System.Windows.Forms.CheckBox();
            this.buttonSeleccionarOpcionUsuario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOpcionesUsuario = new System.Windows.Forms.ComboBox();
            this.bAtrasOpciones = new System.Windows.Forms.Button();
            this.openFoto = new System.Windows.Forms.OpenFileDialog();
            this.openMusic = new System.Windows.Forms.OpenFileDialog();
            this.openVideo = new System.Windows.Forms.OpenFileDialog();
            this.pIntroProfile.SuspendLayout();
            this.pEditarProfile.SuspendLayout();
            this.panelEditarNombre.SuspendLayout();
            this.panelOpcionesUsuario.SuspendLayout();
            this.panelCambiarOpcionesUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAtrasProfile
            // 
            this.bAtrasProfile.Location = new System.Drawing.Point(96, 292);
            this.bAtrasProfile.Name = "bAtrasProfile";
            this.bAtrasProfile.Size = new System.Drawing.Size(75, 23);
            this.bAtrasProfile.TabIndex = 0;
            this.bAtrasProfile.Text = "back";
            this.bAtrasProfile.UseVisualStyleBackColor = true;
            this.bAtrasProfile.Click += new System.EventHandler(this.bAtrasProfile_Click);
            // 
            // tNombreProfile
            // 
            this.tNombreProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.tNombreProfile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tNombreProfile.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombreProfile.ForeColor = System.Drawing.SystemColors.Window;
            this.tNombreProfile.Location = new System.Drawing.Point(256, 182);
            this.tNombreProfile.Name = "tNombreProfile";
            this.tNombreProfile.Size = new System.Drawing.Size(123, 20);
            this.tNombreProfile.TabIndex = 1;
            this.tNombreProfile.Text = "Nombre Usuario";
            this.tNombreProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelImagenPerfil
            // 
            this.panelImagenPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelImagenPerfil.BackgroundImage")));
            this.panelImagenPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImagenPerfil.Location = new System.Drawing.Point(256, 48);
            this.panelImagenPerfil.Name = "panelImagenPerfil";
            this.panelImagenPerfil.Size = new System.Drawing.Size(123, 119);
            this.panelImagenPerfil.TabIndex = 2;
            // 
            // bEditProfile
            // 
            this.bEditProfile.Location = new System.Drawing.Point(279, 292);
            this.bEditProfile.Name = "bEditProfile";
            this.bEditProfile.Size = new System.Drawing.Size(75, 23);
            this.bEditProfile.TabIndex = 3;
            this.bEditProfile.Text = "Edit profile";
            this.bEditProfile.UseVisualStyleBackColor = true;
            this.bEditProfile.Click += new System.EventHandler(this.bEditProfile_Click);
            // 
            // bUserOptions
            // 
            this.bUserOptions.Location = new System.Drawing.Point(453, 292);
            this.bUserOptions.Name = "bUserOptions";
            this.bUserOptions.Size = new System.Drawing.Size(75, 23);
            this.bUserOptions.TabIndex = 4;
            this.bUserOptions.Text = "User options";
            this.bUserOptions.UseVisualStyleBackColor = true;
            this.bUserOptions.Click += new System.EventHandler(this.bUserOptions_Click);
            // 
            // pIntroProfile
            // 
            this.pIntroProfile.Controls.Add(this.label1);
            this.pIntroProfile.Controls.Add(this.bVerUsuario);
            this.pIntroProfile.Controls.Add(this.bAtrasIntroProfile);
            this.pIntroProfile.Location = new System.Drawing.Point(0, 0);
            this.pIntroProfile.Name = "pIntroProfile";
            this.pIntroProfile.Size = new System.Drawing.Size(631, 364);
            this.pIntroProfile.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(163, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Would you Like to See your User?";
            // 
            // bVerUsuario
            // 
            this.bVerUsuario.Location = new System.Drawing.Point(358, 231);
            this.bVerUsuario.Name = "bVerUsuario";
            this.bVerUsuario.Size = new System.Drawing.Size(75, 23);
            this.bVerUsuario.TabIndex = 1;
            this.bVerUsuario.Text = "See User";
            this.bVerUsuario.UseVisualStyleBackColor = true;
            this.bVerUsuario.Click += new System.EventHandler(this.bVerUsuario_Click);
            // 
            // bAtrasIntroProfile
            // 
            this.bAtrasIntroProfile.Location = new System.Drawing.Point(198, 231);
            this.bAtrasIntroProfile.Name = "bAtrasIntroProfile";
            this.bAtrasIntroProfile.Size = new System.Drawing.Size(75, 23);
            this.bAtrasIntroProfile.TabIndex = 0;
            this.bAtrasIntroProfile.Text = "back";
            this.bAtrasIntroProfile.UseVisualStyleBackColor = true;
            this.bAtrasIntroProfile.Click += new System.EventHandler(this.bAtrasIntroProfile_Click);
            // 
            // labelPlaylist
            // 
            this.labelPlaylist.AutoSize = true;
            this.labelPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaylist.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPlaylist.Location = new System.Drawing.Point(113, 231);
            this.labelPlaylist.Name = "labelPlaylist";
            this.labelPlaylist.Size = new System.Drawing.Size(87, 16);
            this.labelPlaylist.TabIndex = 3;
            this.labelPlaylist.Text = "Playlists:    ";
            // 
            // labelFollowers
            // 
            this.labelFollowers.AutoSize = true;
            this.labelFollowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFollowers.ForeColor = System.Drawing.SystemColors.Window;
            this.labelFollowers.Location = new System.Drawing.Point(253, 231);
            this.labelFollowers.Name = "labelFollowers";
            this.labelFollowers.Size = new System.Drawing.Size(95, 16);
            this.labelFollowers.TabIndex = 6;
            this.labelFollowers.Text = "Followers:    ";
            // 
            // labelFollowing
            // 
            this.labelFollowing.AutoSize = true;
            this.labelFollowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFollowing.ForeColor = System.Drawing.SystemColors.Window;
            this.labelFollowing.Location = new System.Drawing.Point(413, 231);
            this.labelFollowing.Name = "labelFollowing";
            this.labelFollowing.Size = new System.Drawing.Size(94, 16);
            this.labelFollowing.TabIndex = 7;
            this.labelFollowing.Text = "Following:    ";
            // 
            // pEditarProfile
            // 
            this.pEditarProfile.Controls.Add(this.panelEditarNombre);
            this.pEditarProfile.Controls.Add(this.bEditarProfile);
            this.pEditarProfile.Controls.Add(this.buttonAtrasEditarProfile);
            this.pEditarProfile.Controls.Add(this.label2);
            this.pEditarProfile.Controls.Add(this.comboBoxEditarProfile);
            this.pEditarProfile.Location = new System.Drawing.Point(3, 0);
            this.pEditarProfile.Name = "pEditarProfile";
            this.pEditarProfile.Size = new System.Drawing.Size(625, 361);
            this.pEditarProfile.TabIndex = 3;
            this.pEditarProfile.Visible = false;
            // 
            // panelEditarNombre
            // 
            this.panelEditarNombre.Controls.Add(this.bCambiarEditar);
            this.panelEditarNombre.Controls.Add(this.checkBoxPublica);
            this.panelEditarNombre.Controls.Add(this.checkBoxPrivada);
            this.panelEditarNombre.Controls.Add(this.LabelIngresarNuevo);
            this.panelEditarNombre.Controls.Add(this.textBoxIngresarNuevo);
            this.panelEditarNombre.Location = new System.Drawing.Point(56, 48);
            this.panelEditarNombre.Name = "panelEditarNombre";
            this.panelEditarNombre.Size = new System.Drawing.Size(506, 286);
            this.panelEditarNombre.TabIndex = 4;
            this.panelEditarNombre.Visible = false;
            // 
            // bCambiarEditar
            // 
            this.bCambiarEditar.Location = new System.Drawing.Point(189, 229);
            this.bCambiarEditar.Name = "bCambiarEditar";
            this.bCambiarEditar.Size = new System.Drawing.Size(174, 23);
            this.bCambiarEditar.TabIndex = 4;
            this.bCambiarEditar.Text = "Change";
            this.bCambiarEditar.UseVisualStyleBackColor = true;
            this.bCambiarEditar.Click += new System.EventHandler(this.bCambiarEditar_Click);
            // 
            // checkBoxPublica
            // 
            this.checkBoxPublica.AutoSize = true;
            this.checkBoxPublica.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBoxPublica.Location = new System.Drawing.Point(294, 149);
            this.checkBoxPublica.Name = "checkBoxPublica";
            this.checkBoxPublica.Size = new System.Drawing.Size(55, 17);
            this.checkBoxPublica.TabIndex = 3;
            this.checkBoxPublica.Text = "Public";
            this.checkBoxPublica.UseVisualStyleBackColor = true;
            this.checkBoxPublica.Visible = false;
            // 
            // checkBoxPrivada
            // 
            this.checkBoxPrivada.AutoSize = true;
            this.checkBoxPrivada.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBoxPrivada.Location = new System.Drawing.Point(189, 149);
            this.checkBoxPrivada.Name = "checkBoxPrivada";
            this.checkBoxPrivada.Size = new System.Drawing.Size(59, 17);
            this.checkBoxPrivada.TabIndex = 2;
            this.checkBoxPrivada.Text = "Private";
            this.checkBoxPrivada.UseVisualStyleBackColor = true;
            this.checkBoxPrivada.Visible = false;
            // 
            // LabelIngresarNuevo
            // 
            this.LabelIngresarNuevo.AutoSize = true;
            this.LabelIngresarNuevo.ForeColor = System.Drawing.SystemColors.Window;
            this.LabelIngresarNuevo.Location = new System.Drawing.Point(20, 125);
            this.LabelIngresarNuevo.Name = "LabelIngresarNuevo";
            this.LabelIngresarNuevo.Size = new System.Drawing.Size(0, 13);
            this.LabelIngresarNuevo.TabIndex = 1;
            // 
            // textBoxIngresarNuevo
            // 
            this.textBoxIngresarNuevo.Location = new System.Drawing.Point(189, 122);
            this.textBoxIngresarNuevo.Name = "textBoxIngresarNuevo";
            this.textBoxIngresarNuevo.Size = new System.Drawing.Size(185, 20);
            this.textBoxIngresarNuevo.TabIndex = 0;
            // 
            // bEditarProfile
            // 
            this.bEditarProfile.Location = new System.Drawing.Point(336, 260);
            this.bEditarProfile.Name = "bEditarProfile";
            this.bEditarProfile.Size = new System.Drawing.Size(75, 23);
            this.bEditarProfile.TabIndex = 3;
            this.bEditarProfile.Text = "Edit";
            this.bEditarProfile.UseVisualStyleBackColor = true;
            this.bEditarProfile.Click += new System.EventHandler(this.bEditarProfile_Click);
            // 
            // buttonAtrasEditarProfile
            // 
            this.buttonAtrasEditarProfile.Location = new System.Drawing.Point(173, 260);
            this.buttonAtrasEditarProfile.Name = "buttonAtrasEditarProfile";
            this.buttonAtrasEditarProfile.Size = new System.Drawing.Size(75, 23);
            this.buttonAtrasEditarProfile.TabIndex = 2;
            this.buttonAtrasEditarProfile.Text = "back";
            this.buttonAtrasEditarProfile.UseVisualStyleBackColor = true;
            this.buttonAtrasEditarProfile.Click += new System.EventHandler(this.buttonAtrasEditarProfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(169, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "What Would you Like to Edit?";
            // 
            // comboBoxEditarProfile
            // 
            this.comboBoxEditarProfile.FormattingEnabled = true;
            this.comboBoxEditarProfile.Items.AddRange(new object[] {
            "Change Username",
            "Change Password",
            "Change Privacy",
            "Change Profile Picture"});
            this.comboBoxEditarProfile.Location = new System.Drawing.Point(173, 170);
            this.comboBoxEditarProfile.Name = "comboBoxEditarProfile";
            this.comboBoxEditarProfile.Size = new System.Drawing.Size(238, 21);
            this.comboBoxEditarProfile.TabIndex = 0;
            // 
            // panelOpcionesUsuario
            // 
            this.panelOpcionesUsuario.Controls.Add(this.panelCambiarOpcionesUsuario);
            this.panelOpcionesUsuario.Controls.Add(this.buttonSeleccionarOpcionUsuario);
            this.panelOpcionesUsuario.Controls.Add(this.label4);
            this.panelOpcionesUsuario.Controls.Add(this.label3);
            this.panelOpcionesUsuario.Controls.Add(this.comboBoxOpcionesUsuario);
            this.panelOpcionesUsuario.Controls.Add(this.bAtrasOpciones);
            this.panelOpcionesUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelOpcionesUsuario.Name = "panelOpcionesUsuario";
            this.panelOpcionesUsuario.Size = new System.Drawing.Size(625, 358);
            this.panelOpcionesUsuario.TabIndex = 3;
            this.panelOpcionesUsuario.Visible = false;
            // 
            // panelCambiarOpcionesUsuario
            // 
            this.panelCambiarOpcionesUsuario.Controls.Add(this.labelInsertTitle);
            this.panelCambiarOpcionesUsuario.Controls.Add(this.textBoxNombreCancion);
            this.panelCambiarOpcionesUsuario.Controls.Add(this.textBoxPath);
            this.panelCambiarOpcionesUsuario.Controls.Add(this.labelPath);
            this.panelCambiarOpcionesUsuario.Controls.Add(this.labelPremium);
            this.panelCambiarOpcionesUsuario.Controls.Add(this.buttonUpdateOpciones);
            this.panelCambiarOpcionesUsuario.Controls.Add(this.bAtrasCambiarOpciones);
            this.panelCambiarOpcionesUsuario.Controls.Add(this.labelCambio);
            this.panelCambiarOpcionesUsuario.Controls.Add(this.checkBoxNo);
            this.panelCambiarOpcionesUsuario.Controls.Add(this.checkBoxSi);
            this.panelCambiarOpcionesUsuario.Location = new System.Drawing.Point(6, 82);
            this.panelCambiarOpcionesUsuario.Name = "panelCambiarOpcionesUsuario";
            this.panelCambiarOpcionesUsuario.Size = new System.Drawing.Size(619, 252);
            this.panelCambiarOpcionesUsuario.TabIndex = 5;
            this.panelCambiarOpcionesUsuario.Visible = false;
            // 
            // labelInsertTitle
            // 
            this.labelInsertTitle.AutoSize = true;
            this.labelInsertTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.labelInsertTitle.Location = new System.Drawing.Point(39, 140);
            this.labelInsertTitle.Name = "labelInsertTitle";
            this.labelInsertTitle.Size = new System.Drawing.Size(74, 13);
            this.labelInsertTitle.TabIndex = 8;
            this.labelInsertTitle.Text = "Insert the Title";
            this.labelInsertTitle.Visible = false;
            // 
            // textBoxNombreCancion
            // 
            this.textBoxNombreCancion.Location = new System.Drawing.Point(253, 137);
            this.textBoxNombreCancion.Name = "textBoxNombreCancion";
            this.textBoxNombreCancion.Size = new System.Drawing.Size(269, 20);
            this.textBoxNombreCancion.TabIndex = 6;
            this.textBoxNombreCancion.Visible = false;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(253, 74);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(269, 20);
            this.textBoxPath.TabIndex = 7;
            this.textBoxPath.Visible = false;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.labelPath.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPath.Location = new System.Drawing.Point(39, 78);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(142, 13);
            this.labelPath.TabIndex = 6;
            this.labelPath.Text = "Insert the Path to Add Media";
            this.labelPath.Visible = false;
            // 
            // labelPremium
            // 
            this.labelPremium.AutoSize = true;
            this.labelPremium.BackColor = System.Drawing.Color.Red;
            this.labelPremium.Location = new System.Drawing.Point(90, 52);
            this.labelPremium.Name = "labelPremium";
            this.labelPremium.Size = new System.Drawing.Size(35, 13);
            this.labelPremium.TabIndex = 5;
            this.labelPremium.Text = "label5";
            // 
            // buttonUpdateOpciones
            // 
            this.buttonUpdateOpciones.Location = new System.Drawing.Point(323, 181);
            this.buttonUpdateOpciones.Name = "buttonUpdateOpciones";
            this.buttonUpdateOpciones.Size = new System.Drawing.Size(117, 23);
            this.buttonUpdateOpciones.TabIndex = 4;
            this.buttonUpdateOpciones.Text = "Update";
            this.buttonUpdateOpciones.UseVisualStyleBackColor = true;
            this.buttonUpdateOpciones.Click += new System.EventHandler(this.buttonUpdateOpciones_Click);
            // 
            // bAtrasCambiarOpciones
            // 
            this.bAtrasCambiarOpciones.Location = new System.Drawing.Point(150, 181);
            this.bAtrasCambiarOpciones.Name = "bAtrasCambiarOpciones";
            this.bAtrasCambiarOpciones.Size = new System.Drawing.Size(117, 23);
            this.bAtrasCambiarOpciones.TabIndex = 3;
            this.bAtrasCambiarOpciones.Text = "back";
            this.bAtrasCambiarOpciones.UseVisualStyleBackColor = true;
            this.bAtrasCambiarOpciones.Click += new System.EventHandler(this.bAtrasCambiarOpciones_Click);
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.ForeColor = System.Drawing.SystemColors.Window;
            this.labelCambio.Location = new System.Drawing.Point(39, 116);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(35, 13);
            this.labelCambio.TabIndex = 2;
            this.labelCambio.Text = "label5";
            this.labelCambio.Visible = false;
            // 
            // checkBoxNo
            // 
            this.checkBoxNo.AutoSize = true;
            this.checkBoxNo.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBoxNo.Location = new System.Drawing.Point(442, 114);
            this.checkBoxNo.Name = "checkBoxNo";
            this.checkBoxNo.Size = new System.Drawing.Size(80, 17);
            this.checkBoxNo.TabIndex = 1;
            this.checkBoxNo.Text = "checkBox2";
            this.checkBoxNo.UseVisualStyleBackColor = true;
            this.checkBoxNo.Visible = false;
            // 
            // checkBoxSi
            // 
            this.checkBoxSi.AutoSize = true;
            this.checkBoxSi.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBoxSi.Location = new System.Drawing.Point(268, 115);
            this.checkBoxSi.Name = "checkBoxSi";
            this.checkBoxSi.Size = new System.Drawing.Size(80, 17);
            this.checkBoxSi.TabIndex = 0;
            this.checkBoxSi.Text = "checkBox1";
            this.checkBoxSi.UseVisualStyleBackColor = true;
            this.checkBoxSi.Visible = false;
            // 
            // buttonSeleccionarOpcionUsuario
            // 
            this.buttonSeleccionarOpcionUsuario.Location = new System.Drawing.Point(339, 263);
            this.buttonSeleccionarOpcionUsuario.Name = "buttonSeleccionarOpcionUsuario";
            this.buttonSeleccionarOpcionUsuario.Size = new System.Drawing.Size(107, 23);
            this.buttonSeleccionarOpcionUsuario.TabIndex = 4;
            this.buttonSeleccionarOpcionUsuario.Text = "Select";
            this.buttonSeleccionarOpcionUsuario.UseVisualStyleBackColor = true;
            this.buttonSeleccionarOpcionUsuario.Click += new System.EventHandler(this.buttonSeleccionarOpcionUsuario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(248, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(96, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "What Would You Like To Do?";
            // 
            // comboBoxOpcionesUsuario
            // 
            this.comboBoxOpcionesUsuario.FormattingEnabled = true;
            this.comboBoxOpcionesUsuario.Items.AddRange(new object[] {
            "Change Membership",
            "Add Song",
            "Add Video",
            "Change Admin Attribute",
            "Log Out"});
            this.comboBoxOpcionesUsuario.Location = new System.Drawing.Point(258, 169);
            this.comboBoxOpcionesUsuario.Name = "comboBoxOpcionesUsuario";
            this.comboBoxOpcionesUsuario.Size = new System.Drawing.Size(225, 21);
            this.comboBoxOpcionesUsuario.TabIndex = 1;
            // 
            // bAtrasOpciones
            // 
            this.bAtrasOpciones.Location = new System.Drawing.Point(144, 263);
            this.bAtrasOpciones.Name = "bAtrasOpciones";
            this.bAtrasOpciones.Size = new System.Drawing.Size(107, 23);
            this.bAtrasOpciones.TabIndex = 0;
            this.bAtrasOpciones.Text = "back";
            this.bAtrasOpciones.UseVisualStyleBackColor = true;
            this.bAtrasOpciones.Click += new System.EventHandler(this.bAtrasOpciones_Click);
            // 
            // openFoto
            // 
            this.openFoto.FileName = "openFileDialog1";
            this.openFoto.Filter = "Archivos PNG (*.png)|*.png";
            // 
            // openMusic
            // 
            this.openMusic.FileName = "openMusic";
            this.openMusic.Filter = "Archivos MP3 (*.mp3)|*.mp3";
            // 
            // openVideo
            // 
            this.openVideo.FileName = "openFileDialog2";
            this.openVideo.Filter = "Archivos MP4 (*.mp4)|*.mp4";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panelOpcionesUsuario);
            this.Controls.Add(this.pEditarProfile);
            this.Controls.Add(this.labelFollowing);
            this.Controls.Add(this.labelFollowers);
            this.Controls.Add(this.labelPlaylist);
            this.Controls.Add(this.pIntroProfile);
            this.Controls.Add(this.bUserOptions);
            this.Controls.Add(this.bEditProfile);
            this.Controls.Add(this.panelImagenPerfil);
            this.Controls.Add(this.tNombreProfile);
            this.Controls.Add(this.bAtrasProfile);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(634, 364);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.pIntroProfile.ResumeLayout(false);
            this.pIntroProfile.PerformLayout();
            this.pEditarProfile.ResumeLayout(false);
            this.pEditarProfile.PerformLayout();
            this.panelEditarNombre.ResumeLayout(false);
            this.panelEditarNombre.PerformLayout();
            this.panelOpcionesUsuario.ResumeLayout(false);
            this.panelOpcionesUsuario.PerformLayout();
            this.panelCambiarOpcionesUsuario.ResumeLayout(false);
            this.panelCambiarOpcionesUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAtrasProfile;
        private System.Windows.Forms.TextBox tNombreProfile;
        private System.Windows.Forms.Panel panelImagenPerfil;
        private System.Windows.Forms.Button bEditProfile;
        private System.Windows.Forms.Button bUserOptions;
        private System.Windows.Forms.Panel pIntroProfile;
        private System.Windows.Forms.Button bVerUsuario;
        private System.Windows.Forms.Button bAtrasIntroProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPlaylist;
        private System.Windows.Forms.Label labelFollowers;
        private System.Windows.Forms.Label labelFollowing;
        private System.Windows.Forms.Panel pEditarProfile;
        private System.Windows.Forms.Button bEditarProfile;
        private System.Windows.Forms.Button buttonAtrasEditarProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEditarProfile;
        private System.Windows.Forms.Panel panelEditarNombre;
        private System.Windows.Forms.Label LabelIngresarNuevo;
        private System.Windows.Forms.TextBox textBoxIngresarNuevo;
        private System.Windows.Forms.CheckBox checkBoxPublica;
        private System.Windows.Forms.CheckBox checkBoxPrivada;
        private System.Windows.Forms.Button bCambiarEditar;
        private System.Windows.Forms.Panel panelOpcionesUsuario;
        private System.Windows.Forms.Button bAtrasOpciones;
        private System.Windows.Forms.Button buttonSeleccionarOpcionUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOpcionesUsuario;
        private System.Windows.Forms.Panel panelCambiarOpcionesUsuario;
        private System.Windows.Forms.Label labelCambio;
        private System.Windows.Forms.CheckBox checkBoxNo;
        private System.Windows.Forms.CheckBox checkBoxSi;
        private System.Windows.Forms.Button bAtrasCambiarOpciones;
        private System.Windows.Forms.Button buttonUpdateOpciones;
        private System.Windows.Forms.Label labelPremium;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelInsertTitle;
        private System.Windows.Forms.TextBox textBoxNombreCancion;
        private System.Windows.Forms.OpenFileDialog openFoto;
        private System.Windows.Forms.OpenFileDialog openMusic;
        private System.Windows.Forms.OpenFileDialog openVideo;
    }
}
