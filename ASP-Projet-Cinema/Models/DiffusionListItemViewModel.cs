using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Projet_Cinema.Models
{
    public class DiffusionListItemViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_Diffusion { get; set; }
        [DisplayName("Date de diffusion")]
        [DataType(DataType.Date)]

        public DateTime DiffusionDate { get; set; }
        [DisplayName("Heure de diffusion")]
        [DataType(DataType.DateTime)]

        public DateTime DiffusionTime { get; set; }
        [DisplayName("Langue")]

        public string AudioLang { get; set; }
        [DisplayName("Sous titres")]

        public string SubTitleLang { get; set; }
        [ScaffoldColumn(false)]

        public int Id_CinemaRoom { get; set; }
        [ScaffoldColumn(false)]

        public int Id_Movie { get; set; }
    }
}
