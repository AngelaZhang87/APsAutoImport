using System.Collections.Specialized;
using System.ComponentModel;

namespace APsAutoImport.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }
        public string? Description { get; set; }
        public bool InTransit { get; set; }
        public bool TestDrive { get; set; }
        public string? ImageUrl {  get; set; }
        public bool HybridCollection { get; set; }

        public bool ArrivingSoon {  get; set; }
        public Catergory Catergory { get; set; } = default!;



    }
}
