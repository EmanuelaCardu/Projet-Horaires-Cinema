using System;
using System.Collections.Generic;
using System.Text;
using BLL = BLL_Projet_Cinema.Entities;
using DAL = DAL_Projet_Cinema.Entities;

namespace BLL_Projet_Cinema.Mappers
{
    internal static class Mapper
    {
        #region Movie
        public static BLL.Movie ToBLL(this DAL.Movie entity)
        {
            if (entity == null) return null;
            return new BLL.Movie(
                entity.Id_Movie,
                entity.Title,
                entity.SubTitle,
                entity.ReleaseYear,
                entity.Synopsis,
                entity.PosterUrl,
                entity.Duration);
        }

        public static DAL.Movie ToDAL(this BLL.Movie entity)
        {
            if (entity is null) return null;
            return new DAL.Movie()
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
        #endregion
    }
}
