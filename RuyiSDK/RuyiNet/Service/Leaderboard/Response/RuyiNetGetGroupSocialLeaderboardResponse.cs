﻿using System;

namespace Ruyi.SDK.Online
{
    /// <summary>
    /// Response recieved from retrieving a social leaderboard.
    /// </summary>
    public class RuyiNetGetGroupSocialLeaderboardResponse
    {
        /// <summary>
        /// The data class.
        /// </summary>
        [Serializable]
        public class Data
        {
            /// <summary>
            /// Represents a single leaderboard entry.
            /// </summary>
            [Serializable]
            public class LeaderboardEntry
            {
                /// <summary>
                /// The ID of the player this entry represents.
                /// </summary>
                public string playerId;

                /// <summary>
                /// The latest score for the player.
                /// </summary>
                public int score;

                /// <summary>
                /// Extra data provided by the developer, if any.
                /// </summary>
                public string data;

                /// <summary>
                /// When this entry was created (UNIX timestamp).
                /// </summary>
                public long createdAt;

                /// <summary>
                /// When this entry was last updated (UNIX timestamp).
                /// </summary>
                public long updatedAt;

                /// <summary>
                /// The index of this entry.
                /// </summary>
                public int index;

                /// <summary>
                /// The overall rank of the player on this leaderboard.
                /// </summary>
                public int rank;

                /// <summary>
                /// The display name of the player.
                /// </summary>
                public string playerName;

                /// <summary>
                /// The URL of the player's profile picture.
                /// </summary>
                public string pictureUrl;
            }

            /// <summary>
            /// The list of entries for this leaderboard page.
            /// </summary>
            public LeaderboardEntry[] leaderboard;

            /// <summary>
            /// True if there are more entries after this page.
            /// </summary>
            public bool moreAfter;

            /// <summary>
            /// True if there are more entries before this page.
            /// </summary>
            public bool moreBefore;

            /// <summary>
            /// How long before the next time this leaderboard is reset.
            /// </summary>
            public int timeBeforeReset;

            /// <summary>
            /// The server time when this leaderboard was retrieved (UNIX timestamp).
            /// </summary>
            public long server_time;
        }

        /// <summary>
        /// The data returned with the response.
        /// </summary>
        public Data data;

        /// <summary>
        /// The status of the response.
        /// </summary>
        public int status;
    }
}
