﻿using ASP_Projet_Cinema.Handlers;
using ASP_Projet_Cinema.Models;
using BLL_Projet_Cinema.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared_Projet_Cinema.Repositories;

namespace ASP_Projet_Cinema.Controllers
{
    public class CinemaPlaceController : Controller
    {
        private readonly ICinemaPlaceRepository<CinemaPlace> _CinemaPlaceRepository;
        private readonly IDiffusionRepository<Diffusion> _DiffusionRepository;
        public CinemaPlaceController(ICinemaPlaceRepository<CinemaPlace> CinemaPlaceRepository, IDiffusionRepository<Diffusion> DiffusionRepository)
        {
            _CinemaPlaceRepository = CinemaPlaceRepository;
            _DiffusionRepository = DiffusionRepository;
        }
        // GET: CinemaPlaceController
        public ActionResult Index()
        {
            IEnumerable<CinemaPlaceListItemViewModel> model =_CinemaPlaceRepository.Get().Select(d => d.ToListItem());
            return View(model);
        }

        // GET: CinemaPlaceController/Details/5
        public ActionResult Details(int id)
        {
            CinemaPlaceDetailsViewModel model = _CinemaPlaceRepository.Get(id).ToDetails();
            model.Diffusions = _DiffusionRepository.GetByCinemaPlace(id).Select(d =>d.ToListItem());
            return View(model); 
        }

        // GET: CinemaPlaceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CinemaPlaceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CinemaPlaceCreateForm form)
        {
            try
            {
                if (form == null) ModelState.AddModelError(nameof(form), "Pas de données reçue");
                if (!ModelState.IsValid) throw new Exception();
                int id = _CinemaPlaceRepository.Insert(form.ToBLL());
                return RedirectToAction(nameof(Details), new { id });
            }
            catch
            {
                return View();
            }
        }

        // GET: CinemaPlaceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CinemaPlaceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CinemaPlaceController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                CinemaPlaceDeleteViewModel model = _CinemaPlaceRepository.Get(id).ToDelete();
                if (model == null) throw new InvalidDataException();
                return View(model);
            }
            catch 
            { return RedirectToAction(nameof(Index));
            }
            
        }

        // POST: CinemaPlaceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CinemaPlaceDeleteViewModel model)
        {
            try
            {
                _CinemaPlaceRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
}
