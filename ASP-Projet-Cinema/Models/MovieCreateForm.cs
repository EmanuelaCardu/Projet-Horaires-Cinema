namespace ASP_Projet_Cinema.Models
{
    public class MovieCreateForm
    {
        public int Id_Movie { get; set; }
        public string Title { get; set; }
        public string? SubTitle { get; set; }
        public short ReleaseYear { get; set; }
        public string Synopsis { get; set; }
        public string PosterUrl { get; set; }
        public int Duration { get; set; }
    }
}
