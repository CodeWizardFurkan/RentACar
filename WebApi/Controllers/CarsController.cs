using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carSerivce;

        public CarsController(ICarService carSerivce)
        {
            _carSerivce = carSerivce;
        }

        [HttpGet("getall")]
        public List<Car> GetAll()
        {
            return _carSerivce.GetAll();
        }

        [HttpGet("getbyid")]
        public Car GetById(int id)
        {
            return _carSerivce.GetById(id);
        }

        [HttpPost("add")]
        public void Add(Car car)
        {
            _carSerivce.Add(car);
        }

        [HttpPost("delete")]
        public void Delete(Car car)
        {
            _carSerivce.Delete(car);
        }

        [HttpPost("update")]
        public void Update(Car car)
        {
            _carSerivce.Update(car);
        }
    }
}
