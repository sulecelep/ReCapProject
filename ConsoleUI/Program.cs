using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //var values= carManager.GetAll();
            //foreach (var value in values)
            //{
            //    Console.WriteLine(value.DailyPrice);
            //}
            //Car car = new Car { Id=6,BrandId=2,DailyPrice=122340,ColorId=4,Description="Deneme",ModelYear=2019};
            //carManager.Add(car);
            //var values = carManager.GetAll();
            var values = carManager.GetCarDetails();
            foreach (var value in values)
            {
                Console.WriteLine(value.CarName + " "+ value.BrandName +" "+value.ColorName +" " + value.DailyPrice );
            }
        }
    }
}