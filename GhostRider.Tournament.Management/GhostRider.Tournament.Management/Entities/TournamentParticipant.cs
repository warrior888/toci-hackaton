using GhostRider.Tournament.Management.Interfaces.Entities;

namespace GhostRider.Tournament.Management.Entities
{
    public class TournamentParticipant : ITournamentParticipant
    {
        public string Name { get; set; }

        public ITournamentScore Score { get; set; }

        public int CompareTo(ITournamentParticipant other)
        {
            return Score.Points > other.Score.Points ? 1 : Score.Points < other.Score.Points ? -1 : 0;
        }
    }
}