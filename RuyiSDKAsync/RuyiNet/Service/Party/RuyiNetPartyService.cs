﻿using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Ruyi.SDK.Online
{
    /// <summary>
    /// Allows players to gather together in a party.
    /// </summary>
    public class RuyiNetPartyService : RuyiNetService
    {
        /// <summary>
        /// Create the Party Service.
        /// </summary>
        /// <param name="client">The Ruyi Net client.</param>
        internal RuyiNetPartyService(RuyiNetClient client)
        : base(client)
        {
        }

        /// <summary>
        /// Get the current party information for the player.
        /// </summary>
        /// <param name="index">The index of user</param>
        public async Task<RuyiNetGetPartyInfoResponse> GetPartyInfo(int index)
        {
            var resp = await mClient.BCService.Script_RunParentScriptAsync("GetPartyInfo", "{}", "RUYI", index, token);
            return mClient.Process<RuyiNetGetPartyInfoResponse>(resp);
        }

        /// <summary>
        /// Get information on the party members in the current party.
        /// </summary>
        /// <param name="index">The index of user</param>
        public async Task<RuyiNetGetProfilesResponse> GetPartyMembersInfo(int index)
        {
            var resp = await mClient.BCService.Script_RunParentScriptAsync("GetPartyMembers", "{}", "RUYI", index, token);
            return mClient.Process<RuyiNetGetProfilesResponse>(resp);
        }

        /// <summary>
        /// Invite someone to join a party.
        /// </summary>
        /// <param name="index">The index of user</param>
        /// <param name="profileId">The profile ID of the player to invite.</param>
        public async Task<RuyiNetResponse> SendPartyInvitation(int index, string profileId)
        {
            var payload = new RuyiNetProfileIdRequest()
            {
                profileId = profileId
            };

            var resp = await mClient.BCService.Script_RunParentScriptAsync("SendPartyInvitation", JsonConvert.SerializeObject(payload), "RUYI", index, token);
            return mClient.Process<RuyiNetResponse>(resp);
        }

        /// <summary>
        /// Accept a party invitation.
        /// </summary>
        /// <param name="index">The index of user</param>
        /// <param name="groupId">The group ID of the party to join.</param>
        public async Task<RuyiNetResponse> AcceptPartyInvitation(int index, string groupId)
        {
            var payload = new RuyiNetGroupIdRequest()
            {
                groupId = groupId
            };

            var resp = await mClient.BCService.Script_RunParentScriptAsync("AcceptPartyInvitation", JsonConvert.SerializeObject(payload), "RUYI", index, token);
            return mClient.Process<RuyiNetResponse>(resp);
        }

        /// <summary>
        /// Reject a party invitation.
        /// </summary>
        /// <param name="index">The index of user</param>
        /// <param name="groupId">The group ID of the party to reject.</param>
        public async Task<RuyiNetResponse> RejectPartyInvitation(int index, string groupId)
        {
            var payload = new RuyiNetGroupIdRequest()
            {
                groupId = groupId
            };

            var resp = await mClient.BCService.Script_RunParentScriptAsync("RejectPartyInvitation", JsonConvert.SerializeObject(payload), "RUYI", index, token);
            return mClient.Process<RuyiNetResponse>(resp);
        }

        /// <summary>
        /// Join a friend's party.
        /// </summary>
        /// <param name="index">The index of user</param>
        /// <param name="groupId">The group ID of the party to join.</param>
        public async Task<RuyiNetResponse> JoinParty(int index, string groupId)
        {
            var payload = new RuyiNetGroupIdRequest()
            {
                groupId = groupId
            };

            var resp = await mClient.BCService.Script_RunParentScriptAsync("JoinParty", JsonConvert.SerializeObject(payload), "RUYI", index, token);
            return mClient.Process<RuyiNetResponse>(resp);
        }

        /// <summary>
        /// Leave a party.
        /// </summary>
        /// <param name="index">The index of user</param>
        /// <param name="groupId">The group ID of the party to leave.</param>
        public async Task<RuyiNetResponse> LeaveParty(int index, string groupId)
        {
            var payload = new RuyiNetGroupIdRequest()
            {
                groupId = groupId
            };

            var resp = await mClient.BCService.Script_RunParentScriptAsync("LeaveParty", JsonConvert.SerializeObject(payload), "RUYI", index, token);
            return mClient.Process<RuyiNetResponse>(resp);
        }

        [Serializable]
        private class RuyiNetGroupIdRequest
        {
            public string groupId;
        }
    }

    /// <summary>
    /// The response when getting party information.
    /// </summary>
    [Serializable]
    public class RuyiNetGetPartyInfoResponse
    {
        /// <summary>
        /// The response data.
        /// </summary>
        [Serializable]
        public class Data
        {
            /// <summary>
            /// The response.
            /// </summary>
            [Serializable]
            public class Response
            {
                /// <summary>
                /// Information on a group.
                /// </summary>
                [Serializable]
                public class Group
                {
                    /// <summary>
                    /// The type of this group (should be "PARTY")
                    /// </summary>
                    public string groupType;

                    /// <summary>
                    /// The ID of the group.
                    /// </summary>
                    public string groupId;

                    /// <summary>
                    /// Whether or not the group is open.
                    /// </summary>
                    public bool isOpenGroup;

                    /// <summary>
                    /// Number of players requesting membership.
                    /// </summary>
                    public int requestingPendingMemberCount;

                    /// <summary>
                    /// Number of players invited to the group.
                    /// </summary>
                    public int invitedPendingMemberCount;

                    /// <summary>
                    /// The profile ID of the owner
                    /// </summary>
                    public string ownerId;

                    /// <summary>
                    /// The name of the group (should be the owner's username)
                    /// </summary>
                    public string name;

                    /// <summary>
                    /// Number of people in the group.
                    /// </summary>
                    public int memberCount;
                }

                /// <summary>
                /// Groups the player has requested membership of.
                /// </summary>
                public Group[] requested;

                /// <summary>
                /// Groups the player has been invited to.
                /// </summary>
                public Group[] invited;

                /// <summary>
                /// Groups the player is a member of.
                /// </summary>
                public Group[] groups;
            }

            /// <summary>
            /// The response.
            /// </summary>
            public Response response;

            /// <summary>
            /// Whether or not the server-side script ran successfully.
            /// </summary>
            public bool success;
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
