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

        public HomeController(ILogger<HomeController> logger,IRepository<MasterAbout> repository)
        {
            _logger = logger;
            MasterAboutRepository = repository;
        }

        public IActionResult Index()
        {
            
            var masterAboutData = MasterAboutRepository.GetAllClient().ToViewModelList().FirstOrDefault();

            var obj = new HomeViewModel
            {
                MasterAbout = masterAboutData ?? new MasterAboutViewModel() // Fallback to avoid null
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
