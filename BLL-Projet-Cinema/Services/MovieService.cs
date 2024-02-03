﻿using BLL_Projet_Cinema.Entities;
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
        private readonly IMovieRepository<DAL.Movie> _repository;

        public MovieService(IMovieRepository<DAL.Movie> repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);

        }

        public IEnumerable<Movie> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());

        }

        public Movie Get(int id)
        {
            return _repository.Get(id).ToBLL();

        }

        public int Insert(Movie data)
        {
            return _repository.Insert(data.ToDAL());
        }

        public void Update(Movie data)
        {
            _repository.Update(data.ToDAL());
        }
    }
}