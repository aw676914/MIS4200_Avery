using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Avery_MIS4200.DAL;
using Avery_MIS4200.Models;
using Microsoft.AspNet.Identity;

namespace Avery_MIS4200.Controllers
{
    public class RegeistarsController : Controller
    {
        private MovieContext db = new MovieContext();

        // GET: Regeistars
        public ActionResult Index()
        {
            return View(db.Regeistars.ToList());
        }

        // GET: Regeistars/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regeistar regeistar = db.Regeistars.Find(id);
            if (regeistar == null)
            {
                return HttpNotFound();
            }
            return View(regeistar);
        }

        // GET: Regeistars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Regeistars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Email,firstName,lastName,PhoneNumber,Studio,Position,hireDate")] Regeistar regeistar)
        {
            if (ModelState.IsValid)
            {



                Guid memberID;
                Guid.TryParse(User.Identity.GetUserId(), out memberID);
                regeistar.ID = memberID;
                db.Regeistars.Add(regeistar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(regeistar);
        }

        // GET: Regeistars/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regeistar regeistar = db.Regeistars.Find(id);
            if (regeistar == null)
            {
                return HttpNotFound();
            }
            return View(regeistar);
        }

        // POST: Regeistars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Email,firstName,lastName,PhoneNumber,Studio,Position,hireDate")] Regeistar regeistar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(regeistar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(regeistar);
        }

        // GET: Regeistars/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regeistar regeistar = db.Regeistars.Find(id);
            if (regeistar == null)
            {
                return HttpNotFound();
            }
            return View(regeistar);
        }

        // POST: Regeistars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Regeistar regeistar = db.Regeistars.Find(id);
            db.Regeistars.Remove(regeistar);
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
