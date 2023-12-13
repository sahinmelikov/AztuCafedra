using AztuKafedra.Models;

namespace AztuKafedra.ViewModel
{
    public class HomeVM
    {
        public List<ParentCategory> ParentCategories { get; set; }
        public List<ChildCategory> ChildCategories { get;  set; }
        public List<BigParentsCategory> BigParentsCategories { get; set; }
    }
}
