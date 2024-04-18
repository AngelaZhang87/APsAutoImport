using APsAutoImport.Models;
using APsAutoImport.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace APsAutoImport.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;//declare instance
        private readonly ICatergoryRepository _catergoryRepository;//instance

        public CarController(ICarRepository carRepository, ICatergoryRepository catergoryRepository)//Generate constructor injection
        {
            _carRepository = carRepository;
            _catergoryRepository = catergoryRepository;
        }

        public IActionResult List() //action method
        {
            //return View(_carRepository.AllCars);
            string pageDescription = "AP AUTO COMPANY";
            //after generated viewmodel
            CarListViewModel carListViewModel = new CarListViewModel(_carRepository.AllCars, pageDescription);
            return View(carListViewModel);


        }
        public IActionResult Details(int id) 
        {
        var car =_carRepository.GetCarById(id);
            if(car ==null)
            {
                return NotFound();
            }
            return View(car);
        }
    }
}
