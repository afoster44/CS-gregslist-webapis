using System;
using System.Collections.Generic;
using gregslist.Models;
using gregslist.Repositories;

namespace gregslist.Services
{
    public class CarsService
    {
        public readonly CarsRepository _repo;

        public CarsService(CarsRepository repo)
        {
            _repo = repo;
        }

        internal IEnumerable<Car> Get()
        {
            return _repo.Get();
        }

        internal Car Create(Car newCar)
        {
            return _repo.Create(newCar);
        }

        internal Car Get(int id)
        {
            Car car = _repo.Get(id);
            if (car == null)
            {
                throw new Exception("invalid id");
            }
            return car;
        }

        internal Car Edit(int id, Car car)
        {
            Car original = Get(car.Id);

            original.Make = car.Make != null ? car.Make : original.Make;
            original.Model = car.Model != null ? car.Model : original.Model;
            original.Year = car.Year > 0 ? car.Year : original.Year;
            original.Price = car.Price > 0 ? car.Price : original.Price;

            return _repo.Edit(original);
        }
    }
}