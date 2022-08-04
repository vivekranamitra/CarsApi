using CarsApi.Data.Contexts;
using CarsApi.Data.Models;
using CarsApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApi.Domain.Repositories
{
    public class CarRepository : ICarRepository
    {
        private CarContext _carContext;

        public CarRepository(CarContext carContext)
        {
            _carContext = carContext;
        }
        public bool Add(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException("car");
            }
            if (car.Make == null || string.IsNullOrEmpty(car.Make))
            {
                throw new ArgumentNullException("car.Make is required");
            }
            if (car.Model == null || string.IsNullOrEmpty(car.Model))
            {
                throw new ArgumentNullException("car.Model is required");
            }
            _carContext.Cars.Add(new CarModel
            {
                Make = car.Make,
                Model = car.Model
            });
            return _carContext.SaveChanges() > 0 ? true : false;
        }


        /// <summary>
        /// Validates a user's username and password against the repostory
        /// If a match is found, returns a User object with just the username
        /// Otherwise return an empty user object
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User? Login(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }
            if (user.UserName == null || string.IsNullOrEmpty(user.UserName))
            {
                throw new ArgumentNullException("user.username is required");
            }
            if (user.Password == null || string.IsNullOrEmpty(user.Password))
            {
                throw new ArgumentNullException("user.password is required");
            }

            var userModel = _carContext.Users.Where(u => u.UserName.ToLower().Equals(user.UserName.ToLower()) && u.Password.Equals(user.Password)).FirstOrDefault();
            return userModel == null ? null : new User { UserName = userModel.UserName };
        }
        
        /// <summary>
        /// Returns a list of Car objects that match the search criteria
        /// If the searchWith parameter is empty, the entire list of Cars is returned.
        /// </summary>
        /// <param name="searchWith"></param>
        /// <returns></returns>
        public IEnumerable<Car> Search(string searchWith)
        {
            List<Car> searchResults = new List<Car>();
            if (string.IsNullOrEmpty(searchWith))
            {
                _carContext.Cars.ToList().ForEach(
                    c => searchResults.Add(new Car
                    {
                        Make = c.Make,
                        Model = c.Model
                    }));    
            }
            else
            {
                //use lower case on all comparisions
                var searchWithLC = searchWith.ToLower();
                var result = _carContext.Cars.Where(c => c.Make.ToLower().Equals(searchWithLC) || c.Model.ToLower().Equals(searchWithLC)).ToList();
                //todo: use AutoMapper
                result.ForEach(c => searchResults.Add(new Car
                {
                    Make = c.Make,
                    Model = c.Model
                }));
            }
            
            return searchResults;
        }
    }
}
