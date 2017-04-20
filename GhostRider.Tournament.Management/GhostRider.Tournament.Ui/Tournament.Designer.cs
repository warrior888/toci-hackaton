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
            this.GroupAggregate = new System.Windows.Forms.Button();
            this.FillUp = new System.Windows.Forms.Button();
            this.trophySystem = new System.Windows.Forms.RadioButton();
            this.groupSystem = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // participantAddLabel
            // 
            this.participantAddLabel.AutoSize = true;
            this.participantAddLabel.Location = new System.Drawing.Point(20, 16);
            this.participantAddLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.participantAddLabel.Name = "participantAddLabel";
            this.participantAddLabel.Size = new System.Drawing.Size(115, 17);
            this.participantAddLabel.TabIndex = 0;
            this.participantAddLabel.Text = "Podaj uczestnika";
            // 
            // participantTextbox
            // 
            this.participantTextbox.Location = new System.Drawing.Point(143, 12);
            this.participantTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.participantTextbox.Name = "participantTextbox";
            this.participantTextbox.Size = new System.Drawing.Size(279, 22);
            this.participantTextbox.TabIndex = 1;
            // 
            // addParticipant
            // 
            this.addParticipant.Location = new System.Drawing.Point(430, 10);
            this.addParticipant.Margin = new System.Windows.Forms.Padding(4);
            this.addParticipant.Name = "addParticipant";
            this.addParticipant.Size = new System.Drawing.Size(176, 28);
            this.addParticipant.TabIndex = 2;
            this.addParticipant.Text = "Dodaj";
            this.addParticipant.UseVisualStyleBackColor = true;
            this.addParticipant.Click += new System.EventHandler(this.addParticipant_Click);
            // 
            // groupsCountTextbox
            // 
            this.groupsCountTextbox.Location = new System.Drawing.Point(691, 13);
            this.groupsCountTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.groupsCountTextbox.Name = "groupsCountTextbox";
            this.groupsCountTextbox.Size = new System.Drawing.Size(53, 22);
            this.groupsCountTextbox.TabIndex = 3;
            this.groupsCountTextbox.Text = "3";
            // 
            // drawGroupsButton
            // 
            this.drawGroupsButton.Location = new System.Drawing.Point(752, 10);
            this.drawGroupsButton.Margin = new System.Windows.Forms.Padding(4);
            this.drawGroupsButton.Name = "drawGroupsButton";
            this.drawGroupsButton.Size = new System.Drawing.Size(100, 28);
            this.drawGroupsButton.TabIndex = 4;
            this.drawGroupsButton.Text = "Losuj grupy";
            this.drawGroupsButton.UseVisualStyleBackColor = true;
            this.drawGroupsButton.Click += new System.EventHandler(this.drawGroupsButton_Click);
            // 
            // groupsCountLabel
            // 
            this.groupsCountLabel.AutoSize = true;
            this.groupsCountLabel.Location = new System.Drawing.Point(614, 16);
            this.groupsCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.groupsCountLabel.Name = "groupsCountLabel";
            this.groupsCountLabel.Size = new System.Drawing.Size(69, 17);
            this.groupsCountLabel.TabIndex = 5;
            this.groupsCountLabel.Text = "Ilość grup";
            // 
            // GroupAggregate
            // 
            this.GroupAggregate.Location = new System.Drawing.Point(860, 10);
            this.GroupAggregate.Margin = new System.Windows.Forms.Padding(4);
            this.GroupAggregate.Name = "GroupAggregate";
            this.GroupAggregate.Size = new System.Drawing.Size(132, 28);
            this.GroupAggregate.TabIndex = 6;
            this.GroupAggregate.Text = "Podsumuj Grupy";
            this.GroupAggregate.UseVisualStyleBackColor = true;
            this.GroupAggregate.Click += new System.EventHandler(this.GroupAggregate_Click);
            // 
            // FillUp
            // 
            this.FillUp.Location = new System.Drawing.Point(1000, 10);
            this.FillUp.Margin = new System.Windows.Forms.Padding(4);
            this.FillUp.Name = "FillUp";
            this.FillUp.Size = new System.Drawing.Size(132, 28);
            this.FillUp.TabIndex = 7;
            this.FillUp.Text = "Wypełnij";
            this.FillUp.UseVisualStyleBackColor = true;
            this.FillUp.Click += new System.EventHandler(this.FillUp_Click);
            // 
            // trophySystem
            // 
            this.trophySystem.AutoSize = true;
            this.trophySystem.Location = new System.Drawing.Point(1139, 14);
            this.trophySystem.Name = "trophySystem";
            this.trophySystem.Size = new System.Drawing.Size(148, 21);
            this.trophySystem.TabIndex = 10;
            this.trophySystem.TabStop = true;
            this.trophySystem.Text = "System Pucharowy";
            this.trophySystem.UseVisualStyleBackColor = true;
            this.trophySystem.CheckedChanged += new System.EventHandler(this.trophySystem_CheckedChanged);
            // 
            // groupSystem
            // 
            this.groupSystem.AutoSize = true;
            this.groupSystem.Location = new System.Drawing.Point(1293, 14);
            this.groupSystem.Name = "groupSystem";
            this.groupSystem.Size = new System.Drawing.Size(128, 21);
            this.groupSystem.TabIndex = 11;
            this.groupSystem.TabStop = true;
            this.groupSystem.Text = "Grupa Finałowa";
            this.groupSystem.UseVisualStyleBackColor = true;
            this.groupSystem.CheckedChanged += new System.EventHandler(this.groupSystem_CheckedChanged);
            // 
            // Tournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1773, 647);
            this.Controls.Add(this.groupSystem);
            this.Controls.Add(this.trophySystem);
            this.Controls.Add(this.FillUp);
            this.Controls.Add(this.GroupAggregate);
            this.Controls.Add(this.groupsCountLabel);
            this.Controls.Add(this.drawGroupsButton);
            this.Controls.Add(this.groupsCountTextbox);
            this.Controls.Add(this.addParticipant);
            this.Controls.Add(this.participantTextbox);
            this.Controls.Add(this.participantAddLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button GroupAggregate;
        private System.Windows.Forms.Button FillUp;
        private System.Windows.Forms.RadioButton trophySystem;
        private System.Windows.Forms.RadioButton groupSystem;
    }
}

