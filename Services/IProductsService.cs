namespace Shop.Services
{
    using Shop.Models.InputModels;

    public interface IProductsService
    {
        void AddProduct(AddProductInputModel input);

        IEnumerable<KeyValuePair<int, string>> GetAllSubCategoryNames();
    }
}
