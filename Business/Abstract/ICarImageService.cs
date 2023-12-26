using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll(Expression<Func<CarImage, bool>> filter = null);
        IDataResult<List<CarImage>> GetByCarId(int carId);
        IDataResult<CarImage> GetByImageId(int imageId);
        IResult Add(IFormFile file, CarImage entity);
        IResult Update(IFormFile file, CarImage entity);
        IResult Delete(CarImage entity);
    }
}
