using System;
using System.Collections.Generic;
using System.Text;
using BLL = BLL_Projet_Cinema.Entities;
using DAL = DAL_Projet_Cinema.Entities;

namespace BLL_Projet_Cinema.Mappers
{
    internal static class Mapper
    {
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
    }
}
