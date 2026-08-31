using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Extensions.Mapping;
using Portfolio.Models;
using Portfolio.Repositories;
using Portfolio.ViewModels;

namespace Portfolio.Areas.Admin.Controllers
{
        [Area("Admin")]
    public class MasterPositionsController : Controller
    {
        IRepository<MasterPositions> Repository;
        public MasterPositionsController(IRepository<MasterPositions> repository)
        {
            Repository = repository;
        }
         
        // GET: MasterPositionsController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();
            return View(data );
        }

        // GET: MasterPositionsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MasterPositionsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterPositionsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterPositionsViewModel collection)
        {
            try
            {
                Repository.Add(collection.ToModel());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterPositionsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MasterPositionsController/Edit/5
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

        // GET: MasterPositionsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MasterPositionsController/Delete/5
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
