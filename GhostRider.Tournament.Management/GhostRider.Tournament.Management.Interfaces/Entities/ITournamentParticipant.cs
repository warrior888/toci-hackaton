using System;

namespace GhostRider.Tournament.Management.Interfaces.Entities
{
    public interface ITournamentParticipant : IComparable<ITournamentParticipant>
    {
        string Name { get; set; }

        ITournamentScore Score { get; set; }
    }
}