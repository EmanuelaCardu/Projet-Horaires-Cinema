using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BLL_Projet_Cinema.Entities
{
    public class Movie
    {
        private List<Diffusion> _diffusions;

        public int Id_Movie { get; private set; }
        public string Title { get; private set; }
        public string? SubTitle { get; set; }
        public short ReleaseYear { get;  private set; }
       
        public string Synopsis { get; set; }
        public string PosterUrl { get; set; }
        public int Duration { get; private set; }

        public Diffusion[] Diffusions
        {
            get
            {
                return _diffusions?.ToArray() ?? new Diffusion[0];
            }
        }

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

        public void AddDiffusions(IEnumerable<Diffusion> diffusions)
        {
            if (diffusions is null) throw new ArgumentNullException(nameof(diffusions));
            foreach (Diffusion diffusion in diffusions)
            {
                AddDiffusion(diffusion);
            }
        }

        public void AddDiffusion(Diffusion diffusion)
        {
            _diffusions ??= new List<Diffusion>();
            //if (diffusion is null) throw new ArgumentNullException(nameof(diffusion));
            //if (_diffusions.Contains(diffusion)) throw new ArgumentException(nameof(diffusion), $"la diffusion {diffusion.Id_Diffusion} existe deja.");
            //if ((!(student.Section is null) && student.Section != this) || student.Section_id != this.Section_id) throw new ArgumentException(nameof(student), $"L'étudiant {student.Student_id} est déjà inscrit dans une section différente.");

            _diffusions.Add(diffusion);
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
