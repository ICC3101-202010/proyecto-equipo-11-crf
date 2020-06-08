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
            this.panelLibrary = new System.Windows.Forms.Panel();
            this.labelEmptyLibrary = new System.Windows.Forms.Label();
            this.pbEmpty = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelAddPlaylist = new System.Windows.Forms.Label();
            this.panelLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpty)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLibraruTitle
            // 
            this.panelLibraruTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.panelLibraruTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLibraruTitle.Location = new System.Drawing.Point(0, 0);
            this.panelLibraruTitle.Name = "panelLibraruTitle";
            this.panelLibraruTitle.Size = new System.Drawing.Size(643, 42);
            this.panelLibraruTitle.TabIndex = 0;
            // 
            // panelLibrary
            // 
            this.panelLibrary.AutoScroll = true;
            this.panelLibrary.Controls.Add(this.labelAddPlaylist);
            this.panelLibrary.Controls.Add(this.pictureBox2);
            this.panelLibrary.Controls.Add(this.flowLayoutPanel1);
            this.panelLibrary.Controls.Add(this.labelEmptyLibrary);
            this.panelLibrary.Controls.Add(this.pbEmpty);
            this.panelLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLibrary.Location = new System.Drawing.Point(0, 42);
            this.panelLibrary.Name = "panelLibrary";
            this.panelLibrary.Size = new System.Drawing.Size(643, 318);
            this.panelLibrary.TabIndex = 1;
            this.panelLibrary.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLibrary_Paint);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(194, 211);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 158);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(250, 248);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panelLibrary);
            this.Controls.Add(this.panelLibraruTitle);
            this.Name = "Library";
            this.Size = new System.Drawing.Size(643, 360);
            this.Enter += new System.EventHandler(this.Library_Enter);
            this.panelLibrary.ResumeLayout(false);
            this.panelLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpty)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLibraruTitle;
        private System.Windows.Forms.Panel panelLibrary;
        private System.Windows.Forms.Label labelEmptyLibrary;
        private System.Windows.Forms.PictureBox pbEmpty;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAddPlaylist;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
