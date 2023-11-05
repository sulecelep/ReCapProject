using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car entity)
        {
            if(entity.DailyPrice>0 && entity.Description.Length>2)
            {
                _carDal.Add(entity);
            }
            else
            {
                Console.WriteLine("Arabanın günlük fiyatı 0 TL'nin üzerinde ve adı minimum 2 karakter olmalıdır.");
            }
        }

        public void Delete(Car entity)
        {
            _carDal.Delete(entity);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _carDal.GetAll(filter);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(x => x.Id == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(x=>x.BrandId==id).ToList();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(x => x.ColorId == id).ToList();
        }

        public void Update(Car entity)
        {
            _carDal.Update(entity);
        }
    }
}
