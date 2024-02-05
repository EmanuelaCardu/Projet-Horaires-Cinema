using DAL_Projet_Cinema.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL_Projet_Cinema.Mappers
{
    internal static class Mapper
    {
        public static Movie ToMovie(this IDataRecord record)
        {
            if (record is null) return null;
            return new Movie()
            {
                Id_Movie = (int)record["Id_Movie"],
                Title = (string)record["Title"],
                SubTitle = (record["SubTitle"] is DBNull) ? null : (string?)record["SubTitle"],
                ReleaseYear = (short)record["ReleaseYear"],
                Synopsis = (string)record["Synopsis"],
                PosterUrl = (string)record["PosterUrl"],
                Duration = (int)record["Duration"]
            };
         }

        public static CinemaPlace ToCinemaPlace(this IDataRecord record)
        {
            if (record is null) return null;
            return new CinemaPlace()
            {
                Id_CinemaPlace = (int)record["Id_CinemaPlace"],
                Name = (string)record["Name"],
                City = (string)record["City"],
                Street = (string)record["Street"],
                Number = (string)record["Number"]
            };
        }
    }
}
