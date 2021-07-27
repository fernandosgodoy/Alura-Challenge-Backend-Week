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
    public class VideosController 
        : ControllerBase
    {
        private readonly VideoService _videoService;

        public VideosController(VideoService videoService)
        {
            this._videoService = videoService;
        }

        [HttpGet()]
        public IEnumerable<Video> GetAll()
        {
            return _videoService.ListAll();
        }

        [Route("{id}")]
        [HttpGet()]
        public Video Get([FromRoute]int id)
        {
            return _videoService.FindById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Video video)
        {
            var inserted = _videoService.Insert(video);
            if (inserted)
                return Ok();
            else
                return StatusCode(500);
        }

        [Route("{id}")]
        [HttpPut]
        public IActionResult Put([FromRoute]int id, [FromBody] Video video)
        {
            var updated = _videoService.Update(id,  video);
            if (updated)
                return Ok();
            else
                return StatusCode(500);
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete([FromRoute] int id)
        {
            var deleted = _videoService.Delete(id);
            if (deleted)
                return Ok();
            else
                return StatusCode(500);
        }
    }
}
