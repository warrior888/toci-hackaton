using GhostRider.Tournament.Management.Interfaces.Entities;

namespace GhostRider.Tournament.Management.Entities
{
    public class TournamentOponents : ITournamentOponents
    {
        public ITournamentParticipant Left { get; set; }

        public ITournamentParticipant Right { get; set; }

        public int LeftScore { get; set; }

        public int RightScore { get; set; }
    }
}