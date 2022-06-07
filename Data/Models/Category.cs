namespace Shop.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        public Category()
        {
            SubCategories = new HashSet<SubCategory>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
