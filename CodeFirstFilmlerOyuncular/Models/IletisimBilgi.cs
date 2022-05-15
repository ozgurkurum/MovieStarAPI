using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFilmlerOyuncular.Models
{
    [Table("IletisimBilgileri")]
    public class IletisimBilgi
    {

        [Required, MaxLength(13)]
        public string Telefon { get; set; }
        public string Adres { get; set; }

        [Key,ForeignKey("Oyuncu")]
        public int OyuncuId { get; set; }
        public Oyuncu Oyuncu { get; set; }
    }
}
