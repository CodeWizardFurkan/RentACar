using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("getall")]
        public List<Brand> GetAll()
        {
            return _brandService.GetAll();
        }

        [HttpGet("getbyid")]
        public Brand GetById(int id)
        {
            return _brandService.GetById(id);
        }


        [HttpPost("add")]
        public void Add(Brand brand)
        {
            _brandService.Add(brand);
        }

        [HttpPost("delete")]
        public void Delete(Brand brand)
        {
            _brandService.Delete(brand);
        }

        [HttpPost("update")]
        public void Update(Brand brand)
        {
            _brandService.Update(brand);
        }
    }
}
