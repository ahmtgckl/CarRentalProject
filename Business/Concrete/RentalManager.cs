﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (CheckIfRentable(rental.CarId).Success == false)
            {
                return new ErrorResult();
            }

            _rentalDal.Add(rental);

            return new SuccessResult();
        }
        public IResult CheckIfRentable(int carId)
        {
            var checkedRental = _rentalDal.Get(r => r.CarId == carId && r.ReturnDate == null);

            if (checkedRental != null)
            {
                return new ErrorResult();
            }

            return new SuccessResult();
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<Rental>> GetById(int rentalId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.RentalId == rentalId));
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
/* _rentalDal.Add(rental);
            return new SuccessResult();*/