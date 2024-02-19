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
    public class MovieService : IMovieRepository<Movie>
    {
        private readonly IMovieRepository<DAL.Movie> _movieRepository;
        private readonly IDiffusionRepository<Diffusion> _diffusionRepository;

        public MovieService(IMovieRepository<DAL.Movie> movieRepository, IDiffusionRepository<Diffusion> diffusionRepository)
        {
            _movieRepository = movieRepository;
            _diffusionRepository = diffusionRepository;
        }

        public void Delete(int id)
        {
            _movieRepository.Delete(id);

        }

        public IEnumerable<Movie> Get()
        {
            return _movieRepository.Get().Select(d => d.ToBLL());

        }

        public Movie Get(int id)
        {
            Movie entity = _movieRepository.Get(id).ToBLL();
            IEnumerable<Diffusion> diffusion = _diffusionRepository.GetByMovie(id);
            entity.AddDiffusions(diffusion);
            return entity;

        }

        public int Insert(Movie data)
        {
            return _movieRepository.Insert(data.ToDAL());
        }

        public void Update(Movie data)
        {
            _movieRepository.Update(data.ToDAL());
        }
    }
}
