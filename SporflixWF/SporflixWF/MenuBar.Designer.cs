using Spotflix;

namespace SporflixWF
{
    partial class MenuBar
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonMixer = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLibrary = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonFinder = new System.Windows.Forms.Button();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.profile = new Spotflix.Profile();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonVideo = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(644, 58);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.flowLayoutPanel2.Controls.Add(this.buttonMixer);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(97, 52);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // buttonMixer
            // 
            this.buttonMixer.AutoSize = true;
            this.buttonMixer.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonMixer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMixer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMixer.Location = new System.Drawing.Point(3, 3);
            this.buttonMixer.Margin = new System.Windows.Forms.Padding(3, 3, 43, 3);
            this.buttonMixer.Name = "buttonMixer";
            this.buttonMixer.Size = new System.Drawing.Size(94, 43);
            this.buttonMixer.TabIndex = 6;
            this.buttonMixer.Text = "Mixer";
            this.buttonMixer.UseVisualStyleBackColor = false;
            this.buttonMixer.Click += new System.EventHandler(this.buttonMixer_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.flowLayoutPanel3.Controls.Add(this.buttonLibrary);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(106, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(96, 52);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // buttonLibrary
            // 
            this.buttonLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLibrary.AutoSize = true;
            this.buttonLibrary.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLibrary.Location = new System.Drawing.Point(3, 3);
            this.buttonLibrary.Margin = new System.Windows.Forms.Padding(3, 3, 43, 3);
            this.buttonLibrary.Name = "buttonLibrary";
            this.buttonLibrary.Size = new System.Drawing.Size(93, 43);
            this.buttonLibrary.TabIndex = 8;
            this.buttonLibrary.Text = "Library";
            this.buttonLibrary.UseVisualStyleBackColor = false;
            this.buttonLibrary.Click += new System.EventHandler(this.buttonLibrary_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.flowLayoutPanel4.Controls.Add(this.buttonHome);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(208, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(97, 52);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // buttonHome
            // 
            this.buttonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHome.AutoSize = true;
            this.buttonHome.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Location = new System.Drawing.Point(3, 3);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(3, 3, 43, 3);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(94, 43);
            this.buttonHome.TabIndex = 7;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.flowLayoutPanel5.Controls.Add(this.buttonFinder);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(311, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(105, 52);
            this.flowLayoutPanel5.TabIndex = 3;
            // 
            // buttonFinder
            // 
            this.buttonFinder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinder.AutoSize = true;
            this.buttonFinder.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonFinder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinder.Location = new System.Drawing.Point(3, 3);
            this.buttonFinder.Margin = new System.Windows.Forms.Padding(3, 3, 43, 3);
            this.buttonFinder.Name = "buttonFinder";
            this.buttonFinder.Size = new System.Drawing.Size(102, 43);
            this.buttonFinder.TabIndex = 7;
            this.buttonFinder.Text = "Finder";
            this.buttonFinder.UseVisualStyleBackColor = false;
            this.buttonFinder.Click += new System.EventHandler(this.buttonFinder_Click_1);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.flowLayoutPanel6.Controls.Add(this.buttonProfile);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(422, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(97, 52);
            this.flowLayoutPanel6.TabIndex = 9;
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonProfile.Location = new System.Drawing.Point(3, 3);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(94, 43);
            this.buttonProfile.TabIndex = 0;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            Profile profile = new Profile();
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click_1);
            this.buttonProfile.Click += new System.EventHandler(profile.buttonProfile_Click_1);
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.profile.Location = new System.Drawing.Point(0, 0);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(634, 341);
            this.profile.TabIndex = 0;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.buttonVideo);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(525, 3);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(107, 52);
            this.flowLayoutPanel7.TabIndex = 1;
            // 
            // buttonVideo
            // 
            this.buttonVideo.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonVideo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonVideo.Location = new System.Drawing.Point(3, 3);
            this.buttonVideo.Name = "buttonVideo";
            this.buttonVideo.Size = new System.Drawing.Size(104, 43);
            this.buttonVideo.TabIndex = 7;
            this.buttonVideo.Text = "Video";
            this.buttonVideo.UseVisualStyleBackColor = false;
            this.buttonVideo.Click += new System.EventHandler(this.buttonVideo_Click);
            // 
            // MenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MenuBar";
            this.Size = new System.Drawing.Size(644, 58);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button buttonMixer;
        private System.Windows.Forms.Button buttonLibrary;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonFinder;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Button buttonProfile;
        private Profile profile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Button buttonVideo;
    }
}
