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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxFind = new System.Windows.Forms.ComboBox();
            this.labelFinder = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.panelMostrar = new System.Windows.Forms.Panel();
            this.listBoxPrueba = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panelMostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxFind);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.comboBoxFind);
            this.panel1.Controls.Add(this.labelFinder);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 385);
            this.panel1.TabIndex = 0;
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
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(160, 88);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(116, 20);
            this.textBoxFind.TabIndex = 4;
            // 
            // panelMostrar
            // 
            this.panelMostrar.Controls.Add(this.listBoxPrueba);
            this.panelMostrar.Location = new System.Drawing.Point(305, 0);
            this.panelMostrar.Name = "panelMostrar";
            this.panelMostrar.Size = new System.Drawing.Size(345, 385);
            this.panelMostrar.TabIndex = 1;
            // 
            // listBoxPrueba
            // 
            this.listBoxPrueba.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxPrueba.FormattingEnabled = true;
            this.listBoxPrueba.Location = new System.Drawing.Point(42, 47);
            this.listBoxPrueba.Name = "listBoxPrueba";
            this.listBoxPrueba.Size = new System.Drawing.Size(102, 277);
            this.listBoxPrueba.TabIndex = 0;
            // 
            // Finder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelMostrar);
            this.Controls.Add(this.panel1);
            this.Name = "Finder";
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
        private System.Windows.Forms.ListBox listBoxPrueba;
    }
}
