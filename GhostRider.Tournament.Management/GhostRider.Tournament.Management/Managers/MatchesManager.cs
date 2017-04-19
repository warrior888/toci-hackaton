using System;
using System.Collections.Generic;
using GhostRider.Tournament.Management.Entities;

namespace GhostRider.Tournament.Management.Managers
{
    public class MatchesManager
    {
        private Dictionary<int, TournamentGroup> Groups;

        public MatchesManager(Dictionary<int, TournamentGroup> groups)
        {
            Groups = groups;
        }

        public void AcceptScore(int leftScore, int rightScore, string participantsKey)
        {
            AcceptScore(leftScore, rightScore, GetMatch(participantsKey), participantsKey);
        }

        public void AcceptScore(int leftScore, int rightScore, int group, string participantsKey)
        {
            Groups[group].Matches[participantsKey].LeftScore = leftScore;
            Groups[group].Matches[participantsKey].RightScore = rightScore;
        }

        protected int GetMatch(string participantKey)
        {
            foreach (var tournamentGroup in Groups)
            {
                foreach (var match in tournamentGroup.Value.Matches)
                {
                    if (match.Key == participantKey)
                    {
                        return tournamentGroup.Key;
                    }
                }
            }

            throw new ApplicationException("No group for given participant.");
        }
    }
}