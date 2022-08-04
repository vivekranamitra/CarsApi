using CarsApi.Domain.Models;
using CarsApi.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CarsApi.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private ICarRepository _carRepository;
        public CarsController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public IEnumerable<Car> GetAll()
        {
            return _carRepository.Search(String.Empty);
        }

        [HttpGet]
        [Route("{searchWith}")]
        public IEnumerable<Car> Search([FromRoute]string searchWith)
        {
            return _carRepository.Search(searchWith);
        }

        [HttpPost]
        public bool Add(Car car)
        {
            return _carRepository.Add(car);
        }
    }
}
