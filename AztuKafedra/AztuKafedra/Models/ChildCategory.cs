namespace AztuKafedra.Models
{
    public class ChildCategory
    {
        public int Id { get;set; }
        public string Name { get;set; }
        public ParentCategory ParentCategory { get;set; }
        public int ParentId { get; set; }
    }
}
