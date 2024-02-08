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

        public static DiffusionListItemViewModel ToListItem (this Diffusion entity)
        {
            if (entity is null) return null;
            return new DiffusionListItemViewModel()
            {
                Id_Diffusion = entity.Id_Diffusion,
                DiffusionDate = entity.DiffusionDate,
                DiffusionTime = entity.DiffusionTime,
                AudioLang = entity.AudioLang,
                SubTitleLang = entity.SubTitleLang,
                Id_CinemaRoom = entity.Id_CinemaRoom,
                Id_Movie = entity.Id_Movie,
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

        public static CinemaPlace ToBLL( this CinemaPlaceCreateForm entity)
        {
            if (entity is null) return null;
            return new CinemaPlace(
                0,
                entity.Name,
                entity.City,
                entity.Street,
                entity.Number
                );
        }


        public static Diffusion ToBLL( this DiffusionCreateForm entity)
        {
            if (entity is null) return null;
            return new Diffusion(
                0,
                entity.DiffusionDate,
                entity.DiffusionTime,
                entity.AudioLang,
                entity.SubTitleLang = "",
                0,
                0);
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
        public static DiffusionDetailsViewModel ToDetails (this Diffusion entity)
            {
            if (entity is null) return (null);
            return new DiffusionDetailsViewModel()
            {
                Id_Diffusion = entity.Id_Diffusion,
                DiffusionDate = entity.DiffusionDate,
                DiffusionTime = entity.DiffusionTime,
                AudioLang = entity.AudioLang,
                SubTitleLang = entity.SubTitleLang,
                Id_CinemaRoom = entity.Id_CinemaRoom,
                Id_Movie = entity.Id_Movie

            };
            }




        
        public static MovieEditForm ToEdit(this Movie entity)
        {
            if (entity is null) return null;
            return new MovieEditForm()
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

        public static Movie ToBLL(this MovieEditForm entity)
        {
            if (entity is null) return null;
            return new Movie(
                entity.Id_Movie,
                entity.Title,
                entity.SubTitle,
                entity.ReleaseYear,
                entity.Synopsis,
                entity.PosterUrl,
                entity.Duration
                );
        }

        public static CinemaPlaceDeleteViewModel ToDelete(this CinemaPlace entity)
        {
            if (entity is null) return null;
            return new CinemaPlaceDeleteViewModel()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
                Street = entity.Street,
                Number = entity.Number,
            };
        }

        public static MovieDeleteViewModel ToDelete( this Movie entity)
        {
            if (entity is null) return null;
            return new MovieDeleteViewModel()
            {
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
