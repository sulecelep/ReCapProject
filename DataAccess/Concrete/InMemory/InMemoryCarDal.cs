using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=450000,ModelYear=2013,Description="Dizel yakıt kullanan ticari araç" },
                new Car{Id=2,BrandId=2,ColorId=1,DailyPrice=950000,ModelYear=2016,Description="Dizel yakıt kullanan ticari araç" },
                new Car{Id=3,BrandId=3,ColorId=1,DailyPrice=250000,ModelYear=2009,Description="Dizel yakıt kullanan ticari araç" },
                new Car{Id=4,BrandId=3,ColorId=1,DailyPrice=150000,ModelYear=2004,Description="Dizel yakıt kullanan ticari araç" },
                new Car{Id=5,BrandId=1,ColorId=1,DailyPrice=350000,ModelYear=2012,Description="Dizel yakıt kullanan ticari araç" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car value = _cars.Where(x => x.Id == car.Id).FirstOrDefault();
            _cars.Remove(value);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car value = _cars.Where(x => x.Id == car.Id).FirstOrDefault();
            value.DailyPrice = car.DailyPrice;
            value.BrandId = car.BrandId;
            value.ModelYear = car.ModelYear;
            value.Description = car.Description;
            value.ColorId = car.ColorId;
        }
    }
}
