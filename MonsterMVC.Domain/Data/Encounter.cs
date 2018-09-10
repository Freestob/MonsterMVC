using System.Collections;
using System.Collections.Generic;

namespace MonsterMVC.Domain.Data
{
    public class Encounter
    {
        public int Id { get; set; }
        public ICollection<ActiveMonster> ActiveMonsters { get; set; }
    }
}