using System.Collections.Generic;
using System.Windows.Forms;

namespace GhostRider.Tournament.Ui.Entities
{
    public class LabelEntity
    {
        public string Text  { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }

        public const int SizeX = 80;
        public const int SizeY = 13;
    }
}