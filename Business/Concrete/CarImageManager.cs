using Business.Abstract;
using Business.Constants.Messages;
using Business.Constants.Paths;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private readonly ICarImageDal _carImageDal;
        private readonly IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, CarImage entity)
        {
            IResult result = BusinessRules.Run(CheckCarImagesCountOfCar(entity.CarId));
            if (result != null)
            {
                return result;
            }
            entity.ImagePath = _fileHelper.Upload(file, CarImagePath.ImagesPath);
            entity.Date = DateTime.Now;
            
            _carImageDal.Add(entity);
            
            return new SuccessResult(CarImageMessage.CarImageAdded);
        }

        public IResult Delete(CarImage entity)
        {
            _fileHelper.Delete(CarImagePath.ImagesPath + entity.ImagePath);
            _carImageDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll(Expression<Func<CarImage, bool>> filter = null)
        {
            var values=  _carImageDal.GetAll(filter);
            return new SuccessDataResult<List<CarImage>>(values, CarImageMessage.CarImagesListed);
        }
        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            var values = _carImageDal.GetAll(x=>x.CarId==carId).ToList();
            if(values.Count()==0)
            {
                //CarImages tablosuna CarId'si 0 olan bir CarImage ekledim, eğer arabanın fotoğrafı yoksa bu fotoğraf default olarak listelenecek
                values = _carImageDal.GetAll(x => x.CarId == 0).ToList();
            }
            return new SuccessDataResult<List<CarImage>>(values, CarImageMessage.CarImagesByCarListed);
        }

        public IDataResult<CarImage> GetByImageId(int imageId)
        {
            var value = _carImageDal.GetAll(x => x.CarImageId == imageId).FirstOrDefault();
            return new SuccessDataResult<CarImage>(value, CarImageMessage.CarImageGetting);
        }
        public IResult Update(IFormFile file, CarImage entity)
        {
            entity.ImagePath = _fileHelper.Update(file, CarImagePath.ImagesPath + entity.ImagePath, CarImagePath.ImagesPath);
            _carImageDal.Update(entity);
            return new SuccessResult();
        }

        private IResult CheckCarImagesCountOfCar(int? carId)
        {
            var result=_carImageDal.GetAll(x=>x.CarId==carId).Count();
            if(result>=5)
            {
                return new ErrorResult(CarImageMessage.CarImageCountError);
            }
            return new SuccessResult();
        }


     
    }
}
