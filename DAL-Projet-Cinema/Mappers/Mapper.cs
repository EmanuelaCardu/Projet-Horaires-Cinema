﻿using DAL_Projet_Cinema.Entities;
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

        public static Diffusion ToDiffusion(this IDataRecord record)
        {
            if (record is null) return null;
            return new Diffusion()
            {
                Id_Diffusion = (int)record["Id_Diffusion"],
                DiffusionDate = (DateTime)record["DiffusionDate"],
                DiffusionTime = (TimeSpan)record["DiffusionTime"],
                AudioLang = (string)record["AudioLang"],
                SubTitleLang = (record["SubTitleLang"] is DBNull) ? null : (string?)record["SubTitleLang"],
                Id_CinemaRoom = (int)record["Id_CinemaRoom"],
                Id_Movie = (int)record["Id_Movie"]
            };
        }

        public static CinemaRoom ToCinemaRoom (this IDataRecord record)
        {
            return new CinemaRoom()
            {
                Id_CinemaRoom = (int)record["Id_CinemaRoom"],
                SeatsCount = (int)record["SeatsCount"],
                ScreenWidth = (int)record["ScreenWidth"],
                ScreenHeight = (int)record["ScreenHeight"],
                Can3D = (bool)record["Can3D"],
                Can4DX = (bool)record["Can4DX"],
                Id_CinemaPlace = (int)record["Id_CinemaPlace"]

            };
        }
    }
}



