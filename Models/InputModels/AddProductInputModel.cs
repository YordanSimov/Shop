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

        public string SubCategoryName { get; set; }

        public List<Characteristics> Characteristics { get; set; }
    }
}
