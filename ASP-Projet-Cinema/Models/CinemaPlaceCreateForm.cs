using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_Projet_Cinema.Models
{
    public class CinemaPlaceCreateForm
    {
        [DisplayName("Nom")]
        [Required(ErrorMessage = "Le nom du cinéma est obligatoire.")]
        [MaxLength(64, ErrorMessage = "Le nom ne peut dépasser 64 caractères.")]
        [MinLength(1, ErrorMessage = "Le nom doit avoir au minimum 1 caractères.")]
        public string Name { get; set; }
        [DisplayName("Ville")]
        [Required(ErrorMessage = "Le nom de la ville est obligatoire.")]
        [MaxLength(64, ErrorMessage = "Le nom ne peut dépasser 64 caractères.")]
        [MinLength(1, ErrorMessage = "Le nom doit avoir au minimum 1 caractères.")]
        public string City { get; set; }
        [DisplayName("Rue")]
        [Required(ErrorMessage = "Le nom de la rue est obligatoire.")]
        [MaxLength(64, ErrorMessage = "Ne peut dépasser 128 caractères.")]
        [MinLength(1, ErrorMessage = "Doit avoir au minimum 1 caractères.")]
        public string Street { get; set; }
        [DisplayName("Numéro")]
        [Required(ErrorMessage = "Le numéro de la rue est obligatoire.")]
        [MaxLength(64, ErrorMessage = "Ne peut dépasser 8 caractères.")]
        [MinLength(1, ErrorMessage = "Doit avoir au minimum 1 caractères.")]
        public string Number { get; set; }
    }
}
