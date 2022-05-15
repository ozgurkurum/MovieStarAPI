using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFilmlerOyuncular.Models
{
    [Table("Oyuncular")]
    public class Oyuncu
    {
        public Oyuncu()
        {
            Filmler = new List<Film>();
        }
        public int Id { get; set; }
        [Required, MaxLength(60)]
        public string AdSoyad { get; set; }
        public List<Film> Filmler { get; set; }
        public virtual IletisimBilgi IletisimBilgi { get; set; }

    }
}
