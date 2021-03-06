﻿namespace FootballBetting.Models
{
    using System.Collections.Generic;

    public class Competition
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CompetitionTypeId { get; set; }

        public CompetitionType CompetitionType { get; set; }

        public ICollection<Game> Games { get; set; } = new HashSet<Game>();
    }
}