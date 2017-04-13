using GhostRider.Tournament.Management.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GhostRider.Tournament.Management.Test
{
    [TestClass]
    public class ParticipantsManagerTests
    {
        [TestMethod]
        public void TestGroupDraw()
        {
            ParticipantsManager manager = new ParticipantsManager();

            var tournamentParticipants = manager.GetTournamentParticipants(DataProvider.TournamentParticipants);

            var groups = manager.DrawGroups(tournamentParticipants, 3);
            var groups2 = manager.DrawGroups(manager.GetTournamentParticipants(DataProvider.TournamentParticipants), 2);
        }
    }
}