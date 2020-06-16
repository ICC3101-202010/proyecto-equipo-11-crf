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
            this.panelByRating = new System.Windows.Forms.Panel();
            this.buttonMenor = new System.Windows.Forms.Button();
            this.buttonMayor = new System.Windows.Forms.Button();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxFind = new System.Windows.Forms.ComboBox();
            this.labelFinder = new System.Windows.Forms.Label();
            this.panelFinderUser = new System.Windows.Forms.Panel();
            this.buttonFollow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxUsuarios = new System.Windows.Forms.ComboBox();
            this.panelMostrar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxFound = new System.Windows.Forms.ComboBox();
            this.panelRate = new System.Windows.Forms.Panel();
            this.labelRate = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.panelMetadata = new System.Windows.Forms.Panel();
            this.labelMetadata = new System.Windows.Forms.Label();
            this.listBoxMetadata = new System.Windows.Forms.ListBox();
            this.panelButttons = new System.Windows.Forms.Panel();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelFavorite = new System.Windows.Forms.Label();
            this.ButtonFavorite = new System.Windows.Forms.Button();
            this.buttonRate = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.labelDonload = new System.Windows.Forms.Label();
            this.buttonMetadata = new System.Windows.Forms.Button();
            this.buttonLyrics = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelByRating.SuspendLayout();
            this.panelFinderUser.SuspendLayout();
            this.panelMostrar.SuspendLayout();
            this.panelRate.SuspendLayout();
            this.panelMetadata.SuspendLayout();
            this.panelButttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelByRating);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.textBoxFind);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.comboBoxFind);
            this.panel1.Controls.Add(this.labelFinder);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 346);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelByRating
            // 
            this.panelByRating.Controls.Add(this.buttonMenor);
            this.panelByRating.Controls.Add(this.buttonMayor);
            this.panelByRating.Controls.Add(this.buttonIgual);
            this.panelByRating.Location = new System.Drawing.Point(55, 135);
            this.panelByRating.Name = "panelByRating";
            this.panelByRating.Size = new System.Drawing.Size(121, 37);
            this.panelByRating.TabIndex = 6;
            this.panelByRating.Visible = false;
            // 
            // buttonMenor
            // 
            this.buttonMenor.Location = new System.Drawing.Point(91, 5);
            this.buttonMenor.Name = "buttonMenor";
            this.buttonMenor.Size = new System.Drawing.Size(27, 29);
            this.buttonMenor.TabIndex = 2;
            this.buttonMenor.Text = "<";
            this.buttonMenor.UseVisualStyleBackColor = true;
            this.buttonMenor.Click += new System.EventHandler(this.buttonMenor_Click);
            // 
            // buttonMayor
            // 
            this.buttonMayor.Location = new System.Drawing.Point(3, 6);
            this.buttonMayor.Name = "buttonMayor";
            this.buttonMayor.Size = new System.Drawing.Size(27, 28);
            this.buttonMayor.TabIndex = 0;
            this.buttonMayor.Text = ">";
            this.buttonMayor.UseVisualStyleBackColor = true;
            this.buttonMayor.Click += new System.EventHandler(this.buttonMayor_Click);
            // 
            // buttonIgual
            // 
            this.buttonIgual.Location = new System.Drawing.Point(49, 5);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(27, 29);
            this.buttonIgual.TabIndex = 1;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = true;
            this.buttonIgual.Click += new System.EventHandler(this.buttonIgual_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(182, 177);
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
            this.buttonSearch.Location = new System.Drawing.Point(182, 135);
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
            "User",
            "Person Characteristics",
            "All",
            "Top Streamed",
            "Top Rated",
            "By Rating",
            "By Size"});
            this.comboBoxFind.Location = new System.Drawing.Point(10, 88);
            this.comboBoxFind.Name = "comboBoxFind";
            this.comboBoxFind.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFind.TabIndex = 2;
            // 
            // labelFinder
            // 
            this.labelFinder.AutoSize = true;
            this.labelFinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinder.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelFinder.Location = new System.Drawing.Point(120, 30);
            this.labelFinder.Name = "labelFinder";
            this.labelFinder.Size = new System.Drawing.Size(60, 20);
            this.labelFinder.TabIndex = 0;
            this.labelFinder.Text = "Finder";
            // 
            // panelFinderUser
            // 
            this.panelFinderUser.Controls.Add(this.buttonFollow);
            this.panelFinderUser.Controls.Add(this.label2);
            this.panelFinderUser.Controls.Add(this.comboBoxUsuarios);
            this.panelFinderUser.Location = new System.Drawing.Point(305, 3);
            this.panelFinderUser.Name = "panelFinderUser";
            this.panelFinderUser.Size = new System.Drawing.Size(339, 349);
            this.panelFinderUser.TabIndex = 11;
            this.panelFinderUser.Visible = false;
            // 
            // buttonFollow
            // 
            this.buttonFollow.Location = new System.Drawing.Point(91, 281);
            this.buttonFollow.Name = "buttonFollow";
            this.buttonFollow.Size = new System.Drawing.Size(104, 23);
            this.buttonFollow.TabIndex = 2;
            this.buttonFollow.Text = "Follow";
            this.buttonFollow.UseVisualStyleBackColor = true;
            this.buttonFollow.Click += new System.EventHandler(this.buttonFollow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "This are or Users, select the one you wish to Follow!";
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Location = new System.Drawing.Point(7, 33);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(270, 21);
            this.comboBoxUsuarios.TabIndex = 0;
            // 
            // panelMostrar
            // 
            this.panelMostrar.Controls.Add(this.panelMetadata);
            this.panelMostrar.Controls.Add(this.flowLayoutPanel1);
            this.panelMostrar.Controls.Add(this.comboBoxFound);
            this.panelMostrar.Controls.Add(this.panelRate);
            this.panelMostrar.Controls.Add(this.panelButttons);
            this.panelMostrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMostrar.Location = new System.Drawing.Point(305, 0);
            this.panelMostrar.Name = "panelMostrar";
            this.panelMostrar.Size = new System.Drawing.Size(345, 352);
            this.panelMostrar.TabIndex = 1;
            this.panelMostrar.Visible = false;
            this.panelMostrar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMostrar_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 244);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // comboBoxFound
            // 
            this.comboBoxFound.FormattingEnabled = true;
            this.comboBoxFound.Location = new System.Drawing.Point(16, 45);
            this.comboBoxFound.Name = "comboBoxFound";
            this.comboBoxFound.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFound.TabIndex = 6;
            // 
            // panelRate
            // 
            this.panelRate.Controls.Add(this.labelRate);
            this.panelRate.Controls.Add(this.buttonAccept);
            this.panelRate.Controls.Add(this.label1);
            this.panelRate.Controls.Add(this.textBoxRate);
            this.panelRate.Location = new System.Drawing.Point(9, 208);
            this.panelRate.Name = "panelRate";
            this.panelRate.Size = new System.Drawing.Size(311, 112);
            this.panelRate.TabIndex = 7;
            this.panelRate.Visible = false;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRate.Location = new System.Drawing.Point(25, 73);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(105, 13);
            this.labelRate.TabIndex = 6;
            this.labelRate.Text = "Insert a valid number";
            this.labelRate.Visible = false;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(180, 30);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 5;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stars (0-5)";
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(28, 33);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxRate.TabIndex = 0;
            // 
            // panelMetadata
            // 
            this.panelMetadata.Controls.Add(this.labelMetadata);
            this.panelMetadata.Controls.Add(this.listBoxMetadata);
            this.panelMetadata.Location = new System.Drawing.Point(19, 193);
            this.panelMetadata.Name = "panelMetadata";
            this.panelMetadata.Size = new System.Drawing.Size(323, 128);
            this.panelMetadata.TabIndex = 7;
            this.panelMetadata.Visible = false;
            this.panelMetadata.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelMetadata
            // 
            this.labelMetadata.AutoSize = true;
            this.labelMetadata.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelMetadata.Location = new System.Drawing.Point(9, 4);
            this.labelMetadata.Name = "labelMetadata";
            this.labelMetadata.Size = new System.Drawing.Size(55, 13);
            this.labelMetadata.TabIndex = 0;
            this.labelMetadata.Text = "Metadada";
            // 
            // listBoxMetadata
            // 
            this.listBoxMetadata.FormattingEnabled = true;
            this.listBoxMetadata.Location = new System.Drawing.Point(20, 20);
            this.listBoxMetadata.Name = "listBoxMetadata";
            this.listBoxMetadata.Size = new System.Drawing.Size(279, 95);
            this.listBoxMetadata.TabIndex = 1;
            // 
            // panelButttons
            // 
            this.panelButttons.Controls.Add(this.buttonLyrics);
            this.panelButttons.Controls.Add(this.buttonPlay);
            this.panelButttons.Controls.Add(this.labelFavorite);
            this.panelButttons.Controls.Add(this.ButtonFavorite);
            this.panelButttons.Controls.Add(this.buttonRate);
            this.panelButttons.Controls.Add(this.buttonDownload);
            this.panelButttons.Controls.Add(this.labelDonload);
            this.panelButttons.Controls.Add(this.buttonMetadata);
            this.panelButttons.Location = new System.Drawing.Point(170, 6);
            this.panelButttons.Name = "panelButttons";
            this.panelButttons.Size = new System.Drawing.Size(148, 181);
            this.panelButttons.TabIndex = 11;
            this.panelButttons.Visible = false;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(34, 3);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click_1);
            // 
            // labelFavorite
            // 
            this.labelFavorite.AutoSize = true;
            this.labelFavorite.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFavorite.Location = new System.Drawing.Point(115, 37);
            this.labelFavorite.Name = "labelFavorite";
            this.labelFavorite.Size = new System.Drawing.Size(19, 13);
            this.labelFavorite.TabIndex = 10;
            this.labelFavorite.Text = "✅";
            this.labelFavorite.Visible = false;
            // 
            // ButtonFavorite
            // 
            this.ButtonFavorite.Location = new System.Drawing.Point(34, 32);
            this.ButtonFavorite.Name = "ButtonFavorite";
            this.ButtonFavorite.Size = new System.Drawing.Size(75, 23);
            this.ButtonFavorite.TabIndex = 2;
            this.ButtonFavorite.Text = "Favorite";
            this.ButtonFavorite.UseVisualStyleBackColor = true;
            this.ButtonFavorite.Click += new System.EventHandler(this.ButtonFavorite_Click);
            // 
            // buttonRate
            // 
            this.buttonRate.Location = new System.Drawing.Point(34, 61);
            this.buttonRate.Name = "buttonRate";
            this.buttonRate.Size = new System.Drawing.Size(75, 23);
            this.buttonRate.TabIndex = 3;
            this.buttonRate.Text = "Rate";
            this.buttonRate.UseVisualStyleBackColor = true;
            this.buttonRate.Click += new System.EventHandler(this.buttonRate_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(34, 90);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(75, 23);
            this.buttonDownload.TabIndex = 4;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // labelDonload
            // 
            this.labelDonload.AutoSize = true;
            this.labelDonload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDonload.Location = new System.Drawing.Point(115, 95);
            this.labelDonload.Name = "labelDonload";
            this.labelDonload.Size = new System.Drawing.Size(19, 13);
            this.labelDonload.TabIndex = 8;
            this.labelDonload.Text = "✅";
            this.labelDonload.Visible = false;
            // 
            // buttonMetadata
            // 
            this.buttonMetadata.Location = new System.Drawing.Point(34, 119);
            this.buttonMetadata.Name = "buttonMetadata";
            this.buttonMetadata.Size = new System.Drawing.Size(75, 23);
            this.buttonMetadata.TabIndex = 5;
            this.buttonMetadata.Text = "Metadata";
            this.buttonMetadata.UseVisualStyleBackColor = true;
            this.buttonMetadata.Click += new System.EventHandler(this.buttonMetadata_Click);
            // 
            // buttonLyrics
            // 
            this.buttonLyrics.Location = new System.Drawing.Point(34, 148);
            this.buttonLyrics.Name = "buttonLyrics";
            this.buttonLyrics.Size = new System.Drawing.Size(75, 23);
            this.buttonLyrics.TabIndex = 11;
            this.buttonLyrics.Text = "Lyrics";
            this.buttonLyrics.UseVisualStyleBackColor = true;
            this.buttonLyrics.Click += new System.EventHandler(this.buttonLyrics_Click);
            // 
            // Finderr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMostrar);
            this.Controls.Add(this.panelFinderUser);
            this.Name = "Finderr";
            this.Size = new System.Drawing.Size(650, 352);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelByRating.ResumeLayout(false);
            this.panelFinderUser.ResumeLayout(false);
            this.panelFinderUser.PerformLayout();
            this.panelMostrar.ResumeLayout(false);
            this.panelRate.ResumeLayout(false);
            this.panelRate.PerformLayout();
            this.panelMetadata.ResumeLayout(false);
            this.panelMetadata.PerformLayout();
            this.panelButttons.ResumeLayout(false);
            this.panelButttons.PerformLayout();
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
        private System.Windows.Forms.Panel panelRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelDonload;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelMetadata;
        private System.Windows.Forms.ListBox listBoxMetadata;
        private System.Windows.Forms.Label labelMetadata;
        private System.Windows.Forms.Label labelFavorite;

        private System.Windows.Forms.Panel panelButttons;

        private System.Windows.Forms.Panel panelFinderUser;
        private System.Windows.Forms.Button buttonFollow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
        private System.Windows.Forms.Panel panelByRating;
        private System.Windows.Forms.Button buttonMenor;
        private System.Windows.Forms.Button buttonMayor;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.Button buttonLyrics;
    }
}
