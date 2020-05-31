namespace Entrega3
{
    partial class UCLoging
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
            this.PanelRegisterInformation = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelLogIn = new System.Windows.Forms.Label();
            this.textBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.textBoxUsernameLogIn = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsernameRegister = new System.Windows.Forms.Label();
            this.PanelRegisterInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelRegisterInformation
            // 
            this.PanelRegisterInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.PanelRegisterInformation.Controls.Add(this.labelError);
            this.PanelRegisterInformation.Controls.Add(this.btnLogin);
            this.PanelRegisterInformation.Controls.Add(this.labelLogIn);
            this.PanelRegisterInformation.Controls.Add(this.textBoxPasswordLogin);
            this.PanelRegisterInformation.Controls.Add(this.textBoxUsernameLogIn);
            this.PanelRegisterInformation.Controls.Add(this.labelPassword);
            this.PanelRegisterInformation.Controls.Add(this.labelUsernameRegister);
            this.PanelRegisterInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRegisterInformation.Location = new System.Drawing.Point(0, 0);
            this.PanelRegisterInformation.Name = "PanelRegisterInformation";
            this.PanelRegisterInformation.Size = new System.Drawing.Size(643, 356);
            this.PanelRegisterInformation.TabIndex = 7;
            this.PanelRegisterInformation.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelRegisterInformation_Paint);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(169, 271);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(294, 16);
            this.labelError.TabIndex = 17;
            this.labelError.Text = "ERROR, please fill all the field, or incorrect users";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(281, 319);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelLogIn
            // 
            this.labelLogIn.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogIn.ForeColor = System.Drawing.Color.White;
            this.labelLogIn.Location = new System.Drawing.Point(129, 22);
            this.labelLogIn.MaximumSize = new System.Drawing.Size(900, 900);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(382, 43);
            this.labelLogIn.TabIndex = 15;
            this.labelLogIn.Text = "Log In";
            this.labelLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLogIn.Click += new System.EventHandler(this.labelLogIn_Click);
            // 
            // textBoxPasswordLogin
            // 
            this.textBoxPasswordLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPasswordLogin.Location = new System.Drawing.Point(281, 200);
            this.textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            this.textBoxPasswordLogin.Size = new System.Drawing.Size(170, 20);
            this.textBoxPasswordLogin.TabIndex = 5;
            // 
            // textBoxUsernameLogIn
            // 
            this.textBoxUsernameLogIn.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxUsernameLogIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsernameLogIn.Location = new System.Drawing.Point(281, 119);
            this.textBoxUsernameLogIn.Name = "textBoxUsernameLogIn";
            this.textBoxUsernameLogIn.Size = new System.Drawing.Size(170, 20);
            this.textBoxUsernameLogIn.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPassword.Location = new System.Drawing.Point(171, 198);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(75, 18);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // labelUsernameRegister
            // 
            this.labelUsernameRegister.AutoSize = true;
            this.labelUsernameRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameRegister.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelUsernameRegister.Location = new System.Drawing.Point(169, 117);
            this.labelUsernameRegister.Name = "labelUsernameRegister";
            this.labelUsernameRegister.Size = new System.Drawing.Size(77, 18);
            this.labelUsernameRegister.TabIndex = 0;
            this.labelUsernameRegister.Text = "Username";
            // 
            // UCLoging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelRegisterInformation);
            this.Name = "UCLoging";
            this.Size = new System.Drawing.Size(643, 356);
            this.PanelRegisterInformation.ResumeLayout(false);
            this.PanelRegisterInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelRegisterInformation;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelLogIn;
        private System.Windows.Forms.TextBox textBoxPasswordLogin;
        private System.Windows.Forms.TextBox textBoxUsernameLogIn;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsernameRegister;
    }
}
