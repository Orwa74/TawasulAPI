using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplecationDbContext context;

        public ProductController(ApplecationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetProduct()
        {
            var products = context.Products.ToList();
            return Ok(products);
        }

        [HttpGet("Id")]
        public ActionResult<Product> GetProductById(int id)
        {
            return context.Products.Find(id);
        }
    }
}
