﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetByCarId(int CarId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByColorId(int colorId);
        IDataResult<List<Car>> GetByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int carId);

        IDataResult<List<CarDetailDto>> GetCarDetailsByColorAndByBrand(int colorId, int brandId);


    }
}
