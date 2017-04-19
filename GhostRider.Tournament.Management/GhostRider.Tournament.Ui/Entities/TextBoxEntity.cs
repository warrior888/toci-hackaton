using System.Collections.Generic;
using System.Windows.Forms;

namespace GhostRider.Tournament.Ui.Entities
{
    public class TextBoxEntity
    {
        public string Name { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public string Owner { get; set; }
        public string Pair { get; set; }
        public Dictionary<string, MatchTextbox> Textboxes { get; set; }

        public const int SizeX = 30;
        public const int SizeY = 13;
    }
}