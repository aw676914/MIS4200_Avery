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
    public class TvShowsController : Controller
    {
        private MovieContext db = new MovieContext();

        // GET: TvShows
        public ActionResult Index()
        {
            var tvShows = db.TvShows.Include(t => t.Movies);
            return View(tvShows.ToList());
        }

        // GET: TvShows/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TvShows tvShows = db.TvShows.Find(id);
            if (tvShows == null)
            {
                return HttpNotFound();
            }
            return View(tvShows);
        }

        // GET: TvShows/Create
        public ActionResult Create()
        {
            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "Genre");
            return View();
        }

        // POST: TvShows/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TvShowsID,Genre,MovieName,DirectorFirstName,DirectorLastName,MovieMade,MovieID")] TvShows tvShows)
        {
            if (ModelState.IsValid)
            {
                db.TvShows.Add(tvShows);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "Genre", tvShows.MovieID);
            return View(tvShows);
        }

        // GET: TvShows/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TvShows tvShows = db.TvShows.Find(id);
            if (tvShows == null)
            {
                return HttpNotFound();
            }
            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "Genre", tvShows.MovieID);
            return View(tvShows);
        }

        // POST: TvShows/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TvShowsID,Genre,MovieName,DirectorFirstName,DirectorLastName,MovieMade,MovieID")] TvShows tvShows)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tvShows).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "Genre", tvShows.MovieID);
            return View(tvShows);
        }

        // GET: TvShows/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TvShows tvShows = db.TvShows.Find(id);
            if (tvShows == null)
            {
                return HttpNotFound();
            }
            return View(tvShows);
        }

        // POST: TvShows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TvShows tvShows = db.TvShows.Find(id);
            db.TvShows.Remove(tvShows);
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
