using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

ColorManager colorManager = new ColorManager(new EfColorDal());

BrandManager brandManager = new BrandManager(new EfBrandDal());

foreach (var carDetailsDto in carManager.GetCarDetails().Data)
{
    Console.WriteLine($"{carDetailsDto.Id} {carDetailsDto.BrandName} {carDetailsDto.ColorName} {carDetailsDto.DailyPrice}");
}

foreach (var color in colorManager.GetAll().Data)
{
    Console.WriteLine($"{color.ColorId} {color.ColorName}");
}

foreach (var brand in brandManager.GetAll().Data)
{
    Console.WriteLine($"{brand.BrandId} {brand.BrandName}");
}