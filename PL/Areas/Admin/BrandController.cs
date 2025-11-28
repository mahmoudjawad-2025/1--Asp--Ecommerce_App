using B_L_L.Services.Classes;
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
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _service;

        public BrandsController(IBrandService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var category = _service.GetById(id);
            if (category is null) return NotFound();
            return Ok(category);
        }

        //[HttpPost("Create")]
        //public IActionResult Create([FromBody] BrandRequest request)
        //{
        //    var id = _service.Create(request);
        //    return CreatedAtAction(nameof(Get), new { id }, new { message = "Brand created" });
        //}
        [HttpPost("")]
        public async Task<IActionResult> Create([FromForm] BrandRequest request)
        {
            var result = await _service.CreateFile(request);
            return Ok(result);
        }



        [HttpPatch("Update/{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] BrandRequest request)
        {
            var updated = _service.Update(id, request);
            return updated > 0 ? Ok() : NotFound();
        }

        [HttpPatch("ToggleStatus/{id}")]
        public IActionResult ToggleStatus([FromRoute] int id)
        {
            var updated = _service.ToggleStatus(id);
            return updated ? Ok(new { message = "Status toggled" }) : NotFound(new { message = "Brand not found" });
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _service.Delete(id);
            return deleted > 0 ? Ok() : NotFound();
        }
    }
}