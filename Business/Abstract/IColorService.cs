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
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll(Expression<Func<Color, bool>> filter = null);
        IDataResult<Color> GetById(int id);
        IResult Add(Color entity);
        IResult Delete(Color entity);
        IResult Update(Color entity);
    }
}
