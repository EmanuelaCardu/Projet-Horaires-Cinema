using BLL_Projet_Cinema.Entities;
using BLL_Projet_Cinema.Mappers;
using Shared_Projet_Cinema.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL = DAL_Projet_Cinema.Entities;

namespace BLL_Projet_Cinema.Services
{
    public class CinemaPlaceService : ICinemaPlaceRepository<CinemaPlace>
    {
        private readonly ICinemaPlaceRepository<DAL.CinemaPlace> _cinemaPlaceRepository;
        private readonly IDiffusionRepository<DAL.Diffusion> _diffusionRepository;
        private readonly ICinemaRoomRepository<CinemaRoom> _cinemaRoomRepository;

        public CinemaPlaceService(ICinemaPlaceRepository<DAL.CinemaPlace> cinemaPlaceRepository, IDiffusionRepository<Diffusion> diffusionRepository, ICinemaRoomRepository<CinemaRoom> cinemaRoomRepository)
        {
            _cinemaPlaceRepository = cinemaPlaceRepository;
            _diffusionRepository = diffusionRepository;
            _cinemaRoomRepository = cinemaRoomRepository;
        }

        public void Delete(int id)
        {
            _cinemaPlaceRepository.Delete(id);
        }

        public IEnumerable<CinemaPlace> Get()
        {
            return _cinemaPlaceRepository.Get().Select(d => d.ToBLL());
        }

        public CinemaPlace Get(int id)
        {
            CinemaPlace entity = _cinemaPlaceRepository.Get(id).ToBLL();
            IEnumerable<Diffusion> diffusion = _diffusionRepository.GetByCinema(id);
            entity.AddDiffusions(diffusion);
            /*chercher l 'ensemble des cinemaRomms de la cinemaPlace*/

            IEnumerable<CinemaRoom> cinemaRooms = _cinemaRoomRepository.GetByCinemaPlace(id);
            entity.AddRooms(cinemaRooms);
            return entity;

        }

        public int Insert(CinemaPlace data)
        {
            return _cinemaPlaceRepository.Insert(data.ToDAL());
        }

        public void Update(CinemaPlace data)
        {
            _cinemaPlaceRepository.Update(data.ToDAL());
        }
    }
}
