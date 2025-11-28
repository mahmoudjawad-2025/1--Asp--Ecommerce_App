using B_L_L.Services.Interfaces;
using D_A_L.DTO.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace P_L.Areas.Admin
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Admin")]
    //[Authorize(Roles = "admin, superAdmin")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("")]
        public IActionResult GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 5)
        {
            var products = _productService.GetAllProducts(Request, pageNumber, pageSize, false);
            return Ok(products);
        }


        [HttpPost("")]
        public async Task<IActionResult> Create([FromForm] ProductRequest request)
        {
            var result = await _productService.CreateProduct(request);
            return Ok(result);
        }

    }
}

