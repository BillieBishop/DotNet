using SayHello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SayHello.Controllers
{
    public class SayHelloController : Controller
    {
        // GET: SayHello
        public ActionResult Index()
        {
            return View();
        } 

        // POST: SayHello/Create
        [HttpPost]
        public ActionResult Index(Person person)
        {
            try
            {
                // TODO: Add insert logic here

                //return RedirectToAction("Index");
                if (ModelState.IsValid)
                {
                    return View("SayHello", person);
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }       
    }
}
