using CodeFirstFilmlerOyuncular.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirstFilmlerOyuncular.Models;
using HtmlAgilityPack;
using CodeFirstFilmlerOyuncular.DTOs;
using System.Net.Http;
using System.Data.Entity;

namespace CodeFirstFilmlerOyuncular
{
    public partial class MainForm : Form
    {
        FilmOyuncuContext db = new FilmOyuncuContext();
        public MainForm()
        {
            InitializeComponent();
            //TurYukle();
        }

        private void TurYukle()
        {
            if (!db.Turler.Any())
            {
                db.Turler.Add(new Tur()
                {
                    Ad = "Bilim Kurgu",
                });
                db.Turler.Add(new Tur()
                {
                    Ad = "Komedi",
                });
                db.Turler.Add(new Tur()
                {
                    Ad = "Romantik",
                });
                db.Turler.Add(new Tur()
                {
                    Ad = "Dram",
                });
                db.Turler.Add(new Tur()
                {
                    Ad = "Gerilim",
                });
                db.Turler.Add(new Tur()
                {
                    Ad = "Korku",
                });
                db.Turler.Add(new Tur()
                {
                    Ad = "Fantastik",
                });
                db.Turler.Add(new Tur()
                {
                    Ad = "Romantik Komedi",
                });
                db.Turler.Add(new Tur()
                {
                    Ad = "Belgesel",
                });
                //db.SaveChanges();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //dgvFilmler.DataSource = db.Filmler.ToList();
            string turHepsi = "All";
            cmbTur.Items.Add(turHepsi);
            cmbTur.SelectedItem = turHepsi;
            foreach (var item in db.Turler)
            {
                cmbTur.Items.Add(item.Ad);
            }
            if (cmbTur.SelectedIndex == 0)
            {
                FilmleriYukle();
            }
        }

        private void FilmleriYukle()
        {
            dgvFilmler.Rows.Clear();
            foreach (var item in db.Filmler.ToList())
            {
                dgvFilmler.Rows.Add(item.ID, item.Ad, item.Poster, item.Yil,item.IMDBPuani,item.imdbID,item.Tur.Ad,string.Join(",",item.Oyuncular.Select(x=>x.AdSoyad)));
                //Film film = item;
                //Tur tur = film.Tur;
                //List<Oyuncu> oyuncular = film.Oyuncular; // Virtual yazmadık null gelecek
            }
            //Film film = db.Filmler.Include(x => x.Tur).Include(x => x.Oyuncular).FirstOrDefault(x => x.ID == 502);
            //Film ve turu virtual yapmazsan ınclude ile yapabiliriz.
        }
        private void tsmiOyuncular_Click(object sender, EventArgs e)
        {
            OyuncularForm oyuncularForm = new OyuncularForm(db);
            oyuncularForm.ShowDialog();
        }

        private void dgvFilmler_SelectionChanged(object sender, EventArgs e)
        {
            //pbo poster güncelle!
            if (dgvFilmler.SelectedRows.Count>0)
            {
                string poster = (string)dgvFilmler.SelectedRows[0].Cells[2].Value;
                pboFilmPoster.ImageLocation = poster;
                pboFilmPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        internal void UpdateMain()
        {
            FilmleriYukle();
        }

        private void tsmiTurler_Click(object sender, EventArgs e)
        {
            //turler form aç tüm crud işlemlerini yap tür için tasarım size ait.
            TurForm turFrm = new TurForm();
            turFrm.ShowDialog();
        }

        private void tsmiFilmEkle_Click(object sender, EventArgs e)
        {
            //filmekle form tasarım size ait ister tür ve oyuncu seçtirip ekleyin ister tür ve oyuncu seçmeden ekleyin size kalmış
            FilmEkleForm filmEkleFrm = new FilmEkleForm();
            filmEkleFrm.ShowDialog();
        }

        private void dgvFilmler_MouseDown(object sender, MouseEventArgs e)
        {
            // eğer sağ tuş tıklandıysa context menü strip'i dgv üzerinde göster ve satır seçili olsun.
            if (e.Button == MouseButtons.Right )
            {
                var hti = dgvFilmler.HitTest(e.X, e.Y);
                dgvFilmler.Rows[hti.RowIndex].Selected = true;
                cmsFilmler.Show(dgvFilmler, new Point(e.X, e.Y));
            }
        }

        private void tsmiSil_Click(object sender, EventArgs e)
        {
            //Seçili film message box ile onay verildikten sonra silinir.
            int id = (int)dgvFilmler.SelectedRows[0].Cells[0].Value;
            var silinecekFilmAdi = db.Filmler.Where(x => x.ID == id).Select(x => x.Ad).FirstOrDefault();
            if (dgvFilmler.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(silinecekFilmAdi + " adlı film silinecektir onaylıyor musunuz?", "Silme işlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Film silinecekFilm = db.Filmler.FirstOrDefault(x => x.ID == id);
                    db.Filmler.Remove(silinecekFilm);
                    db.SaveChanges();
                    FilmleriYukle();
                }
            }
        }
        private void tsmiGuncelle_Click(object sender, EventArgs e)
        {
            //seçili film güncelle form'a gönderilir ve güncellenir.(tur ve oyuncuları burada güncellemek opsiyonel)
            int gidenFilmId = (int)dgvFilmler.SelectedRows[0].Cells[0].Value;
            FilmEkleForm filmEkleFrm = new FilmEkleForm(gidenFilmId);
            filmEkleFrm.ShowDialog();
        }

        private void tsmiOyuncuGuncelle_Click(object sender, EventArgs e)
        {
            //Filmin sadece oyuncuları üzerinden güncelleme yapılır. Ekle sil işlemleri

            //Filmin oyuncu ve tür güncelleme işlemlerini FilmEkleForm'da yaptırdım. Film üzerinden contextmenustrip ile güncelle dediğimizde o form açılıyor.
        }

        private void tsmiTurGuncelle_Click(object sender, EventArgs e)
        {
            //Filmin sadece tür bilgisi güncellenir.
        }

        private void cmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTur.SelectedIndex == 0)
            {
                FilmleriYukle();
            }
            else
            {
                var tureGoreSeciliFilm = db.Filmler.Where(x => x.TurId == cmbTur.SelectedIndex).ToList();
                dgvFilmler.Rows.Clear();
                foreach (var item in tureGoreSeciliFilm)
                {
                    dgvFilmler.Rows.Add(item.ID, item.Ad, item.Poster, item.Yil, item.IMDBPuani, item.imdbID, item.Tur.Ad, string.Join(",", item.Oyuncular.Select(x => x.AdSoyad)));
                }
            }
        }

        private void txtFilmAra_TextChanged(object sender, EventArgs e)
        {
            string filmAra = txtFilmAra.Text;
            var arananFilmListesi = from item in db.Filmler
                                    where item.Ad.Contains(filmAra)
                                    select item;
            var arananFilmListesi2 = db.Filmler.Where(x => x.Ad.Contains(filmAra)).Select(x => x);
            dgvFilmler.Rows.Clear();
            foreach (var item in arananFilmListesi2.ToList())
            {
                dgvFilmler.Rows.Add(item.ID, item.Ad, item.Poster, item.Yil, item.IMDBPuani, item.imdbID, item.Tur.Ad, string.Join(",", item.Oyuncular.Select(x => x.AdSoyad)));
            }
        }
        //EKSTRA GÖREV: 
        //combobox'daki tür seçimine göre filmler listelenir. combobox'a türler yüklenirken en üste bir adet Hepsi seçeneği eklenir. Hepsi seçili ise tüm filmler değilse o türe sahip filmler listelenlir.
        //txt'deki string değeri filmlerin adında geçiyorsa o filmler listelenir.(combox ile beraber çalıştırılabilir.)
    }
}
