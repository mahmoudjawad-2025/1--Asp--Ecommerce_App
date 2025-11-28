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
    [Authorize(Roles = "admin,superAdmin")]
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
            return Ok(service.GetAll());
        }

        [HttpGet("Get/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var category = service.GetById(id);
            if (category is null) return NotFound();
            return Ok(category);
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] CategoryRequest request)
        {
            var id = service.Create(request);
            return CreatedAtAction(nameof(Get), new { id }, new { message = "Category created" });
        }

        [HttpPatch("Update/{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] CategoryRequest request)
        {
            var updated = service.Update(id, request);
            return updated > 0 ? Ok() : NotFound();
        }

        [HttpPatch("ToggleStatus/{id}")]
        public IActionResult ToggleStatus([FromRoute] int id)
        {
            var updated = service.ToggleStatus(id);
            return updated ? Ok(new { message = "Status toggled" }) : NotFound(new { message = "Category not found" });
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = service.Delete(id);
            return deleted > 0 ? Ok() : NotFound();
        }
    }
}
