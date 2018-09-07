using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterMVC.Domain.DomainModel
{
    public class Monster
    {
        [JsonProperty("_id")]
        public string _Id { get; set; }
        [JsonProperty("index")]
        public int Index { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("size")]
        public string Size { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("subtype")]
        public string Subtype { get; set; }
        [JsonProperty("alignment")]
        public string Alignment { get; set; }
        [JsonProperty("armor_class")]
        public int ArmorClass { get; set; }
        [JsonProperty("hit_points")]
        public int HitPoints { get; set; }
        [JsonProperty("hit_dice")]
        public string hHitdice { get; set; }
        [JsonProperty("speed")]
        public string Speed { get; set; }
        [JsonProperty("strength")]
        public int Strength { get; set; }
        [JsonProperty("dexterity")]
        public int Dexterity { get; set; }
        [JsonProperty("constitution")]
        public int Constitution { get; set; }
        [JsonProperty("intelligence")]
        public int Intelligence { get; set; }
        [JsonProperty("wisdom")]
        public int Wisdom { get; set; }
        [JsonProperty("charisma")]
        public int Charisma { get; set; }
        [JsonProperty("perception")]
        public int Perception { get; set; }
        [JsonProperty("stealth")]
        public int stealth { get; set; }
        [JsonProperty("damage_vulnerabilities")]
        public string DamageVulnerabilities { get; set; }
        [JsonProperty("damage_resistances")]
        public string DamageResistances { get; set; }
        [JsonProperty("damage_immunities")]
        public string DamageImmunities { get; set; }
        [JsonProperty("condition_immunities")]
        public string ConditionImmunities { get; set; }
        [JsonProperty("senses")]
        public string Senses { get; set; }
        [JsonProperty("languages")]
        public string Languages { get; set; }
        [JsonProperty("challenge_rating")]
        public int ChallengeRating { get; set; }
        [JsonProperty("special_abilities")]
        public List<SpecialAbility> SpecialAbilities { get; set; }
        [JsonProperty("actions")]
        public List<Action> Actions { get; set; }
        [JsonProperty("Url")]
        public string Url { get; set; }
    }
}
