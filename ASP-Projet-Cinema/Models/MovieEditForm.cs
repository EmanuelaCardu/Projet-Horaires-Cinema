using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Projet_Cinema.Models
{
    public class MovieEditForm
    {
        [HiddenInput]
        [Required]
        public int Id_Movie { get; set; }
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

        public short ReleaseYear { get; set; }
        [DisplayName("Description")]
        [Required(ErrorMessage = "La description est obligatoire.")]
        [MaxLength(1000, ErrorMessage = "La description  ne peut dépasser 1000 caractères.")]
        [MinLength(20, ErrorMessage = "La description doit avoir au minimum 20 caractères.")]

        public string Synopsis { get; set; }
        [DisplayName("Poster")]
        [Required(ErrorMessage = "Le poster est obligatoire.")]


        public string PosterUrl { get; set; }
        [DisplayName("Durée")]
        [Required(ErrorMessage = "La durée est obligatoire.")]
        [Range(20, 500, ErrorMessage = "La durée doit être compise entre 20 minutes et 500 minutes")]
        public int Duration { get; set; }
    }
}
