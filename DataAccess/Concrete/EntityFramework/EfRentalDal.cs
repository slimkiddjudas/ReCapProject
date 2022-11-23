using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalProjectContext>, IRentalDal
    {
        public List<RentalDetailsDto> GetRentalDetails()
        {
            using (CarRentalProjectContext context = new CarRentalProjectContext())
            {
                var result = from rental in context.Rentals
                    join car in context.Cars on rental.CarId equals car.Id
                    join customer in context.Customers on rental.CustomerId equals customer.CustomerId
                    join user in context.Users on customer.UserId equals user.UserId
                    join color in context.Colors on car.ColorId equals color.ColorId
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    select new RentalDetailsDto
                    {
                        RentalId = rental.RentalId,
                        CarBrandName = brand.BrandName,
                        CarColorName = color.ColorName,
                        CustomerFirstName = user.FirstName,
                        CustomerLastName = user.LastName,
                        RentDate = rental.RentDate,
                        ReturnDate = rental.ReturnDate
                    };
                return result.ToList();
            }
        }
    }
}
