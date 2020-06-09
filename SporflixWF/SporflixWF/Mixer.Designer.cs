namespace Spotflix
{
    partial class Mixer
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
            this.comboBoxMixer = new System.Windows.Forms.ComboBox();
            this.buttonPlayMixer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMixer
            // 
            this.comboBoxMixer.FormattingEnabled = true;
            this.comboBoxMixer.Location = new System.Drawing.Point(34, 18);
            this.comboBoxMixer.Name = "comboBoxMixer";
            this.comboBoxMixer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMixer.TabIndex = 0;
            // 
            // buttonPlayMixer
            // 
            this.buttonPlayMixer.Location = new System.Drawing.Point(184, 18);
            this.buttonPlayMixer.Name = "buttonPlayMixer";
            this.buttonPlayMixer.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayMixer.TabIndex = 1;
            this.buttonPlayMixer.Text = "Play";
            this.buttonPlayMixer.UseVisualStyleBackColor = true;
            this.buttonPlayMixer.Click += new System.EventHandler(this.buttonPlayMixer_Click);
            // 
            // Mixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.BackgroundImage = global::SporflixWF.Properties.Resources.dj;
            this.Controls.Add(this.buttonPlayMixer);
            this.Controls.Add(this.comboBoxMixer);
            this.Name = "Mixer";
            this.Size = new System.Drawing.Size(552, 349);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMixer;
        private System.Windows.Forms.Button buttonPlayMixer;
    }
}
