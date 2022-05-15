
namespace CodeFirstFilmlerOyuncular
{
    partial class TurForm
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
            this.dgvTurler = new System.Windows.Forms.DataGridView();
            this.btnTurEkle = new System.Windows.Forms.Button();
            this.txtTurler = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSil = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTurler
            // 
            this.dgvTurler.AllowUserToAddRows = false;
            this.dgvTurler.AllowUserToDeleteRows = false;
            this.dgvTurler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurler.Location = new System.Drawing.Point(17, 89);
            this.dgvTurler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTurler.MultiSelect = false;
            this.dgvTurler.Name = "dgvTurler";
            this.dgvTurler.ReadOnly = true;
            this.dgvTurler.RowHeadersVisible = false;
            this.dgvTurler.RowHeadersWidth = 51;
            this.dgvTurler.RowTemplate.Height = 24;
            this.dgvTurler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurler.Size = new System.Drawing.Size(381, 362);
            this.dgvTurler.TabIndex = 0;
            this.dgvTurler.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvTurler_MouseDown);
            // 
            // btnTurEkle
            // 
            this.btnTurEkle.Location = new System.Drawing.Point(304, 49);
            this.btnTurEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTurEkle.Name = "btnTurEkle";
            this.btnTurEkle.Size = new System.Drawing.Size(94, 30);
            this.btnTurEkle.TabIndex = 1;
            this.btnTurEkle.Text = "Tur Ekle";
            this.btnTurEkle.UseVisualStyleBackColor = true;
            this.btnTurEkle.Click += new System.EventHandler(this.btnTurEkle_Click);
            // 
            // txtTurler
            // 
            this.txtTurler.Location = new System.Drawing.Point(239, 25);
            this.txtTurler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTurler.Name = "txtTurler";
            this.txtTurler.Size = new System.Drawing.Size(159, 20);
            this.txtTurler.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsGuncelle,
            this.cmsSil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // cmsGuncelle
            // 
            this.cmsGuncelle.Name = "cmsGuncelle";
            this.cmsGuncelle.Size = new System.Drawing.Size(180, 22);
            this.cmsGuncelle.Text = "Guncelle";
            this.cmsGuncelle.Click += new System.EventHandler(this.cmsGuncelle_Click);
            // 
            // cmsSil
            // 
            this.cmsSil.Name = "cmsSil";
            this.cmsSil.Size = new System.Drawing.Size(180, 22);
            this.cmsSil.Text = "Sil";
            this.cmsSil.Click += new System.EventHandler(this.cmsSil_Click);
            // 
            // TurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 481);
            this.Controls.Add(this.txtTurler);
            this.Controls.Add(this.btnTurEkle);
            this.Controls.Add(this.dgvTurler);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TurForm";
            this.Text = "TurForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurler;
        private System.Windows.Forms.Button btnTurEkle;
        private System.Windows.Forms.TextBox txtTurler;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsGuncelle;
        private System.Windows.Forms.ToolStripMenuItem cmsSil;
    }
}