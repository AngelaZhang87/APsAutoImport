using System.ComponentModel.DataAnnotations;

namespace APsAutoImport.Models
{
    public class Catergory
    {
        [Key]
        public int CatergoryID { get; set; }
        public string? CatergoryName { get; set; }
        public string Location { get; set; } = string.Empty;
        public List<Car>?Cars { get; set; }

    }
}


