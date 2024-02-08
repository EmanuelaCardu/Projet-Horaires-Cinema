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
    public class CinemaRoomService: ICinemaRoomRepository<CinemaRoom>
    {
        private readonly IMovieRepository<DAL.CinemaRoom> _repository;

        public CinemaRoomService(IMovieRepository<DAL.CinemaRoom> repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<CinemaRoom> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());

        }

        public CinemaRoom Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(CinemaRoom data)
        {
            return _repository.Insert(data.ToDAL());
        }

        public void Update(CinemaRoom data)
        {
            _repository.Update(data.ToDAL());
        }
    }
}
