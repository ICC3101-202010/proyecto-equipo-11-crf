namespace Spotflix
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
            this.logIn1 = new Spotflix.LogIn();
            this.mailValidation1 = new Spotflix.MailValidation();
            this.register1 = new Spotflix.Register();
            this.welcome1 = new Spotflix.Welcome();
            this.preferences1 = new Spotflix.Preferences();
            this.SuspendLayout();
            // 
            // logIn1
            // 
            this.logIn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logIn1.Location = new System.Drawing.Point(0, 0);
            this.logIn1.Name = "logIn1";
            this.logIn1.Size = new System.Drawing.Size(643, 360);
            this.logIn1.TabIndex = 3;
            // 
            // mailValidation1
            // 
            this.mailValidation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.mailValidation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailValidation1.Location = new System.Drawing.Point(0, 0);
            this.mailValidation1.Name = "mailValidation1";
            this.mailValidation1.Size = new System.Drawing.Size(643, 360);
            this.mailValidation1.TabIndex = 2;
            // 
            // register1
            // 
            this.register1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.register1.Location = new System.Drawing.Point(0, 0);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(643, 360);
            this.register1.TabIndex = 1;
            // 
            // welcome1
            // 
            this.welcome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcome1.Location = new System.Drawing.Point(0, 0);
            this.welcome1.Name = "welcome1";
            this.welcome1.Size = new System.Drawing.Size(643, 360);
            this.welcome1.TabIndex = 0;
            // 
            // preferences1
            // 
            this.preferences1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preferences1.Location = new System.Drawing.Point(0, 0);
            this.preferences1.Name = "preferences1";
            this.preferences1.Size = new System.Drawing.Size(643, 360);
            this.preferences1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 360);
            this.Controls.Add(this.preferences1);
            this.Controls.Add(this.logIn1);
            this.Controls.Add(this.mailValidation1);
            this.Controls.Add(this.register1);
            this.Controls.Add(this.welcome1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Welcome welcome1;
        private Register register1;
        private MailValidation mailValidation1;
        private LogIn logIn1;
        private Preferences preferences1;
    }
}

