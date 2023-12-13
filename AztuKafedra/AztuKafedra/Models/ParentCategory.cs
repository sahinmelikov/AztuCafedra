namespace AztuKafedra.Models
{
    public class ParentCategory
    {
        public int Id { get; set;} 
        public string Name { get; set; }
        public List<ChildCategory> ChildCategories { get; set; }
        public BigParentsCategory BigParentsCategory { get; set; }
        public int BigParentsCategoryId { get; set; }

    }
}
