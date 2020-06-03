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
            this.bAtrasProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAtrasProfile
            // 
            this.bAtrasProfile.Location = new System.Drawing.Point(164, 292);
            this.bAtrasProfile.Name = "bAtrasProfile";
            this.bAtrasProfile.Size = new System.Drawing.Size(75, 23);
            this.bAtrasProfile.TabIndex = 0;
            this.bAtrasProfile.Text = "back";
            this.bAtrasProfile.UseVisualStyleBackColor = true;
            this.bAtrasProfile.Click += new System.EventHandler(this.bAtrasProfile_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.bAtrasProfile);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(623, 382);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAtrasProfile;
    }
}
