
namespace CodeFirstFilmlerOyuncular
{
    partial class FilmEkleForm
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPoster = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImdbPuani = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.cmbTurler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOyuncu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(131, 65);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(298, 21);
            this.txtAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad : ";
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(131, 113);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(298, 21);
            this.txtYil.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yıl : ";
            // 
            // txtPoster
            // 
            this.txtPoster.Location = new System.Drawing.Point(131, 161);
            this.txtPoster.Name = "txtPoster";
            this.txtPoster.Size = new System.Drawing.Size(298, 21);
            this.txtPoster.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Poster : ";
            // 
            // txtImdbPuani
            // 
            this.txtImdbPuani.Location = new System.Drawing.Point(132, 209);
            this.txtImdbPuani.Name = "txtImdbPuani";
            this.txtImdbPuani.Size = new System.Drawing.Size(298, 21);
            this.txtImdbPuani.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "IMDB Puanı : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tur : ";
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Location = new System.Drawing.Point(337, 461);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(93, 33);
            this.btnFilmEkle.TabIndex = 2;
            this.btnFilmEkle.Text = "Ekle";
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // cmbTurler
            // 
            this.cmbTurler.FormattingEnabled = true;
            this.cmbTurler.Location = new System.Drawing.Point(131, 257);
            this.cmbTurler.Name = "cmbTurler";
            this.cmbTurler.Size = new System.Drawing.Size(298, 23);
            this.cmbTurler.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Oyuncular : ";
            // 
            // txtOyuncu
            // 
            this.txtOyuncu.Location = new System.Drawing.Point(131, 307);
            this.txtOyuncu.Multiline = true;
            this.txtOyuncu.Name = "txtOyuncu";
            this.txtOyuncu.Size = new System.Drawing.Size(298, 113);
            this.txtOyuncu.TabIndex = 7;
            // 
            // FilmEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 547);
            this.Controls.Add(this.txtOyuncu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTurler);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtImdbPuani);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPoster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FilmEkleForm";
            this.Text = "FilmEkleForm";
            this.Load += new System.EventHandler(this.FilmEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPoster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImdbPuani;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.ComboBox cmbTurler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOyuncu;
    }
}