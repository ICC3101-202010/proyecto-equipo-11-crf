namespace Spotflix
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panelLoadingMainMenu = new System.Windows.Forms.Panel();
            this.panelMainmenu = new System.Windows.Forms.Panel();
            this.panelMusicLibrary = new System.Windows.Forms.Panel();
            this.panelTestSOng = new System.Windows.Forms.Panel();
            this.pbTestSong = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.panelUserSettings = new System.Windows.Forms.Panel();
            this.panelLibrary = new System.Windows.Forms.Panel();
            this.panelMixer = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.labelLoading = new System.Windows.Forms.Label();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.labelNameSong = new System.Windows.Forms.Label();
            this.panelLoadingMainMenu.SuspendLayout();
            this.panelMainmenu.SuspendLayout();
            this.panelMusicLibrary.SuspendLayout();
            this.panelTestSOng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestSong)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLoadingMainMenu
            // 
            this.panelLoadingMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.panelLoadingMainMenu.Controls.Add(this.panelMainmenu);
            this.panelLoadingMainMenu.Controls.Add(this.labelLoading);
            this.panelLoadingMainMenu.Controls.Add(this.pictureBoxLoading);
            this.panelLoadingMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoadingMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLoadingMainMenu.Name = "panelLoadingMainMenu";
            this.panelLoadingMainMenu.Size = new System.Drawing.Size(643, 356);
            this.panelLoadingMainMenu.TabIndex = 0;
            // 
            // panelMainmenu
            // 
            this.panelMainmenu.Controls.Add(this.panelMusicLibrary);
            this.panelMainmenu.Controls.Add(this.panel2);
            this.panelMainmenu.Controls.Add(this.panel1);
            this.panelMainmenu.Controls.Add(this.panelOptions);
            this.panelMainmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainmenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainmenu.Name = "panelMainmenu";
            this.panelMainmenu.Size = new System.Drawing.Size(643, 356);
            this.panelMainmenu.TabIndex = 4;
            // 
            // panelMusicLibrary
            // 
            this.panelMusicLibrary.Controls.Add(this.panelTestSOng);
            this.panelMusicLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMusicLibrary.Location = new System.Drawing.Point(0, 40);
            this.panelMusicLibrary.Name = "panelMusicLibrary";
            this.panelMusicLibrary.Size = new System.Drawing.Size(643, 226);
            this.panelMusicLibrary.TabIndex = 3;
            this.panelMusicLibrary.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMusicLibrary_Paint);
            // 
            // panelTestSOng
            // 
            this.panelTestSOng.Controls.Add(this.labelNameSong);
            this.panelTestSOng.Controls.Add(this.pbTestSong);
            this.panelTestSOng.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTestSOng.Location = new System.Drawing.Point(0, 0);
            this.panelTestSOng.Name = "panelTestSOng";
            this.panelTestSOng.Size = new System.Drawing.Size(643, 49);
            this.panelTestSOng.TabIndex = 0;
            this.panelTestSOng.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTestSOng_Paint);
            // 
            // pbTestSong
            // 
            this.pbTestSong.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbTestSong.Location = new System.Drawing.Point(0, 0);
            this.pbTestSong.Name = "pbTestSong";
            this.pbTestSong.Size = new System.Drawing.Size(99, 49);
            this.pbTestSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestSong.TabIndex = 0;
            this.pbTestSong.TabStop = false;
            this.pbTestSong.Click += new System.EventHandler(this.pbTestSong_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 40);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(254, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AQUI VA EL MAIN MENU";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 38);
            this.panel1.TabIndex = 1;
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.panelUserSettings);
            this.panelOptions.Controls.Add(this.panelLibrary);
            this.panelOptions.Controls.Add(this.panelMixer);
            this.panelOptions.Controls.Add(this.panelSearch);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOptions.Location = new System.Drawing.Point(0, 304);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(643, 52);
            this.panelOptions.TabIndex = 0;
            // 
            // panelUserSettings
            // 
            this.panelUserSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUserSettings.Location = new System.Drawing.Point(480, 0);
            this.panelUserSettings.Name = "panelUserSettings";
            this.panelUserSettings.Size = new System.Drawing.Size(163, 52);
            this.panelUserSettings.TabIndex = 3;
            // 
            // panelLibrary
            // 
            this.panelLibrary.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLibrary.Location = new System.Drawing.Point(320, 0);
            this.panelLibrary.Name = "panelLibrary";
            this.panelLibrary.Size = new System.Drawing.Size(160, 52);
            this.panelLibrary.TabIndex = 2;
            // 
            // panelMixer
            // 
            this.panelMixer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMixer.Location = new System.Drawing.Point(160, 0);
            this.panelMixer.Name = "panelMixer";
            this.panelMixer.Size = new System.Drawing.Size(160, 52);
            this.panelMixer.TabIndex = 1;
            // 
            // panelSearch
            // 
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(160, 52);
            this.panelSearch.TabIndex = 0;
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelLoading.Location = new System.Drawing.Point(279, 276);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(89, 25);
            this.labelLoading.TabIndex = 3;
            this.labelLoading.Text = "Loading";
            this.labelLoading.Click += new System.EventHandler(this.labelLoading_Click);
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLoading.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoading.Image")));
            this.pictureBoxLoading.InitialImage = null;
            this.pictureBoxLoading.Location = new System.Drawing.Point(211, 28);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(226, 221);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoading.TabIndex = 2;
            this.pictureBoxLoading.TabStop = false;
            // 
            // labelNameSong
            // 
            this.labelNameSong.AutoSize = true;
            this.labelNameSong.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNameSong.Location = new System.Drawing.Point(141, 19);
            this.labelNameSong.Name = "labelNameSong";
            this.labelNameSong.Size = new System.Drawing.Size(35, 13);
            this.labelNameSong.TabIndex = 1;
            this.labelNameSong.Text = "label2";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLoadingMainMenu);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(643, 356);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panelLoadingMainMenu.ResumeLayout(false);
            this.panelLoadingMainMenu.PerformLayout();
            this.panelMainmenu.ResumeLayout(false);
            this.panelMusicLibrary.ResumeLayout(false);
            this.panelTestSOng.ResumeLayout(false);
            this.panelTestSOng.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestSong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoadingMainMenu;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Panel panelMainmenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Panel panelUserSettings;
        private System.Windows.Forms.Panel panelLibrary;
        private System.Windows.Forms.Panel panelMixer;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelMusicLibrary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTestSOng;
        private System.Windows.Forms.PictureBox pbTestSong;
        private System.Windows.Forms.Label labelNameSong;
    }
}
