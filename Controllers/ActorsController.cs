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

namespace Avery_MIS4200.Controllers
{
    public class ActorsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Actors
        public ActionResult Index()
        {
            var actors = db.Actors.Include(a => a.Studio).Include(a => a.TvShows);
            return View(actors.ToList());
        }

        // GET: Actors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actors actors = db.Actors.Find(id);
            if (actors == null)
            {
                return HttpNotFound();
            }
            return View(actors);
        }

        // GET: Actors/Create
        public ActionResult Create()
        {
            ViewBag.StudioID = new SelectList(db.Studios, "StudioID", "StudioName");
            ViewBag.TvShowsID = new SelectList(db.TvShows, "TvShowsID", "Genre");
            ViewBag.ID = new SelectList(db.Actors, "ID", "fullName");
            return View();
        }

        // POST: Actors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ActorsID,ActorsPay,MovieID,TvShowsID,StudioID")] Actors actors)
        {
            if (ModelState.IsValid)
            {
                db.Actors.Add(actors);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudioID = new SelectList(db.Studios, "StudioID", "StudioName", actors.StudioID);
            ViewBag.TvShowsID = new SelectList(db.TvShows, "TvShowsID", "Genre", actors.TvShowsID);
            return View(actors);
        }

        // GET: Actors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actors actors = db.Actors.Find(id);
            if (actors == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudioID = new SelectList(db.Studios, "StudioID", "StudioName", actors.StudioID);
            ViewBag.TvShowsID = new SelectList(db.TvShows, "TvShowsID", "Genre", actors.TvShowsID);
            return View(actors);
        }

        // POST: Actors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ActorsID,ActorsPay,MovieID,TvShowsID,StudioID")] Actors actors)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actors).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudioID = new SelectList(db.Studios, "StudioID", "StudioName", actors.StudioID);
            ViewBag.TvShowsID = new SelectList(db.TvShows, "TvShowsID", "Genre", actors.TvShowsID);
            return View(actors);
        }

        // GET: Actors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actors actors = db.Actors.Find(id);
            if (actors == null)
            {
                return HttpNotFound();
            }
            return View(actors);
        }

        // POST: Actors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Actors actors = db.Actors.Find(id);
            db.Actors.Remove(actors);
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
