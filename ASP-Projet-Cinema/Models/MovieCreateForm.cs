using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_Projet_Cinema.Models
{
    public class MovieCreateForm
    {

        [DisplayName("Titre")]
        [Required(ErrorMessage = "Le titre est obligatoire.")]
        [MaxLength(64, ErrorMessage = "Le titre ne peut dépasser 64 caractères.")]
        [MinLength(1, ErrorMessage = "Le titre doit avoir au minimum 1 caractères.")]
        public string Title { get; set; }

        [DisplayName("Sous titre")]
        [MaxLength(64, ErrorMessage = "Le sous titre ne peut dépasser 64 caractères.")]
        [MinLength(1, ErrorMessage = "Le sous titre doit avoir au minimum 1 caractères.")]
        public string? SubTitle { get; set; }

        [DisplayName("Date de sortie")]
        [Required(ErrorMessage = "La date de sortie est obligatoire.")]
        [DataType(DataType.Date)]
        public short ReleaseYear { get; set; }
        [DisplayName("Description")]
        [Required(ErrorMessage = "La description est obligatoire.")]
        [MaxLength(500, ErrorMessage = "La description  ne peut dépasser 500 caractères.")]
        [MinLength(20, ErrorMessage = "La description doit avoir au minimum 20 caractères.")]


        public string Synopsis { get; set; }
        [DisplayName("Poster")]
        [Required(ErrorMessage = "Le poster est obligatoire.")]
        


        public string PosterUrl { get; set; }
        [DisplayName("Durée")]
        [Required(ErrorMessage = "La durée est obligatoire.")]
        [MaxLength(500, ErrorMessage = "La durée ne peut dépasser 400 minutes.")]
        [MinLength(20, ErrorMessage = "La durée doit avoir au minimum 120 minutes.")]


        public int Duration { get; set; }
    }
}
