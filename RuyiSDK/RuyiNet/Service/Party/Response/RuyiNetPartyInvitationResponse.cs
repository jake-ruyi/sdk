﻿using System;

namespace Ruyi.SDK.Online
{
    /// <summary>
    /// Represents a response from a list party invitation request.
    /// </summary>
    [Serializable]
    public class RuyiNetPartyInvitationResponse
    {
        /// <summary>
        /// Represents the response data.
        /// </summary>
        public class Data
        {
            /// <summary>
            /// The list of invitations.
            /// </summary>
            public RuyiNetPartyInvitationData[] invites;
        }

        /// <summary>
        /// The response data.
        /// </summary>
        public Data data;

        /// <summary>
        /// The status of the response.
        /// </summary>
        public int status;
    }
}
