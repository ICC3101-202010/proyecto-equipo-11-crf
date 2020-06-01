namespace Spotflix
{
    partial class MailValidation
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
            this.btnSubmitPreferencesRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxNoVerified = new System.Windows.Forms.CheckBox();
            this.checkBoxYesVerified = new System.Windows.Forms.CheckBox();
            this.labelMailVerification = new System.Windows.Forms.Label();
            this.labelRegistrationPreferencesRegister = new System.Windows.Forms.Label();
            this.labelMailSentRegister = new System.Windows.Forms.Label();
            this.PanelRegisterInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelRegisterInformation
            // 
            this.PanelRegisterInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.PanelRegisterInformation.Controls.Add(this.btnSubmitPreferencesRegister);
            this.PanelRegisterInformation.Controls.Add(this.label1);
            this.PanelRegisterInformation.Controls.Add(this.checkBoxNoVerified);
            this.PanelRegisterInformation.Controls.Add(this.checkBoxYesVerified);
            this.PanelRegisterInformation.Controls.Add(this.labelMailVerification);
            this.PanelRegisterInformation.Controls.Add(this.labelRegistrationPreferencesRegister);
            this.PanelRegisterInformation.Controls.Add(this.labelMailSentRegister);
            this.PanelRegisterInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRegisterInformation.Location = new System.Drawing.Point(0, 0);
            this.PanelRegisterInformation.Name = "PanelRegisterInformation";
            this.PanelRegisterInformation.Size = new System.Drawing.Size(643, 360);
            this.PanelRegisterInformation.TabIndex = 9;
            this.PanelRegisterInformation.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelRegisterInformation_Paint);
            // 
            // btnSubmitPreferencesRegister
            // 
            this.btnSubmitPreferencesRegister.BackColor = System.Drawing.Color.Lavender;
            this.btnSubmitPreferencesRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitPreferencesRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSubmitPreferencesRegister.Location = new System.Drawing.Point(212, 215);
            this.btnSubmitPreferencesRegister.Name = "btnSubmitPreferencesRegister";
            this.btnSubmitPreferencesRegister.Size = new System.Drawing.Size(127, 23);
            this.btnSubmitPreferencesRegister.TabIndex = 21;
            this.btnSubmitPreferencesRegister.Text = "Submit";
            this.btnSubmitPreferencesRegister.UseVisualStyleBackColor = false;
            this.btnSubmitPreferencesRegister.Click += new System.EventHandler(this.btnSubmitPreferencesRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(202, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "if answer was yes notice it.....";
            // 
            // checkBoxNoVerified
            // 
            this.checkBoxNoVerified.AutoSize = true;
            this.checkBoxNoVerified.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxNoVerified.Location = new System.Drawing.Point(279, 192);
            this.checkBoxNoVerified.Name = "checkBoxNoVerified";
            this.checkBoxNoVerified.Size = new System.Drawing.Size(40, 17);
            this.checkBoxNoVerified.TabIndex = 19;
            this.checkBoxNoVerified.Text = "No";
            this.checkBoxNoVerified.UseVisualStyleBackColor = true;
            // 
            // checkBoxYesVerified
            // 
            this.checkBoxYesVerified.AutoSize = true;
            this.checkBoxYesVerified.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxYesVerified.Location = new System.Drawing.Point(229, 192);
            this.checkBoxYesVerified.Name = "checkBoxYesVerified";
            this.checkBoxYesVerified.Size = new System.Drawing.Size(44, 17);
            this.checkBoxYesVerified.TabIndex = 18;
            this.checkBoxYesVerified.Text = "Yes";
            this.checkBoxYesVerified.UseVisualStyleBackColor = true;
            // 
            // labelMailVerification
            // 
            this.labelMailVerification.AutoSize = true;
            this.labelMailVerification.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelMailVerification.Location = new System.Drawing.Point(205, 164);
            this.labelMailVerification.Name = "labelMailVerification";
            this.labelMailVerification.Size = new System.Drawing.Size(142, 13);
            this.labelMailVerification.TabIndex = 17;
            this.labelMailVerification.Text = "Here insert mail verification...";
            // 
            // labelRegistrationPreferencesRegister
            // 
            this.labelRegistrationPreferencesRegister.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationPreferencesRegister.ForeColor = System.Drawing.Color.White;
            this.labelRegistrationPreferencesRegister.Location = new System.Drawing.Point(82, 16);
            this.labelRegistrationPreferencesRegister.MaximumSize = new System.Drawing.Size(900, 900);
            this.labelRegistrationPreferencesRegister.Name = "labelRegistrationPreferencesRegister";
            this.labelRegistrationPreferencesRegister.Size = new System.Drawing.Size(382, 43);
            this.labelRegistrationPreferencesRegister.TabIndex = 16;
            this.labelRegistrationPreferencesRegister.Text = "Registration";
            this.labelRegistrationPreferencesRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMailSentRegister
            // 
            this.labelMailSentRegister.AutoSize = true;
            this.labelMailSentRegister.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelMailSentRegister.Location = new System.Drawing.Point(205, 102);
            this.labelMailSentRegister.Name = "labelMailSentRegister";
            this.labelMailSentRegister.Size = new System.Drawing.Size(149, 13);
            this.labelMailSentRegister.TabIndex = 0;
            this.labelMailSentRegister.Text = "Here insert mail sent to user....";
            // 
            // MailValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.PanelRegisterInformation);
            this.Name = "MailValidation";
            this.Size = new System.Drawing.Size(643, 360);
            this.Load += new System.EventHandler(this.MailValidation_Load);
            this.PanelRegisterInformation.ResumeLayout(false);
            this.PanelRegisterInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelRegisterInformation;
        private System.Windows.Forms.Button btnSubmitPreferencesRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxNoVerified;
        private System.Windows.Forms.CheckBox checkBoxYesVerified;
        private System.Windows.Forms.Label labelMailVerification;
        private System.Windows.Forms.Label labelRegistrationPreferencesRegister;
        private System.Windows.Forms.Label labelMailSentRegister;
    }
}
