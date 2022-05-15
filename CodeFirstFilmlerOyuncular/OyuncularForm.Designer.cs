
namespace CodeFirstFilmlerOyuncular
{
    partial class OyuncularForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvOyuncular = new System.Windows.Forms.DataGridView();
            this.btnOyuncuEkle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncular)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOyuncular
            // 
            this.dgvOyuncular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOyuncular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.AdSoyad,
            this.Telefon,
            this.Adres});
            this.dgvOyuncular.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOyuncular.Location = new System.Drawing.Point(0, 154);
            this.dgvOyuncular.MultiSelect = false;
            this.dgvOyuncular.Name = "dgvOyuncular";
            this.dgvOyuncular.RowHeadersVisible = false;
            this.dgvOyuncular.RowHeadersWidth = 51;
            this.dgvOyuncular.RowTemplate.Height = 24;
            this.dgvOyuncular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOyuncular.Size = new System.Drawing.Size(1125, 489);
            this.dgvOyuncular.TabIndex = 0;
            this.dgvOyuncular.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvOyuncular_MouseDown);
            // 
            // btnOyuncuEkle
            // 
            this.btnOyuncuEkle.Location = new System.Drawing.Point(949, 62);
            this.btnOyuncuEkle.Name = "btnOyuncuEkle";
            this.btnOyuncuEkle.Size = new System.Drawing.Size(148, 53);
            this.btnOyuncuEkle.TabIndex = 1;
            this.btnOyuncuEkle.Text = "Oyuncu Ekle";
            this.btnOyuncuEkle.UseVisualStyleBackColor = true;
            this.btnOyuncuEkle.Click += new System.EventHandler(this.btnOyuncuEkle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 52);
            // 
            // guncelleToolStripMenuItem
            // 
            this.guncelleToolStripMenuItem.Name = "guncelleToolStripMenuItem";
            this.guncelleToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.guncelleToolStripMenuItem.Text = "Guncelle";
            this.guncelleToolStripMenuItem.Click += new System.EventHandler(this.guncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // AdSoyad
            // 
            this.AdSoyad.HeaderText = "Ad Soyad";
            this.AdSoyad.MinimumWidth = 6;
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Width = 125;
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 6;
            this.Telefon.Name = "Telefon";
            this.Telefon.Width = 125;
            // 
            // Adres
            // 
            this.Adres.HeaderText = "Adres";
            this.Adres.MinimumWidth = 6;
            this.Adres.Name = "Adres";
            this.Adres.Width = 125;
            // 
            // OyuncularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 643);
            this.Controls.Add(this.btnOyuncuEkle);
            this.Controls.Add(this.dgvOyuncular);
            this.Name = "OyuncularForm";
            this.Text = "OyuncularForm";
            this.Load += new System.EventHandler(this.OyuncularForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncular)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOyuncular;
        private System.Windows.Forms.Button btnOyuncuEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
    }
}