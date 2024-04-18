using APsAutoImport.Models;
using APsAutoImport.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace APsAutoImport.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _carRepository;
        public HomeController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public IActionResult Index()
        {
           var hybridcollection= _carRepository.HybridCollection;
            var homeViewModel = new HomeViewModel(hybridcollection);
            return View(homeViewModel);
        }
    }
}
