using System.Collections.Generic;
using GhostRider.Tournament.Management.Entities;

namespace GhostRider.Tournament.Management.Managers
{
    public class ScoreManager
    {
        private Dictionary<int, TournamentGroup> Groups;

        public ScoreManager(Dictionary<int, TournamentGroup> groups)
        {
            Groups = groups;
        }

        public void CalculateScores()
        {
            foreach (var tournamentGroup in Groups)
            {
                foreach (var match in tournamentGroup.Value.Matches)
                {
                    if (match.Value.LeftScore == match.Value.RightScore)
                    {
                        
                    }
                }
            }
        }
    }
}