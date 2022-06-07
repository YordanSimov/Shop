namespace Shop.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class SubCategory
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public Product Product { get; set; }

        [ForeignKey("Product")]
        public string ProductId { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }
    }
}
