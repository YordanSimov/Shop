namespace Shop.Services
{
    using Shop.Data;
    using Shop.Data.Models;
    using Shop.Models.InputModels;

    public class ProductsService : IProductsService
    {
        private readonly ApplicationDbContext dbContext;

        public ProductsService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddProduct(AddProductInputModel input)
        {
            var product = new Product()
            {
                Name = input.Name,
                Description = input.Description,
                IsAvailable = input.IsAvailable,
                CreatedOn = input.CreatedOn,
                Price = input.Price,
            };

            if (dbContext.Brands.FirstOrDefault(x => x.Name == input.BrandName) == null)
            {
                product.Brand = new Brand
                {
                    Name = input.BrandName 
                };
            }

            foreach (var ch in input.Characteristics)
            {
                var characteristic = new Characteristic
                {
                    Key = ch.Key,
                    Value = ch.Value,
                    Product = product
                };
                dbContext.Characteristics.Add(characteristic);
            }

            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }
    }
}
