using MonsterMVC.Domain.Data.Abstract;
using MonsterMVC.Domain.DomainModel;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterMVC.Service.Monsters
{
    class RestSharpMonsterService : IMonsterService
    {
        private readonly IRestClient _client;
        public RestSharpMonsterService()
        {
            _client = new RestClient(ConfigurationManager.AppSettings["Dnd5eapiBaseUrl"]);
        }

        public async Task<Monster> GetMonsterAsync(int id)
        {
            var request = new RestRequest(string.Format(ConfigurationManager.AppSettings["Dnd5eapiBaseUrl"], id), Method.GET);
            var response = await _client.ExecuteTaskAsync<Monster>(request);
            return response.Data;
        }
    }
}
