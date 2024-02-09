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
        private readonly ICinemaPlaceRepository<DAL.CinemaPlace> _CinemaPlaceRepository;
        private readonly IDiffusionRepository<DAL.Diffusion> _DiffusionRepository;
        public CinemaPlaceService(ICinemaPlaceRepository<DAL.CinemaPlace> CinemaPlaceRepository, IDiffusionRepository<DAL.Diffusion> DiffusionRepository)
        {
            _CinemaPlaceRepository = CinemaPlaceRepository;   
            _DiffusionRepository = DiffusionRepository;
        }

        public void Delete(int id)
        {
            _CinemaPlaceRepository.Delete(id);
        }

        public IEnumerable<CinemaPlace> Get()
        {
            return _CinemaPlaceRepository.Get().Select(d => d.ToBLL());
        }

        public CinemaPlace Get(int id)
        {
            return _CinemaPlaceRepository.Get(id).ToBLL();

        }

        public int Insert(CinemaPlace data)
        {
            return _CinemaPlaceRepository.Insert(data.ToDAL());
        }

        public void Update(CinemaPlace data)
        {
            _CinemaPlaceRepository.Update(data.ToDAL());
        }
    }
}
