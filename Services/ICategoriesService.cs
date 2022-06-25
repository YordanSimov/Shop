namespace Shop.Services
{
    using Shop.Data.Models;

    public interface ICategoriesService
    {
        IEnumerable<Category> GetAllCategories();
    }
}
