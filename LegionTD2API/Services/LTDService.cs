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
        #endregion

        #region Units GET Requests

        #endregion

        #region Games GET Requests

        #endregion

        #region Information GET Requests

        #endregion
    }
}
