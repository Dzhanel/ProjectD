using System.ComponentModel.DataAnnotations;
using static ProjectD.Common.Constants.DataConstants.Map;

namespace ProjectD.Data.Entities
{
    public class Map
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(MaxNameLength, MinimumLength = MinNameLength)]
        public string Name { get; set; } = null!;

        [Range(MinLatitude, MaxLatitude)]
        public double StartLongitude { get; set; }
        
        [Range(MinLatitude, MaxLatitude)]
        public double SartLatitude { get; set; }

        [Range(MinLongitude, MaxLongitude)]
        public double FinishLongitude { get; set; }

        [Range(MinLongitude, MaxLongitude)]
        public double FinishLatitude { get; set; }

        [Required]
        [Range(MaxLength, MinLength)]
        public double LengthKm { get; set; }

        public TimeSpan BestTime { get; set; }
        public ICollection<Event> Events { get; set; } = new List<Event>();    
    }
}
