using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll(Expression<Func<Brand, bool>> filter = null);
        IDataResult<Brand> GetById(int id);
        IResult Add(Brand entity);
        IResult Delete(Brand entity);
        IResult Update(Brand entity);
    }
}
