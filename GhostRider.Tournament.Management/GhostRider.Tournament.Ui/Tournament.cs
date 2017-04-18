using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GhostRider.Tournament.Management.Entities;
using GhostRider.Tournament.Management.Managers;
using GhostRider.Tournament.Management.Test;

namespace GhostRider.Tournament.Ui
{
    public partial class Tournament : Form
    {
        protected Dictionary<string, TournamentParticipant> Participants = new Dictionary<string, TournamentParticipant>();
        private Dictionary<int, TournamentGroup> Groups;
        protected ParticipantsManager ParticipantsManager = new ParticipantsManager();
        private int groupsCount = 1;

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
                    Label lb = new Label();
                    lb.Text = TournamentParticipants.Value.Name;
                    lb.Location = new Point(x, y);
                    lb.Size = new System.Drawing.Size(80, 13);
                    Controls.Add(lb);

                    y += 23;
                }

                x += sizeX;
            }
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
