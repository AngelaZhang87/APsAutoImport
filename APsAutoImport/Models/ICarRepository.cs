namespace APsAutoImport.Models
{
    public interface ICarRepository

    {
        IEnumerable<Car> AllCars { get; }
        IEnumerable<Car> HybridCollection { get; }
        Car? GetCarById(int CarId);

    }
}
