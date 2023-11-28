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
    public interface IUserService
    {
        IDataResult<List<User>> GetAll(Expression<Func<User, bool>> filter = null);
        IDataResult<User> GetById(int id);
        IResult Add(User entity);
        IResult Delete(User entity);
        IResult Update(User entity);
    }
}
