namespace Shop.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid().ToString();
            Characteristics = new HashSet<Characteristic>();
            Orders = new HashSet<Order>();
            Images = new HashSet<Image>();
        }

        [Required]
        public string Id { get; set; }

        [MaxLength(70)]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public int? CountOfOrders { get; set; }

        public bool IsAvailable { get; set; }

        [Required]
        public double Price { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public Brand Brand { get; set; }

        public int BrandId { get; set; }

        public SubCategory SubCategory { get; set; }

        public ICollection<Characteristic> Characteristics { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Image> Images { get; set; }
    }
}
