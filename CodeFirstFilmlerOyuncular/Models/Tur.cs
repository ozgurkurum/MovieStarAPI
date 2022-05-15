using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFilmlerOyuncular.Models
{
    [Table("Turler")]
    public class Tur
    {
        public Tur()
        {
            Filmler = new List<Film>();
        }
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Ad { get; set; }
        List<Film> Filmler { get; set; }
    }
}
