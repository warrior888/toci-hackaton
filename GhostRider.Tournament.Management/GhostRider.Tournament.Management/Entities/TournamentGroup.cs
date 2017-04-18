using System.Collections.Generic;

namespace GhostRider.Tournament.Management.Entities
{
    public class TournamentGroup
    {
        public Dictionary<string, TournamentParticipant> Group { get; set; }

        public Dictionary<string, TournamentOponents> Matches { get; set; }
    }
}