using System.Collections.Generic;
using GhostRider.Tournament.Management.Interfaces.Entities;

namespace GhostRider.Tournament.Management.Entities
{
    public class TournamentGroup : ITournamentGroup
    {
        public Dictionary<string, ITournamentParticipant> Group { get; set; }

        public Dictionary<string, ITournamentOponents> Matches { get; set; }
    }
}