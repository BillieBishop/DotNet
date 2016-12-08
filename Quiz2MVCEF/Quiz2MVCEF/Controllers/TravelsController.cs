using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Quiz2MVCEF.Models;

namespace Quiz2MVCEF.Controllers
{
    public class TravelsController : Controller
    {
        private TravelEntities db = new TravelEntities();

        // GET: Travels
        public ActionResult Index(string ComfortString, string fromAirportFilter, string toAirportFilter, string comfortclassFilter)
        {
            //
            var travels = from m in db.Travel
                          select m;

            //Taking care of that Enum thing
            var comfortList = Enum.GetNames(typeof(ComfortClass)).ToList();            
            ViewBag.ComfortString = new SelectList(comfortList);

            if (!string.IsNullOrEmpty(ComfortString))
            {
               // ComfortClass comfortCasted;
                //Enum.TryParse(ComfortString, out comfortCasted);
                travels = travels.Where(x => x.ComfortClass == ComfortString);
            }



            //Adding a filter on FromAirport
            var FromAirportList = new List<string>();
            var FromAirportQuery = from d in db.Travel
                                   orderby d.FromAirport
                                   select d.FromAirport;
            FromAirportList.AddRange(FromAirportQuery.Distinct());
            ViewBag.fromAirportFilter = new SelectList(FromAirportList);

            //Adding a filter on ToAirport
            var ToAirportList = new List<string>();
            var ToAirportQuery = from a in db.Travel
                                 orderby a.ToAirport
                                 select a.ToAirport;
            ToAirportList.AddRange(ToAirportQuery.Distinct());
            ViewBag.toAirportFilter = new SelectList(ToAirportList);

            //Adding a filter on ComfortClass
            var ComfortClassList = new List<string>();
            var ComfortClassQuery = from c in db.Travel
                                    orderby c.ComfortClass
                                    select c.ComfortClass;
            ComfortClassList.AddRange(ComfortClassQuery.Distinct());
            ViewBag.comfortclassFilter = new SelectList(ComfortClassList);


            //
            if (!String.IsNullOrEmpty(fromAirportFilter))
            {
                travels = travels.Where(s => s.FromAirport == fromAirportFilter);
            }

            if (!String.IsNullOrEmpty(toAirportFilter))
            {
                travels = travels.Where(s => s.ToAirport == toAirportFilter);
            }

            if (!String.IsNullOrEmpty(comfortclassFilter))
            {
                travels = travels.Where(s => s.ComfortClass == comfortclassFilter);
            }







            //return View(db.Travel.ToList());
            return View(travels);
        }

        // GET: Travels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Travel travel = db.Travel.Find(id);
            if (travel == null)
            {
                return HttpNotFound();
            }
            return View(travel);
        }

        // GET: Travels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Travels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Age,PassportNo,Departure,Arrival,FromAirport,ToAirport,ComfortClass")] Travel travel)
        {
            if (ModelState.IsValid)
            {
                db.Travel.Add(travel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(travel);
        }

        // GET: Travels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Travel travel = db.Travel.Find(id);
            if (travel == null)
            {
                return HttpNotFound();
            }
            return View(travel);
        }

        // POST: Travels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Age,PassportNo,Departure,Arrival,FromAirport,ToAirport,ComfortClass")] Travel travel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(travel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(travel);
        }

        // GET: Travels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Travel travel = db.Travel.Find(id);
            if (travel == null)
            {
                return HttpNotFound();
            }
            return View(travel);
        }

        // POST: Travels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Travel travel = db.Travel.Find(id);
            db.Travel.Remove(travel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
