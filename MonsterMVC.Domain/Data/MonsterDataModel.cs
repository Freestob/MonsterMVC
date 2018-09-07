using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterMVC.Domain.Data
{
    public class MonsterDataModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float ChallengeRating { get; set; }
        public int UrlId { get; set; }
    }
}