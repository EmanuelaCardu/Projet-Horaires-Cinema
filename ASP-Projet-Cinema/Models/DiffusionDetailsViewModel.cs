namespace ASP_Projet_Cinema.Models
{
    public class DiffusionDetailsViewModel
    {
        public int Id_Diffusion { get; set; }
        public DateTime DiffusionDate { get; set; }
        public TimeSpan DiffusionTime { get; set; }
        public string AudioLang { get; set; }
        public string? SubTitleLang { get; set; }
        public int Id_CinemaRoom { get; set; }
        public int Id_Movie { get; set; }
    }
}
