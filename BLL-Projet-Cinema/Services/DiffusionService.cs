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
        public DiffusionService(IDiffusionRepository<DAL.Diffusion> repository)
        {
            _diffusionRepository = repository;
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
            throw new NotImplementedException();
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
