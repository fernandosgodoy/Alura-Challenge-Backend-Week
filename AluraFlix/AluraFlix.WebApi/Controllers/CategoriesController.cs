using AluraFlix.Domain;
using AluraFlix.Services.Applications;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraFlix.WebApi.Controllers
{

    [Route("api/{controller}")]
    [ApiController]
    public class CategoriesController 
        : ControllerBase
    {

        private readonly CategoryService _categoryService;

        public CategoriesController(CategoryService categoryService)
        {
            this._categoryService = categoryService;
        }

        [HttpGet()]
        public IEnumerable<Category> GetAll()
        {
            return _categoryService.ListAll();
        }

        [Route("{id}")]
        [HttpGet()]
        public Category Get([FromRoute] int id)
        {
            return _categoryService.FindById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Category category)
        {
            if (ModelState.IsValid)
            {
                var inserted = _categoryService.Insert(category);
                if (inserted)
                    return Ok();
                else
                    return StatusCode(500);
            }
            else
                return BadRequest();
        }

        [Route("{id}")]
        [HttpPut]
        public IActionResult Put([FromRoute] int id, [FromBody] Category category)
        {
            if (ModelState.IsValid)
            {
                var updated = _categoryService.Update(id, category);
                if (updated)
                    return Ok();
                else
                    return StatusCode(500);
            }
            else
                return BadRequest();
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete([FromRoute] int id)
        {
            if (ModelState.IsValid)
            {
                var deleted = _categoryService.Delete(id);
                if (deleted)
                    return Ok();
                else
                    return StatusCode(500);
            }
            else
                return BadRequest();
        }

    }
}
