using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MonsterMVC.Data;
using MonsterMVC.Domain.Data;

namespace MonsterMVC.Controllers
{
    public class EncountersController : Controller
    {
        private MonsterDbContext db = new MonsterDbContext();

        // GET: Encounters
        public ActionResult Index()
        {
            return View(db.Encounters.ToList());
        }

        // GET: Encounters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encounter encounter = db.Encounters.Find(id);
            if (encounter == null)
            {
                return HttpNotFound();
            }
            return View(encounter);
        }

        // GET: Encounters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Encounters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] Encounter encounter)
        {
            if (ModelState.IsValid)
            {
                db.Encounters.Add(encounter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(encounter);
        }

        // GET: Encounters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encounter encounter = db.Encounters.Find(id);
            if (encounter == null)
            {
                return HttpNotFound();
            }
            return View(encounter);
        }

        // POST: Encounters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] Encounter encounter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(encounter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(encounter);
        }

        // GET: Encounters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encounter encounter = db.Encounters.Find(id);
            if (encounter == null)
            {
                return HttpNotFound();
            }
            return View(encounter);
        }

        // POST: Encounters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Encounter encounter = db.Encounters.Find(id);
            db.Encounters.Remove(encounter);
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
