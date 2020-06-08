namespace SporflixWF
{
    partial class VideoPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayer));
            this.flowLayoutPanelVideo = new System.Windows.Forms.FlowLayoutPanel();
            this.panelPlayVideo = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonStartVid = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.panelPlayVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelVideo
            // 
            this.flowLayoutPanelVideo.Location = new System.Drawing.Point(3, 57);
            this.flowLayoutPanelVideo.Name = "flowLayoutPanelVideo";
            this.flowLayoutPanelVideo.Size = new System.Drawing.Size(637, 289);
            this.flowLayoutPanelVideo.TabIndex = 0;
            // 
            // panelPlayVideo
            // 
            this.panelPlayVideo.Controls.Add(this.buttonStop);
            this.panelPlayVideo.Controls.Add(this.buttonPause);
            this.panelPlayVideo.Controls.Add(this.axWindowsMediaPlayer1);
            this.panelPlayVideo.Controls.Add(this.buttonStartVid);
            this.panelPlayVideo.Location = new System.Drawing.Point(3, 3);
            this.panelPlayVideo.Name = "panelPlayVideo";
            this.panelPlayVideo.Size = new System.Drawing.Size(640, 343);
            this.panelPlayVideo.TabIndex = 0;
            this.panelPlayVideo.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 42);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(634, 301);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // buttonStartVid
            // 
            this.buttonStartVid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartVid.Location = new System.Drawing.Point(3, 3);
            this.buttonStartVid.Name = "buttonStartVid";
            this.buttonStartVid.Size = new System.Drawing.Size(46, 33);
            this.buttonStartVid.TabIndex = 4;
            this.buttonStartVid.Text = "▶";
            this.buttonStartVid.UseVisualStyleBackColor = true;
            this.buttonStartVid.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPause.Location = new System.Drawing.Point(55, 3);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(47, 33);
            this.buttonPause.TabIndex = 5;
            this.buttonPause.Text = "⏸";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(108, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(47, 33);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "⏹";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // VideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panelPlayVideo);
            this.Controls.Add(this.flowLayoutPanelVideo);
            this.Name = "VideoPlayer";
            this.Size = new System.Drawing.Size(643, 360);
            this.panelPlayVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVideo;
        private System.Windows.Forms.Panel panelPlayVideo;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button buttonStartVid;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStop;
    }
}
