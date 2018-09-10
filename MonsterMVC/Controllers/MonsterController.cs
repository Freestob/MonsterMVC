using MonsterMVC.Clients;
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
        [HttpPost]
        public async Task<ActionResult> GetMonster(int monsterId)
        {
            var monster = await _monsterClient.GetMonster(monsterId);

            return View(monster);
        }
        
    }
}