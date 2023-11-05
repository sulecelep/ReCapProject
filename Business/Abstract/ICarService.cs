﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll(Expression<Func<Car, bool>> filter = null);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        List<CarDetailDto> GetCarDetails();
        Car GetById(int id);
        void Add(Car entity);
        void Delete(Car entity);
        void Update(Car entity);
    }
}