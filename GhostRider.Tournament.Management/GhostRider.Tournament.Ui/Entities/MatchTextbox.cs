using System.Windows.Forms;

namespace GhostRider.Tournament.Ui.Entities
{
    public class MatchTextbox : TextBox
    {
        public string Owner { get; protected set; }
        public string MatchPair { get; protected set; }

        public MatchTextbox(string owner, string matchPair)
        {
            Owner = owner;
            MatchPair = matchPair;
        }
    }
}