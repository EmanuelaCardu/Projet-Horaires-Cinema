﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Projet_Cinema.Models
{
    public class CinemaPlaceListItemViewModel
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

        public IEnumerable<DiffusionListItemViewModel> Diffusions { get; set; }

    }
}
