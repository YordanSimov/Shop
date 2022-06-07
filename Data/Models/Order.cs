namespace Shop.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class Order
    {
        public Order()
        {
                Id = Guid.NewGuid().ToString();
                Products = new HashSet<Product>(); 
        }

           [Required]   
            public string  Id { get; set; }

            public DateTime CreatedOn { get; set; }

            public string Status { get; set; }

             [Required]
            public double OrderPrice { get; set; }

            [Required]
            public double DeliveryPrice { get; set; }

            public DateTime? DeliveredOn { get; set; }

            [Required]
            [MaxLength(10)]
            public string Phone { get; set; }

            [Required]
            [MaxLength(40)]
            public string Email { get; set; }

            [Required]
            public string DeliveryType { get; set; }

            public City City { get; set; }

            public int CityId { get; set; }

            public Address Address { get; set; }

          public ICollection<Product> Products { get; set; }
    }
}
