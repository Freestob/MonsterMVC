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
    public class ActiveMonstersController : Controller
    {
        private MonsterDbContext db = new MonsterDbContext();

        // GET: ActiveMonsterso
        public ActionResult Index()
        {
            var activeMonsters = db.ActiveMonsters.Include(a => a.Encounter).Include(a => a.Monster);
            return View(activeMonsters.ToList());
        }

        // GET: ActiveMonsters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActiveMonster activeMonster = db.ActiveMonsters.Find(id);
            if (activeMonster == null)
            {
                return HttpNotFound();
            }
            return View(activeMonster);
        }

        // GET: ActiveMonsters/Create
        public ActionResult Create()
        {
            ViewBag.EncounterId = new SelectList(db.Encounters, "Id", "Id");
            ViewBag.MonsterId = new SelectList(db.Monsters, "Id", "Name");
            return View();
        }

        // POST: ActiveMonsters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EncounterId,MonsterId,HealthPoints,IsAlive")] ActiveMonster activeMonster)
        {
            if (ModelState.IsValid)
            {
                db.ActiveMonsters.Add(activeMonster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EncounterId = new SelectList(db.Encounters, "Id", "Id", activeMonster.EncounterId);
            ViewBag.MonsterId = new SelectList(db.Monsters, "Id", "Name", activeMonster.MonsterId);
            return View(activeMonster);
        }

        // GET: ActiveMonsters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActiveMonster activeMonster = db.ActiveMonsters.Find(id);
            if (activeMonster == null)
            {
                return HttpNotFound();
            }
            ViewBag.EncounterId = new SelectList(db.Encounters, "Id", "Id", activeMonster.EncounterId);
            ViewBag.MonsterId = new SelectList(db.Monsters, "Id", "Name", activeMonster.MonsterId);
            return View(activeMonster);
        }

        // POST: ActiveMonsters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EncounterId,MonsterId,HealthPoints,IsAlive")] ActiveMonster activeMonster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(activeMonster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EncounterId = new SelectList(db.Encounters, "Id", "Id", activeMonster.EncounterId);
            ViewBag.MonsterId = new SelectList(db.Monsters, "Id", "Name", activeMonster.MonsterId);
            return View(activeMonster);
        }

        // GET: ActiveMonsters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActiveMonster activeMonster = db.ActiveMonsters.Find(id);
            if (activeMonster == null)
            {
                return HttpNotFound();
            }
            return View(activeMonster);
        }

        // POST: ActiveMonsters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ActiveMonster activeMonster = db.ActiveMonsters.Find(id);
            db.ActiveMonsters.Remove(activeMonster);
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
