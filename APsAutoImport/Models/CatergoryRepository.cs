namespace APsAutoImport.Models
{
    public class CatergoryRepository : ICatergoryRepository
    {
        private readonly APsAutoImportDbContext _aPsAutoImportDbContext;


        public CatergoryRepository(APsAutoImportDbContext aPsAutoImportDbContext)
        {
            _aPsAutoImportDbContext = aPsAutoImportDbContext;
        }

        public IEnumerable<Catergory> AllCatergories => _aPsAutoImportDbContext.Catergories.OrderBy(p => p.CatergoryName);//refer back to delership.cs
    }
}
