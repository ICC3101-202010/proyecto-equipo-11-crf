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
            this.tNombreProfile.Location = new System.Drawing.Point(256, 186);
            this.tNombreProfile.Name = "tNombreProfile";
            this.tNombreProfile.Size = new System.Drawing.Size(123, 13);
            this.tNombreProfile.TabIndex = 1;
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
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.bUserOptions);
            this.Controls.Add(this.bEditProfile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tNombreProfile);
            this.Controls.Add(this.bAtrasProfile);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(623, 382);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAtrasProfile;
        private System.Windows.Forms.TextBox tNombreProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bEditProfile;
        private System.Windows.Forms.Button bUserOptions;
    }
}
