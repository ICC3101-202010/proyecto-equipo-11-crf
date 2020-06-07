namespace SporflixWF
{
    partial class MenuBar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonFinder = new System.Windows.Forms.Button();
            this.buttonLibrary = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonMixer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 52);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.buttonFinder);
            this.flowLayoutPanel1.Controls.Add(this.buttonLibrary);
            this.flowLayoutPanel1.Controls.Add(this.buttonProfile);
            this.flowLayoutPanel1.Controls.Add(this.buttonMixer);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(635, 52);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonFinder
            // 
            this.buttonFinder.AutoSize = true;
            this.buttonFinder.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonFinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinder.Location = new System.Drawing.Point(3, 3);
            this.buttonFinder.Margin = new System.Windows.Forms.Padding(3, 3, 43, 3);
            this.buttonFinder.Name = "buttonFinder";
            this.buttonFinder.Size = new System.Drawing.Size(124, 46);
            this.buttonFinder.TabIndex = 4;
            this.buttonFinder.Text = "Finder";
            this.buttonFinder.UseVisualStyleBackColor = false;
            // 
            // buttonLibrary
            // 
            this.buttonLibrary.AutoSize = true;
            this.buttonLibrary.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLibrary.Location = new System.Drawing.Point(173, 3);
            this.buttonLibrary.Margin = new System.Windows.Forms.Padding(3, 3, 43, 3);
            this.buttonLibrary.Name = "buttonLibrary";
            this.buttonLibrary.Size = new System.Drawing.Size(124, 46);
            this.buttonLibrary.TabIndex = 5;
            this.buttonLibrary.Text = "Library";
            this.buttonLibrary.UseVisualStyleBackColor = false;
            // 
            // buttonProfile
            // 
            this.buttonProfile.AutoSize = true;
            this.buttonProfile.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.Location = new System.Drawing.Point(343, 3);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(3, 3, 43, 3);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(119, 46);
            this.buttonProfile.TabIndex = 6;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            // 
            // buttonMixer
            // 
            this.buttonMixer.AutoSize = true;
            this.buttonMixer.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonMixer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMixer.Location = new System.Drawing.Point(508, 3);
            this.buttonMixer.Name = "buttonMixer";
            this.buttonMixer.Size = new System.Drawing.Size(124, 46);
            this.buttonMixer.TabIndex = 7;
            this.buttonMixer.Text = "Mixer";
            this.buttonMixer.UseVisualStyleBackColor = false;
            // 
            // MenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MenuBar";
            this.Size = new System.Drawing.Size(643, 52);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonFinder;
        private System.Windows.Forms.Button buttonLibrary;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonMixer;
    }
}
