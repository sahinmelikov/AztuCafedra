namespace AztuKafedra.Models
{
    public class Pasition
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ChildCategoryId { get; set; }
        public ChildCategory ChildCategory { get; set; }
       


    }
}
