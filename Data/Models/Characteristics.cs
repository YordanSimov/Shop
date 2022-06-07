namespace Shop.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Characteristics
    {
        [Key]
        public int Id { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public Product Product { get; set; }

        public string ProductId { get; set; }
    }
}
