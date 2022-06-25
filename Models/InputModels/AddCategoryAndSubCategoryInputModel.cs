namespace Shop.Models.InputModels
{
    using Shop.Data.Models;

    public class AddCategoryAndSubCategoryInputModel
    {
        public string CategoryNameToAdd { get; set; }

        public ICollection<Category> Categories { get; set; }

        public ICollection<string> SubCategory { get; set; }
    }
}
