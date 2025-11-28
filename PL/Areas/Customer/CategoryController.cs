using B_L_L.Services.Interfaces;
using D_A_L.DTO.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace P_L.Areas.Controllers
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Customer")]
    [Authorize(Roles = "customer")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService service;

        public CategoryController(ICategoryService service)
        {
            this.service = service;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(service.GetAll(true));
        }

        [HttpGet("Get/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var category = service.GetById(id);
            if (category is null) return NotFound();
            return Ok(category);
        }
    }
}
