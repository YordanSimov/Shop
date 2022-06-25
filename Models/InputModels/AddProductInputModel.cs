namespace Shop.Models.InputModels
{
    using Shop.Data.Models;

    public class AddProductInputModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsAvailable { get; set; }

        public DateTime CreatedOn { get; set; }

        public string BrandName { get; set; }

        public double Price { get; set; }

        public IEnumerable<KeyValuePair<int, string>> SubCategoryItems { get; set; }

        public int SubCategoryId { get; set; }

        public List<Characteristic> Characteristics { get; set; }
    }
}
