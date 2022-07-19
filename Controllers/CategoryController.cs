namespace Shop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Shop.Data;
    using Shop.Data.Models;
    using Shop.Models.InputModels;
    using Shop.Services;

    public class CategoryController : Controller
    {
        private readonly ICategoriesService categoriesService;
        private readonly ApplicationDbContext dbContext;

        public CategoryController( ICategoriesService categoriesService, ApplicationDbContext dbContext)
        {
            this.categoriesService = categoriesService;
            this.dbContext = dbContext;
        }

        public IActionResult AddCategory()
        {
            var inputModel = new AddCategoryAndSubCategoryInputModel();
            inputModel.Categories = this.categoriesService.GetAllCategories().ToList();
            return View("~/Views/Admin/Category/Add.cshtml", inputModel);
        }

        [HttpPost]
        public IActionResult AddCategory(AddCategoryAndSubCategoryInputModel inputModel)
        {
            var subcategories = new List<SubCategory>();
            foreach (var sub in inputModel.SubCategory)
            {
                subcategories.Add(new SubCategory() { Name = sub });
            }
            if (dbContext.Categories.FirstOrDefault(x=>x.Name == inputModel.CategoryNameToAdd) == null)
            {
                dbContext.Categories.Add(new Category() { Name = inputModel.CategoryNameToAdd , SubCategories = subcategories });
            }
            dbContext.SaveChanges();
            return RedirectToAction("Index","Admin");
        }
    }
}
