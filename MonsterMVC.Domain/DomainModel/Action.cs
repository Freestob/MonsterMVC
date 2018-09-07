using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterMVC.Domain.DomainModel
{
    public class Action
    {
        [JsonProperty("damage_bonus")]
        public int DamageBonus { get; set; }
        [JsonProperty("attack_bonus")]
        public int AttackBonus { get; set; }
        [JsonProperty("desc")]
        public string Desc { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
