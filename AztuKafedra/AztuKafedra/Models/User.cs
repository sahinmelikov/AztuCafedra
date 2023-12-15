﻿namespace AztuKafedra.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }

       
        public ChildCategory ChildCategory { get; set; }
         public int ChildCategoryId { get; set; }
        // PasitionId için dış anahtar, CASCADE silme yolu kaldırıldı
    
    }
}
