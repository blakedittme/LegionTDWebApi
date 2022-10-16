using LegionTD2API.Interfaces;
using LegionTD2API.Routes;
using LegionTD2API.Services;
using Microsoft.AspNetCore.Mvc;

namespace LegionTD2API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LTD2Controller : Controller
    {
        ILTDService _ltdService; 
        public LTD2Controller(ILTDService _lTDService)
        {
            _ltdService = _lTDService;
        }

        #region Players GET Requests
        [HttpGet(LTDRoutes.PLAYER_BY_ID)]
        public async Task<string> GetPlayerById(string id)
        {
            var player = await _ltdService.GetPlayerById(id);
            return player;
        }

        [HttpGet("/players/byName/{name}")]
        public async Task<string> GetPlayerByName(string name)
        {
            var player = await _ltdService.GetPlayerByName(name);
            return player;
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
