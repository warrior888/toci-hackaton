using System;
using System.Collections.Generic;
using GhostRider.Tournament.Management.Entities;

namespace GhostRider.Tournament.Management.Managers
{
    public class ParticipantsManager
    {
        public Dictionary<string, TournamentParticipant> GetTournamentParticipants(List<string> participants)
        {
            Dictionary<string, TournamentParticipant> result = new Dictionary<string, TournamentParticipant>();

            foreach (var participant in participants)
            {
                if (!result.ContainsKey(participant))
                {
                    result.Add(participant, new TournamentParticipant { Name = participant });
                }
            }

            return result;
        }

        public Dictionary<int, TournamentGroup> DrawGroups(Dictionary<string, TournamentParticipant> allParticipants, int numberOfGroups)
        {
            Dictionary<int, TournamentGroup> result = new Dictionary<int, TournamentGroup>();
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int randomPosition = 1;
            int i = 0;

            while (allParticipants.Count > 0)
            {
                randomPosition = rnd.Next(1, allParticipants.Count);
                string name = GetDictKeyForPosition(randomPosition, allParticipants);
                int groupNumber = i % numberOfGroups + 1;

                if (result.ContainsKey(groupNumber))
                {
                    result[groupNumber].Group.Add(name, allParticipants[name]);
                }
                else
                {
                    result.Add(groupNumber, new TournamentGroup { Group = new Dictionary<string, TournamentParticipant> { { name, allParticipants[name] } } });
                }

                allParticipants.Remove(name);

                i++;
            }

            return result;
        }

        protected string GetDictKeyForPosition(int position, Dictionary<string, TournamentParticipant> participants)
        {
            int i = 1;

            foreach (var participant in participants)
            {
                if (i == position)
                {
                    return participant.Key;
                }

                i++;
            }

            throw new ApplicationException("position is not found in participants list");
        }
    }
}