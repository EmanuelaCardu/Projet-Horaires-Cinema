using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_Projet_Cinema.Models
{
    public class CinemaPlaceDetailsViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_CinemaPlace { get; set; }
        [DisplayName("Nom")]
        public string Name { get; set; }
        [DisplayName("Ville")]
        public string City { get; set; }
        [DisplayName("Rue")]
        public string Street { get; set; }
        [DisplayName("Numéro")]
        public string Number { get; set; }
        [ScaffoldColumn(false)]

        public IEnumerable<DiffusionListItemViewModel> Diffusions { get; set; }
    }
}

