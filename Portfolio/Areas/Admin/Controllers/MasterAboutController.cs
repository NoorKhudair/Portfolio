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

        // GET: MasterAboutController/Edit/5
   
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

        public ActionResult Edit(int id)
        {
            var data = Repository.GetById(id);
            if (data == null)
            {
                return NotFound();
            }

            // Map the domain model to the view model to populate the form
            var viewModel = data.ToViewModel();
            return View(viewModel);
        }

        // POST: MasterAboutController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterAboutViewModel collection)
        {
            try
            {
                var existingModel = Repository.GetById(id);
                if (existingModel == null)
                {
                    return NotFound();
                }

                // Handle Image replacement
                if (collection.ImageFile != null)
                {
                    var newImageUrl = FileHelper.SaveImage(collection.ImageFile, "MasterAbout");

                    if (newImageUrl != "Error")
                    {
                        FileHelper.DeleteFile(existingModel.ImageURL); // delete old file after new one saved successfully
                        existingModel.ImageURL = newImageUrl;
                    }
                }

                // Handle CV replacement
                if (collection.CVFile != null)
                {
                    var newCvUrl = FileHelper.SaveDoc(collection.CVFile, "MasterAboutCV");

                    if (newCvUrl != "Error")
                    {
                        FileHelper.DeleteFile(existingModel.CVURL);
                        existingModel.CVURL = newCvUrl;
                    }
                }

                existingModel.Name = collection.Name;
                existingModel.Desc = collection.Desc;
                existingModel.Country = collection.Country;
                existingModel.Address = collection.Address;
                existingModel.Email = collection.Email;
                existingModel.Phone = collection.Phone;
                existingModel.DateOfBirth = collection.DateOfBirth;
                existingModel.IsActive = collection.IsActive;
                existingModel.EditedBy = User.Identity?.Name;
                existingModel.EditedAt = DateTime.Now;

                Repository.Update(existingModel);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return View(collection);
            }
        }
    }
}