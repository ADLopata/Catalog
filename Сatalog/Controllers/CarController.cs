using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Сatalog.Models;
using Сatalog.Models.DAL;

namespace Сatalog.Controllers
{ 
    public class CarController : Controller
    {
        private ShopContext db = new ShopContext();

        //
        // GET: /Car/

        public ViewResult Index()
        {
            using (var d = new ShopContext())
            return View(d.Car.ToList());
        }

        //
        // GET: /Car/Details/5

        public ViewResult Details(int id)
        {
            Car car = db.Car.Find(id);
            return View(car);
        }

        //
        // GET: /Car/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Car/Create

        [HttpPost]
        public ActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                db.Car.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(car);
        }
        
        //
        // GET: /Car/Edit/5
 
        public ActionResult Edit(int id)
        {
            Car car = db.Car.Find(id);
            return View(car);
        }

        //
        // POST: /Car/Edit/5

        [HttpPost]
        public ActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car);
        }

        //
        // GET: /Car/Delete/5
 
        public ActionResult Delete(int id)
        {
            Car car = db.Car.Find(id);
            return View(car);
        }

        //
        // POST: /Car/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Car car = db.Car.Find(id);
            db.Car.Remove(car);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}