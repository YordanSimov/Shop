namespace Shop.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class City
    {
        public City()
        {
                Addresses = new HashSet<Address>();   
                Orders = new HashSet<Order>();   
        }
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Address> Addresses { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
