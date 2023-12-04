using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private readonly IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }
        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            var result = _colorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetByID/{id}")]
        public IActionResult GetByID(int id)
        {
            var result = _colorService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        public IActionResult Add(Color color)
        {
            var result = _colorService.Add(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete]
        public IActionResult Delete(Color color)
        {
            var result = _colorService.Delete(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut]
        public IActionResult Update(Color color)
        {
            var result = _colorService.Update(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
