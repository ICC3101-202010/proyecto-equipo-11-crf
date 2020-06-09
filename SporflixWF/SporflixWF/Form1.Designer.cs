
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loading1 = new Spotflix.Loading();
            this.mainMenu2 = new Spotflix.MainMenu();
            this.mixer2 = new Spotflix.Mixer();
            this.videoPlayer2 = new SporflixWF.VideoPlayer();
            this.notPremium1 = new SporflixWF.NotPremium();
            this.profile1 = new Spotflix.Profile();
            this.library1 = new Spotflix.Library();
            this.playerBar1 = new Spotflix.PlayerBar();
            this.menuBar1 = new SporflixWF.MenuBar();
            this.preferences1 = new Spotflix.Preferences();
            this.logIn1 = new Spotflix.LogIn();
            this.mailValidation1 = new Spotflix.MailValidation();
            this.register1 = new Spotflix.Register();
            this.welcome1 = new Spotflix.Welcome();
            this.finderr1 = new Spotflix.Finderr();
            this.SuspendLayout();
            // 
            // loading1
            // 
            this.loading1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loading1.CausesValidation = false;
            this.loading1.Location = new System.Drawing.Point(0, 0);
            this.loading1.Name = "loading1";
            this.loading1.Size = new System.Drawing.Size(643, 436);
            this.loading1.TabIndex = 18;
            // 
            // mainMenu2
            // 
            this.mainMenu2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mainMenu2.Location = new System.Drawing.Point(0, 0);
            this.mainMenu2.Name = "mainMenu2";
            this.mainMenu2.Size = new System.Drawing.Size(643, 347);
            this.mainMenu2.TabIndex = 17;
            // 
            // mixer2
            // 
            this.mixer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mixer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.mixer2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mixer2.BackgroundImage")));
            this.mixer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mixer2.Location = new System.Drawing.Point(0, 0);
            this.mixer2.Name = "mixer2";
            this.mixer2.Size = new System.Drawing.Size(641, 347);
            this.mixer2.TabIndex = 16;
            // 
            // videoPlayer2
            // 
            this.videoPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.videoPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.videoPlayer2.Location = new System.Drawing.Point(0, 0);
            this.videoPlayer2.Name = "videoPlayer2";
            this.videoPlayer2.Size = new System.Drawing.Size(641, 378);
            this.videoPlayer2.TabIndex = 15;
            // 
            // notPremium1
            // 
            this.notPremium1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.notPremium1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.notPremium1.Location = new System.Drawing.Point(0, 0);
            this.notPremium1.Name = "notPremium1";
            this.notPremium1.Size = new System.Drawing.Size(641, 347);
            this.notPremium1.TabIndex = 14;
            // 
            // profile1
            // 
            this.profile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.profile1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.profile1.Location = new System.Drawing.Point(0, 0);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(641, 347);
            this.profile1.TabIndex = 13;
            // 
            // library1
            // 
            this.library1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.library1.AutoScroll = true;
            this.library1.AutoSize = true;
            this.library1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.library1.Enabled = false;
            this.library1.Location = new System.Drawing.Point(0, 0);
            this.library1.Name = "library1";
            this.library1.Size = new System.Drawing.Size(641, 347);
            this.library1.TabIndex = 12;
            // 
            // playerBar1
            // 
            this.playerBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playerBar1.Location = new System.Drawing.Point(0, 343);
            this.playerBar1.Name = "playerBar1";
            this.playerBar1.Size = new System.Drawing.Size(644, 35);
            this.playerBar1.TabIndex = 9;
            // 
            // menuBar1
            // 
            this.menuBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.menuBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.menuBar1.Location = new System.Drawing.Point(0, 378);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(641, 58);
            this.menuBar1.TabIndex = 8;
            this.menuBar1.Load += new System.EventHandler(this.menuBar1_Load);
            // 
            // preferences1
            // 
            this.preferences1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.preferences1.Location = new System.Drawing.Point(0, 0);
            this.preferences1.Name = "preferences1";
            this.preferences1.Size = new System.Drawing.Size(641, 436);
            this.preferences1.TabIndex = 4;
            // 
            // logIn1
            // 
            this.logIn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logIn1.AutoSize = true;
            this.logIn1.Location = new System.Drawing.Point(0, 0);
            this.logIn1.Name = "logIn1";
            this.logIn1.Size = new System.Drawing.Size(641, 436);
            this.logIn1.TabIndex = 3;
            // 
            // mailValidation1
            // 
            this.mailValidation1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mailValidation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.mailValidation1.Location = new System.Drawing.Point(0, 0);
            this.mailValidation1.Name = "mailValidation1";
            this.mailValidation1.Size = new System.Drawing.Size(641, 436);
            this.mailValidation1.TabIndex = 2;
            // 
            // register1
            // 
            this.register1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register1.Location = new System.Drawing.Point(0, 0);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(641, 436);
            this.register1.TabIndex = 1;
            // 
            // welcome1
            // 
            this.welcome1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcome1.Location = new System.Drawing.Point(0, 0);
            this.welcome1.Name = "welcome1";
            this.welcome1.Size = new System.Drawing.Size(641, 436);
            this.welcome1.TabIndex = 0;
            // 
            // finderr1
            // 
            this.finderr1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.finderr1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.finderr1.Location = new System.Drawing.Point(0, 0);
            this.finderr1.Name = "finderr1";
            this.finderr1.Size = new System.Drawing.Size(644, 347);
            this.finderr1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(641, 436);
            this.Controls.Add(this.loading1);
            this.Controls.Add(this.mainMenu2);
            this.Controls.Add(this.mixer2);
            this.Controls.Add(this.videoPlayer2);
            this.Controls.Add(this.notPremium1);
            this.Controls.Add(this.profile1);
            this.Controls.Add(this.library1);
            this.Controls.Add(this.playerBar1);
            this.Controls.Add(this.menuBar1);
            this.Controls.Add(this.preferences1);
            this.Controls.Add(this.logIn1);
            this.Controls.Add(this.mailValidation1);
            this.Controls.Add(this.register1);
            this.Controls.Add(this.welcome1);
            this.Controls.Add(this.finderr1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Welcome welcome1;
        private Register register1;
        private MailValidation mailValidation1;
        private LogIn logIn1;
        private Preferences preferences1;
        private MainMenu mainMenu1;
        private Finderr finderr1;
        private SporflixWF.MenuBar menuBar1;
        private PlayerBar playerBar1;
        private Mixer mixer1;
        private Library library1;
        private Profile profile1;
        private SporflixWF.VideoPlayer videoPlayer1;
        private SporflixWF.NotPremium notPremium1;
        private SporflixWF.VideoPlayer videoPlayer2;
        private Mixer mixer2;
        private MainMenu mainMenu2;
        private Loading loading1;
    }
}

