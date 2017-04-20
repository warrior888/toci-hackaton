using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GhostRider.Tournament.Management.Entities;
using GhostRider.Tournament.Management.Managers;

namespace GhostRider.Tournament.Ui.Entities
{
    public class TournamentParticipantsRenderer
    {
        public string Text { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public List<Label> Labels { get; set; }
        public Dictionary<string, MatchTextbox> TextBoxList = new Dictionary<string, MatchTextbox>();
        protected List<Label> GroupsLabels = new List<Label>();
        protected GroupsManager GroupManager = new GroupsManager();
        protected List<Label> MatchesLabels = new List<Label>();
        public int Y;
        
        

        public const int SizeX = 80;
        public const int SizeY = 13;

        public virtual void RenderMatches(Dictionary<int, TournamentGroup> Groups, Control.ControlCollection Control, int X)
        {
            GroupManager.CreateMatches(Groups);

            int x = X + 63;
            int y;
            int sizeX = 90;

            TextBoxList = new Dictionary<string, MatchTextbox>();
            foreach (var group in Groups)
            {
                y = 33;
                foreach (var match in group.Value.Matches)
                {
                    AddLabel(new LabelEntity {LocationX = x, LocationY = y, Text = match.Value.Left.Name }, Control);

                    AddTextbox(new TextBoxEntity { LocationX = x, LocationY = y, Name = match.Key + "Left", Textboxes = TextBoxList, Owner = match.Value.Left.Name, Pair = match.Key }, Control);

                    AddTextbox(new TextBoxEntity { LocationX = x + 40, LocationY = y, Name = match.Key + "Right", Textboxes = TextBoxList, Owner = match.Value.Right.Name, Pair = match.Key }, Control);

                    AddLabel(new LabelEntity {LocationX = x + 160, LocationY = y, Text = match.Value.Right.Name }, Control);
                    y += 23;
                }
                x += 240;
                UpdateY(y);
            }
        }

        public virtual void AddLabel(LabelEntity info, Control.ControlCollection Controls)
        {
            Label lb = new Label();
            GroupsLabels.Add(lb);
            lb.Text = info.Text;
            lb.Location = new Point(info.LocationX, info.LocationY);
            lb.Size = new System.Drawing.Size(LabelEntity.SizeX, LabelEntity.SizeY);
            Controls.Add(lb);
        }

        protected virtual void AddTextbox(TextBoxEntity info, Control.ControlCollection Controls)
        {
            MatchTextbox tb = new MatchTextbox(info.Owner, info.Pair);
            TextBoxList.Add(info.Name, tb);
            tb.Location = new Point(info.LocationX + 80, info.LocationY);
            tb.Size = new System.Drawing.Size(TextBoxEntity.SizeX, TextBoxEntity.SizeY);
            Controls.Add(tb);
        }

        private void UpdateY(int currentY)
        {
            if (currentY > Y)
            {
                Y = currentY;
            }
        }

        public void CleanTable<TGroupsLabels>(Control.ControlCollection Controls, TGroupsLabels labels) where TGroupsLabels : IEnumerable<Control>
        {
            
            foreach (var groupLabel in labels)
            {
                Controls.Remove(groupLabel);
            }
                
            
        }

        public virtual void RemoveControls(Control.ControlCollection Controls)
        {
            if (GroupsLabels.Count > 0)
            {
                CleanTable<List<Label>>(Controls, GroupsLabels);
                CleanTable<List<MatchTextbox>>(Controls, TextBoxList.Select(m => m.Value).ToList());
            }
        }
    }
}