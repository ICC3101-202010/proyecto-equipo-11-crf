namespace Spotflix
{
    partial class Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            this.panelLibraruTitle = new System.Windows.Forms.Panel();
            this.pbAddRigth = new System.Windows.Forms.PictureBox();
            this.labelLibraryTitle = new System.Windows.Forms.Label();
            this.panelLibrary = new System.Windows.Forms.Panel();
            this.panelNewPlaylist = new System.Windows.Forms.Panel();
            this.panelTtileAdd = new System.Windows.Forms.Panel();
            this.labelTtilePlaylist = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonAddPlaylist = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelImageAdd = new System.Windows.Forms.Label();
            this.labelNamePlaylist = new System.Windows.Forms.Label();
            this.labelAddPlaylist = new System.Windows.Forms.Label();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.labelEmptyLibrary = new System.Windows.Forms.Label();
            this.pbEmpty = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLibraruTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddRigth)).BeginInit();
            this.panelLibrary.SuspendLayout();
            this.panelNewPlaylist.SuspendLayout();
            this.panelTtileAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpty)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLibraruTitle
            // 
            this.panelLibraruTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.panelLibraruTitle.Controls.Add(this.pbAddRigth);
            this.panelLibraruTitle.Controls.Add(this.labelLibraryTitle);
            this.panelLibraruTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLibraruTitle.Location = new System.Drawing.Point(0, 0);
            this.panelLibraruTitle.Name = "panelLibraruTitle";
            this.panelLibraruTitle.Size = new System.Drawing.Size(643, 42);
            this.panelLibraruTitle.TabIndex = 0;
            // 
            // pbAddRigth
            // 
            this.pbAddRigth.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbAddRigth.Enabled = false;
            this.pbAddRigth.Image = ((System.Drawing.Image)(resources.GetObject("pbAddRigth.Image")));
            this.pbAddRigth.Location = new System.Drawing.Point(574, 0);
            this.pbAddRigth.Name = "pbAddRigth";
            this.pbAddRigth.Size = new System.Drawing.Size(69, 42);
            this.pbAddRigth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddRigth.TabIndex = 4;
            this.pbAddRigth.TabStop = false;
            this.pbAddRigth.Visible = false;
            this.pbAddRigth.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelLibraryTitle
            // 
            this.labelLibraryTitle.AutoSize = true;
            this.labelLibraryTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibraryTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLibraryTitle.Location = new System.Drawing.Point(260, 9);
            this.labelLibraryTitle.Name = "labelLibraryTitle";
            this.labelLibraryTitle.Size = new System.Drawing.Size(125, 30);
            this.labelLibraryTitle.TabIndex = 0;
            this.labelLibraryTitle.Text = "L i b r a r y";
            // 
            // panelLibrary
            // 
            this.panelLibrary.AutoScroll = true;
            this.panelLibrary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLibrary.Controls.Add(this.flowLayoutPanel1);
            this.panelLibrary.Controls.Add(this.panelNewPlaylist);
            this.panelLibrary.Controls.Add(this.labelAddPlaylist);
            this.panelLibrary.Controls.Add(this.pbAdd);
            this.panelLibrary.Controls.Add(this.labelEmptyLibrary);
            this.panelLibrary.Controls.Add(this.pbEmpty);
            this.panelLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLibrary.Location = new System.Drawing.Point(0, 42);
            this.panelLibrary.Name = "panelLibrary";
            this.panelLibrary.Size = new System.Drawing.Size(643, 318);
            this.panelLibrary.TabIndex = 1;
            this.panelLibrary.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLibrary_Paint);
            // 
            // panelNewPlaylist
            // 
            this.panelNewPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.panelNewPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNewPlaylist.Controls.Add(this.panelTtileAdd);
            this.panelNewPlaylist.Controls.Add(this.pictureBox2);
            this.panelNewPlaylist.Controls.Add(this.buttonAddPlaylist);
            this.panelNewPlaylist.Controls.Add(this.textBoxName);
            this.panelNewPlaylist.Controls.Add(this.labelImageAdd);
            this.panelNewPlaylist.Controls.Add(this.labelNamePlaylist);
            this.panelNewPlaylist.Enabled = false;
            this.panelNewPlaylist.Location = new System.Drawing.Point(379, 76);
            this.panelNewPlaylist.Name = "panelNewPlaylist";
            this.panelNewPlaylist.Size = new System.Drawing.Size(169, 154);
            this.panelNewPlaylist.TabIndex = 5;
            this.panelNewPlaylist.Visible = false;
            // 
            // panelTtileAdd
            // 
            this.panelTtileAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTtileAdd.Controls.Add(this.labelTtilePlaylist);
            this.panelTtileAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTtileAdd.Location = new System.Drawing.Point(0, 0);
            this.panelTtileAdd.Name = "panelTtileAdd";
            this.panelTtileAdd.Size = new System.Drawing.Size(165, 23);
            this.panelTtileAdd.TabIndex = 6;
            // 
            // labelTtilePlaylist
            // 
            this.labelTtilePlaylist.AutoSize = true;
            this.labelTtilePlaylist.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTtilePlaylist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTtilePlaylist.Location = new System.Drawing.Point(55, 5);
            this.labelTtilePlaylist.Name = "labelTtilePlaylist";
            this.labelTtilePlaylist.Size = new System.Drawing.Size(72, 16);
            this.labelTtilePlaylist.TabIndex = 3;
            this.labelTtilePlaylist.Text = "New Playlist";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // buttonAddPlaylist
            // 
            this.buttonAddPlaylist.BackColor = System.Drawing.Color.Gray;
            this.buttonAddPlaylist.FlatAppearance.BorderSize = 0;
            this.buttonAddPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddPlaylist.Location = new System.Drawing.Point(44, 110);
            this.buttonAddPlaylist.Name = "buttonAddPlaylist";
            this.buttonAddPlaylist.Size = new System.Drawing.Size(76, 26);
            this.buttonAddPlaylist.TabIndex = 4;
            this.buttonAddPlaylist.Text = "Add";
            this.buttonAddPlaylist.UseVisualStyleBackColor = false;
            this.buttonAddPlaylist.Click += new System.EventHandler(this.buttonAddPlaylist_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Gray;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxName.Location = new System.Drawing.Point(58, 37);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 13);
            this.textBoxName.TabIndex = 3;
            // 
            // labelImageAdd
            // 
            this.labelImageAdd.AutoSize = true;
            this.labelImageAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelImageAdd.Location = new System.Drawing.Point(16, 73);
            this.labelImageAdd.Name = "labelImageAdd";
            this.labelImageAdd.Size = new System.Drawing.Size(36, 13);
            this.labelImageAdd.TabIndex = 2;
            this.labelImageAdd.Text = "Image";
            // 
            // labelNamePlaylist
            // 
            this.labelNamePlaylist.AutoSize = true;
            this.labelNamePlaylist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNamePlaylist.Location = new System.Drawing.Point(17, 37);
            this.labelNamePlaylist.Name = "labelNamePlaylist";
            this.labelNamePlaylist.Size = new System.Drawing.Size(35, 13);
            this.labelNamePlaylist.TabIndex = 0;
            this.labelNamePlaylist.Text = "Name";
            // 
            // labelAddPlaylist
            // 
            this.labelAddPlaylist.AutoSize = true;
            this.labelAddPlaylist.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelAddPlaylist.Location = new System.Drawing.Point(325, 259);
            this.labelAddPlaylist.Name = "labelAddPlaylist";
            this.labelAddPlaylist.Size = new System.Drawing.Size(60, 13);
            this.labelAddPlaylist.TabIndex = 4;
            this.labelAddPlaylist.Text = "Add playlist";
            // 
            // pbAdd
            // 
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.Location = new System.Drawing.Point(250, 248);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(69, 38);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 3;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labelEmptyLibrary
            // 
            this.labelEmptyLibrary.AutoSize = true;
            this.labelEmptyLibrary.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelEmptyLibrary.Location = new System.Drawing.Point(258, 217);
            this.labelEmptyLibrary.Name = "labelEmptyLibrary";
            this.labelEmptyLibrary.Size = new System.Drawing.Size(127, 13);
            this.labelEmptyLibrary.TabIndex = 1;
            this.labelEmptyLibrary.Text = "Ops, your Library is empty";
            this.labelEmptyLibrary.Click += new System.EventHandler(this.labelEmptyLibrary_Click);
            // 
            // pbEmpty
            // 
            this.pbEmpty.Image = ((System.Drawing.Image)(resources.GetObject("pbEmpty.Image")));
            this.pbEmpty.Location = new System.Drawing.Point(203, 24);
            this.pbEmpty.Name = "pbEmpty";
            this.pbEmpty.Size = new System.Drawing.Size(242, 190);
            this.pbEmpty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmpty.TabIndex = 0;
            this.pbEmpty.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(641, 316);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Visible = false;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panelLibrary);
            this.Controls.Add(this.panelLibraruTitle);
            this.Name = "Library";
            this.Size = new System.Drawing.Size(643, 360);
            this.Enter += new System.EventHandler(this.Library_Enter);
            this.panelLibraruTitle.ResumeLayout(false);
            this.panelLibraruTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddRigth)).EndInit();
            this.panelLibrary.ResumeLayout(false);
            this.panelLibrary.PerformLayout();
            this.panelNewPlaylist.ResumeLayout(false);
            this.panelNewPlaylist.PerformLayout();
            this.panelTtileAdd.ResumeLayout(false);
            this.panelTtileAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLibraruTitle;
        private System.Windows.Forms.Panel panelLibrary;
        private System.Windows.Forms.Label labelEmptyLibrary;
        private System.Windows.Forms.PictureBox pbEmpty;
        private System.Windows.Forms.Label labelAddPlaylist;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Panel panelNewPlaylist;
        private System.Windows.Forms.Label labelImageAdd;
        private System.Windows.Forms.Label labelNamePlaylist;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAddPlaylist;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelTtileAdd;
        private System.Windows.Forms.Label labelTtilePlaylist;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelLibraryTitle;
        private System.Windows.Forms.PictureBox pbAddRigth;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
