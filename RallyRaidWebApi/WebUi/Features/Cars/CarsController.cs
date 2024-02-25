using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace WebUi.Features.Cars
{
    [Route("api/cars")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        //static List<Car> cars = new List<Car>()
        //{
        //    new Car(){Id= 1 , TeamName="Team A", Speed = 100, MelfunctionChance = 0.2},
        //    new Car(){Id= 2 , TeamName="Team B", Speed = 90, MelfunctionChance = 0.1},
        //    new Car(){Id= 3 , TeamName="Team C", Speed = 80, MelfunctionChance = 0.15},
        //};

        public ActionResult<List<Car>> GetCars()
        {
            List<Car> cars = new List<Car>()
            {
                new Car(){Id= 1 , TeamName="Team A", Speed = 100, MelfunctionChance = 0.2},
                new Car(){Id= 2 , TeamName="Team B", Speed = 90, MelfunctionChance = 0.1},
                new Car(){Id= 3 , TeamName="Team C", Speed = 80, MelfunctionChance = 0.15},
            };
            return Ok(cars);
        }
    }
}
