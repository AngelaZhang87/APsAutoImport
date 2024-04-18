
using Microsoft.EntityFrameworkCore;

namespace APsAutoImport.Models
{
    public class CarRepository : ICarRepository
    {
        private readonly APsAutoImportDbContext _aPsAutoImportDbContext;

        public CarRepository(APsAutoImportDbContext aPsAutoImportDbContext)
        {
            _aPsAutoImportDbContext = aPsAutoImportDbContext;
        }

        public IEnumerable<Car> AllCars
        {
            get
            {
                return _aPsAutoImportDbContext.Cars.Include(c => c.Catergory);
            }
          
        }

        public IEnumerable<Car> HybridCollection
        {
            get
            {
                return _aPsAutoImportDbContext.Cars.Include(c => c.Catergory).Where(p => p.HybridCollection);
            }
        }
        
        public Car? GetCarById(int carId)
        {
            return _aPsAutoImportDbContext.Cars.Include(c => c.Catergory).FirstOrDefault(p => p.CarId==carId);
        }
    }
}
