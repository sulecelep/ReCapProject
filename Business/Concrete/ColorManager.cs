using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color entity)
        {
            _colorDal.Add(entity);
            return new SuccessResult(ColorMessage.ColorAdded);
        }

        public IResult Delete(Color entity)
        {
            _colorDal.Delete(entity);
            return new SuccessResult(ColorMessage.ColorDeleted);

        }

        public IDataResult< List<Color>> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return new SuccessDataResult<List<Color>>( _colorDal.GetAll(filter), ColorMessage.ColorsListed);

        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(x => x.Id == id), ColorMessage.ColorGetting);

        }

        public IResult Update(Color entity)
        {
            _colorDal.Update(entity);
            return new SuccessResult(ColorMessage.ColorUpdated);

        }
    }
}
