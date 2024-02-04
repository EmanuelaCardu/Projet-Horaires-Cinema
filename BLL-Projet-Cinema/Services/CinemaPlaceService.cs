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
        private readonly ICinemaPlaceRepository<DAL.CinemaPlace> _repository;
        public CinemaPlaceService(ICinemaPlaceRepository<DAL.CinemaPlace> repository)
        {
            _repository = repository;   
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<CinemaPlace> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());
        }

        public CinemaPlace Get(int id)
        {
            return _repository.Get(id).ToBLL();

        }

        public int Insert(CinemaPlace data)
        {
            return _repository.Insert(data.ToDAL());
        }

        public void Update(CinemaPlace data)
        {
            _repository.Update(data.ToDAL());
        }
    }
}
