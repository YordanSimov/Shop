namespace Shop.Data.Models
{
    public class Image
    {
        public Image()
        {
             Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        public string RemoteImageUrl { get; set; }

        public Product Product { get; set; }

        public string ProductId { get; set; }
    }
}
