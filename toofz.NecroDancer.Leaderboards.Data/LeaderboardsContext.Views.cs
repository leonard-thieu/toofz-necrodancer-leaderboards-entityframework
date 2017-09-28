//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Entity.Infrastructure.MappingViews;

[assembly: DbMappingViewCacheTypeAttribute(
    typeof(toofz.NecroDancer.Leaderboards.LeaderboardsContext),
    typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySetsec7aa160e5db3f303bfbbfc008e9a31f74fbdc288aaf322a16b1d2c1f61616d0))]

namespace Edm_EntityMappingGeneratedViews
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data.Entity.Core.Metadata.Edm;

    /// <summary>
    /// Implements a mapping view cache.
    /// </summary>
    [GeneratedCode("Entity Framework 6 Power Tools", "0.9.2.0")]
    internal sealed class ViewsForBaseEntitySetsec7aa160e5db3f303bfbbfc008e9a31f74fbdc288aaf322a16b1d2c1f61616d0 : DbMappingViewCache
    {
        /// <summary>
        /// Gets a hash value computed over the mapping closure.
        /// </summary>
        public override string MappingHashValue
        {
            get { return "ec7aa160e5db3f303bfbbfc008e9a31f74fbdc288aaf322a16b1d2c1f61616d0"; }
        }

        /// <summary>
        /// Gets a view corresponding to the specified extent.
        /// </summary>
        /// <param name="extent">The extent.</param>
        /// <returns>The mapping view, or null if the extent is not associated with a mapping view.</returns>
        public override DbMappingView GetView(EntitySetBase extent)
        {
            if (extent == null)
            {
                throw new ArgumentNullException("extent");
            }

            var extentName = extent.EntityContainer.Name + "." + extent.Name;

            if (extentName == "CodeFirstDatabase.DailyEntry")
            {
                return GetView0();
            }

            if (extentName == "CodeFirstDatabase.DailyLeaderboard")
            {
                return GetView1();
            }

            if (extentName == "CodeFirstDatabase.Player")
            {
                return GetView2();
            }

            if (extentName == "CodeFirstDatabase.Entry")
            {
                return GetView3();
            }

            if (extentName == "CodeFirstDatabase.Leaderboard")
            {
                return GetView4();
            }

            if (extentName == "LeaderboardsContext.DailyEntries")
            {
                return GetView5();
            }

            if (extentName == "LeaderboardsContext.DailyLeaderboards")
            {
                return GetView6();
            }

            if (extentName == "LeaderboardsContext.Players")
            {
                return GetView7();
            }

            if (extentName == "LeaderboardsContext.Entries")
            {
                return GetView8();
            }

            if (extentName == "LeaderboardsContext.Leaderboards")
            {
                return GetView9();
            }

            if (extentName == "CodeFirstDatabase.Replay")
            {
                return GetView10();
            }

            if (extentName == "LeaderboardsContext.Replays")
            {
                return GetView11();
            }

            return null;
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.DailyEntry.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView0()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing DailyEntry
        [CodeFirstDatabaseSchema.DailyEntry](T1.DailyEntry_LeaderboardId, T1.DailyEntry_Rank, T1.DailyEntry_SteamId, T1.DailyEntry_ReplayId, T1.DailyEntry_Score, T1.DailyEntry_Zone, T1.DailyEntry_Level)
    FROM (
        SELECT 
            T.LeaderboardId AS DailyEntry_LeaderboardId, 
            T.Rank AS DailyEntry_Rank, 
            T.SteamId AS DailyEntry_SteamId, 
            T.ReplayId AS DailyEntry_ReplayId, 
            T.Score AS DailyEntry_Score, 
            T.Zone AS DailyEntry_Zone, 
            T.Level AS DailyEntry_Level, 
            True AS _from0
        FROM LeaderboardsContext.DailyEntries AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.DailyLeaderboard.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView1()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing DailyLeaderboard
        [CodeFirstDatabaseSchema.DailyLeaderboard](T1.DailyLeaderboard_LeaderboardId, T1.DailyLeaderboard_LastUpdate, T1.DailyLeaderboard_Date, T1.DailyLeaderboard_IsProduction, T1.DailyLeaderboard_ProductId)
    FROM (
        SELECT 
            T.LeaderboardId AS DailyLeaderboard_LeaderboardId, 
            T.LastUpdate AS DailyLeaderboard_LastUpdate, 
            T.Date AS DailyLeaderboard_Date, 
            T.IsProduction AS DailyLeaderboard_IsProduction, 
            T.ProductId AS DailyLeaderboard_ProductId, 
            True AS _from0
        FROM LeaderboardsContext.DailyLeaderboards AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.Player.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView2()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Player
        [CodeFirstDatabaseSchema.Player](T1.Player_SteamId, T1.Player_LastUpdate, T1.Player_Exists, T1.Player_Name, T1.Player_Avatar)
    FROM (
        SELECT 
            T.SteamId AS Player_SteamId, 
            T.LastUpdate AS Player_LastUpdate, 
            T.[Exists] AS Player_Exists, 
            T.Name AS Player_Name, 
            T.Avatar AS Player_Avatar, 
            True AS _from0
        FROM LeaderboardsContext.Players AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.Entry.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView3()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Entry
        [CodeFirstDatabaseSchema.Entry](T1.Entry_LeaderboardId, T1.Entry_Rank, T1.Entry_SteamId, T1.Entry_ReplayId, T1.Entry_Score, T1.Entry_Zone, T1.Entry_Level)
    FROM (
        SELECT 
            T.LeaderboardId AS Entry_LeaderboardId, 
            T.Rank AS Entry_Rank, 
            T.SteamId AS Entry_SteamId, 
            T.ReplayId AS Entry_ReplayId, 
            T.Score AS Entry_Score, 
            T.Zone AS Entry_Zone, 
            T.Level AS Entry_Level, 
            True AS _from0
        FROM LeaderboardsContext.Entries AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.Leaderboard.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView4()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Leaderboard
        [CodeFirstDatabaseSchema.Leaderboard](T1.Leaderboard_LeaderboardId, T1.Leaderboard_LastUpdate, T1.Leaderboard_IsProduction, T1.Leaderboard_ProductId, T1.Leaderboard_ModeId, T1.Leaderboard_RunId, T1.Leaderboard_CharacterId)
    FROM (
        SELECT 
            T.LeaderboardId AS Leaderboard_LeaderboardId, 
            T.LastUpdate AS Leaderboard_LastUpdate, 
            T.IsProduction AS Leaderboard_IsProduction, 
            T.ProductId AS Leaderboard_ProductId, 
            T.ModeId AS Leaderboard_ModeId, 
            T.RunId AS Leaderboard_RunId, 
            T.CharacterId AS Leaderboard_CharacterId, 
            True AS _from0
        FROM LeaderboardsContext.Leaderboards AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for LeaderboardsContext.DailyEntries.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView5()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing DailyEntries
        [toofz.NecroDancer.Leaderboards.DailyEntry](T1.DailyEntry_LeaderboardId, T1.DailyEntry_Rank, T1.DailyEntry_SteamId, T1.DailyEntry_ReplayId, T1.DailyEntry_Score, T1.DailyEntry_Zone, T1.DailyEntry_Level)
    FROM (
        SELECT 
            T.LeaderboardId AS DailyEntry_LeaderboardId, 
            T.Rank AS DailyEntry_Rank, 
            T.SteamId AS DailyEntry_SteamId, 
            T.ReplayId AS DailyEntry_ReplayId, 
            T.Score AS DailyEntry_Score, 
            T.Zone AS DailyEntry_Zone, 
            T.Level AS DailyEntry_Level, 
            True AS _from0
        FROM CodeFirstDatabase.DailyEntry AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for LeaderboardsContext.DailyLeaderboards.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView6()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing DailyLeaderboards
        [toofz.NecroDancer.Leaderboards.DailyLeaderboard](T1.DailyLeaderboard_LeaderboardId, T1.DailyLeaderboard_LastUpdate, T1.DailyLeaderboard_Date, T1.DailyLeaderboard_IsProduction, T1.DailyLeaderboard_ProductId)
    FROM (
        SELECT 
            T.LeaderboardId AS DailyLeaderboard_LeaderboardId, 
            T.LastUpdate AS DailyLeaderboard_LastUpdate, 
            T.Date AS DailyLeaderboard_Date, 
            T.IsProduction AS DailyLeaderboard_IsProduction, 
            T.ProductId AS DailyLeaderboard_ProductId, 
            True AS _from0
        FROM CodeFirstDatabase.DailyLeaderboard AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for LeaderboardsContext.Players.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView7()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Players
        [toofz.NecroDancer.Leaderboards.Player](T1.Player_SteamId, T1.Player_LastUpdate, T1.Player_Exists, T1.Player_Name, T1.Player_Avatar)
    FROM (
        SELECT 
            T.SteamId AS Player_SteamId, 
            T.LastUpdate AS Player_LastUpdate, 
            T.[Exists] AS Player_Exists, 
            T.Name AS Player_Name, 
            T.Avatar AS Player_Avatar, 
            True AS _from0
        FROM CodeFirstDatabase.Player AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for LeaderboardsContext.Entries.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView8()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Entries
        [toofz.NecroDancer.Leaderboards.Entry](T1.Entry_LeaderboardId, T1.Entry_Rank, T1.Entry_SteamId, T1.Entry_ReplayId, T1.Entry_Score, T1.Entry_Zone, T1.Entry_Level)
    FROM (
        SELECT 
            T.LeaderboardId AS Entry_LeaderboardId, 
            T.Rank AS Entry_Rank, 
            T.SteamId AS Entry_SteamId, 
            T.ReplayId AS Entry_ReplayId, 
            T.Score AS Entry_Score, 
            T.Zone AS Entry_Zone, 
            T.Level AS Entry_Level, 
            True AS _from0
        FROM CodeFirstDatabase.Entry AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for LeaderboardsContext.Leaderboards.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView9()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Leaderboards
        [toofz.NecroDancer.Leaderboards.Leaderboard](T1.Leaderboard_LeaderboardId, T1.Leaderboard_LastUpdate, T1.Leaderboard_IsProduction, T1.Leaderboard_ProductId, T1.Leaderboard_ModeId, T1.Leaderboard_RunId, T1.Leaderboard_CharacterId)
    FROM (
        SELECT 
            T.LeaderboardId AS Leaderboard_LeaderboardId, 
            T.LastUpdate AS Leaderboard_LastUpdate, 
            T.IsProduction AS Leaderboard_IsProduction, 
            T.ProductId AS Leaderboard_ProductId, 
            T.ModeId AS Leaderboard_ModeId, 
            T.RunId AS Leaderboard_RunId, 
            T.CharacterId AS Leaderboard_CharacterId, 
            True AS _from0
        FROM CodeFirstDatabase.Leaderboard AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.Replay.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView10()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Replay
        [CodeFirstDatabaseSchema.Replay](T1.Replay_ReplayId, T1.Replay_ErrorCode, T1.Replay_Seed, T1.Replay_Version, T1.Replay_KilledBy, T1.Replay_Uri)
    FROM (
        SELECT 
            T.ReplayId AS Replay_ReplayId, 
            T.ErrorCode AS Replay_ErrorCode, 
            T.Seed AS Replay_Seed, 
            T.Version AS Replay_Version, 
            T.KilledBy AS Replay_KilledBy, 
            T.Uri AS Replay_Uri, 
            True AS _from0
        FROM LeaderboardsContext.Replays AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for LeaderboardsContext.Replays.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView11()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Replays
        [toofz.NecroDancer.Leaderboards.Replay](T1.Replay_ReplayId, T1.Replay_ErrorCode, T1.Replay_Seed, T1.Replay_Version, T1.Replay_KilledBy, T1.Replay_Uri)
    FROM (
        SELECT 
            T.ReplayId AS Replay_ReplayId, 
            T.ErrorCode AS Replay_ErrorCode, 
            T.Seed AS Replay_Seed, 
            T.Version AS Replay_Version, 
            T.KilledBy AS Replay_KilledBy, 
            T.Uri AS Replay_Uri, 
            True AS _from0
        FROM CodeFirstDatabase.Replay AS T
    ) AS T1");
        }
    }
}
