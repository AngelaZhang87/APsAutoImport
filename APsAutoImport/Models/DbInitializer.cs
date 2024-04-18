using APsAutoImport.Models;

namespace APsAutoImport.Models
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            APsAutoImportDbContext context =
                applicationBuilder.ApplicationServices.CreateScope().
                ServiceProvider.GetRequiredService<APsAutoImportDbContext>();

            if (!context.Catergories.Any())
            {
                context.Catergories.AddRange(Catergories.Select(c => c.Value));
            }
            if (!context.Cars.Any())
            {
                context.AddRange
                    (
                        new Car { Make = "Toyota", Model = "Prius", Year = 2017, Price = 18999, HybridCollection = true, ArrivingSoon=true, ImageUrl = "/lib/APImgaes/PopularRange/2017Prius.png", Description = "dludiucbaljdhwgclja", InTransit = true, TestDrive = true, Catergory = Catergories["Popular Range"] },
                        new Car { Make = "Toyota", Model = "Aqua", Year = 2012, Price = 8800, HybridCollection = true, ArrivingSoon = true, ImageUrl = "/lib/APImgaes/PopularRange/2012Aqua.png", Description = "dludiucbaljdhwgclja", InTransit = true, TestDrive = true , Catergory = Catergories["Popular Range"] },
                        new Car { Make = "Toyota", Model = "Prius", Year = 2015, Price = 13999, HybridCollection = true, ArrivingSoon = true, ImageUrl = "/lib/APImgaes/PopularRange/2015Prius.png", Description = "dludiucbaljdhwgclja", InTransit = false, TestDrive = false, Catergory = Catergories["Popular Range"] },
                        new Car { Make = "BMW", Model = "I8", Year = 2020, Price = 120000, HybridCollection= true, ArrivingSoon = true, ImageUrl = "/lib/APImgaes/LuxuryRange/BMWi8.png", Description = "Butterfly door", InTransit = true, TestDrive = true, Catergory = Catergories["Luxury Range"] },
                        new Car { Make = "Porsche", Model = "Caynne", Year = 2016, Price = 58800, HybridCollection = false, ArrivingSoon = true, ImageUrl = "/lib/APImgaes/LuxuryRange/Caynne.png", Description = "dludiucbaljdhwgclja", InTransit = true, TestDrive = true , Catergory = Catergories["Luxury Range"] },
                        new Car { Make = "Honda", Model = "FK8", Year = 2023, Price = 62000, HybridCollection = false, ArrivingSoon = true, ImageUrl = "/lib/APImgaes/LuxuryRange/HondaFk8.png", Description = "dludiucbaljdhwgclja", InTransit = false, TestDrive = false, Catergory = Catergories["Luxury Range"] },
                        new Car { Make = "Honda", Model = "s2000", Year = 2002, Price = 68999, HybridCollection = false, ArrivingSoon = true,ImageUrl = "/lib/APImgaes/LuxuryRange/HondaS2000.png", Description = "dludiucbaljdhwgclja", InTransit = true, TestDrive = true, Catergory = Catergories["Luxury Range"] },
                        new Car { Make = "Honda", Model = "Vezel", Year = 2016, Price = 26800, HybridCollection = true, ArrivingSoon = true,ImageUrl = "/lib/APImgaes/PopularRange/HondaVezel.png", Description = "dludiucbaljdhwgclja", InTransit = true, TestDrive = true, Catergory = Catergories["Popular Range"] }
                     );
            }
            context.SaveChanges();
        }
        private static Dictionary<string, Catergory>? catergories;
        
        public static Dictionary<string, Catergory> Catergories
        {
            get
            {
                if ( catergories == null ) 
                {
                    var genresList = new Catergory[]
                    { 
                        
                           new Catergory { CatergoryName= "Luxury Range" },
                           new Catergory { CatergoryName= "Popular Range" },

                    };

                    catergories = new Dictionary<string, Catergory>();
                    foreach(Catergory genre in genresList)
                    {
                        catergories.Add(genre.CatergoryName, genre);
                    }
                }
                return catergories;
            }
        }
    }
}
