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
using System.Data.Entity;

namespace CodeFirstFilmlerOyuncular
{
    public partial class OyuncularForm : Form
    {
        private readonly FilmOyuncuContext db;

        public OyuncularForm(FilmOyuncuContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnOyuncuEkle_Click(object sender, EventArgs e)
        {
            OyuncuEkleGuncelleForm oyuncuForm = new OyuncuEkleGuncelleForm(db);
            oyuncuForm.ShowDialog();
            OyuncularıListele();
        }

        private void OyuncularıListele()
        {
            //Oyuncuları dgv de listelicez
            dgvOyuncular.Rows.Clear();
            foreach (var item in db.Oyuncular.Include(x => x.IletisimBilgi))
            {
                if (item.IletisimBilgi != null)
                {
                    dgvOyuncular.Rows.Add(item.Id, item.AdSoyad, item.IletisimBilgi.Adres, item.IletisimBilgi.Telefon);
                }
                else
                {
                    dgvOyuncular.Rows.Add(item.Id, item.AdSoyad, "Yok", "Yok");
                }
            }
        }

        private void OyuncularForm_Load(object sender, EventArgs e)
        {
            OyuncularıListele();
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //seçili oyunucu alıp oyuncuguncelle forma db ile beraber göndericez ve oyunucuyu/id güncellicez.
            //oyuncuGuncelleform'un 2 tane constructorı olucak.
            //sonradan eklenen constructor çalışırsa oyuncuEkleGuncelle formdaki btnEkle'nin text'i güncelle olucak ve ilgili alanlar dolu gelicek.
            int id = (int)dgvOyuncular.SelectedRows[0].Cells[0].Value;
            OyuncuEkleGuncelleForm oyuncuekleguncelleform = new OyuncuEkleGuncelleForm(db, id);
            oyuncuekleguncelleform.ShowDialog();
            OyuncularıListele();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Secili oyuncuyu silecez. Odev. Id si bulunmalı.
            int id = (int)dgvOyuncular.SelectedRows[0].Cells[0].Value;
            var silinecek = db.Oyuncular.Where(x => x.Id == id).FirstOrDefault();
            db.Oyuncular.Remove(silinecek);
            db.SaveChanges();
            OyuncularıListele();
        }

        private void dgvOyuncular_MouseDown(object sender, MouseEventArgs e)
        {
            //eğer sağ click olduysa context menu strip göstericez.
            var hti = dgvOyuncular.HitTest(e.X, e.Y);
            if (e.Button == MouseButtons.Right && hti.RowIndex >= 0)
            {
                dgvOyuncular.ClearSelection();
                dgvOyuncular.Rows[hti.RowIndex].Selected = true;
                contextMenuStrip1.Show(dgvOyuncular, new Point(e.X, e.Y));
            }
        }
    }
}
