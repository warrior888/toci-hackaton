using System.Collections.Generic;
namespace GhostRider.Tournament.Management.Interfaces.Entities
{
    public interface ITournamentGroup
    {
        Dictionary<string, ITournamentParticipant> Group { get; set; }

        Dictionary<string, ITournamentOponents> Matches { get; set; }
    }
}