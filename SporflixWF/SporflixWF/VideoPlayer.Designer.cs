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
            this.button1 = new System.Windows.Forms.Button();
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
            this.panelPlayVideo.Controls.Add(this.axWindowsMediaPlayer1);
            this.panelPlayVideo.Controls.Add(this.button1);
            this.panelPlayVideo.Location = new System.Drawing.Point(3, 3);
            this.panelPlayVideo.Name = "panelPlayVideo";
            this.panelPlayVideo.Size = new System.Drawing.Size(640, 343);
            this.panelPlayVideo.TabIndex = 0;
            this.panelPlayVideo.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(637, 343);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.Visible = false;
            
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button button1;
    }
}
