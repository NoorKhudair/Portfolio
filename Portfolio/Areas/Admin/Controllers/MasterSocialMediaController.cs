using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Extensions.Mapping;
using Portfolio.Models;
using Portfolio.Repositories;
using Portfolio.ViewModels;

namespace Portfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MasterSocialMediaController : Controller
    {

        IRepository<MasterSocialMedia> Repository;
        public MasterSocialMediaController(IRepository<MasterSocialMedia> repository)
        {
            Repository = repository;
        }

        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();
            return View(data);
        }

        // GET: MasterSocialMediaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MasterSocialMediaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterSocialMediaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterSocialMediaViewModel collection)
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

        // GET: MasterSocialMediaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MasterSocialMediaController/Edit/5
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

        // GET: MasterSocialMediaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MasterSocialMediaController/Delete/5
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
