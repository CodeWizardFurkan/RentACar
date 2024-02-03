using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {

        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet("getall")]
        public List<Color> GetAll()
        {
            return _colorService.GetAll();
        }

        [HttpGet("getbyid")]
        public Color GetById(int id)
        {
            return _colorService.GetById(id);
        }

        [HttpPost("add")]
        public void Add(Color color)
        {
            _colorService.Add(color);
        }

        [HttpPost("delete")]
        public void Delete(Color color)
        {
            _colorService.Delete(color);
        }

        [HttpPost("update")]
        public void Update(Color color)
        {
            _colorService.Update(color);
        }
    }
}
