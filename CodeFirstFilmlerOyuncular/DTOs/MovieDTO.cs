using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFilmlerOyuncular.DTOs
{
    public class MovieDTO
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Actors { get; set; }
        public string Poster { get; set; }
        public decimal imdbRating { get; set; }
        public string imdbID { get; set; }
        public override string ToString()
        {
            return $"{Title}\r\n{Year}\r\n{Genre}\r\n{Actors}\r\n{Poster}\r\n{imdbRating}\r\n{imdbID}";
        }
    }
}
