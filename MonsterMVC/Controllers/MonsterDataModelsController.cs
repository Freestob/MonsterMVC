using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MonsterMVC.Clients;
using MonsterMVC.Data;
using MonsterMVC.Domain.Data;
using MonsterMVC.Domain.Data.Abstract;
using MonsterMVC.Domain.DomainModel;

namespace MonsterMVC.Controllers
{
    public class MonsterDataModelsController : Controller
    {
        private MonsterDbContext db = new MonsterDbContext();
        private readonly MonsterClient _monsterClient = new MonsterClient();


        private MonsterDataModel monsterDataModel = new MonsterDataModel();

        public async Task<ActionResult> GetMonster(int id)
        {
            var monster = await _monsterClient.GetMonster(id);

            return View(monster);
        }

        [HttpPost]
        public ActionResult GetMonsterName(string monsterName)
        {
            if (monsterName == monsterDataModel.Name)
            {
                 var id = monsterDataModel.Id;
                return RedirectToAction("GetMonster", "MonsterDataModelController", (monsterName));
            }

            return View();


        }

        // GET: MonsterDataModels
        public ActionResult Index()
        {
            return View(db.Monsters.ToList());
        }

      

        // GET: MonsterDataModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MonsterDataModel monsterDataModel = db.Monsters.Find(id);
            if (monsterDataModel == null)
            {
                return HttpNotFound();
            }

            return RedirectToAction("GetMonster", "Monster", new{id = monsterDataModel.UrlId});
        }


        // GET: MonsterDataModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MonsterDataModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,ChallengeRating,UrlId")] MonsterDataModel monsterDataModel)
        {
            if (ModelState.IsValid)
            {
                db.Monsters.Add(monsterDataModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(monsterDataModel);
        }

        // GET: MonsterDataModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MonsterDataModel monsterDataModel = db.Monsters.Find(id);
            if (monsterDataModel == null)
            {
                return HttpNotFound();
            }
            return View(monsterDataModel);
        }

        // POST: MonsterDataModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,ChallengeRating,UrlId")] MonsterDataModel monsterDataModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(monsterDataModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(monsterDataModel);
        }

        // GET: MonsterDataModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MonsterDataModel monsterDataModel = db.Monsters.Find(id);
            if (monsterDataModel == null)
            {
                return HttpNotFound();
            }
            return View(monsterDataModel);
        }

        // POST: MonsterDataModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MonsterDataModel monsterDataModel = db.Monsters.Find(id);
            db.Monsters.Remove(monsterDataModel);
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
