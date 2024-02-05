﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Projet_Cinema.Controllers
{
    public class MovieDetailsViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_Movie { get;  set; }
        [DisplayName("Titre")]
        public string Title { get;  set; }
        [DisplayName("Sous titre")]
        public string? SubTitle { get; set; }
        [DisplayName("Date de sorite")]
        public short ReleaseYear { get; set; }
        [DisplayName("Description")]

        public string Synopsis { get; set; }
        [DisplayName("Poster")]
        public string PosterUrl { get; set; }
        [DisplayName("Durée")]
        public int Duration { get;  set; }
    }
}