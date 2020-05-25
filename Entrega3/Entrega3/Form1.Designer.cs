namespace Entrega3
{
    partial class Form1
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
            this.panelLoggin = new System.Windows.Forms.Panel();
            this.labelSpotflix = new System.Windows.Forms.Label();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.panelLoggin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLoggin
            // 
            this.panelLoggin.Controls.Add(this.buttonSalir);
            this.panelLoggin.Controls.Add(this.buttonLogin);
            this.panelLoggin.Controls.Add(this.buttonRegistrar);
            this.panelLoggin.Location = new System.Drawing.Point(12, 57);
            this.panelLoggin.Name = "panelLoggin";
            this.panelLoggin.Size = new System.Drawing.Size(619, 287);
            this.panelLoggin.TabIndex = 0;
            // 
            // labelSpotflix
            // 
            this.labelSpotflix.AutoSize = true;
            this.labelSpotflix.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpotflix.Location = new System.Drawing.Point(257, 9);
            this.labelSpotflix.Name = "labelSpotflix";
            this.labelSpotflix.Size = new System.Drawing.Size(111, 31);
            this.labelSpotflix.TabIndex = 1;
            this.labelSpotflix.Text = "Spotflix";
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(27, 23);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrar.TabIndex = 2;
            this.buttonRegistrar.Text = "Registrarse";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(27, 81);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(27, 137);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 356);
            this.Controls.Add(this.labelSpotflix);
            this.Controls.Add(this.panelLoggin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelLoggin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLoggin;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Label labelSpotflix;
    }
}

