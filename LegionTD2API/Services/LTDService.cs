using LegionTD2API.Interfaces;
using LegionTD2API.Routes;

namespace LegionTD2API.Services
{
    public class LTDService : ILTDService
    {
        private HttpClient _httpClient;

        //TODO: add this to config or keystore
        public LTDService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        #region Players GET Requests
        public async Task<string> GetPlayerById(string id)
        {
            string url = $"/players/byId/{id}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetPlayerByName(string name)
        {
            string url = $"/players/byName/{name}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetPlayerBestFriends(string id)
        {
            string url = $"/players/bestFriends/{id}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetPlayerMatchHistory(string id)
        {
            string url = $"/players/matchHistory/{id}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetPlayerStatsById(string id)
        {
            string url = $"/players/stats/{id}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetPlayerStats()
        {
            string url = $"/players/stats";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
        #endregion

        #region Units GET Requests
        public async Task<string> GetUnitsById(string id)
        {
            string url = $"/units/byId/{id}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetUnitsByName(string name)
        {
            string url = $"/units/byName/{name}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetUnitsByVersion(string version)
        {
            string url = $"/units/byVersion/{version}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
        #endregion

        #region Games GET Requests
        public async Task<string> GetGames()
        {
            string url = $"/games";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetGamesById(string id)
        {
            string url = $"/games/byId/{id}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
        #endregion

        #region Information GET Requests
        public async Task<string> GetLegionsById(string id)
        {
            string url = $"/info/legions/byId/{id}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetAllLegionsInfo(string offset, string limit)
        {
            string url = $"/info/legions/{offset}/{limit}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetWavesById(string id)
        {
            string url = $"/info/waves/byId/{id}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetAllWavesInfo(string offset, string limit)
        {
            string url = $"/info/waves/{offset}/{limit}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetSpellsById(string id)
        {
            string url = $"/info/spells/byId/{id}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetAllSpellsInfo(string offset, string limit)
        {
            string url = $"/info/spells/{offset}/{limit}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetAbilitiesById(string id)
        {
            string url = $"/info/abilities/byId/{id}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetAllAbilitiesInfo(string offset, string limit)
        {
            string url = $"/info/abilities/{offset}/{limit}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetResearchById(string id)
        {
            string url = $"/info/research/byId/{id}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetAllResearchInfo(string offset, string limit)
        {
            string url = $"/info/research/{offset}/{limit}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetDescriptionById(string id)
        {
            string url = $"/info/descriptions/{id}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
        #endregion
    }
}
