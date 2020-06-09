namespace Spotflix
{
    partial class Welcome
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
            this.PanelMainMenu = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelSpotflix = new System.Windows.Forms.Label();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.labelS = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.PanelMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMainMenu
            // 
            this.PanelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.PanelMainMenu.Controls.Add(this.buttonLogin);
            this.PanelMainMenu.Controls.Add(this.labelSpotflix);
            this.PanelMainMenu.Controls.Add(this.buttonRegistrar);
            this.PanelMainMenu.Controls.Add(this.labelS);
            this.PanelMainMenu.Controls.Add(this.labelP);
            this.PanelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMainMenu.Name = "PanelMainMenu";
            this.PanelMainMenu.Size = new System.Drawing.Size(643, 449);
            this.PanelMainMenu.TabIndex = 2;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(276, 192);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelSpotflix
            // 
            this.labelSpotflix.AutoSize = true;
            this.labelSpotflix.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpotflix.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelSpotflix.Location = new System.Drawing.Point(240, 39);
            this.labelSpotflix.Name = "labelSpotflix";
            this.labelSpotflix.Size = new System.Drawing.Size(154, 31);
            this.labelSpotflix.TabIndex = 1;
            this.labelSpotflix.Text = "SPOTFLIX";
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(276, 116);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrar.TabIndex = 2;
            this.buttonRegistrar.Text = "Sign Up";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // labelS
            // 
            this.labelS.Font = new System.Drawing.Font("Castellar", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.labelS.Location = new System.Drawing.Point(-54, 95);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(250, 289);
            this.labelS.TabIndex = 5;
            this.labelS.Text = "S";
            // 
            // labelP
            // 
            this.labelP.Font = new System.Drawing.Font("Castellar", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.labelP.Location = new System.Drawing.Point(420, -40);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(310, 289);
            this.labelP.TabIndex = 6;
            this.labelP.Text = "P";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelMainMenu);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(643, 449);
            this.PanelMainMenu.ResumeLayout(false);
            this.PanelMainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMainMenu;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelSpotflix;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label labelP;
    }
}
