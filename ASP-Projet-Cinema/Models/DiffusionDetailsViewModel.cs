using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Projet_Cinema.Models
{
    public class DiffusionDetailsViewModel
    {
        [HiddenInput]
        [Required]
        public int Id_Diffusion { get; set; }
        [DisplayName("Date de diffusion")]
        public DateTime DiffusionDate { get; set; }
        [DisplayName("Heure de diffusion")]

        public TimeSpan DiffusionTime { get; set; }
        [DisplayName("Langue")]


        public string AudioLang { get; set; }
        [DisplayName("Sous titres")]

        public string? SubTitleLang { get; set; }
        [ScaffoldColumn(false)]

        [HiddenInput]
        [Required]
        public int Id_CinemaRoom { get; set; }
        [ScaffoldColumn(false)]

        [HiddenInput]
        [Required]
        public int Id_Movie { get; set; }
    }
}
