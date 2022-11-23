using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

ColorManager colorManager = new ColorManager(new EfColorDal());

BrandManager brandManager = new BrandManager(new EfBrandDal());

foreach (var carDetailsDto in carManager.GetCarDetails())
{
    Console.WriteLine($"{carDetailsDto.Id} {carDetailsDto.BrandName} {carDetailsDto.ColorName} {carDetailsDto.DailyPrice}");
}

