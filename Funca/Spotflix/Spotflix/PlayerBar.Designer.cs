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
            this.BarPanelFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.pbPlayStop = new System.Windows.Forms.PictureBox();
            this.ProgressBarSong = new XComponent.SliderBar.MACTrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BarPanelFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayStop)).BeginInit();
            this.SuspendLayout();
            // 
            // BarPanelFlow
            // 
            this.BarPanelFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.BarPanelFlow.Controls.Add(this.pbPlayStop);
            this.BarPanelFlow.Controls.Add(this.ProgressBarSong);
            this.BarPanelFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarPanelFlow.Location = new System.Drawing.Point(0, 0);
            this.BarPanelFlow.Name = "BarPanelFlow";
            this.BarPanelFlow.Size = new System.Drawing.Size(637, 35);
            this.BarPanelFlow.TabIndex = 0;
            // 
            // pbPlayStop
            // 
            this.pbPlayStop.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayStop.Location = new System.Drawing.Point(3, 3);
            this.pbPlayStop.Name = "pbPlayStop";
            this.pbPlayStop.Size = new System.Drawing.Size(65, 29);
            this.pbPlayStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayStop.TabIndex = 0;
            this.pbPlayStop.TabStop = false;
            // 
            // ProgressBarSong
            // 
            this.ProgressBarSong.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBarSong.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.ProgressBarSong.Dock = System.Windows.Forms.DockStyle.Right;
            this.ProgressBarSong.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBarSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.ProgressBarSong.IndentHeight = 6;
            this.ProgressBarSong.Location = new System.Drawing.Point(74, 3);
            this.ProgressBarSong.Maximum = 10;
            this.ProgressBarSong.Minimum = 0;
            this.ProgressBarSong.Name = "ProgressBarSong";
            this.ProgressBarSong.Size = new System.Drawing.Size(560, 29);
            this.ProgressBarSong.TabIndex = 1;
            this.ProgressBarSong.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.ProgressBarSong.TickColor = System.Drawing.Color.Indigo;
            this.ProgressBarSong.TickHeight = 4;
            this.ProgressBarSong.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ProgressBarSong.TrackerColor = System.Drawing.Color.Teal;
            this.ProgressBarSong.TrackerSize = new System.Drawing.Size(8, 17);
            this.ProgressBarSong.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ProgressBarSong.TrackLineHeight = 3;
            this.ProgressBarSong.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.ProgressBarSong.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            // 
            // PlayerBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BarPanelFlow);
            this.Name = "PlayerBar";
            this.Size = new System.Drawing.Size(637, 35);
            this.BarPanelFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayStop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel BarPanelFlow;
        private System.Windows.Forms.PictureBox pbPlayStop;
        private XComponent.SliderBar.MACTrackBar ProgressBarSong;
        private System.Windows.Forms.Timer timer1;
    }
}
