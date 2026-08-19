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
            if (!ModelState.IsValid)
            {
                return View(collection); // Pass the collection back so filled data isn't lost
            }

            try
            {
                // 1. Process files safely (Check for nulls inside FileHelper or handle appropriately)
                if (collection.ImageFile != null)
                {
                    collection.ImageURL = FileHelper.SaveImage(collection.ImageFile, "MasterAbout");
                }

                if (collection.CVFile != null)
                {
                    collection.CVURL = FileHelper.SaveDoc(collection.CVFile, "MasterAboutCV");
                }

                // 2. Validate upload results
                if (collection.ImageURL == "Error" || collection.CVURL == "Error")
                {
                    ModelState.AddModelError("", "Failed to upload files. Please try again.");
                    return View(collection);
                }

                // 3. Map and save to database
                var model = collection.ToModel();
                model.CreatedBy = User.Identity?.Name ?? "Admin";

                Repository.Add(model);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // Add exception details to ModelState to display on screen for easy debugging
                ModelState.AddModelError("", $"An error occurred while saving: {ex.Message}");
                return View(collection);
            }
        }

        // GET: MasterAboutController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
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
