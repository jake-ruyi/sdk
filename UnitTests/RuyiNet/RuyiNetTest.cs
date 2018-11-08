﻿using NUnit.Framework;
using Ruyi.SDK.BrainCloudApi;
using System;
using System.Collections.Generic;

namespace Ruyi.SDK.Online.Tests
{
    [TestFixture, Timeout(120000)]
    class RuyiNetTest
    {
        const string TEST_APP_ID = "30005";
        const string TEST_APP_SECRET = "9918d6c0-88e0-449c-bf27-b5dfbc6a59cd";
        const string TEST_LEADERBOARD_ID = "testCreate";

        static string[] PLAYER_IDS =
        {
            "bfdcafbf-b15d-4c01-93b0-b363b310ef80"
        };

        [SetUp]
        public void CreateRuyiSDK()
        {
            if (mSDK == null)
            {
                mSDKContext = new RuyiSDKContext()
                {
                    endpoint = RuyiSDKContext.Endpoint.Console
                };

                mSDK = RuyiSDK.CreateInstance(mSDKContext);
            }
        }

        [TearDown]
        public void DisposeRuyiSDK()
        {
            mSDK.Dispose();
        }

        [Test]
        public void RuyiNetTest_Initialise()
        {
            //  Check RuyiNet is available.
            Assert.IsTrue(IsRuyiNetAvailable);

            //  Check services initialised okay.
            Assert.NotNull(mSDK.RuyiNetService.CloudService);
            Assert.NotNull(mSDK.RuyiNetService.FriendService);
            Assert.NotNull(mSDK.RuyiNetService.LeaderboardService);
            Assert.NotNull(mSDK.RuyiNetService.LobbyService);
            Assert.NotNull(mSDK.RuyiNetService.PartyService);
            Assert.NotNull(mSDK.RuyiNetService.ProfileService);
            Assert.NotNull(mSDK.RuyiNetService.TelemetryService);

            mSDK.RuyiNetService.Initialise(TEST_APP_ID, TEST_APP_SECRET, null);

            while (mSDK.RuyiNetService.IsWorking) { mSDK.Update(); }
        }

        [Test]
        public void RuyiNetTest_CloudBackupData()
        {
            mSDK.RuyiNetService.Initialise(TEST_APP_ID, TEST_APP_SECRET, () =>
            {
                mSDK.RuyiNetService.CloudService.BackupData(0, (RuyiNetResponse response) => { CheckResponseStatus(response.status); });
            });

            while (mSDK.RuyiNetService.IsWorking) { mSDK.Update(); }
        }

        [Test]
        public void RuyiNetTest_CloudRestoreData()
        {
            mSDK.RuyiNetService.Initialise(TEST_APP_ID, TEST_APP_SECRET, () =>
            {
                mSDK.RuyiNetService.CloudService.RestoreData(0, (RuyiNetResponse response) => { CheckResponseStatus(response.status); });
            });

            while (mSDK.RuyiNetService.IsWorking) { mSDK.Update(); }
        }

        [Test]
        public void RuyiNetTest_Friend()
        {
            mSDK.RuyiNetService.Initialise(TEST_APP_ID, TEST_APP_SECRET, () =>
            {
                mSDK.RuyiNetService.FriendService.AddFriend(0, PLAYER_IDS[0],
                    (RuyiNetResponse response) =>
                {
                    CheckResponseStatus(response.status);

                    mSDK.RuyiNetService.FriendService.ListFriends(0,
                        (RuyiNetFriendSummaryData[] friends) =>
                    {
                        Assert.GreaterOrEqual(friends.Length, 1);

                        var i = Array.FindIndex(friends, (x) => (x.PlayerId == PLAYER_IDS[0]));

                        Assert.GreaterOrEqual(i, 0);

                        mSDK.RuyiNetService.FriendService.RemoveFriend(0, PLAYER_IDS[0],
                            (RuyiNetResponse removeFriendResponse) =>
                        {
                            CheckResponseStatus(removeFriendResponse.status);

                            mSDK.RuyiNetService.FriendService.ListFriends(0,
                                (RuyiNetFriendSummaryData[] friends2) =>
                            {
                                i = Array.FindIndex(friends2, (x) => (x.PlayerId == PLAYER_IDS[0]));

                                Assert.IsTrue(i < 0);
                            });
                        });
                    });
                });
            });

            while (mSDK.RuyiNetService.IsWorking) { mSDK.Update(); }
        }

        [Test]
        public void RuyiNetTest_GetProfile()
        {
            mSDK.RuyiNetService.Initialise(TEST_APP_ID, TEST_APP_SECRET, () =>
            {
                mSDK.RuyiNetService.FriendService.GetProfile(0, PLAYER_IDS[0],
                    (RuyiNetGetProfileResponse getProfileResponse) =>
                {
                    CheckResponseStatus(getProfileResponse.status);
                    Assert.IsTrue(getProfileResponse.data.success);
                    Assert.IsTrue(getProfileResponse.data.response.profileId == PLAYER_IDS[0]);

                    mSDK.RuyiNetService.FriendService.GetProfiles(0, PLAYER_IDS,
                        (RuyiNetGetProfilesResponse getProfilesResponse) =>
                    {
                        CheckResponseStatus(getProfileResponse.status);
                        Assert.IsTrue(getProfileResponse.data.success);

                        var profileList = getProfilesResponse.data.response;

                        foreach (var playerId in PLAYER_IDS)
                        {
                            var i = Array.FindIndex(profileList, (x) => (x.profileId == playerId));
                            Assert.GreaterOrEqual(i, 0);
                        }
                    });
                });
            });

            while (mSDK.RuyiNetService.IsWorking) { mSDK.Update(); }
        }

