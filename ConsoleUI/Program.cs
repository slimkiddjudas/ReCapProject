using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

ColorManager colorManager = new ColorManager(new EfColorDal());

BrandManager brandManager = new BrandManager(new EfBrandDal());

UserManager userManager = new UserManager(new EfUserDal());

CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

RentalManager rentalManager = new RentalManager(new EfRentalDal());

foreach (var rentalDetail in rentalManager.GetRentalDetails().Data)
{
    Console.WriteLine($"{rentalDetail.CustomerFirstName} {rentalDetail.CustomerLastName} {rentalDetail.CarBrandName} {rentalDetail.CarColorName} {rentalDetail.RentDate}");
}

foreach (var customerDetails in customerManager.GetCustomerDetails().Data)
{
    Console.WriteLine($"{customerDetails.CustomerId} {customerDetails.CustomerFirstName} {customerDetails.CustomerLastName} {customerDetails.CustomerEmail} {customerDetails.CompanyName}");
}
