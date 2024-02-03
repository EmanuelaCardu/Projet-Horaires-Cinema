using ASP_Projet_Cinema.Models;
using BLL_Projet_Cinema.Entities;

namespace ASP_Projet_Cinema.Handlers
{
    public static class Mapper
    {
        public static MovieListItemViewModel ToListItem(this Movie entity)
        {
            if (entity == null) return null;
            return new MovieListItemViewModel()
            {
                Id_Movie = entity.Id_Movie,
                Title = entity.Title,
                SubTitle = entity.SubTitle,
                ReleaseYear = entity.ReleaseYear,
                Synopsis = entity.Synopsis,
                PosterUrl = entity.PosterUrl,
                Duration = entity.Duration
            };
        }
    }
}
