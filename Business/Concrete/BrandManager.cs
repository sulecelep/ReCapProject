using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand entity)
        {
            _brandDal.Add(entity);
        }

        public void Delete(Brand entity)
        {
            _brandDal.Delete(entity);
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return _brandDal.GetAll(filter);
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(x=>x.Id == id);    
        }

        public void Update(Brand entity)
        {
            _brandDal.Update(entity);
        }
    }
}
