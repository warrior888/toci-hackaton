namespace GhostRider.Tournament.Management.Interfaces.Entities
{
    public interface ITournamentParticipant
    {
        string Name { get; set; }

        ITournamentScore Score { get; set; }
    }
}