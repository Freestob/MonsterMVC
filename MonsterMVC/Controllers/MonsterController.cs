using MonsterMVC.Clients;
using MonsterMVC.Domain.Data;
using MonsterMVC.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MonsterMVC.Controllers
{
    public class MonsterController : Controller
    {
        private readonly MonsterClient _monsterClient = new MonsterClient();

        // GET: Monster
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> GetMonster(int id)
        {
            var monster = await _monsterClient.GetMonster(id);

            return View(monster);
        }

    }
}