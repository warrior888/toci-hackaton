using GhostRider.Tournament.Management.Interfaces.Entities;

namespace GhostRider.Tournament.Management.Entities
{
    public class TournamentParticipant : ITournamentParticipant
    {
        public string Name { get; set; }

        public ITournamentScore Score { get; set; }
    }
}