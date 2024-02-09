using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Projet_Cinema.Entities
{
    public class CinemaPlace
    {
        private List<Diffusion> _diffusions;
        public int Id_CinemaPlace { get; private set; }
        public string Name { get; set; }
        public string City { get;  private set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public Diffusion[] Diffusions
        {
            get
            {
                return _diffusions?.ToArray() ?? new Diffusion[0];
            }
        }



        public CinemaPlace(int id_CinemaPlace, string name, string city, string street, string number)
        {
            Id_CinemaPlace = id_CinemaPlace;
            Name = name;
            City = city;
            Street = street;
            Number = number;
        }


        
    }

    
}
