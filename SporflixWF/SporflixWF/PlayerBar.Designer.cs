namespace Spotflix
{
    partial class PlayerBar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerBar));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBarContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDurationContainer = new System.Windows.Forms.Panel();
            this.labelDuration = new System.Windows.Forms.Label();
            this.pbPlayStop = new System.Windows.Forms.PictureBox();
            this.ProgressBarSong = new XComponent.SliderBar.MACTrackBar();
            this.panelBarContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDurationContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayStop)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelBarContainer
            // 
            this.panelBarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.panelBarContainer.Controls.Add(this.pictureBox1);
            this.panelBarContainer.Controls.Add(this.panelDurationContainer);
            this.panelBarContainer.Controls.Add(this.pbPlayStop);
            this.panelBarContainer.Controls.Add(this.ProgressBarSong);
            this.panelBarContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBarContainer.Location = new System.Drawing.Point(0, 0);
            this.panelBarContainer.Name = "panelBarContainer";
            this.panelBarContainer.Size = new System.Drawing.Size(637, 35);
            this.panelBarContainer.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panelDurationContainer
            // 
            this.panelDurationContainer.Controls.Add(this.labelDuration);
            this.panelDurationContainer.Location = new System.Drawing.Point(492, 3);
            this.panelDurationContainer.Name = "panelDurationContainer";
            this.panelDurationContainer.Size = new System.Drawing.Size(142, 29);
            this.panelDurationContainer.TabIndex = 17;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDuration.Location = new System.Drawing.Point(63, 9);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(35, 13);
            this.labelDuration.TabIndex = 0;
            this.labelDuration.Text = "label1";
            // 
            // pbPlayStop
            // 
            this.pbPlayStop.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayStop.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayStop.Image")));
            this.pbPlayStop.Location = new System.Drawing.Point(3, 3);
            this.pbPlayStop.Name = "pbPlayStop";
            this.pbPlayStop.Size = new System.Drawing.Size(39, 29);
            this.pbPlayStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayStop.TabIndex = 16;
            this.pbPlayStop.TabStop = false;
            // 
            // ProgressBarSong
            // 
            this.ProgressBarSong.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBarSong.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.ProgressBarSong.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBarSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.ProgressBarSong.IndentHeight = 6;
            this.ProgressBarSong.Location = new System.Drawing.Point(98, 3);
            this.ProgressBarSong.Maximum = 10;
            this.ProgressBarSong.Minimum = 0;
            this.ProgressBarSong.Name = "ProgressBarSong";
            this.ProgressBarSong.Size = new System.Drawing.Size(388, 29);
            this.ProgressBarSong.TabIndex = 15;
            this.ProgressBarSong.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.ProgressBarSong.TickColor = System.Drawing.Color.Indigo;
            this.ProgressBarSong.TickHeight = 4;
            this.ProgressBarSong.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ProgressBarSong.TrackerColor = System.Drawing.Color.Gray;
            this.ProgressBarSong.TrackerSize = new System.Drawing.Size(8, 17);
            this.ProgressBarSong.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProgressBarSong.TrackLineHeight = 3;
            this.ProgressBarSong.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.ProgressBarSong.Value = 0;
            this.ProgressBarSong.Scroll += new System.EventHandler(this.ProgressBarSong_Scroll_1);
            // 

            // pbPlayStop
            // 
            this.pbPlayStop.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayStop.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayStop.Image")));
            this.pbPlayStop.Location = new System.Drawing.Point(3, 3);
            this.pbPlayStop.Name = "pbPlayStop";
            this.pbPlayStop.Size = new System.Drawing.Size(39, 29);
            this.pbPlayStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayStop.TabIndex = 16;
            this.pbPlayStop.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 

            // PlayerBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBarContainer);
            this.Name = "PlayerBar";
            this.Size = new System.Drawing.Size(637, 35);
            this.panelBarContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDurationContainer.ResumeLayout(false);
            this.panelDurationContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayStop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelBarContainer;
        private XComponent.SliderBar.MACTrackBar ProgressBarSong;
        private System.Windows.Forms.Panel panelDurationContainer;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbPlayStop;
    }
}
