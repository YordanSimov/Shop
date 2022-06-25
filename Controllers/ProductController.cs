namespace Shop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Shop.Data;
    using Shop.Models.InputModels;
    using Shop.Services;

    public class ProductController : Controller
    {
        private ApplicationDbContext dbContext;
        private readonly IProductsService productsService;

        public ProductController(ApplicationDbContext dbContext, IProductsService productsService)
        {
            this.dbContext = dbContext;
            this.productsService = productsService;
        }
        public IActionResult Add()
        {
            var inputModel = new AddProductInputModel();
            inputModel.SubCategoryItems = productsService.GetAllSubCategoryNames();
            return View("~/Views/Admin/Product/Add.cshtml",inputModel);
        }

        [HttpPost]
        public IActionResult Add(AddProductInputModel addProductInputModel)
        {
            productsService.AddProduct(addProductInputModel);
            return RedirectToAction("Index", "Home");
        }
    }
}
