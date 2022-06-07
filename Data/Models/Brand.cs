namespace Shop.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>(); 
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
