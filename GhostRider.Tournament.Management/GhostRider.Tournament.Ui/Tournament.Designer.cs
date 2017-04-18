﻿namespace GhostRider.Tournament.Ui
{
    partial class Tournament
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.participantAddLabel = new System.Windows.Forms.Label();
            this.participantTextbox = new System.Windows.Forms.TextBox();
            this.addParticipant = new System.Windows.Forms.Button();
            this.groupsCountTextbox = new System.Windows.Forms.TextBox();
            this.drawGroupsButton = new System.Windows.Forms.Button();
            this.groupsCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // participantAddLabel
            // 
            this.participantAddLabel.AutoSize = true;
            this.participantAddLabel.Location = new System.Drawing.Point(13, 13);
            this.participantAddLabel.Name = "participantAddLabel";
            this.participantAddLabel.Size = new System.Drawing.Size(88, 13);
            this.participantAddLabel.TabIndex = 0;
            this.participantAddLabel.Text = "Podaj uczestnika";
            // 
            // participantTextbox
            // 
            this.participantTextbox.Location = new System.Drawing.Point(107, 10);
            this.participantTextbox.Name = "participantTextbox";
            this.participantTextbox.Size = new System.Drawing.Size(210, 20);
            this.participantTextbox.TabIndex = 1;
            // 
            // addParticipant
            // 
            this.addParticipant.Location = new System.Drawing.Point(323, 8);
            this.addParticipant.Name = "addParticipant";
            this.addParticipant.Size = new System.Drawing.Size(132, 23);
            this.addParticipant.TabIndex = 2;
            this.addParticipant.Text = "Dodaj";
            this.addParticipant.UseVisualStyleBackColor = true;
            this.addParticipant.Click += new System.EventHandler(this.addParticipant_Click);
            // 
            // groupsCountTextbox
            // 
            this.groupsCountTextbox.Location = new System.Drawing.Point(533, 10);
            this.groupsCountTextbox.Name = "groupsCountTextbox";
            this.groupsCountTextbox.Size = new System.Drawing.Size(41, 20);
            this.groupsCountTextbox.TabIndex = 3;
            this.groupsCountTextbox.Text = "3";
            // 
            // drawGroupsButton
            // 
            this.drawGroupsButton.Location = new System.Drawing.Point(580, 8);
            this.drawGroupsButton.Name = "drawGroupsButton";
            this.drawGroupsButton.Size = new System.Drawing.Size(75, 23);
            this.drawGroupsButton.TabIndex = 4;
            this.drawGroupsButton.Text = "Losuj grupy";
            this.drawGroupsButton.UseVisualStyleBackColor = true;
            this.drawGroupsButton.Click += new System.EventHandler(this.drawGroupsButton_Click);
            // 
            // groupsCountLabel
            // 
            this.groupsCountLabel.AutoSize = true;
            this.groupsCountLabel.Location = new System.Drawing.Point(462, 13);
            this.groupsCountLabel.Name = "groupsCountLabel";
            this.groupsCountLabel.Size = new System.Drawing.Size(53, 13);
            this.groupsCountLabel.TabIndex = 5;
            this.groupsCountLabel.Text = "Ilość grup";
            // 
            // Tournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 526);
            this.Controls.Add(this.groupsCountLabel);
            this.Controls.Add(this.drawGroupsButton);
            this.Controls.Add(this.groupsCountTextbox);
            this.Controls.Add(this.addParticipant);
            this.Controls.Add(this.participantTextbox);
            this.Controls.Add(this.participantAddLabel);
            this.Name = "Tournament";
            this.Text = "Tournament";
            this.Load += new System.EventHandler(this.Tournament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label participantAddLabel;
        private System.Windows.Forms.TextBox participantTextbox;
        private System.Windows.Forms.Button addParticipant;
        private System.Windows.Forms.TextBox groupsCountTextbox;
        private System.Windows.Forms.Button drawGroupsButton;
        private System.Windows.Forms.Label groupsCountLabel;

        
    }
}

