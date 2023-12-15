using System.Data;

namespace AztuKafedra.Models
{
    public class ChildCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public ParentCategory ParentCategory { get; set; }

        public List<Pasition> Pasitions { get; set; }
        public List<User> Users { get; set; }

    }
}
