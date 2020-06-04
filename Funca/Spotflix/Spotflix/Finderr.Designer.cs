namespace Spotflix
{
    partial class Finderr
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxFind = new System.Windows.Forms.ComboBox();
            this.labelFinder = new System.Windows.Forms.Label();
            this.panelMostrar = new System.Windows.Forms.Panel();
            this.buttonMetadata = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonRate = new System.Windows.Forms.Button();
            this.ButtonFavorite = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.comboBoxFound = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panelMostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.textBoxFind);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.comboBoxFind);
            this.panel1.Controls.Add(this.labelFinder);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 382);
            this.panel1.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(107, 340);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(160, 88);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(116, 20);
            this.textBoxFind.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(107, 301);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxFind
            // 
            this.comboBoxFind.FormattingEnabled = true;
            this.comboBoxFind.Items.AddRange(new object[] {
            "Song",
            "Video",
            "Playlist",
            "Actor/Director",
            "Band",
            "Album",
            "Top Streamed",
            "Top Rated",
            "User"});
            this.comboBoxFind.Location = new System.Drawing.Point(10, 88);
            this.comboBoxFind.Name = "comboBoxFind";
            this.comboBoxFind.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFind.TabIndex = 2;
            // 
            // labelFinder
            // 
            this.labelFinder.AutoSize = true;
            this.labelFinder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinder.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFinder.Location = new System.Drawing.Point(120, 30);
            this.labelFinder.Name = "labelFinder";
            this.labelFinder.Size = new System.Drawing.Size(62, 22);
            this.labelFinder.TabIndex = 0;
            this.labelFinder.Text = "Finder";
            // 
            // panelMostrar
            // 
            this.panelMostrar.Controls.Add(this.comboBoxFound);
            this.panelMostrar.Controls.Add(this.buttonMetadata);
            this.panelMostrar.Controls.Add(this.buttonDownload);
            this.panelMostrar.Controls.Add(this.buttonRate);
            this.panelMostrar.Controls.Add(this.ButtonFavorite);
            this.panelMostrar.Controls.Add(this.buttonPlay);

            this.panelMostrar.Location = new System.Drawing.Point(305, 0);

            
            this.panelMostrar.Location = new System.Drawing.Point(305, 3);

            this.panelMostrar.Name = "panelMostrar";
            this.panelMostrar.Size = new System.Drawing.Size(345, 385);
            this.panelMostrar.TabIndex = 1;
            this.panelMostrar.Visible = false;
            // 
            // buttonMetadata
            // 
            this.buttonMetadata.Location = new System.Drawing.Point(195, 222);
            this.buttonMetadata.Name = "buttonMetadata";
            this.buttonMetadata.Size = new System.Drawing.Size(75, 23);
            this.buttonMetadata.TabIndex = 5;
            this.buttonMetadata.Text = "Metadata";
            this.buttonMetadata.UseVisualStyleBackColor = true;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(195, 177);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(75, 23);
            this.buttonDownload.TabIndex = 4;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            // 
            // buttonRate
            // 
            this.buttonRate.Location = new System.Drawing.Point(195, 135);
            this.buttonRate.Name = "buttonRate";
            this.buttonRate.Size = new System.Drawing.Size(75, 23);
            this.buttonRate.TabIndex = 3;
            this.buttonRate.Text = "Rate";
            this.buttonRate.UseVisualStyleBackColor = true;
            // 
            // ButtonFavorite
            // 
            this.ButtonFavorite.Location = new System.Drawing.Point(195, 91);
            this.ButtonFavorite.Name = "ButtonFavorite";
            this.ButtonFavorite.Size = new System.Drawing.Size(75, 23);
            this.ButtonFavorite.TabIndex = 2;
            this.ButtonFavorite.Text = "Favorite";
            this.ButtonFavorite.UseVisualStyleBackColor = true;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(195, 53);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            // 
            // comboBoxFound
            // 
            this.comboBoxFound.FormattingEnabled = true;
            this.comboBoxFound.Location = new System.Drawing.Point(43, 90);
            this.comboBoxFound.Name = "comboBoxFound";
            this.comboBoxFound.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFound.TabIndex = 6;
            // 
            // Finderr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelMostrar);
            this.Controls.Add(this.panel1);
            this.Name = "Finderr";
            this.Size = new System.Drawing.Size(650, 385);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMostrar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxFind;
        private System.Windows.Forms.Label labelFinder;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Panel panelMostrar;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonRate;
        private System.Windows.Forms.Button ButtonFavorite;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonMetadata;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxFound;
    }
}
