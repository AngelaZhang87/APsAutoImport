using APsAutoImport.Models;

namespace APsAutoImport.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car>? Cars { get; }
        public string? CurrentCategory { get; }

        public CarListViewModel(IEnumerable<Car> cars, string? currentCategory)//constructor that taking 2 paras
        {
            Cars = cars;
            CurrentCategory = currentCategory;
        }
    }
}
//these classes are not entities,so not in the datebase
//they are acting like a utility class that is used to transfer data between the controller and the view.
