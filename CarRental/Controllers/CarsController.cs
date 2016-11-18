using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRental.Models;

namespace CarRental.Controllers
{
    public class CarsController : Controller
    {        
        public ActionResult Index()
        {
            var cars = GetCars();
            return View(cars);
        }

        public ActionResult Details(int id)
        {
            var car = GetCars().SingleOrDefault(c => c.Id == id);
            return View(car);
        }

        private IEnumerable<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car {Id = 1, Name = "Hundai"},
                new Car {Id = 2, Name = "Toyota"}
            };
        }

        }
}