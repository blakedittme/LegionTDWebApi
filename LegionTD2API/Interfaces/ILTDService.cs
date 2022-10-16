namespace LegionTD2API.Interfaces
{
    public interface ILTDService
    {
        #region PLayers GET Requests
        Task<string> GetPlayerById(string id);
        Task<string> GetPlayerByName(string name);
        #endregion

        #region Units GET Requests

        #endregion

        #region Games GET Requests

        #endregion

        #region Information GET Requests

        #endregion
    }
}
