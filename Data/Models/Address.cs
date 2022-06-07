namespace Shop.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Address
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public City City { get; set; }

        public int CityId { get; set; }

        public Order Order { get; set; }

        [ForeignKey("Order")]
        public string OrderId { get; set; }

    }
}
