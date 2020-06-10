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
            this.SongsContainerPanelFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTestSOng = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNameSong = new System.Windows.Forms.Label();
            this.pbTestSong = new System.Windows.Forms.PictureBox();
            this.panelSongOptions = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInfoSong = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelLaunchDate = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelplaylit = new System.Windows.Forms.Panel();
            this.labelLoading = new System.Windows.Forms.Label();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelHomeTitle = new System.Windows.Forms.Label();
            this.panelLoadingMainMenu.SuspendLayout();
            this.panelMainmenu.SuspendLayout();
            this.SongsContainerPanelFlow.SuspendLayout();
            this.panelTestSOng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestSong)).BeginInit();
            this.panelSongOptions.SuspendLayout();
            this.panelInfoSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panelLoadingMainMenu.Size = new System.Drawing.Size(643, 360);
            this.panelLoadingMainMenu.TabIndex = 0;
            // 
            // panelMainmenu
            // 
            this.panelMainmenu.Controls.Add(this.SongsContainerPanelFlow);
            this.panelMainmenu.Controls.Add(this.panel2);
            this.panelMainmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainmenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainmenu.Name = "panelMainmenu";
            this.panelMainmenu.Size = new System.Drawing.Size(643, 360);
            this.panelMainmenu.TabIndex = 4;
            // 
            // SongsContainerPanelFlow
            // 
            this.SongsContainerPanelFlow.AutoScroll = true;
            this.SongsContainerPanelFlow.Controls.Add(this.panelTestSOng);
            this.SongsContainerPanelFlow.Controls.Add(this.panelSongOptions);
            this.SongsContainerPanelFlow.Controls.Add(this.panelInfoSong);
            this.SongsContainerPanelFlow.Controls.Add(this.flowLayoutPanel1);
            this.SongsContainerPanelFlow.Controls.Add(this.panelplaylit);
            this.SongsContainerPanelFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SongsContainerPanelFlow.Location = new System.Drawing.Point(0, 40);
            this.SongsContainerPanelFlow.Name = "SongsContainerPanelFlow";
            this.SongsContainerPanelFlow.Size = new System.Drawing.Size(643, 320);
            this.SongsContainerPanelFlow.TabIndex = 3;
            // 
            // panelTestSOng
            // 
            this.panelTestSOng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.panelTestSOng.Controls.Add(this.label2);
            this.panelTestSOng.Controls.Add(this.labelNameSong);
            this.panelTestSOng.Controls.Add(this.pbTestSong);
            this.panelTestSOng.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTestSOng.Enabled = false;
            this.panelTestSOng.Location = new System.Drawing.Point(1, 1);
            this.panelTestSOng.Margin = new System.Windows.Forms.Padding(1);
            this.panelTestSOng.Name = "panelTestSOng";
            this.panelTestSOng.Size = new System.Drawing.Size(637, 67);
            this.panelTestSOng.TabIndex = 0;
            this.panelTestSOng.Visible = false;
            this.panelTestSOng.Click += new System.EventHandler(this.panelTestSOng_Click);
            this.panelTestSOng.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTestSOng_Paint);
            this.panelTestSOng.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTestSOng_MouseDown);
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
            this.labelNameSong.Size = new System.Drawing.Size(114, 13);
            this.labelNameSong.TabIndex = 1;
            this.labelNameSong.Text = "ASI DFLKSDFKLSDJF";
            this.labelNameSong.Click += new System.EventHandler(this.labelNameSong_Click);
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
            // panelSongOptions
            // 
            this.panelSongOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.panelSongOptions.Controls.Add(this.label5);
            this.panelSongOptions.Controls.Add(this.labelInfo);
            this.panelSongOptions.Controls.Add(this.label3);
            this.panelSongOptions.Controls.Add(this.label1);
            this.panelSongOptions.Enabled = false;
            this.panelSongOptions.Location = new System.Drawing.Point(3, 72);
            this.panelSongOptions.Name = "panelSongOptions";
            this.panelSongOptions.Size = new System.Drawing.Size(200, 126);
            this.panelSongOptions.TabIndex = 3;
            this.panelSongOptions.Visible = false;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(0, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Add playlist";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelInfo.Location = new System.Drawing.Point(0, 60);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(200, 30);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Info";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInfo.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(0, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Favorite";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInfoSong
            // 
            this.panelInfoSong.Controls.Add(this.label4);
            this.panelInfoSong.Controls.Add(this.labelRate);
            this.panelInfoSong.Controls.Add(this.labelLaunchDate);
            this.panelInfoSong.Controls.Add(this.labelAlbum);
            this.panelInfoSong.Controls.Add(this.label6);
            this.panelInfoSong.Controls.Add(this.labelGenre);
            this.panelInfoSong.Enabled = false;
            this.panelInfoSong.Location = new System.Drawing.Point(209, 72);
            this.panelInfoSong.Name = "panelInfoSong";
            this.panelInfoSong.Size = new System.Drawing.Size(200, 130);
            this.panelInfoSong.TabIndex = 4;
            this.panelInfoSong.Visible = false;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Enabled = false;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(0, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rate";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // labelRate
            // 
            this.labelRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRate.Enabled = false;
            this.labelRate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRate.Location = new System.Drawing.Point(0, 84);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(200, 21);
            this.labelRate.TabIndex = 5;
            this.labelRate.Text = "Rate";
            this.labelRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRate.Visible = false;
            // 
            // labelLaunchDate
            // 
            this.labelLaunchDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLaunchDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLaunchDate.Location = new System.Drawing.Point(0, 63);
            this.labelLaunchDate.Name = "labelLaunchDate";
            this.labelLaunchDate.Size = new System.Drawing.Size(200, 21);
            this.labelLaunchDate.TabIndex = 4;
            this.labelLaunchDate.Text = "Launch";
            this.labelLaunchDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAlbum
            // 
            this.labelAlbum.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAlbum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAlbum.Location = new System.Drawing.Point(0, 42);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(200, 21);
            this.labelAlbum.TabIndex = 3;
            this.labelAlbum.Text = "Album";
            this.labelAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(0, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Artista";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGenre
            // 
            this.labelGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.labelGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGenre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGenre.Location = new System.Drawing.Point(0, 0);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(200, 21);
            this.labelGenre.TabIndex = 1;
            this.labelGenre.Text = "Genre";
            this.labelGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(415, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panelplaylit
            // 
            this.panelplaylit.AutoScroll = true;
            this.panelplaylit.Location = new System.Drawing.Point(421, 72);
            this.panelplaylit.Name = "panelplaylit";
            this.panelplaylit.Size = new System.Drawing.Size(182, 63);
            this.panelplaylit.TabIndex = 6;
            this.panelplaylit.Visible = false;
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
            this.pictureBoxLoading.Location = new System.Drawing.Point(211, 30);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(226, 221);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoading.TabIndex = 2;
            this.pictureBoxLoading.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.labelHomeTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 40);
            this.panel2.TabIndex = 2;
            // 
            // labelHomeTitle
            // 
            this.labelHomeTitle.AutoSize = true;
            this.labelHomeTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHomeTitle.Location = new System.Drawing.Point(256, 7);
            this.labelHomeTitle.Name = "labelHomeTitle";
            this.labelHomeTitle.Size = new System.Drawing.Size(100, 30);
            this.labelHomeTitle.TabIndex = 1;
            this.labelHomeTitle.Text = "H o m e";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLoadingMainMenu);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(643, 360);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Enter += new System.EventHandler(this.MainMenu_Enter);
            this.panelLoadingMainMenu.ResumeLayout(false);
            this.panelLoadingMainMenu.PerformLayout();
            this.panelMainmenu.ResumeLayout(false);
            this.SongsContainerPanelFlow.ResumeLayout(false);
            this.SongsContainerPanelFlow.PerformLayout();
            this.panelTestSOng.ResumeLayout(false);
            this.panelTestSOng.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestSong)).EndInit();
            this.panelSongOptions.ResumeLayout(false);
            this.panelInfoSong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoadingMainMenu;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Panel panelMainmenu;
        private System.Windows.Forms.Panel panelTestSOng;
        private System.Windows.Forms.PictureBox pbTestSong;
        private System.Windows.Forms.Label labelNameSong;
        private System.Windows.Forms.FlowLayoutPanel SongsContainerPanelFlow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSongOptions;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelInfoSong;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelLaunchDate;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelplaylit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelHomeTitle;
    }
}
