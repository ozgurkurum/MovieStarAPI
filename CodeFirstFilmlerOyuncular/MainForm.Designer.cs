
namespace CodeFirstFilmlerOyuncular
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiOyuncular = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTurler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilmEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvFilmler = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMDBPuani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imdbID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oyuncular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pboFilmPoster = new System.Windows.Forms.PictureBox();
            this.cmsFilmler = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.txtFilmAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFilmPoster)).BeginInit();
            this.cmsFilmler.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOyuncular,
            this.tsmiTurler,
            this.tsmiFilmEkle});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiOyuncular
            // 
            this.tsmiOyuncular.Name = "tsmiOyuncular";
            this.tsmiOyuncular.Size = new System.Drawing.Size(74, 20);
            this.tsmiOyuncular.Text = "Oyuncular";
            this.tsmiOyuncular.Click += new System.EventHandler(this.tsmiOyuncular_Click);
            // 
            // tsmiTurler
            // 
            this.tsmiTurler.Name = "tsmiTurler";
            this.tsmiTurler.Size = new System.Drawing.Size(49, 20);
            this.tsmiTurler.Text = "Turler";
            this.tsmiTurler.Click += new System.EventHandler(this.tsmiTurler_Click);
            // 
            // tsmiFilmEkle
            // 
            this.tsmiFilmEkle.Name = "tsmiFilmEkle";
            this.tsmiFilmEkle.Size = new System.Drawing.Size(66, 20);
            this.tsmiFilmEkle.Text = "Film Ekle";
            this.tsmiFilmEkle.Click += new System.EventHandler(this.tsmiFilmEkle_Click);
            // 
            // dgvFilmler
            // 
            this.dgvFilmler.AllowUserToAddRows = false;
            this.dgvFilmler.AllowUserToDeleteRows = false;
            this.dgvFilmler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ad,
            this.Poster,
            this.Yil,
            this.IMDBPuani,
            this.imdbID,
            this.TurAd,
            this.Oyuncular});
            this.dgvFilmler.Location = new System.Drawing.Point(25, 250);
            this.dgvFilmler.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFilmler.MultiSelect = false;
            this.dgvFilmler.Name = "dgvFilmler";
            this.dgvFilmler.ReadOnly = true;
            this.dgvFilmler.RowHeadersVisible = false;
            this.dgvFilmler.RowHeadersWidth = 51;
            this.dgvFilmler.RowTemplate.Height = 24;
            this.dgvFilmler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmler.Size = new System.Drawing.Size(874, 290);
            this.dgvFilmler.TabIndex = 1;
            this.dgvFilmler.SelectionChanged += new System.EventHandler(this.dgvFilmler_SelectionChanged);
            this.dgvFilmler.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvFilmler_MouseDown);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Ad
            // 
            this.Ad.HeaderText = "Ad";
            this.Ad.MinimumWidth = 6;
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            // 
            // Poster
            // 
            this.Poster.HeaderText = "Poster";
            this.Poster.MinimumWidth = 6;
            this.Poster.Name = "Poster";
            this.Poster.ReadOnly = true;
            // 
            // Yil
            // 
            this.Yil.HeaderText = "Yıl";
            this.Yil.MinimumWidth = 6;
            this.Yil.Name = "Yil";
            this.Yil.ReadOnly = true;
            // 
            // IMDBPuani
            // 
            this.IMDBPuani.HeaderText = "IMDB Puanı";
            this.IMDBPuani.MinimumWidth = 6;
            this.IMDBPuani.Name = "IMDBPuani";
            this.IMDBPuani.ReadOnly = true;
            // 
            // imdbID
            // 
            this.imdbID.HeaderText = "IMDB ID";
            this.imdbID.MinimumWidth = 6;
            this.imdbID.Name = "imdbID";
            this.imdbID.ReadOnly = true;
            // 
            // TurAd
            // 
            this.TurAd.HeaderText = "Tür Adı";
            this.TurAd.MinimumWidth = 6;
            this.TurAd.Name = "TurAd";
            this.TurAd.ReadOnly = true;
            // 
            // Oyuncular
            // 
            this.Oyuncular.HeaderText = "Oyuncular";
            this.Oyuncular.MinimumWidth = 6;
            this.Oyuncular.Name = "Oyuncular";
            this.Oyuncular.ReadOnly = true;
            // 
            // pboFilmPoster
            // 
            this.pboFilmPoster.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pboFilmPoster.Location = new System.Drawing.Point(348, 40);
            this.pboFilmPoster.Margin = new System.Windows.Forms.Padding(2);
            this.pboFilmPoster.Name = "pboFilmPoster";
            this.pboFilmPoster.Size = new System.Drawing.Size(275, 195);
            this.pboFilmPoster.TabIndex = 2;
            this.pboFilmPoster.TabStop = false;
            // 
            // cmsFilmler
            // 
            this.cmsFilmler.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsFilmler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSil,
            this.tsmiGuncelle});
            this.cmsFilmler.Name = "cmsFillmler";
            this.cmsFilmler.Size = new System.Drawing.Size(121, 48);
            // 
            // tsmiSil
            // 
            this.tsmiSil.Name = "tsmiSil";
            this.tsmiSil.Size = new System.Drawing.Size(165, 22);
            this.tsmiSil.Text = "Sil";
            this.tsmiSil.Click += new System.EventHandler(this.tsmiSil_Click);
            // 
            // tsmiGuncelle
            // 
            this.tsmiGuncelle.Name = "tsmiGuncelle";
            this.tsmiGuncelle.Size = new System.Drawing.Size(165, 22);
            this.tsmiGuncelle.Text = "Guncelle";
            this.tsmiGuncelle.Click += new System.EventHandler(this.tsmiGuncelle_Click);
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(714, 212);
            this.cmbTur.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(185, 21);
            this.cmbTur.TabIndex = 4;
            this.cmbTur.SelectedIndexChanged += new System.EventHandler(this.cmbTur_SelectedIndexChanged);
            // 
            // txtFilmAra
            // 
            this.txtFilmAra.Location = new System.Drawing.Point(110, 215);
            this.txtFilmAra.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilmAra.Name = "txtFilmAra";
            this.txtFilmAra.Size = new System.Drawing.Size(170, 20);
            this.txtFilmAra.TabIndex = 5;
            this.txtFilmAra.TextChanged += new System.EventHandler(this.txtFilmAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(671, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tur : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Film Ara : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 570);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilmAra);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.pboFilmPoster);
            this.Controls.Add(this.dgvFilmler);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFilmPoster)).EndInit();
            this.cmsFilmler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOyuncular;
        private System.Windows.Forms.DataGridView dgvFilmler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yil;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMDBPuani;
        private System.Windows.Forms.DataGridViewTextBoxColumn imdbID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oyuncular;
        private System.Windows.Forms.PictureBox pboFilmPoster;
        private System.Windows.Forms.ToolStripMenuItem tsmiTurler;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilmEkle;
        private System.Windows.Forms.ContextMenuStrip cmsFilmler;
        private System.Windows.Forms.ToolStripMenuItem tsmiSil;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuncelle;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.TextBox txtFilmAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}