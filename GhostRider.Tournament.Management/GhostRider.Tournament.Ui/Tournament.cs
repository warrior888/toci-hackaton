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
using GhostRider.Tournament.Management.Interfaces.Entities;
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
        protected List<Label> MatchesLabels = new List<Label>();
        private int X = startX;
        private const int startX = 13;
        private int startY = 33;
        private const int progressY = 23;
        int sizeX = 90;
        protected TournamentParticipantsRenderer Renderer = new TournamentParticipantsRenderer();
        

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
                Participants.Add(participantTextbox.Text, new TournamentParticipant {Name = participantTextbox.Text, Score = new TournamentScore()});
                participantTextbox.Text = "";
            }
        }

        private void drawGroupsButton_Click(object sender, EventArgs e)
        {
            Renderer.RemoveControls(Controls);
            X = startX;
            groupsCount = int.Parse(groupsCountTextbox.Text);
            DrawGroups();

            AddTournamentParticipantsLabels<ITournamentGroup, ITournamentParticipant>(Groups.Select(m => m.Value), AddParticipantLabel);
            
            PrintMatches();
        }

        private void PrintMatches()
        {
            Renderer.RenderMatches(Groups, Controls, X);
        }
        

        private void GroupAggregate_Click(object sender, EventArgs e)
        {
            CalculateScore();
            //AddTournamentParticipantsLabels(Groups);
        }

        private void FillUp_Click(object sender, EventArgs e)
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            foreach (var item in Renderer.TextBoxList)
            {
                item.Value.Text = r.Next(1, 8).ToString();
            }
        }

        private void trophySystem_CheckedChanged(object sender, EventArgs e)
        {
            ITournamentGroup finalGroup = new TournamentGroup { Group = new Dictionary<string, ITournamentParticipant>()};

            foreach (var group in Groups)
            {
                var element = group.Value.Group.OrderBy(m => m.Value.Score).Last();

                finalGroup.Group.Add(element.Key, element.Value);
            }

            AddTournamentParticipantsLabels<ITournamentGroup, ITournamentParticipant>(new [] { finalGroup }, AddParticipantLabel);
        }

        private void groupSystem_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected virtual void AddTournamentParticipantsLabels<TGroup, TParticipant>(IEnumerable<TGroup> groups, Action<ITournamentParticipant, int, int> addLabels) 
            where TGroup : ITournamentGroup 
            where TParticipant : ITournamentParticipant
        {
            int x = X;
            int y = startY;
            foreach (var group in groups)
            {
                AddTournamentParticipantsLabels(group.Group.Select(m => m.Value).ToList(), addLabels, y, x);
                x += sizeX;
            }
            X = x;
        }


        protected virtual void AddTournamentParticipantsLabels<TParticipant>(List<TParticipant> groups, Action<TParticipant, int, int> addLabels, int y, int x) where TParticipant : ITournamentParticipant
        {
            
            //foreach (var group in groups)
            //{
                int Y = y;

                foreach (TParticipant TournamentParticipants in groups)
                {
                    addLabels(TournamentParticipants, x, Y);
                    // Renderer.AddLabel(new LabelEntity { LocationX = x, LocationY = Y, Text = TournamentParticipants.Value.Name }, Controls);
                            Y += progressY;
                }

            startY = Y;
            //    x += sizeX;
            //}
            //X = x;
        }

        protected virtual void CalculateScore()
        {
            MatchesManager matchesManager = new MatchesManager(Groups);

            var grouped = Renderer.TextBoxList.GroupBy(m => m.Value.MatchPair);

            foreach (var textboxes in grouped)
            {
                var firstPlayerTb = textboxes.First();
                var secondPlayerTb = textboxes.Skip(1).First();

                if (!string.IsNullOrEmpty(firstPlayerTb.Value.Text) && !string.IsNullOrEmpty(secondPlayerTb.Value.Text))
                {
                    matchesManager.AcceptScore(int.Parse(firstPlayerTb.Value.Text), int.Parse(secondPlayerTb.Value.Text), firstPlayerTb.Value.MatchPair);
                }
            }

            ScoreManager scoreManager = new ScoreManager(Groups);
            scoreManager.CalculateScores();
        }

        protected virtual void AddParticipantLabel(ITournamentParticipant participant,int x, int y)
        {
            Renderer.AddLabel(new LabelEntity { LocationX = x, LocationY = y, Text = participant.Name }, Controls);
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
