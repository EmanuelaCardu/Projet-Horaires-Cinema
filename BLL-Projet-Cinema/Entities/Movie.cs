using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BLL_Projet_Cinema.Entities
{
    public class Movie
    {
        public int Id_Movie { get; private set; }
        public string Title { get; private set; }
        public string? SubTitle { get; set; }
        public short ReleaseYear { get;  private set; }
       
        public string Synopsis { get; set; }
        public string PosterUrl { get; set; }
        public int Duration { get; private set; }

        public Movie(int id_Movie, string title, string? subTitle, short releaseYear, 
            string synopsis, string posterUrl, int duration)
        {
            Id_Movie = id_Movie;
            Title = title;
            SubTitle = subTitle;
            ReleaseYear = releaseYear;
            Synopsis = synopsis;
            PosterUrl = posterUrl;
            Duration = duration;
        }

    //    CONSTRAINT[CK_Movie_ReleaseYear] CHECK([ReleaseYear] BETWEEN 1800 AND YEAR(GETDATE())),
    //CONSTRAINT[CK_Movie_Duration] CHECK([Duration] > 0), 

        //public void UpdateSynopsis (string newSynopsis)
        //{
        //    if(newSynopsis < 50 || newSynopsis > 500) throw new ArgumentOutOfRangeException(nameof(newSynopsis), "Le résumé doit rester compris" +
        //        "entre 0 et 500 charactères");
        //    Synopsis = newSynopsis;
        //}
    }
}
