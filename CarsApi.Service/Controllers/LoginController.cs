using CarsApi.Domain.Models;
using CarsApi.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CarsApi.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private ICarRepository _carRepository;
        public LoginController(ICarRepository carRepository)
        {
            _carRepository = carRepository; 
        }

        [HttpPost]
        public bool Login([FromBody]User user)
        {
            var userLogin = _carRepository.Login(user);
            return userLogin == null ? false : true;
        }
    }
}
