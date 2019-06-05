using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Muusikapood.Models;

namespace Muusikapood.Controllers
{
    public class MuusikapoedsController : Controller
    {
        private MuusikapoodDb db = new MuusikapoodDb();

        // GET: Muusikapoeds
        public ActionResult Index()
        {
            return View(db.Muusikadb.ToList());
        }

        // GET: Muusikapoeds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Muusikapoed muusikapoed = db.Muusikadb.Find(id);
            if (muusikapoed == null)
            {
                return HttpNotFound();
            }
            return View(muusikapoed);
        }
        
        // GET: Muusikapoeds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Muusikapoeds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,instrument,Kvaliteet,hind,kirjeldus")] Muusikapoed muusikapoed)
        {
            if (ModelState.IsValid)
            {
                db.Muusikadb.Add(muusikapoed);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(muusikapoed);
        }

        // GET: Muusikapoeds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Muusikapoed muusikapoed = db.Muusikadb.Find(id);
            if (muusikapoed == null)
            {
                return HttpNotFound();
            }
            return View(muusikapoed);
        }

        // POST: Muusikapoeds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,instrument,Kvaliteet,hind,kirjeldus")] Muusikapoed muusikapoed)
        {
            if (ModelState.IsValid)
            {
                db.Entry(muusikapoed).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(muusikapoed);
        }

        // GET: Muusikapoeds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Muusikapoed muusikapoed = db.Muusikadb.Find(id);
            if (muusikapoed == null)
            {
                return HttpNotFound();
            }
            return View(muusikapoed);
        }

        // POST: Muusikapoeds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Muusikapoed muusikapoed = db.Muusikadb.Find(id);
            db.Muusikadb.Remove(muusikapoed);
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
