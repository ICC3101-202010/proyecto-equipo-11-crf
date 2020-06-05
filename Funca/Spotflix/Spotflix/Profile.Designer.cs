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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bEditProfile = new System.Windows.Forms.Button();
            this.bUserOptions = new System.Windows.Forms.Button();
            this.pIntroProfile = new System.Windows.Forms.Panel();
            this.bAtrasIntroProfile = new System.Windows.Forms.Button();
            this.bVerUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pIntroProfile.SuspendLayout();
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
            this.tNombreProfile.BackColor = System.Drawing.SystemColors.MenuText;
            this.tNombreProfile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tNombreProfile.ForeColor = System.Drawing.SystemColors.Window;
            this.tNombreProfile.Location = new System.Drawing.Point(296, 185);
            this.tNombreProfile.Name = "tNombreProfile";
            this.tNombreProfile.Size = new System.Drawing.Size(123, 13);
            this.tNombreProfile.TabIndex = 1;
            this.tNombreProfile.Text = "Nombre Usuario";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(256, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 119);
            this.panel1.TabIndex = 2;
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
            this.pIntroProfile.Size = new System.Drawing.Size(623, 382);
            this.pIntroProfile.TabIndex = 5;
            // 
            // bAtrasIntroProfile
            // 
            this.bAtrasIntroProfile.Location = new System.Drawing.Point(198, 231);
            this.bAtrasIntroProfile.Name = "bAtrasIntroProfile";
            this.bAtrasIntroProfile.Size = new System.Drawing.Size(75, 23);
            this.bAtrasIntroProfile.TabIndex = 0;
            this.bAtrasIntroProfile.Text = "atras";
            this.bAtrasIntroProfile.UseVisualStyleBackColor = true;
            this.bAtrasIntroProfile.Click += new System.EventHandler(this.bAtrasIntroProfile_Click);
            // 
            // bVerUsuario
            // 
            this.bVerUsuario.Location = new System.Drawing.Point(358, 231);
            this.bVerUsuario.Name = "bVerUsuario";
            this.bVerUsuario.Size = new System.Drawing.Size(75, 23);
            this.bVerUsuario.TabIndex = 1;
            this.bVerUsuario.Text = "Ver Usuario";
            this.bVerUsuario.UseVisualStyleBackColor = true;
            this.bVerUsuario.Click += new System.EventHandler(this.bVerUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(163, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quieres Proceder a ver tu Usuario?";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.pIntroProfile);
            this.Controls.Add(this.bUserOptions);
            this.Controls.Add(this.bEditProfile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tNombreProfile);
            this.Controls.Add(this.bAtrasProfile);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(623, 382);
            this.pIntroProfile.ResumeLayout(false);
            this.pIntroProfile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAtrasProfile;
        private System.Windows.Forms.TextBox tNombreProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bEditProfile;
        private System.Windows.Forms.Button bUserOptions;
        private System.Windows.Forms.Panel pIntroProfile;
        private System.Windows.Forms.Button bVerUsuario;
        private System.Windows.Forms.Button bAtrasIntroProfile;
        private System.Windows.Forms.Label label1;
    }
}
