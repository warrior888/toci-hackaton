namespace GhostRider.Tournament.Management.Interfaces.Entities
{
    public interface ITournamentOponents
    {
        ITournamentParticipant Left { get; set; }

        ITournamentParticipant Right { get; set; }

        int LeftScore { get; set; }

        int RightScore { get; set; }
    }
}