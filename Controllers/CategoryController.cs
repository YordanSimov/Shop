namespace Shop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Shop.Models.InputModels;
    using Shop.Services;

    public class CategoryController : Controller
    {
        private readonly ICategoriesService categoriesService;

        public CategoryController( ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public IActionResult AddCategory()
        {
            var inputModel = new AddCategoryAndSubCategoryInputModel();
            inputModel.Categories = this.categoriesService.GetAllCategories().ToList();
            return View("~/Views/Admin/Category/Add.cshtml", inputModel);
        }
    }
}
