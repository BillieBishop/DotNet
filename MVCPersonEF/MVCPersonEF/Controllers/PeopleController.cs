using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCPersonEF.Models;

namespace MVCPersonEF.Controllers
{
    public class PeopleController : Controller
    {
        private PeopleEntities db = new PeopleEntities();

        // GET: People
        public ActionResult Index()
        {
            var genderList = Enum.GetNames(typeof(Gender)).ToList();


            return View(db.People.ToList());
        }


        // GET: People/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            People people = db.People.Find(id);
            if (people == null)
            {
                return HttpNotFound();
            }
            return View(people);
        }

        // GET: People/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Age,PostalCode,Gender,BirthDate")] People people)
        {
            if (ModelState.IsValid)
            {
                people.Id = Guid.NewGuid();
                db.People.Add(people);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(people);
        }

        // GET: People/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            People people = db.People.Find(id);
            if (people == null)
            {
                return HttpNotFound();
            }
            return View(people);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Age,PostalCode,Gender,BirthDate")] People people)
        {
            if (ModelState.IsValid)
            {
                db.Entry(people).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(people);
        }

        // GET: People/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            People people = db.People.Find(id);
            if (people == null)
            {
                return HttpNotFound();
            }
            return View(people);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            People people = db.People.Find(id);
            db.People.Remove(people);
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
