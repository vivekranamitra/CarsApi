using CarsApi.Domain.Models;
using System.Collections.Generic;

namespace CarsApi.Domain.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<Car> Search(string searchWith);
        bool Add(Car car);

        User? Login(User user);
    }
}
