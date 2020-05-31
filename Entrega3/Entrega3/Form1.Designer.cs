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
            this.ucMainMenu1 = new Entrega3.UCMainMenu();
            this.ucLoading1 = new Entrega3.UCLoading();
            this.ucLoging1 = new Entrega3.UCLoging();
            this.ucMailValidation1 = new Entrega3.UCMailValidation();
            this.ucPreferencesRegister1 = new Entrega3.UCPreferencesRegister();
            this.ucRegister1 = new Entrega3.UCRegister();
            this.ucWelcome1 = new Entrega3.UCWelcome();
            this.SuspendLayout();
            // 
            // ucMainMenu1
            // 
            this.ucMainMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.ucMainMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMainMenu1.Location = new System.Drawing.Point(0, 0);
            this.ucMainMenu1.Name = "ucMainMenu1";
            this.ucMainMenu1.Size = new System.Drawing.Size(643, 356);
            this.ucMainMenu1.TabIndex = 6;
            // 
            // ucLoading1
            // 
            this.ucLoading1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.ucLoading1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ucLoading1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLoading1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ucLoading1.Location = new System.Drawing.Point(0, 0);
            this.ucLoading1.Name = "ucLoading1";
            this.ucLoading1.Size = new System.Drawing.Size(643, 356);
            this.ucLoading1.TabIndex = 5;
            // 
            // ucLoging1
            // 
            this.ucLoging1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLoging1.Location = new System.Drawing.Point(0, 0);
            this.ucLoging1.Name = "ucLoging1";
            this.ucLoging1.Size = new System.Drawing.Size(643, 356);
            this.ucLoging1.TabIndex = 4;
            // 
            // ucMailValidation1
            // 
            this.ucMailValidation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMailValidation1.Location = new System.Drawing.Point(0, 0);
            this.ucMailValidation1.Name = "ucMailValidation1";
            this.ucMailValidation1.Size = new System.Drawing.Size(643, 356);
            this.ucMailValidation1.TabIndex = 3;
            // 
            // ucPreferencesRegister1
            // 
            this.ucPreferencesRegister1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPreferencesRegister1.Location = new System.Drawing.Point(0, 0);
            this.ucPreferencesRegister1.Name = "ucPreferencesRegister1";
            this.ucPreferencesRegister1.Size = new System.Drawing.Size(643, 356);
            this.ucPreferencesRegister1.TabIndex = 2;
            this.ucPreferencesRegister1.Load += new System.EventHandler(this.ucPreferencesRegister1_Load);
            // 
            // ucRegister1
            // 
            this.ucRegister1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRegister1.Location = new System.Drawing.Point(0, 0);
            this.ucRegister1.Name = "ucRegister1";
            this.ucRegister1.Size = new System.Drawing.Size(643, 356);
            this.ucRegister1.TabIndex = 1;
            this.ucRegister1.Load += new System.EventHandler(this.ucRegister1_Load);
            // 
            // ucWelcome1
            // 
            this.ucWelcome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucWelcome1.Location = new System.Drawing.Point(0, 0);
            this.ucWelcome1.Name = "ucWelcome1";
            this.ucWelcome1.Size = new System.Drawing.Size(643, 356);
            this.ucWelcome1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 356);
            this.Controls.Add(this.ucMainMenu1);
            this.Controls.Add(this.ucLoading1);
            this.Controls.Add(this.ucLoging1);
            this.Controls.Add(this.ucMailValidation1);
            this.Controls.Add(this.ucPreferencesRegister1);
            this.Controls.Add(this.ucRegister1);
            this.Controls.Add(this.ucWelcome1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCWelcome ucWelcome1;
        private UCRegister ucRegister1;
        private UCPreferencesRegister ucPreferencesRegister1;
        private UCMailValidation ucMailValidation1;
        private UCLoging ucLoging1;
        private UCLoading ucLoading1;
        private UCMainMenu ucMainMenu1;
    }
}

