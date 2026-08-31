using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Portfolio.Extensions.Mapping;
using Portfolio.Models;
using Portfolio.Repositories;
using Portfolio.ViewModels;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IRepository <MasterAbout> MasterAboutRepository;
        IRepository<MasterTitles> MasterTitlesRepository;
        IRepository<MasterPositions> MasterPositionsRepository;
        IRepository<MasterSocialMedia> MasterSocialMediaRepository;


        public HomeController(ILogger<HomeController> logger, IRepository<MasterAbout> repository, IRepository<MasterTitles> masterTitlesRepository, IRepository<MasterPositions> masterPositionsRepository, IRepository<MasterSocialMedia> masterSocialMediaRepository)
        {
            _logger = logger;
            MasterAboutRepository = repository;
            MasterTitlesRepository = masterTitlesRepository;
            MasterPositionsRepository = masterPositionsRepository;
            MasterSocialMediaRepository = masterSocialMediaRepository;
        }

        public IActionResult Index()
        {
            
            var masterAboutData = MasterAboutRepository.GetAllClient().ToViewModelList().FirstOrDefault();
            var masterTitlesData = MasterTitlesRepository.GetAllClient().ToViewModelList();
            var masterPositionsData = MasterPositionsRepository.GetAllClient().ToViewModelList();
            var masterSocialMediaData = MasterSocialMediaRepository.GetAllClient().ToViewModelList();

            var obj = new HomeViewModel
            {
                MasterAbout = masterAboutData ?? new MasterAboutViewModel(),
                MasterTitle = masterTitlesData ,
                MasterPositions = masterPositionsData ,
                MasterSocialMedia = masterSocialMediaData ,


            }; 
            return View(obj);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
