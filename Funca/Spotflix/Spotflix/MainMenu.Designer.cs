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
            this.PanelMiniPlayerFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.SongsContainerPanelFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTestSOng = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNameSong = new System.Windows.Forms.Label();
            this.pbTestSong = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonMixer = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonLibrary = new System.Windows.Forms.Button();
            this.buttonFinder = new System.Windows.Forms.Button();
            this.labelLoading = new System.Windows.Forms.Label();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.panelLoadingMainMenu.SuspendLayout();
            this.panelMainmenu.SuspendLayout();
            this.SongsContainerPanelFlow.SuspendLayout();
            this.panelTestSOng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestSong)).BeginInit();
            this.panelOptions.SuspendLayout();
            this.panelSearch.SuspendLayout();
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
            this.panelMainmenu.Controls.Add(this.PanelMiniPlayerFlow);
            this.panelMainmenu.Controls.Add(this.SongsContainerPanelFlow);
            this.panelMainmenu.Controls.Add(this.panel2);
            this.panelMainmenu.Controls.Add(this.panelOptions);
            this.panelMainmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainmenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainmenu.Name = "panelMainmenu";
            this.panelMainmenu.Size = new System.Drawing.Size(643, 356);
            this.panelMainmenu.TabIndex = 4;
            // 
            // PanelMiniPlayerFlow
            // 
            this.PanelMiniPlayerFlow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelMiniPlayerFlow.Location = new System.Drawing.Point(0, 276);
            this.PanelMiniPlayerFlow.Name = "PanelMiniPlayerFlow";
            this.PanelMiniPlayerFlow.Size = new System.Drawing.Size(643, 28);
            this.PanelMiniPlayerFlow.TabIndex = 4;
            // 
            // SongsContainerPanelFlow
            // 
            this.SongsContainerPanelFlow.AutoScroll = true;
            this.SongsContainerPanelFlow.Controls.Add(this.panelTestSOng);
            this.SongsContainerPanelFlow.Location = new System.Drawing.Point(0, 40);
            this.SongsContainerPanelFlow.Name = "SongsContainerPanelFlow";
            this.SongsContainerPanelFlow.Size = new System.Drawing.Size(643, 236);
            this.SongsContainerPanelFlow.TabIndex = 3;
            // 
            // panelTestSOng
            // 
            this.panelTestSOng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.panelTestSOng.Controls.Add(this.label2);
            this.panelTestSOng.Controls.Add(this.labelNameSong);
            this.panelTestSOng.Controls.Add(this.pbTestSong);
            this.panelTestSOng.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTestSOng.Location = new System.Drawing.Point(1, 1);
            this.panelTestSOng.Margin = new System.Windows.Forms.Padding(1);
            this.panelTestSOng.Name = "panelTestSOng";
            this.panelTestSOng.Size = new System.Drawing.Size(637, 67);
            this.panelTestSOng.TabIndex = 0;
            this.panelTestSOng.Click += new System.EventHandler(this.panelTestSOng_Click);
            this.panelTestSOng.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTestSOng_Paint);
            this.panelTestSOng.MouseLeave += new System.EventHandler(this.panelTestSOng_MouseLeave);
            this.panelTestSOng.MouseHover += new System.EventHandler(this.panelTestSOng_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(528, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // labelNameSong
            // 
            this.labelNameSong.AutoSize = true;
            this.labelNameSong.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNameSong.Location = new System.Drawing.Point(167, 28);
            this.labelNameSong.Name = "labelNameSong";
            this.labelNameSong.Size = new System.Drawing.Size(35, 13);
            this.labelNameSong.TabIndex = 1;
            this.labelNameSong.Text = "label2";
            // 
            // pbTestSong
            // 
            this.pbTestSong.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbTestSong.Location = new System.Drawing.Point(0, 0);
            this.pbTestSong.Name = "pbTestSong";
            this.pbTestSong.Size = new System.Drawing.Size(99, 67);
            this.pbTestSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestSong.TabIndex = 0;
            this.pbTestSong.TabStop = false;
            this.pbTestSong.Click += new System.EventHandler(this.pbTestSong_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 40);
            this.panel2.TabIndex = 2;
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.panelSearch);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOptions.Location = new System.Drawing.Point(0, 304);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(643, 52);
            this.panelOptions.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.buttonMixer);
            this.panelSearch.Controls.Add(this.buttonProfile);
            this.panelSearch.Controls.Add(this.buttonLibrary);
            this.panelSearch.Controls.Add(this.buttonFinder);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(643, 52);
            this.panelSearch.TabIndex = 0;
            // 
            // buttonMixer
            // 
            this.buttonMixer.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonMixer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMixer.Location = new System.Drawing.Point(516, 3);
            this.buttonMixer.Name = "buttonMixer";
            this.buttonMixer.Size = new System.Drawing.Size(124, 46);
            this.buttonMixer.TabIndex = 5;
            this.buttonMixer.Text = "Mixer";
            this.buttonMixer.UseVisualStyleBackColor = false;
            this.buttonMixer.Click += new System.EventHandler(this.buttonMixer_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.Location = new System.Drawing.Point(352, 3);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(119, 46);
            this.buttonProfile.TabIndex = 4;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonLibrary
            // 
            this.buttonLibrary.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLibrary.Location = new System.Drawing.Point(171, 3);
            this.buttonLibrary.Name = "buttonLibrary";
            this.buttonLibrary.Size = new System.Drawing.Size(124, 46);
            this.buttonLibrary.TabIndex = 3;
            this.buttonLibrary.Text = "Library";
            this.buttonLibrary.UseVisualStyleBackColor = false;
            this.buttonLibrary.Click += new System.EventHandler(this.buttonLibrary_Click);
            // 
            // buttonFinder
            // 
            this.buttonFinder.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonFinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinder.Location = new System.Drawing.Point(3, 3);
            this.buttonFinder.Name = "buttonFinder";
            this.buttonFinder.Size = new System.Drawing.Size(124, 46);
            this.buttonFinder.TabIndex = 2;
            this.buttonFinder.Text = "Finder";
            this.buttonFinder.UseVisualStyleBackColor = false;
            this.buttonFinder.Click += new System.EventHandler(this.buttonFinder_Click);
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
            this.SongsContainerPanelFlow.ResumeLayout(false);
            this.panelTestSOng.ResumeLayout(false);
            this.panelTestSOng.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestSong)).EndInit();
            this.panelOptions.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoadingMainMenu;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Panel panelMainmenu;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTestSOng;
        private System.Windows.Forms.PictureBox pbTestSong;
        private System.Windows.Forms.Label labelNameSong;
        private System.Windows.Forms.Button buttonMixer;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonLibrary;
        private System.Windows.Forms.Button buttonFinder;
        private System.Windows.Forms.FlowLayoutPanel SongsContainerPanelFlow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel PanelMiniPlayerFlow;
    }
}
