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
    public partial class OyuncuEkleGuncelleForm : Form
    {
        private readonly FilmOyuncuContext db;
        private readonly int id;

        public OyuncuEkleGuncelleForm(FilmOyuncuContext db)
        {
            InitializeComponent();
            this.db = db;
            btnEkleGuncelle.Text = "Ekle";
        }
        public OyuncuEkleGuncelleForm(FilmOyuncuContext db,int id)
        {
            InitializeComponent();
            this.db = db;
            this.id = id;
            btnEkleGuncelle.Text = "Guncelle";
            //Secili filmi db'den çek ve ilgili alanları doldur
            var guncelleme = db.Oyuncular.Where(x => x.Id == id).ToList();
            foreach (var item in guncelleme)
            {
                if (item.IletisimBilgi==null)
                {
                    txtAdSoyad.Text = item.AdSoyad;
                }
                else
                {
                    txtAdSoyad.Text = item.AdSoyad;
                    txtAdres.Text = item.IletisimBilgi.Adres;
                    txtTelefon.Text = item.IletisimBilgi.Telefon;
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Gerekli alanlar boş değilse bir oyuncu oluşturulması ve db ye kaydedilmesi
            if (btnEkleGuncelle.Text=="Ekle")
            {
                
                if (!string.IsNullOrEmpty(txtAdSoyad.Text) && !string.IsNullOrEmpty(txtTelefon.Text) && !string.IsNullOrEmpty(txtAdres.Text))
                {
                    db.Oyuncular.Add(new Oyuncu()
                    {
                        AdSoyad = txtAdSoyad.Text,
                        IletisimBilgi = new IletisimBilgi()
                        {
                            Adres = txtAdres.Text,
                            Telefon = txtTelefon.Text
                        }
                    });
                }
                else
                {
                    MessageBox.Show("Boş olamaz");
                }
            }
            else 
            {
                //Güncelleme işlemi yap! Odev
                var guncelleme = db.Oyuncular.Where(x => x.Id == id).ToList();
                foreach (var item in guncelleme)
                {
                    item.AdSoyad = txtAdSoyad.Text;
                    item.IletisimBilgi.Adres = txtAdres.Text;
                    item.IletisimBilgi.Telefon = txtTelefon.Text;
                }
            }
            db.SaveChanges();
            this.Close();
        }

        private void OyuncuEkleGuncelleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }
    }
}
