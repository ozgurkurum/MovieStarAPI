using CodeFirstFilmlerOyuncular.Data;
using CodeFirstFilmlerOyuncular.DTOs;
using CodeFirstFilmlerOyuncular.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstFilmlerOyuncular
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            await VerileriYukle();
            Application.Run(new MainForm());
        }
        
        static async Task VerileriYukle()
        {
            FilmOyuncuContext db = new FilmOyuncuContext();
            if (!db.Filmler.Any())
            {
                #region Adim1
                //1. Adım imdb.com sitesindeki film idlerini okuma.
                List<string> filmIds = new List<string>();
                string url = "https://www.imdb.com/chart/top/";
                //Web parse işlemi HtmlAgilityPack yüklenir nugetten.
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load(url);
                HtmlNodeCollection films = doc.DocumentNode.SelectNodes("//div[@data-tconst]");//XPATH
                foreach (HtmlNode film in films)
                {
                    filmIds.Add(film.Attributes["data-tconst"].Value);
                }
                #endregion
                #region Adim2
                //2. Adım omdbapi'ye bu idlere göre istek atma ve gelen veriyi istediğimiz şekilde alma.
                //https://www.omdbapi.com/?apikey=cf93546c&i=tt15097216
                List<MovieDTO> movies = new List<MovieDTO>();
                string apiUrl = "https://www.omdbapi.com/?apikey=cf93546c&i=";
                HttpClient httpClient = new HttpClient();
                foreach (string filmId in filmIds)
                {
                    HttpResponseMessage result = await httpClient.GetAsync(apiUrl + filmId);
                    if (result.IsSuccessStatusCode)
                    {
                        //Microsoft.AspNet.WebApi.Client nugetten indirdik. String okumak yerine class olarak okumak için.
                        movies.Add(await result.Content.ReadAsAsync<MovieDTO>());
                        //DTO data transfer object
                    }
                }
                #endregion
                foreach (MovieDTO movie in movies)
                {
                    Film film = new Film()
                    {
                        Ad = movie.Title,
                        imdbID = movie.imdbID,
                        IMDBPuani = movie.imdbRating,
                        Yil = movie.Year,
                        Poster = movie.Poster
                    };
                    string genreAd = movie.Genre.Split(',')[0].Trim();
                    Tur tur = db.Turler.FirstOrDefault(x => x.Ad == genreAd);
                    if (tur != null)
                    {
                        film.Tur = tur;
                    }
                    else
                    {
                        film.Tur = new Tur()
                        {
                            Ad = genreAd
                        };
                    }
                    List<string> oyuncular = movie.Actors.Split(',').ToList();
                    foreach (var item in oyuncular)
                    {
                        Oyuncu oyuncu = db.Oyuncular.FirstOrDefault(x => x.AdSoyad == item.Trim());
                        if (oyuncu != null)
                        {
                            film.Oyuncular.Add(oyuncu);
                        }
                        else
                        {
                            film.Oyuncular.Add(new Oyuncu()
                            {
                                AdSoyad = item.Trim()
                            });
                        }
                    }
                    db.Filmler.Add(film);
                    await db.SaveChangesAsync();//kaydetme işleminin bitmesini bekletiyorum.
                }
            }
        }
    }
}
