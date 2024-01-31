using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Projet_Cinema.Entities
{
    public class Diffusion
    {
        public int Id_Diffusion { get; set; }
        public DateTime DiffusionDate { get; set; }
        public DateTime DiffusionTime { get; set; }
        public string AudioLang { get; set;}
        public string? SubTitleLang {  get; set; }
        public int id_CinemaRoom { get; set; }
        public int id_Movie { get; set; }

    }
}
