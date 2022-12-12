﻿using System.ComponentModel.DataAnnotations;
using ProjectD.Data.Entities;
using ProjectD.Models.Map;
using static ProjectD.Common.Constants.DataConstants.Event;

namespace ProjectD.Models.Event
{
    public class EventViewModel
    {
        public Guid Id { get; init; }

        [Required]
        [StringLength(MaxTitleLength, MinimumLength = MinTitleLength)]
        public string Title { get; init; } = null!;
        [Required]
        [StringLength(MaxTypeLength, MinimumLength = MinTypeLength)]
        public string Type { get; init; } = null!;
        [StringLength(MaxDescription)]
        public string Description { get; init; } = null!;

        [Required]
        public DateTime EventDate { get; init; }
        [StringLength(MaxCondition)]
        public string Conditions { get; init; } = null!;

        [Required]
        public Guid MapId { get; init; }
        public MapViewModel Map { get; init; } = null!;

        public Guid AnnouncmentId { get; init; }
        public Announcment Announcment { get; init; } = null!;

        public ICollection<Racer> Racers { get; init; } = new List<Racer>();


    }
}
