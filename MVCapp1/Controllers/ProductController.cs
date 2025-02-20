using Microsoft.AspNetCore.Mvc;
using MVCapp1.Models;

namespace MVCapp1.Controllers
{
    public class ProductController : Controller
    {
        ProductSamples productSamples = new();
        #region actios test
        //public IActionResult Index()
        //{
        //    return View();
        //}
        //public ViewResult Test()
        //{
        //    ViewResult result = new()
        //    {
        //        ViewName = "view1"
        //    };
        //    return result;

        //}
        //public JsonResult tesst()
        //{
        //    //return Json(new { Id = 1, name = "test" });
        //    JsonResult result = new(new { Id = 1, name = "test" });
        //    return result;
        //}
        //public IActionResult index(int id)
        //{
        //    if (id % 2 == 0)
        //    {
        //        return Content("ok");
        //    }
        //    else
        //    {
        //        return View("view1");
        //    }
        //} 
        #endregion
        public IActionResult GetProduct(int id)
        {
            Product ProductModel = productSamples.GetByID(id);
            //productSamples.GetAll();
            return View("Products", ProductModel);
        }
        public IActionResult GetAllProducts()
        {
            List<Product> Products = productSamples.GetAll();
            return View("GetAllProducts", Products);
        }
    }
}
