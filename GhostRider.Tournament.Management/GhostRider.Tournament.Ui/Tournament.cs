using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using GhostRider.Tournament.Management.Entities;
using GhostRider.Tournament.Management.Managers;
using GhostRider.Tournament.Management.Test;
using GhostRider.Tournament.Ui.Entities;

namespace GhostRider.Tournament.Ui
{
    public partial class Tournament : Form
    {
        protected Dictionary<string, TournamentParticipant> Participants = new Dictionary<string, TournamentParticipant>();
        private Dictionary<int, TournamentGroup> Groups;
        protected ParticipantsManager ParticipantsManager = new ParticipantsManager();
        protected GroupsManager GroupManager = new GroupsManager();
        private int groupsCount = 1;
        protected List<Label> GroupsLabels = new List<Label>();
        protected List<Label> MatchesLabels = new List<Label>();
        private int X;
        protected Dictionary<string, TextBox> TextBoxList = new Dictionary<string, TextBox>();

        public Tournament()
        {
            InitializeComponent();
        }

        public void DrawGroups()
        {
            Groups = ParticipantsManager.DrawGroups(Participants, groupsCount);
        }

        private void Tournament_Load(object sender, EventArgs e)
        {
            Participants = ParticipantsManager.GetTournamentParticipants(DataProvider.TournamentParticipants);
        }

        private void addParticipant_Click(object sender, EventArgs e)
        {
            if (!Participants.ContainsKey(participantTextbox.Text))
            {
                Participants.Add(participantTextbox.Text, new TournamentParticipant {Name = participantTextbox.Text});
                participantTextbox.Text = "";
            }
        }

        private void drawGroupsButton_Click(object sender, EventArgs e)
        {
            if(GroupsLabels.Count >0)
            {
                foreach (var groupLabel in GroupsLabels)
                {
                    Controls.Remove(groupLabel);
                }
                

            }
            groupsCount = int.Parse(groupsCountTextbox.Text);
            DrawGroups();
            

            int x = 13;
            int y;
            int sizeX = 90;

            foreach (var group in Groups)
            {
                y = 33;

                foreach (var TournamentParticipants in group.Value.Group)
                {
                    AddLabel(new LabelEntity
                    {
                        Labels = GroupsLabels,
                        LocationX = x,
                        LocationY =  y,
                        Text = TournamentParticipants.Value.Name
                    });
                    y += 23;
                }

                x += sizeX;
            }
            X = x;
            PrintMatches();
        }

        private void PrintMatches()
        {
            GroupManager.CreateMatches(Groups);

            int x = X + 63;
            int y;
            int sizeX = 90;

            TextBoxList = new Dictionary<string, TextBox>();
            foreach (var group in Groups)
            {
                y = 33;
                foreach (var match in group.Value.Matches)
                {
                    AddLabel(new LabelEntity
                    {
                        Labels = MatchesLabels,
                        LocationX = x,
                        LocationY = y,
                        Text = match.Value.Left.Name
                    });

                    AddTextbox(new TextBoxEntity
                    {
                        LocationX = x,
                        LocationY = y,
                        Name = match.Key+"Left",
                        Textboxes = TextBoxList
                    });

                    AddTextbox(new TextBoxEntity
                    {
                        LocationX = x+40,
                        LocationY = y,
                        Name = match.Key+"Right",
                        Textboxes = TextBoxList
                    });

                    AddLabel(new LabelEntity
                    {
                        Labels = MatchesLabels,
                        LocationX = x + 160,
                        LocationY = y,
                        Text = match.Value.Right.Name
                    });
                    y += 23;
                }
                x += 240;
            }
            
        }

        protected void AddLabel(LabelEntity info)
        {
            Label lb = new Label();
            GroupsLabels.Add(lb);
            lb.Text = info.Text;
            lb.Location = new Point(info.LocationX, info.LocationY);
            lb.Size = new System.Drawing.Size(LabelEntity.SizeX, LabelEntity.SizeY);
            Controls.Add(lb);
        }

        protected void AddTextbox(TextBoxEntity info)
        {
            TextBox tb = new TextBox();
            TextBoxList.Add(info.Name, tb);
            tb.Location = new Point(info.LocationX + 80, info.LocationY);
            tb.Size = new System.Drawing.Size(TextBoxEntity.SizeX, TextBoxEntity.SizeY);
            Controls.Add(tb);
        }

        /*private Label label1;
    this.label1 = new System.Windows.Forms.Label();
    this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(13, 13);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(35, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "label1";
        this.Controls.Add(this.label1);*/
    }
}
