using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace ASP_Projet_Cinema.Models
{
    public class DiffusionCreateForm
    {
        //public int Id_Diffusion { get; set; }
        [DisplayName("Date de diffusion")]
        [Required(ErrorMessage = "La date est obligatoire.")]
      
       
        public DateTime DiffusionDate { get; set; }
        
        [DisplayName("Heure de diffusion")]
        [Required(ErrorMessage = "L'heure est obligatoire.")]

        public TimeSpan DiffusionTime { get; set; }
        [DisplayName("Langue de diffusion")]
        [Required(ErrorMessage = "La date est obligatoire.")]
        public string AudioLang { get; set; }
        [DisplayName("Sous titre")]
      
        public string? SubTitleLang { get; set; }
        [HiddenInput]
        //[Required]
        public int Id_CinemaRoom { get; set; }
        [HiddenInput]
        //[Required]
        public int Id_Movie { get; set; }
    }
}
