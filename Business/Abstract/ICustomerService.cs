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
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll(Expression<Func<Customer, bool>> filter = null);
        IDataResult<Customer> GetById(int id);
        IResult Add(Customer entity);
        IResult Delete(Customer entity);
        IResult Update(Customer entity);
    }
}
