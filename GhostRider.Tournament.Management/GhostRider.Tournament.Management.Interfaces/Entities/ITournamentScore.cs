﻿namespace GhostRider.Tournament.Management.Interfaces.Entities
{
    public interface ITournamentScore
    {
        int Won { get; set; }

        int Lost { get; set; }

        int Draw { get; set; }

        int Points { get; set; }
    }
}