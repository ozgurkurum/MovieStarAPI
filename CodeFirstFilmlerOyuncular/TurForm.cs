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
    public partial class TurForm : Form
    {
        FilmOyuncuContext db = new FilmOyuncuContext();
        int seciliTurId;
        public TurForm()
        {
            InitializeComponent();
            dgvTurler.DataSource = db.Turler.ToList();
        }
        private void btnTurEkle_Click(object sender, EventArgs e)
        {
            var turKontrol = db.Turler.Select(x => x.Ad).Contains(txtTurler.Text.Trim());
            if (btnTurEkle.Text=="Tur Ekle" && !string.IsNullOrEmpty(txtTurler.Text))
            {
                if (turKontrol)
                {
                    MessageBox.Show("Bu tur adı mevcuttur. Aynı tur eklenemez!");
                }
                else
                {
                    db.Turler.Add(new Tur()
                    {
                        Ad=txtTurler.Text
                    });
                    
                }
            }
            else if(btnTurEkle.Text == "Guncelle" && !string.IsNullOrEmpty(txtTurler.Text))
            {
                if (turKontrol)
                {
                    MessageBox.Show("Bu tur adı mevcuttur!");
                }
                else
                {
                    var guncellenecekTur = db.Turler.Where(x => x.Id == seciliTurId).ToList();
                    foreach (var item in guncellenecekTur)
                    {
                        item.Ad = txtTurler.Text;
                    }
                }
                btnTurEkle.Text = "Tur Ekle";
                txtTurler.Text = "";
            }
            else
            {
                MessageBox.Show("Tur adı boş girilemez");
            }
            db.SaveChanges();
            dgvTurler.DataSource = db.Turler.ToList();
        }

        private void cmsGuncelle_Click(object sender, EventArgs e)
        {
            btnTurEkle.Text = "Guncelle";
            seciliTurId = (int)dgvTurler.SelectedRows[0].Cells[0].Value;
            txtTurler.Text = (string)dgvTurler.SelectedRows[0].Cells[1].Value;
        }

        private void cmsSil_Click(object sender, EventArgs e)
        {
            int silinecekTurId= (int)dgvTurler.SelectedRows[0].Cells[0].Value;
            var silinicekTur = db.Turler.Where(x => x.Id == silinecekTurId).FirstOrDefault();
            db.Turler.Remove(silinicekTur);
            db.SaveChanges();
            dgvTurler.DataSource = db.Turler.ToList();
            if (silinicekTur != null)
            {
                MessageBox.Show("Tur silinmiştir");
            }
        }

        private void dgvTurler_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = dgvTurler.HitTest(e.X, e.Y);
            if (e.Button == MouseButtons.Right && hti.RowIndex >= 0)
            {
                dgvTurler.ClearSelection();
                dgvTurler.Rows[hti.RowIndex].Selected = true;
                contextMenuStrip1.Show(dgvTurler, new Point(e.X, e.Y));
            }
        }
    }
}
