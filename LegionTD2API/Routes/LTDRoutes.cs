namespace LegionTD2API.Routes
{
    public class LTDRoutes
    {
        #region Players
        public const string PLAYER_BY_ID = "/players/byId/{id}";
        public const string PLAYER_BY_NAME = "/players/byName/{name}";
        public const string PLAYER_BEST_FRIENDS = "/players/bestFriends/{id}";
        public const string PLAYER_MATCH_HISTORY = "/players/matchHistory/{id}";
        public const string PLAYER_STATS_BY_ID = "/players/stats/{id}";
        public const string PLAYER_STATS = "/players/stats";
        #endregion

        #region Units
        public const string UNITS_BY_ID = "/units/byId/{id}";
        public const string UNITS_BY_NAME = "/units/byId/{id}";
        public const string UNITS_BY_VERSION = "/units/byVersion/{version}";
        #endregion

        #region Games
        public const string GAMES = "/games";
        public const string GAMES_BY_ID = "/games/byId/{id}";
        #endregion

        #region Info
        public const string INFO_LEGIONS_BY_ID = "/info/legions/byId/{id}";
        public const string INFO_LEGIONS_OFFSET_LIMIT = "/info/legions/{offset}/{limit}";
        public const string INFO_WAVES_BY_ID = "/info/waves/byId/{id}";
        public const string INFO_WAVES_OFFSET_LIMIT = "/info/waves/{offset}/{limit}";
        public const string INFO_SPELLS_BY_ID = "/info/spells/byId/{id}";
        public const string INFO_SPELLS_OFFSET_LIMIT = "/info/spells/{offset}/{limit}";
        public const string INFO_ABILITIES_BY_ID = "/info/abilities/byId/{id}";
        public const string INFO_ABILITIE_OFFSET_LIMIT = "/info/abilities/{offset}/{limit}";
        public const string INFO_RESEARCH_BY_ID = "/info/research/byId/{id}";
        public const string INFO_RESEARCH_OFFSET_LIMIT = "/info/research/{offset}/{limit}";
        public const string INFO_DESCRIPTIONS_BY_ID = "/info/descriptions/{id}";
        #endregion
    }
}
