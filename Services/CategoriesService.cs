namespace Shop.Services
{
    using Shop.Data;
    using Shop.Data.Models;
    using System.Collections.Generic;

    public class CategoriesService : ICategoriesService
    {
        private readonly ApplicationDbContext dbContext;

        public CategoriesService(ApplicationDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return dbContext.Categories.ToList();
        }
    }
}
