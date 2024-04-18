using APsAutoImport.Models;
namespace APsAutoImport.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> HybridCollection { get; }
        public HomeViewModel(IEnumerable<Car> hybridCollection)
        {
            HybridCollection = hybridCollection;
        }
    }
}
