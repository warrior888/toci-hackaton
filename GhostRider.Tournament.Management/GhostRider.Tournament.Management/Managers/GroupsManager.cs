using System.Collections.Generic;
using GhostRider.Tournament.Management.Entities;
using GhostRider.Tournament.Management.Interfaces.Entities;

namespace GhostRider.Tournament.Management.Managers
{
    public class GroupsManager
    {
        public Dictionary<int, TournamentGroup> CreateMatches(Dictionary<int, TournamentGroup> groups)
        {
            foreach (var group in groups)
            {
                group.Value.Matches = new Dictionary<string, ITournamentOponents>();

                foreach (var tournamentParticipantA in group.Value.Group)
                {
                    foreach (var tournamentParticipantB in group.Value.Group)
                    {
                        if (!(tournamentParticipantA.Value.Name == tournamentParticipantB.Value.Name || group.Value.Matches.ContainsKey(string.Format("{0}_{1}", tournamentParticipantA.Value.Name, tournamentParticipantB.Value.Name)) || group.Value.Matches.ContainsKey(string.Format("{1}_{0}", tournamentParticipantA.Value.Name, tournamentParticipantB.Value.Name))))
                        {
                            group.Value.Matches.Add(string.Format("{0}_{1}", tournamentParticipantA.Value.Name, tournamentParticipantB.Value.Name), new TournamentOponents { Left = tournamentParticipantA.Value, Right = tournamentParticipantB.Value});
                        }
                    }
                }
            }

            return groups;
        }
    }
}