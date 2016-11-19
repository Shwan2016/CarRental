using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRental.Models;

namespace CarRental.Controllers
{
    public class CarsController : Controller
    {
        private ApplicationDbContext _context;

        public CarsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var cars = _context.Cars.Include(c => c.CarModel).ToList();
            return View(cars);
        }

        public ActionResult Details(int id)
        {
            var car = _context.Cars.Include(c => c.CarModel).SingleOrDefault(c => c.Id == id);

            if (car == null)
                return HttpNotFound();                              

            return View(car);
        }
       
        }
}