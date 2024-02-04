using ASP_Projet_Cinema.Models;
using BLL_Projet_Cinema.Entities;
using Microsoft.Extensions.Logging.Abstractions;

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

        public static CinemaPlaceListItemViewModel ToListItem( this CinemaPlace entity )
        {
            if (entity is null) return null;
            return new CinemaPlaceListItemViewModel()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
                Street = entity.Street,
                Number = entity.Number,
            };
        }
    }
}
