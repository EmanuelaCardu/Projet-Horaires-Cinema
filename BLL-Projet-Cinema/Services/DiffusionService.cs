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
    public class DiffusionService : IDiffusionRepository<Diffusion>
    {
        private readonly IDiffusionRepository<DAL.Diffusion> _diffusionRepository;
        private readonly IMovieRepository<DAL.Movie> _movieRepository;
        private readonly ICinemaRoomRepository<DAL.CinemaRoom> _cinemaRoomRepository;
        public DiffusionService(IDiffusionRepository<DAL.Diffusion> diffusionRepository, IMovieRepository<DAL.Movie> movieRepository, ICinemaRoomRepository<DAL.CinemaRoom> cinemaRoomRepository)
        {
            _diffusionRepository = diffusionRepository;
            _movieRepository = movieRepository;
            _cinemaRoomRepository = cinemaRoomRepository;
        }

        public IEnumerable<Diffusion> GetByCinema(int id)
        {

            //return _diffusionRepository.GetByCinema(id).Select(d => d.ToBLL()

            //);


            return _diffusionRepository.GetByCinema(id).Select(d =>
            {
                Diffusion result = d.ToBLL();
                result.Movie = _movieRepository.Get(result.Id_Movie).ToBLL();
                result.CinemaRoom = _cinemaRoomRepository.Get(result.Id_CinemaRoom).ToBLL();
                return result;
            });


        }

        public IEnumerable<Diffusion> GetByMovie(int id)
        {

            return _diffusionRepository.GetByMovie(id).Select(d =>
            {
                Diffusion result = d.ToBLL();
                result.Movie = _movieRepository.Get(result.Id_Movie).ToBLL();
                result.CinemaRoom = _cinemaRoomRepository.Get(result.Id_CinemaRoom).ToBLL();
                return result;
            });
        }

            public void Delete(int id)
        {
            _diffusionRepository.Delete(id);
        }

        public IEnumerable<Diffusion> Get()
        {
            return _diffusionRepository.Get().Select(d => d.ToBLL());

        }

        public Diffusion Get(int id)
        {
            return _diffusionRepository.Get(id).ToBLL();

        }

        public IEnumerable<Diffusion> GetByCinemaPlace(int id)
        {
            return _diffusionRepository.GetByCinema(id).Select(d=> d.ToBLL());
        }

        public int Insert(Diffusion data)
        {
            return _diffusionRepository.Insert(data.ToDAL());
        }

        public void Update(Diffusion data)
        {
            _diffusionRepository.Update(data.ToDAL());
        }
    }
}
