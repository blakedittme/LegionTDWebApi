using LegionTD2API.Interfaces;
using LegionTD2API.Routes;
using LegionTD2API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

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

        [HttpGet(LTDRoutes.PLAYER_BY_NAME)]
        public async Task<string> GetPlayerByName(string name)
        {
            var player = await _ltdService.GetPlayerByName(name);
            return player;
        }

        [HttpGet(LTDRoutes.PLAYER_BEST_FRIENDS)]
        public async Task<string> GetPlayerBestFriends(string id)
        {
            var player = await _ltdService.GetPlayerBestFriends(id);
            return player;
        }

        [HttpGet(LTDRoutes.PLAYER_MATCH_HISTORY)]
        public async Task<string> GetPlayerMatchHistory(string id)
        {
            var player = await _ltdService.GetPlayerBestFriends(id);
            return player;
        }

        [HttpGet(LTDRoutes.PLAYER_STATS_BY_ID)]
        public async Task<string> GetPlayerStatsById(string id)
        {
            var player = await _ltdService.GetPlayerStatsById(id);
            return player;
        }

        [HttpGet(LTDRoutes.PLAYER_STATS)]
        public async Task<string> GetPlayerStats()
        {
            var player = await _ltdService.GetPlayerStats();
            return player;
        }
        #endregion

        #region Units GET Requests
        [HttpGet(LTDRoutes.UNITS_BY_ID)]
        public async Task<string> GetUnitsById(string id)
        {
            var units = await _ltdService.GetUnitsById(id);
            return units;
        }

        [HttpGet(LTDRoutes.UNITS_BY_NAME)]
        public async Task<string> GetUnitsByName(string name)
        {
            var units = await _ltdService.GetUnitsByName(name);
            return units;
        }

        [HttpGet(LTDRoutes.UNITS_BY_VERSION)]
        public async Task<string> GetUnitsByVersion(string version)
        {
            var units = await _ltdService.GetUnitsByVersion(version);
            return units;
        }
        #endregion

        #region Games GET Requests
        [HttpGet(LTDRoutes.GAMES)]
        public async Task<string> GetGames()
        {
            var games = await _ltdService.GetGames();
            return games;
        }

        [HttpGet(LTDRoutes.GAMES_BY_ID)]
        public async Task<string> GetGamesById(string id)
        {
            var games = await _ltdService.GetGamesById(id);
            return games;
        }
        #endregion

        #region Information GET Requests

        [HttpGet(LTDRoutes.INFO_LEGIONS_BY_ID)]
        public async Task<string> GetLegionsById(string id)
        {
            var legions = await _ltdService.GetLegionsById(id);
            return legions;
        }

        [HttpGet(LTDRoutes.INFO_LEGIONS_OFFSET_LIMIT)]
        public async Task<string> GetAllLegionsInfo(string offset, string limit)
        {
            var legions = await _ltdService.GetAllLegionsInfo(offset, limit);
            return legions;
        }

        [HttpGet(LTDRoutes.INFO_WAVES_BY_ID)]
        public async Task<string> GetWavesById(string id)
        {
            var waves = await _ltdService.GetLegionsById(id);
            return waves;
        }

        [HttpGet(LTDRoutes.INFO_WAVES_OFFSET_LIMIT)]
        public async Task<string> GetAllWavesInfo(string offset, string limit)
        {
            var legions = await _ltdService.GetAllWavesInfo(offset, limit);
            return legions;
        }

        [HttpGet(LTDRoutes.INFO_SPELLS_BY_ID)]
        public async Task<string> GetSpellsById(string id)
        {
            var spells = await _ltdService.GetSpellsById(id);
            return spells;
        }

        [HttpGet(LTDRoutes.INFO_SPELLS_OFFSET_LIMIT)]
        public async Task<string> GetAllSpellsInfo(string offset, string limit)
        {
            var spells = await _ltdService.GetAllSpellsInfo(offset, limit);
            return spells;
        }

        [HttpGet(LTDRoutes.INFO_ABILITIES_BY_ID)]
        public async Task<string> GetAbilitiesById(string id)
        {
            var abilities = await _ltdService.GetSpellsById(id);
            return abilities;
        }

        [HttpGet(LTDRoutes.INFO_ABILITIES_OFFSET_LIMIT)]
        public async Task<string> GetAllAbilitiesInfo(string offset, string limit)
        {
            var abilities = await _ltdService.GetAllAbilitiesInfo(offset, limit);
            return abilities;
        }

        [HttpGet(LTDRoutes.INFO_RESEARCH_BY_ID)]
        public async Task<string> GetResearchById(string id)
        {
            var research = await _ltdService.GetResearchById(id);
            return research;
        }

        [HttpGet(LTDRoutes.INFO_RESEARCH_OFFSET_LIMIT)]
        public async Task<string> GetAllResearchInfo(string offset, string limit)
        {
            var research = await _ltdService.GetAllResearchInfo(offset, limit);
            return research;
        }

        [HttpGet(LTDRoutes.INFO_DESCRIPTIONS_BY_ID)]
        public async Task<string> GetDescriptionById(string id)
        {
            var description = await _ltdService.GetDescriptionById(id);
            return description;
        }
        #endregion
    }
}
