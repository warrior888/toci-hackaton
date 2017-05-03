using System.Collections.Generic;
using System.Linq;
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
                        Groups[tournamentGroup.Key].Group[match.Value.Left.Name].Score.Draw++;
                        Groups[tournamentGroup.Key].Group[match.Value.Left.Name].Score.Points += match.Value.LeftScore;
                        
                        Groups[tournamentGroup.Key].Group[match.Value.Right.Name].Score.Draw++;
                        Groups[tournamentGroup.Key].Group[match.Value.Right.Name].Score.Points += match.Value.RightScore;
                    }
                    if (match.Value.LeftScore > match.Value.RightScore)
                    {
                        Groups[tournamentGroup.Key].Group[match.Value.Left.Name].Score.Won++;
                        Groups[tournamentGroup.Key].Group[match.Value.Left.Name].Score.Points += match.Value.LeftScore;

                        Groups[tournamentGroup.Key].Group[match.Value.Right.Name].Score.Lost++;
                        Groups[tournamentGroup.Key].Group[match.Value.Right.Name].Score.Points += match.Value.RightScore;
                    }
                    else
                    {
                        Groups[tournamentGroup.Key].Group[match.Value.Left.Name].Score.Lost++;
                        Groups[tournamentGroup.Key].Group[match.Value.Left.Name].Score.Points += match.Value.LeftScore;

                        Groups[tournamentGroup.Key].Group[match.Value.Right.Name].Score.Won++;
                        Groups[tournamentGroup.Key].Group[match.Value.Right.Name].Score.Points += match.Value.RightScore;
                    }
                }
            }
        }
    }
}