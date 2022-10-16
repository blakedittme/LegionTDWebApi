namespace LegionTD2API.Interfaces
{
    public interface ILTDService
    {
        #region PLayers GET Requests
        Task<string> GetPlayerById(string id);
        Task<string> GetPlayerByName(string name);
        Task<string> GetPlayerBestFriends(string id);
        Task<string> GetPlayerMatchHistory(string id);
        Task<string> GetPlayerStatsById(string id);
        Task<string> GetPlayerStats();
        #endregion

        #region Units GET Requests
        Task<string> GetUnitsById(string id);
        Task<string> GetUnitsByName(string name);
        Task<string> GetUnitsByVersion(string version);
        #endregion

        #region Games GET Requests
        Task<string> GetGames();
        Task<string> GetGamesById(string id);
        #endregion

        #region Information GET Requests
        Task<string> GetLegionsById(string id);
        Task<string> GetAllLegionsInfo(string offset, string limit);
        Task<string> GetWavesById(string id);
        Task<string> GetAllWavesInfo(string offset, string limit);
        Task<string> GetSpellsById(string id);
        Task<string> GetAllSpellsInfo(string offset, string limit);
        Task<string> GetAbilitiesById(string id);
        Task<string> GetAllAbilitiesInfo(string offset, string limit);
        Task<string> GetResearchById(string id);
        Task<string> GetAllResearchInfo(string offset, string limit);
        Task<string> GetDescriptionById(string id);
        #endregion
    }
}
