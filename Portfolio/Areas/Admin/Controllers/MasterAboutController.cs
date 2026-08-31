using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Extensions.Mapping;
using Portfolio.Helpers.File;
using Portfolio.Models;
using Portfolio.Repositories;
using Portfolio.ViewModels;

namespace Portfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterAboutController : Controller
    {
        IRepository<MasterAbout> Repository;
        IFileHelper FileHelper;
        public MasterAboutController(IRepository<MasterAbout> repository, IFileHelper fileHelper)
        {
            Repository = repository;
            FileHelper = fileHelper;
        }


        // GET: MasterAboutController
        public ActionResult Index()
        {
            return View(Repository.GetAll().ToViewModelList());
        }

        // GET: MasterAboutController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MasterAboutController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterAboutController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterAboutViewModel collection)
        {
            try
            {
                collection.ImageURL = FileHelper.SaveImage(collection.ImageFile, "MasterAbout");
                collection.CVURL = FileHelper.SaveDoc(collection.CVFile, "MasterAboutCV");
                
                if (collection.ImageURL != "Error" && collection.CVURL != "Error")
                {
                    var model = collection.ToModel();
                    model.CreatedBy = User.Identity?.Name;
                    Repository.Add(model);
                    return RedirectToAction(nameof(Index));
                }



                return View(collection);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                return View(collection);
            }

        }

        // POST: MasterAboutController/Edit/5
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

        // GET: MasterAboutController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MasterAboutController/Delete/5
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