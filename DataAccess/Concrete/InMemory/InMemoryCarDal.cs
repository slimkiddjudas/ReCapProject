using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    Id = 1,
                    BrandId = 1,
                    ColorId = 1,
                    ModelYear = new DateTime(2010),
                    DailyPrice = 1500,
                    Description = "Eski Model Siyah Mercedes"
                },
                new Car
                {
                    Id = 2,
                    BrandId = 1,
                    ColorId = 3,
                    ModelYear = new DateTime(2017),
                    DailyPrice = 3500,
                    Description = "Yeni Model Kırmızı Mercedes"
                },
                new Car
                {
                    Id = 3,
                    BrandId = 2,
                    ColorId = 2,
                    ModelYear = new DateTime(2012),
                    DailyPrice = 2750,
                    Description = "Yeni Model Beyaz Audi"
                },
                new Car
                {
                    Id = 4,
                    BrandId = 3,
                    ColorId = 2,
                    ModelYear = new DateTime(2008),
                    DailyPrice = 1100,
                    Description = "Eski Model Beyaz Toyota"
                },
                new Car
                {
                    Id = 5,
                    BrandId = 2,
                    ColorId = 3,
                    ModelYear = new DateTime(2005),
                    DailyPrice = 2000,
                    Description = "Eski Model Kırmızı Audi"
                }
            };
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car entity)
        {
            Car carToDelete = _cars.FirstOrDefault(c => c.Id == entity.Id);
            _cars.Remove(carToDelete);
        }
    }
}
