namespace GhostRider.Tournament.Management.Entities
{
    public class TournamentScore
    {
        public const int WinPoints = 3;
        public const int DrawPoints = 1;

        public int Won { get; set; }

        public int Lost { get; set; }

        public int Draw { get; set; }

        public int Points
        {
            get { return WinPoints*Won + DrawPoints*Draw; }
        }
    }
}