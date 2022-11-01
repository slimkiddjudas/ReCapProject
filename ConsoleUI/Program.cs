using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

ICarService carManager = new CarManager(new EfCarDal());

carManager.Add(new Car
{
    BrandId = 1,
    ColorId = 1,
    ModelYear = new DateTime(2010, 1, 1),
    DailyPrice = -27,
    Description = ""
});

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}

IBrandService brandManager = new BrandManager(new EfBrandDal());

foreach (var brand in brandManager.GetAll())
{
    Console.WriteLine(brand.BrandName);
}

IColorService colorManager = new ColorManager(new EfColorDal());

foreach (var color in colorManager.GetAll())
{
    Console.WriteLine(color.ColorName);
}
