namespace GhostRider.Tournament.Management.Entities
{
    public class TournamentOponents
    {
        public TournamentParticipant Left { get; set; }

        public TournamentParticipant Right { get; set; }

        public int LeftScore { get; set; }

        public int RightScore { get; set; }
    }
}