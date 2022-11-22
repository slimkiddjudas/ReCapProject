using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalProjectContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (CarRentalProjectContext context = new CarRentalProjectContext())
            {
                var result = from car in context.Cars
                    join color in context.Colors on car.ColorId equals color.ColorId
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    select new CarDetailsDto
                    {
                        Id = car.Id,
                        BrandName = brand.BrandName,
                        ColorName = color.ColorName,
                        DailyPrice = car.DailyPrice,
                    };
                return result.ToList();
            }
        }
    }
}
