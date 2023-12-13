using AztuKafedra.DAL;
using AztuKafedra.ViewModel;
using Microsoft.EntityFrameworkCore;
using AztuKafedra.ViewModel;
namespace AztuKafedra.Services
{
    

    public class HomeService
    {
       private readonly AppDbContext _db;

        public HomeService(AppDbContext db)
        {
            _db = db;
        }
        public HomeVM GetHomeData()
        {
            var bigParentsCategories = _db.BigParentsCategory
                .Include(bp => bp.ParentCategories)
                    .ThenInclude(pc => pc.ChildCategories)
                .ToList();

            var homeVm = new HomeVM
            {
                BigParentsCategories = bigParentsCategories
                // Diğer HomeVm alanlarını da doldurabilirsiniz
            };

            return homeVm;
        }
    }
}
