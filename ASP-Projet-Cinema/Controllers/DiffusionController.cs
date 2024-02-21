using ASP_Projet_Cinema.Handlers;
using ASP_Projet_Cinema.Models;
using BLL_Projet_Cinema.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared_Projet_Cinema.Repositories;
using System.Reflection;

namespace ASP_Projet_Cinema.Controllers
{
    public class DiffusionController : Controller
    {
        private readonly IDiffusionRepository<Diffusion> _diffusionRepository;
        private readonly IMovieRepository<Movie> _movieRepository;
        public DiffusionController(IDiffusionRepository<Diffusion> diffusionRepository, IMovieRepository<Movie> movieRepository)
        {
            _diffusionRepository = diffusionRepository;
            _movieRepository = movieRepository;
        }

        // GET: DiffusionController
        public ActionResult Index()
        {
            IEnumerable<DiffusionListItemViewModel> model = _diffusionRepository.Get()
                                                                        .Select(d => d.ToListItem());
            return View(model);
        }

        // GET: DiffusionController/Details/5
        public ActionResult Details(int id)
        {
            DiffusionDetailsViewModel model = _diffusionRepository.Get(id).ToDetails();
            return View(model);
        }

        // GET: DiffusionController/Create
        //public ActionResult Create()
        ////{
        //    //DiffusionCreateForm model = new DiffusionCreateForm();
        //    //model.Movies = _movieRepository.Get().Select(d => d.ToListItem());
        //   return View(/*model*/);
        //}



        // POST: DiffusionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DiffusionCreateForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Pas de données reçues");
                if (!ModelState.IsValid)
                {
                    throw new Exception();
                }

                int id = _diffusionRepository.Insert(form.ToBLL());
                return RedirectToAction(nameof(Details), new { id });
            }
            catch
            {
                //form ??= new DiffusionCreateForm();
                //form.Movies = _movieRepository.Get().Select(d => d.ToListItem());

                return View();
            }
        }

        // GET: DiffusionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DiffusionController/Edit/5
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

        // GET: DiffusionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DiffusionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
