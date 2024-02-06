using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_Projet_Cinema.Models
{
    public class MovieDeleteViewModel
    {

        [DisplayName("Titre")]
     
        public string Title { get; set; }

        [DisplayName("Sous titre")]
       
        public string? SubTitle { get; set; }

        [DisplayName("Date de sortie")]
     

        public short ReleaseYear { get; set; }
        [DisplayName("Description")]
   

        public string Synopsis { get; set; }
        [DisplayName("Poster")]
    


        public string PosterUrl { get; set; }
        [DisplayName("Durée")]
      
        public int Duration { get; set; }
    }
}
