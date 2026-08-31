using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Extensions.Mapping;
using Portfolio.Models;
using Portfolio.Repositories;
using Portfolio.ViewModels;

namespace Portfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MasterTitlesController : Controller
    {
        IRepository<MasterTitles> Repository;
        public MasterTitlesController(IRepository<MasterTitles> repository)
        {
            Repository = repository;
        }

        // GET: MasterTitlesController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();
            return View(data);
        }

        // GET: MasterTitlesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MasterTitlesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterTitlesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterTitleViewModel collection)
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


        // GET: MasterTitles/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MasterTitles/Edit/5
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

        // GET: MasterTitles/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MasterTitles/Delete/5
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
