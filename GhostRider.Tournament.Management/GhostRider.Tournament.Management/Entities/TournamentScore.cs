using GhostRider.Tournament.Management.Interfaces.Entities;

namespace GhostRider.Tournament.Management.Entities
{
    public class TournamentScore : ITournamentScore
    {
        public int Won { get; set; }

        public int Lost { get; set; }

        public int Draw { get; set; }

        public int Points { get; set; }
    }
}