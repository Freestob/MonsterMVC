using MonsterMVC.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterMVC.Domain.Data.Abstract
{
    public interface IMonsterService
    {
        Task<Monster> GetMonsterAsync(int id);
    }
}
