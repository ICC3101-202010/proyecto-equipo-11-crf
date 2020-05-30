namespace Entrega3
{
    partial class UCRegister
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
            this.labelRegistrationRegister = new System.Windows.Forms.Label();
            this.btnSubmitRegister = new System.Windows.Forms.Button();
            this.checkBoxNoRegister = new System.Windows.Forms.CheckBox();
            this.checkBoxYesRegister = new System.Windows.Forms.CheckBox();
            this.labelPreferencesRegister = new System.Windows.Forms.Label();
            this.checkBoxPublicRegister = new System.Windows.Forms.CheckBox();
            this.checkBoxPrivateRegister = new System.Windows.Forms.CheckBox();
            this.labelPrivacityRegister = new System.Windows.Forms.Label();
            this.textBoxMobileRegister = new System.Windows.Forms.TextBox();
            this.textBoxMailRegister = new System.Windows.Forms.TextBox();
            this.textBoxUsernameRegister = new System.Windows.Forms.TextBox();
            this.labelMobileRegister = new System.Windows.Forms.Label();
            this.labelMailRegister = new System.Windows.Forms.Label();
            this.labelUsernameRegister = new System.Windows.Forms.Label();
            this.PanelRegisterInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelRegisterInformation
            // 
            this.PanelRegisterInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.PanelRegisterInformation.Controls.Add(this.labelRegistrationRegister);
            this.PanelRegisterInformation.Controls.Add(this.btnSubmitRegister);
            this.PanelRegisterInformation.Controls.Add(this.checkBoxNoRegister);
            this.PanelRegisterInformation.Controls.Add(this.checkBoxYesRegister);
            this.PanelRegisterInformation.Controls.Add(this.labelPreferencesRegister);
            this.PanelRegisterInformation.Controls.Add(this.checkBoxPublicRegister);
            this.PanelRegisterInformation.Controls.Add(this.checkBoxPrivateRegister);
            this.PanelRegisterInformation.Controls.Add(this.labelPrivacityRegister);
            this.PanelRegisterInformation.Controls.Add(this.textBoxMobileRegister);
            this.PanelRegisterInformation.Controls.Add(this.textBoxMailRegister);
            this.PanelRegisterInformation.Controls.Add(this.textBoxUsernameRegister);
            this.PanelRegisterInformation.Controls.Add(this.labelMobileRegister);
            this.PanelRegisterInformation.Controls.Add(this.labelMailRegister);
            this.PanelRegisterInformation.Controls.Add(this.labelUsernameRegister);
            this.PanelRegisterInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRegisterInformation.Location = new System.Drawing.Point(0, 0);
            this.PanelRegisterInformation.Name = "PanelRegisterInformation";
            this.PanelRegisterInformation.Size = new System.Drawing.Size(578, 390);
            this.PanelRegisterInformation.TabIndex = 6;
            this.PanelRegisterInformation.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelRegisterInformation_Paint);
            // 
            // labelRegistrationRegister
            // 
            this.labelRegistrationRegister.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationRegister.ForeColor = System.Drawing.Color.White;
            this.labelRegistrationRegister.Location = new System.Drawing.Point(95, 9);
            this.labelRegistrationRegister.MaximumSize = new System.Drawing.Size(900, 900);
            this.labelRegistrationRegister.Name = "labelRegistrationRegister";
            this.labelRegistrationRegister.Size = new System.Drawing.Size(382, 43);
            this.labelRegistrationRegister.TabIndex = 15;
            this.labelRegistrationRegister.Text = "Registration";
            this.labelRegistrationRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmitRegister
            // 
            this.btnSubmitRegister.BackColor = System.Drawing.Color.Lavender;
            this.btnSubmitRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSubmitRegister.Location = new System.Drawing.Point(270, 309);
            this.btnSubmitRegister.Name = "btnSubmitRegister";
            this.btnSubmitRegister.Size = new System.Drawing.Size(127, 23);
            this.btnSubmitRegister.TabIndex = 14;
            this.btnSubmitRegister.Text = "Submit";
            this.btnSubmitRegister.UseVisualStyleBackColor = false;
            this.btnSubmitRegister.Click += new System.EventHandler(this.btnSubmitRegister_Click);
            // 
            // checkBoxNoRegister
            // 
            this.checkBoxNoRegister.AutoSize = true;
            this.checkBoxNoRegister.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.checkBoxNoRegister.Location = new System.Drawing.Point(342, 258);
            this.checkBoxNoRegister.Name = "checkBoxNoRegister";
            this.checkBoxNoRegister.Size = new System.Drawing.Size(40, 17);
            this.checkBoxNoRegister.TabIndex = 13;
            this.checkBoxNoRegister.TabStop = false;
            this.checkBoxNoRegister.Text = "No";
            this.checkBoxNoRegister.UseVisualStyleBackColor = true;
            // 
            // checkBoxYesRegister
            // 
            this.checkBoxYesRegister.AutoSize = true;
            this.checkBoxYesRegister.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.checkBoxYesRegister.Location = new System.Drawing.Point(281, 258);
            this.checkBoxYesRegister.Name = "checkBoxYesRegister";
            this.checkBoxYesRegister.Size = new System.Drawing.Size(44, 17);
            this.checkBoxYesRegister.TabIndex = 12;
            this.checkBoxYesRegister.TabStop = false;
            this.checkBoxYesRegister.Text = "Yes";
            this.checkBoxYesRegister.UseVisualStyleBackColor = true;
            // 
            // labelPreferencesRegister
            // 
            this.labelPreferencesRegister.AutoSize = true;
            this.labelPreferencesRegister.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPreferencesRegister.Location = new System.Drawing.Point(59, 258);
            this.labelPreferencesRegister.Name = "labelPreferencesRegister";
            this.labelPreferencesRegister.Size = new System.Drawing.Size(165, 13);
            this.labelPreferencesRegister.TabIndex = 11;
            this.labelPreferencesRegister.Text = "Do you want to add preferences?";
            // 
            // checkBoxPublicRegister
            // 
            this.checkBoxPublicRegister.AutoSize = true;
            this.checkBoxPublicRegister.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.checkBoxPublicRegister.Location = new System.Drawing.Point(342, 225);
            this.checkBoxPublicRegister.Name = "checkBoxPublicRegister";
            this.checkBoxPublicRegister.Size = new System.Drawing.Size(55, 17);
            this.checkBoxPublicRegister.TabIndex = 10;
            this.checkBoxPublicRegister.TabStop = false;
            this.checkBoxPublicRegister.Text = "Public";
            this.checkBoxPublicRegister.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrivateRegister
            // 
            this.checkBoxPrivateRegister.AutoSize = true;
            this.checkBoxPrivateRegister.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxPrivateRegister.Location = new System.Drawing.Point(281, 225);
            this.checkBoxPrivateRegister.Name = "checkBoxPrivateRegister";
            this.checkBoxPrivateRegister.Size = new System.Drawing.Size(59, 17);
            this.checkBoxPrivateRegister.TabIndex = 9;
            this.checkBoxPrivateRegister.Text = "Private";
            this.checkBoxPrivateRegister.UseVisualStyleBackColor = true;
            // 
            // labelPrivacityRegister
            // 
            this.labelPrivacityRegister.AutoSize = true;
            this.labelPrivacityRegister.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPrivacityRegister.Location = new System.Drawing.Point(177, 226);
            this.labelPrivacityRegister.Name = "labelPrivacityRegister";
            this.labelPrivacityRegister.Size = new System.Drawing.Size(47, 13);
            this.labelPrivacityRegister.TabIndex = 6;
            this.labelPrivacityRegister.Text = "Privacity";
            // 
            // textBoxMobileRegister
            // 
            this.textBoxMobileRegister.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxMobileRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMobileRegister.Location = new System.Drawing.Point(281, 160);
            this.textBoxMobileRegister.Name = "textBoxMobileRegister";
            this.textBoxMobileRegister.Size = new System.Drawing.Size(126, 20);
            this.textBoxMobileRegister.TabIndex = 5;
            // 
            // textBoxMailRegister
            // 
            this.textBoxMailRegister.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxMailRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMailRegister.Location = new System.Drawing.Point(281, 112);
            this.textBoxMailRegister.Name = "textBoxMailRegister";
            this.textBoxMailRegister.Size = new System.Drawing.Size(126, 20);
            this.textBoxMailRegister.TabIndex = 4;
            // 
            // textBoxUsernameRegister
            // 
            this.textBoxUsernameRegister.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxUsernameRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsernameRegister.Location = new System.Drawing.Point(281, 66);
            this.textBoxUsernameRegister.Name = "textBoxUsernameRegister";
            this.textBoxUsernameRegister.Size = new System.Drawing.Size(126, 20);
            this.textBoxUsernameRegister.TabIndex = 3;
            // 
            // labelMobileRegister
            // 
            this.labelMobileRegister.AutoSize = true;
            this.labelMobileRegister.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelMobileRegister.Location = new System.Drawing.Point(186, 167);
            this.labelMobileRegister.Name = "labelMobileRegister";
            this.labelMobileRegister.Size = new System.Drawing.Size(38, 13);
            this.labelMobileRegister.TabIndex = 2;
            this.labelMobileRegister.Text = "Mobile";
            // 
            // labelMailRegister
            // 
            this.labelMailRegister.AutoSize = true;
            this.labelMailRegister.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelMailRegister.Location = new System.Drawing.Point(198, 114);
            this.labelMailRegister.Name = "labelMailRegister";
            this.labelMailRegister.Size = new System.Drawing.Size(26, 13);
            this.labelMailRegister.TabIndex = 1;
            this.labelMailRegister.Text = "Mail";
            // 
            // labelUsernameRegister
            // 
            this.labelUsernameRegister.AutoSize = true;
            this.labelUsernameRegister.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelUsernameRegister.Location = new System.Drawing.Point(169, 68);
            this.labelUsernameRegister.Name = "labelUsernameRegister";
            this.labelUsernameRegister.Size = new System.Drawing.Size(55, 13);
            this.labelUsernameRegister.TabIndex = 0;
            this.labelUsernameRegister.Text = "Username";
            // 
            // UCRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelRegisterInformation);
            this.Name = "UCRegister";
            this.Size = new System.Drawing.Size(578, 390);
            this.PanelRegisterInformation.ResumeLayout(false);
            this.PanelRegisterInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelRegisterInformation;
        private System.Windows.Forms.Label labelRegistrationRegister;
        private System.Windows.Forms.Button btnSubmitRegister;
        private System.Windows.Forms.CheckBox checkBoxNoRegister;
        private System.Windows.Forms.CheckBox checkBoxYesRegister;
        private System.Windows.Forms.Label labelPreferencesRegister;
        private System.Windows.Forms.CheckBox checkBoxPublicRegister;
        private System.Windows.Forms.CheckBox checkBoxPrivateRegister;
        private System.Windows.Forms.Label labelPrivacityRegister;
        private System.Windows.Forms.TextBox textBoxMobileRegister;
        private System.Windows.Forms.TextBox textBoxMailRegister;
        private System.Windows.Forms.TextBox textBoxUsernameRegister;
        private System.Windows.Forms.Label labelMobileRegister;
        private System.Windows.Forms.Label labelMailRegister;
        private System.Windows.Forms.Label labelUsernameRegister;
    }
}
