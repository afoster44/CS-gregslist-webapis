using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using gregslist.Models;

namespace gregslist.Repositories
{
    public class CarsRepository
    {
        public readonly IDbConnection _db;

        public CarsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal IEnumerable<Car> Get()
        {
            string sql = "SELECT * FROM cars;";
            return _db.Query<Car>(sql);
        }

        internal Car Create(Car newCar)
        {
            string sql = @"
            INSERT INTO cars
            (make, model, price, year)
            VALUES
            (@Make, @Model, @Price, @Year);
            SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, newCar);
            newCar.Id = id;
            return newCar;
        }

        internal Car Get(int id)
        {
            string sql = "SELECT * FROM cars WHERE id = @id;";
            return _db.QueryFirstOrDefault<Car>(sql, new { id });
        }

        internal Car Edit(Car original)
        {
            string sql = @"
            UPDATE cars
            SET
            make = @Make,
            model = @Model,
            price = @Price,
            year = @Year
            WHERE id = @Id;
            SELECT * FROM cars WHERE id = @Id;";
            return _db.QueryFirstOrDefault<Car>(sql, original);
        }
    }
}