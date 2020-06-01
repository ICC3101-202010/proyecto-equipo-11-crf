namespace Entrega3
{
    partial class UCMainMenuLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMainMenuLoading));
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.labelLoading = new System.Windows.Forms.Label();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.panelOptionsMenu = new System.Windows.Forms.Panel();
            this.panelMainMenuLibrary = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.panelMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLoading.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoading.Image")));
            this.pictureBoxLoading.InitialImage = null;
            this.pictureBoxLoading.Location = new System.Drawing.Point(200, 32);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(226, 221);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoading.TabIndex = 1;
            this.pictureBoxLoading.TabStop = false;
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelLoading.Location = new System.Drawing.Point(270, 287);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(89, 25);
            this.labelLoading.TabIndex = 2;
            this.labelLoading.Text = "Loading";
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Controls.Add(this.panelMainMenuLibrary);
            this.panelMainMenu.Controls.Add(this.panelOptionsMenu);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(643, 356);
            this.panelMainMenu.TabIndex = 3;
            // 
            // panelOptionsMenu
            // 
            this.panelOptionsMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOptionsMenu.Location = new System.Drawing.Point(0, 305);
            this.panelOptionsMenu.Name = "panelOptionsMenu";
            this.panelOptionsMenu.Size = new System.Drawing.Size(643, 51);
            this.panelOptionsMenu.TabIndex = 0;
            // 
            // panelMainMenuLibrary
            // 
            this.panelMainMenuLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainMenuLibrary.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenuLibrary.Name = "panelMainMenuLibrary";
            this.panelMainMenuLibrary.Size = new System.Drawing.Size(643, 272);
            this.panelMainMenuLibrary.TabIndex = 1;
            this.panelMainMenuLibrary.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UCMainMenuLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.pictureBoxLoading);
            this.Name = "UCMainMenuLoading";
            this.Size = new System.Drawing.Size(643, 356);
            this.Load += new System.EventHandler(this.UCMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.panelMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Panel panelMainMenuLibrary;
        private System.Windows.Forms.Panel panelOptionsMenu;
    }
}
