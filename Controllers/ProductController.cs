namespace Shop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Shop.Data;
    using Shop.Models.InputModels;

    public class ProductController : Controller
    {
        private ApplicationDbContext dbContext;
        public ProductController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Add()
        {
            return View("~/Views/Admin/Add.cshtml");
        }

        [HttpPost]
        public IActionResult Add(AddProductInputModel addProductInputModel)
        {
            return View();
        }
    }
}
