using Microsoft.AspNetCore.Mvc;
using OnionApp.Application.Interfaces.Repository;

namespace OnionApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await productRepository.GetAll();
            
        }
    }
}
