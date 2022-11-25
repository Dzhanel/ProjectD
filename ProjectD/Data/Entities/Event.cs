using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ProjectD.Common.Constants.DataConstants.Event;

namespace ProjectD.Data.Entities
{
    public class Event
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(MaxTitleLength, MinimumLength = MinTitleLength)]
        public string Title { get; set; } = null!;
        [Required]
        [StringLength(MaxTypeLength, MinimumLength = MinTypeLength)]
        public string Type { get; set; } = null!;
        [StringLength(MaxDescription)]
        public string Description { get; set; } = null!;
        [Required]
        public DateTime EventDate { get; set; }
        [StringLength(MaxCondition)]
        public string Conditions { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Map))]
        public Guid MapId { get; set; }
        public Map Map { get; set; } = null!;

        [ForeignKey(nameof(Announcment))]
        public Guid AnnouncmentId { get; set; }
        public Announcment Announcment { get; set; } = null!;

        public ICollection<Racer> Racers { get; set; } = new List<Racer>();


    }
}
