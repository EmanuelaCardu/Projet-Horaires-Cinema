using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Projet_Cinema.Models
{
    public class MovieListItemViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_Movie { get; set; }
        [DisplayName("Titre")]
        public string Title { get; set; }
        [DisplayName("Soutitre")]

        public string? SubTitle { get; set; }
        //[DisplayName("Année de sortie")]

        //public short ReleaseYear { get; set; }
        //[DisplayName("Resumé")]

        //public string Synopsis { get; set; }
        //[DisplayName("Poster")]

        //public string PosterUrl { get; set; }
        //[DisplayName("Durée")]

        //public int Duration { get; set; }
    }
}
