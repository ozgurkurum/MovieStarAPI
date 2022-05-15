using CodeFirstFilmlerOyuncular.Data;
using CodeFirstFilmlerOyuncular.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstFilmlerOyuncular
{
    public partial class FilmEkleForm : Form
    {
        private readonly int gelenFilmId;
        FilmOyuncuContext db = new FilmOyuncuContext();
        public FilmEkleForm()
        {
            InitializeComponent();
        }
        public FilmEkleForm(int gelenFilmId)
        {
            InitializeComponent();
            this.gelenFilmId = gelenFilmId;
            var gelenFilm = db.Filmler.Where(x => x.ID == gelenFilmId).FirstOrDefault();
        }
        private void FilmEkleForm_Load(object sender, EventArgs e)
        {
            foreach (var tur in db.Turler)
            {
                cmbTurler.Items.Add(tur.Ad);
            }
            if (gelenFilmId > 0)
            {
                btnFilmEkle.Text = "Guncelle";
                var gelenFilm = db.Filmler.Where(x => x.ID == gelenFilmId).FirstOrDefault();
                txtAd.Text = gelenFilm.Ad;
                txtYil.Text = gelenFilm.Yil.ToString();
                txtPoster.Text = gelenFilm.Poster;
                txtImdbPuani.Text = gelenFilm.IMDBPuani.ToString();
                cmbTurler.SelectedItem = gelenFilm.Tur.Ad;
                foreach (var item in gelenFilm.Oyuncular)
                {
                    txtOyuncu.AppendText(item.AdSoyad + Environment.NewLine);
                }
            }
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            if (btnFilmEkle.Text == "Ekle" && !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtYil.Text))
            {
                List<Oyuncu> oyuncuListesi = new List<Oyuncu>();
                Oyuncu oyuncu = new Oyuncu()
                {
                    AdSoyad = txtOyuncu.Text
                };
                oyuncuListesi.Add(oyuncu);
                db.Filmler.Add(new Film
                {
                    Ad = txtAd.Text,
                    Yil = Convert.ToInt32(txtYil.Text),
                    Poster = txtPoster.Text,
                    IMDBPuani = Convert.ToDecimal(txtImdbPuani.Text),
                    TurId=cmbTurler.SelectedIndex+1,
                    Oyuncular=oyuncuListesi
                });
                MessageBox.Show("Film Eklendi");

            }
            else if (btnFilmEkle.Text=="Guncelle" && !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtYil.Text))
            {
                var guncellenecekFilm = db.Filmler.Where(x => x.ID == gelenFilmId).FirstOrDefault();
                guncellenecekFilm.Ad = txtAd.Text;
                guncellenecekFilm.Yil = Convert.ToInt32(txtYil.Text);
                guncellenecekFilm.Poster = txtPoster.Text;
                guncellenecekFilm.IMDBPuani = Convert.ToDecimal(txtImdbPuani.Text);
                guncellenecekFilm.TurId = cmbTurler.SelectedIndex + 1;
                List<Oyuncu> oyuncuListesi = new List<Oyuncu>();
                Oyuncu oyuncu = new Oyuncu()
                {
                    AdSoyad = txtOyuncu.Text
                };
                oyuncuListesi.Add(oyuncu);
                guncellenecekFilm.Oyuncular = oyuncuListesi;
                MessageBox.Show("Film Guncellendi");
            }
            db.SaveChanges();
            MainForm mainFrm = (MainForm)Application.OpenForms["MainForm"];
            mainFrm.UpdateMain();
            mainFrm.Refresh();
            this.Hide();
        }
    }
}
