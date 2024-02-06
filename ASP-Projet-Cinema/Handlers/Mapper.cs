using ASP_Projet_Cinema.Controllers;
using ASP_Projet_Cinema.Models;
using BLL_Projet_Cinema.Entities;
using Microsoft.Extensions.Logging.Abstractions;
using System.Security.Cryptography.X509Certificates;

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
                //ReleaseYear = entity.ReleaseYear,
                //Synopsis = entity.Synopsis,
                //PosterUrl = entity.PosterUrl,
                //Duration = entity.Duration
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

        public static CinemaPlaceDetailsViewModel ToDetails( this CinemaPlace entity )
        {
            if (entity is null) return null;
            return new CinemaPlaceDetailsViewModel()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
                Street = entity.Street,
                Number = entity.Number

            };
        }

        public static Movie ToBLL( this MovieCreateForm entity )
        {
            if (entity is null) return null;
            return new Movie(
                0,
                entity.Title,
                entity.SubTitle,
                entity.ReleaseYear,
                entity.Synopsis,
                entity.PosterUrl,
                entity.Duration
                );
        }

        public static MovieDetailsViewModel ToDetails (this Movie entity)
        {
            if (entity is null) return null;
            return new MovieDetailsViewModel()
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
        public static MovieEditForm ToEdit(this Movie entity)
        {
            if (entity is null) return null;
            return new MovieEditForm()
            {
                Title = entity.Title,
                SubTitle = entity.SubTitle,
                ReleaseYear = entity.ReleaseYear,
                Synopsis = entity.Synopsis,
                PosterUrl = entity.PosterUrl,
                Duration = entity.Duration
            };
        }

        public static Movie ToBLL(this MovieEditForm entity)
        {
            if (entity is null) return null;
            return new Movie(
                 0,
                entity.Title,
                entity.SubTitle,
                entity.ReleaseYear,
                entity.Synopsis,
                entity.PosterUrl,
                entity.Duration
                );
        }
    }
}
