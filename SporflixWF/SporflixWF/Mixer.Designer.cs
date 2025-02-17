﻿namespace Spotflix
{
    partial class Mixer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mixer));
            this.comboBoxMixer = new System.Windows.Forms.ComboBox();
            this.buttonPlayMixer = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonEfect1 = new System.Windows.Forms.Button();
            this.buttonEfect2 = new System.Windows.Forms.Button();
            this.buttonEfect3 = new System.Windows.Forms.Button();
            this.buttonEfect4 = new System.Windows.Forms.Button();
            this.buttonRadio = new System.Windows.Forms.Button();
            this.panelRadio = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMixer
            // 
            this.comboBoxMixer.FormattingEnabled = true;
            this.comboBoxMixer.Location = new System.Drawing.Point(34, 18);
            this.comboBoxMixer.Name = "comboBoxMixer";
            this.comboBoxMixer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMixer.TabIndex = 0;
            // 
            // buttonPlayMixer
            // 
            this.buttonPlayMixer.Location = new System.Drawing.Point(184, 18);
            this.buttonPlayMixer.Name = "buttonPlayMixer";
            this.buttonPlayMixer.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayMixer.TabIndex = 1;
            this.buttonPlayMixer.Text = "Play";
            this.buttonPlayMixer.UseVisualStyleBackColor = true;
            this.buttonPlayMixer.Click += new System.EventHandler(this.buttonPlayMixer_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(184, 47);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 2;
            this.buttonPause.Text = "Stop";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonEfect1
            // 
            this.buttonEfect1.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonEfect1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEfect1.Location = new System.Drawing.Point(418, 18);
            this.buttonEfect1.Name = "buttonEfect1";
            this.buttonEfect1.Size = new System.Drawing.Size(51, 47);
            this.buttonEfect1.TabIndex = 3;
            this.buttonEfect1.Text = "◤";
            this.buttonEfect1.UseVisualStyleBackColor = false;
            this.buttonEfect1.Click += new System.EventHandler(this.buttonEfect1_Click);
            // 
            // buttonEfect2
            // 
            this.buttonEfect2.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonEfect2.Location = new System.Drawing.Point(475, 18);
            this.buttonEfect2.Name = "buttonEfect2";
            this.buttonEfect2.Size = new System.Drawing.Size(51, 47);
            this.buttonEfect2.TabIndex = 4;
            this.buttonEfect2.Text = "◥";
            this.buttonEfect2.UseVisualStyleBackColor = false;
            this.buttonEfect2.Click += new System.EventHandler(this.buttonEfect2_Click);
            // 
            // buttonEfect3
            // 
            this.buttonEfect3.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonEfect3.Location = new System.Drawing.Point(418, 71);
            this.buttonEfect3.Name = "buttonEfect3";
            this.buttonEfect3.Size = new System.Drawing.Size(51, 47);
            this.buttonEfect3.TabIndex = 5;
            this.buttonEfect3.Text = "◣";
            this.buttonEfect3.UseVisualStyleBackColor = false;
            this.buttonEfect3.Click += new System.EventHandler(this.buttonEfect3_Click);
            // 
            // buttonEfect4
            // 
            this.buttonEfect4.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonEfect4.Location = new System.Drawing.Point(475, 71);
            this.buttonEfect4.Name = "buttonEfect4";
            this.buttonEfect4.Size = new System.Drawing.Size(51, 47);
            this.buttonEfect4.TabIndex = 6;
            this.buttonEfect4.Text = "◢";
            this.buttonEfect4.UseVisualStyleBackColor = false;
            this.buttonEfect4.Click += new System.EventHandler(this.buttonEfect4_Click);
            // 
            // buttonRadio
            // 
            this.buttonRadio.Location = new System.Drawing.Point(184, 76);
            this.buttonRadio.Name = "buttonRadio";
            this.buttonRadio.Size = new System.Drawing.Size(75, 23);
            this.buttonRadio.TabIndex = 7;
            this.buttonRadio.Text = "Radio";
            this.buttonRadio.UseVisualStyleBackColor = true;
            this.buttonRadio.Click += new System.EventHandler(this.buttonRadio_Click);
            // 
            // panelRadio
            // 
            this.panelRadio.Controls.Add(this.button3);
            this.panelRadio.Controls.Add(this.button2);
            this.panelRadio.Controls.Add(this.button1);
            this.panelRadio.Controls.Add(this.axWindowsMediaPlayer1);
            this.panelRadio.Location = new System.Drawing.Point(151, 180);
            this.panelRadio.Name = "panelRadio";
            this.panelRadio.Size = new System.Drawing.Size(398, 166);
            this.panelRadio.TabIndex = 8;
            this.panelRadio.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(295, 166);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(291, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 51);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(291, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 51);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(291, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 51);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Mixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.BackgroundImage = global::SporflixWF.Properties.Resources.dj;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelRadio);
            this.Controls.Add(this.buttonRadio);
            this.Controls.Add(this.buttonEfect4);
            this.Controls.Add(this.buttonEfect3);
            this.Controls.Add(this.buttonEfect2);
            this.Controls.Add(this.buttonEfect1);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonPlayMixer);
            this.Controls.Add(this.comboBoxMixer);
            this.Name = "Mixer";
            this.Size = new System.Drawing.Size(552, 349);
            this.panelRadio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMixer;
        private System.Windows.Forms.Button buttonPlayMixer;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonEfect1;
        private System.Windows.Forms.Button buttonEfect2;
        private System.Windows.Forms.Button buttonEfect3;
        private System.Windows.Forms.Button buttonEfect4;
        private System.Windows.Forms.Button buttonRadio;
        private System.Windows.Forms.Panel panelRadio;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
