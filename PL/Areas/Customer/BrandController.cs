using B_L_L.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace P_L.Areas.Customer
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Customer")]
    [Authorize(Roles = "customer")]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("")]
        public IActionResult GetAll() => Ok(_brandService.GetAll(true));

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var category = _brandService.GetById(id);
            if (category is null) return NotFound();
            return Ok(category);
        }
    }
}