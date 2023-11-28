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
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //var values= carManager.GetAll();
            //foreach (var value in values)
            //{
            //    Console.WriteLine(value.DailyPrice);
            //}
            //Car car = new Car { Id=6,BrandId=2,DailyPrice=122340,ColorId=4,Description="Deneme",ModelYear=2019};
            //carManager.Add(car);
            //var values = carManager.GetAll();
            //var values = carManager.GetCarDetails();
            //foreach (var value in values.Data)
            //{
            //    Console.WriteLine(value.CarName + " "+ value.BrandName +" "+value.ColorName +" " + value.DailyPrice );
            //}

            //10.gün ödev
            Rental rental = new Rental { CarId = 1, CustomerId = 1, RentDate = DateTime.Parse("26.11.2023"), ReturnDate = DateTime.Parse("27.11.2023") };
            var result= rentalManager.Add(rental);
            Console.WriteLine(result.Message);

        }
    }
}