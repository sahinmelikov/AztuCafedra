namespace AztuKafedra.Models
{
    public class BigParentsCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ParentCategory>ParentCategories { get; set; }

    }
}