        [Test]
        public void RuyiNetTest_Leaderboard()
        {
            mSDK.RuyiNetService.Initialise(TEST_APP_ID, TEST_APP_SECRET, () =>
            {
                var leaderboardService = mSDK.RuyiNetService.LeaderboardService;
                leaderboardService.PostScoreToLeaderboard(0, 100, TEST_LEADERBOARD_ID,
                    (bool result) =>
                {
                    Assert.IsTrue(result);

                    leaderboardService.GetGlobalLeaderboardPage(0, TEST_LEADERBOARD_ID, SortOrder.HIGH_TO_LOW, 0, 10,
                        (RuyiNetLeaderboardPage page) =>
                    {
                        Assert.IsNotNull(page);                        

                        Assert.Greater(page.Entries.Count, 0);
                        Assert.LessOrEqual(page.Entries.Count, 10);

                        leaderboardService.GetGlobalLeaderboardView(0, TEST_LEADERBOARD_ID, SortOrder.HIGH_TO_LOW, 5, 5,
                            (RuyiNetLeaderboardPage view) =>
                        {
                            Assert.IsNotNull(view);

                            Assert.Greater(view.Entries.Count, 0);
                            Assert.LessOrEqual(view.Entries.Count, 10);

                            leaderboardService.GetSocialLeaderboard(0, TEST_LEADERBOARD_ID, true,
                                (RuyiNetLeaderboardPage socialLeaderboard) =>
                            {
                                Assert.IsNotNull(socialLeaderboard);

                                Assert.Greater(socialLeaderboard.Entries.Count, 0);
                                Assert.LessOrEqual(socialLeaderboard.Entries.Count, 10);
                            });
                        });
                    });
                });
            });

            while (mSDK.RuyiNetService.IsWorking) { mSDK.Update(); }
        }

        [Test]
        public void RuyiNetTest_Lobby()
        {
            /*mSDK.RuyiNetService.Initialise(TEST_APP_ID, TEST_APP_SECRET, () =>
            {
                var lobbyService = mSDK.RuyiNetService.LobbyService;
                lobbyService.CreateLobby(0, 4, RuyiNetLobbyType.PLAYER,
                    (RuyiNetLobby createLobbyResponse) =>
                {
                    Assert.IsTrue(createLobbyResponse.FreeSlots == 3);
                    Assert.IsTrue(createLobbyResponse.LobbyType == RuyiNetLobbyType.PLAYER);
                    Assert.IsTrue(createLobbyResponse.MaxSlots == 4);
                    Assert.IsTrue(createLobbyResponse.MemberCount == 1);
                    Assert.IsTrue(createLobbyResponse.Members.Length == 1);

                    lobbyService.StartGame(0, createLobbyResponse.LobbyId, createLobbyResponse.ConnectionString,
                        (RuyiNetResponse startGameResponse) =>
                    {
                        CheckResponseStatus(startGameResponse.status);

                        lobbyService.LeaveLobby(0, createLobbyResponse.LobbyId,
                        (RuyiNetResponse leaveLobbyResponse) =>
                        {
                            CheckResponseStatus(leaveLobbyResponse.status);
                        });
                    });
                });
            });

            while (mSDK.RuyiNetService.IsWorking) { mSDK.Update(); }*/
        }

        [Test]
        public void RuyiNetTest_Party()
        {
            mSDK.RuyiNetService.Initialise(TEST_APP_ID, TEST_APP_SECRET, () =>
            {
                var partyService = mSDK.RuyiNetService.PartyService;
                partyService.SendPartyInvitation(0, PLAYER_IDS[0],
                    (RuyiNetParty party) =>
                {
                    partyService.GetPartyInfo(0, party.PartyId, (RuyiNetParty partyInfo) =>
                    {
                        partyService.LeaveParty(0, partyInfo.PartyId, (RuyiNetParty oldParty) =>
                        {

                        });
                    });
                });
            });

            while (mSDK.RuyiNetService.IsWorking) { mSDK.Update(); }
        }

        [Test]
        public void RuyNetTest_Telemetry()
        {
            mSDK.RuyiNetService.Initialise(TEST_APP_ID, TEST_APP_SECRET, () =>
            {
                var telemetryService = mSDK.RuyiNetService.TelemetryService;
                telemetryService.StartTelemetrySession(0, (RuyiNetTelemetrySession session) =>
                {
                    Assert.IsNotNull(session);

                    var customData = new Dictionary<string, string>
                    {
                        ["position"] = "[10, 10]"
                    };

                    telemetryService.LogTelemetryEvent(0, session.Id, "ATTACK", customData, (RuyiNetResponse logEventResponse) =>
                    {
                        CheckResponseStatus(logEventResponse.status);

                        telemetryService.EndTelemetrySession(0, session.Id, (RuyiNetResponse endSessionResponse) =>
                        {
                            CheckResponseStatus(endSessionResponse.status);
                        });
                    });
                });
            });

            while (mSDK.RuyiNetService.IsWorking) { mSDK.Update(); }
        }

        private bool IsRuyiNetAvailable
        {
            get
            {
                return mSDK != null && mSDK.RuyiNetService != null;
            }
        }

        private void CheckResponseStatus(int responseStatus, int expected = 200)
        {
            Assert.AreEqual(expected, responseStatus);
        }

        private RuyiSDK mSDK;
        private RuyiSDKContext mSDKContext;
    }
}
