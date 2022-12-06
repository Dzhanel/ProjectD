using System.ComponentModel.DataAnnotations;
using static ProjectD.Common.Constants.DataConstants.Map;

namespace ProjectD.Models.Map
{
    public class MapServiceModel
    {
        public Guid Id { get; init; }

        [Required]
        [StringLength(MaxNameLength, MinimumLength = MinNameLength)]
        public string Name { get; init; } = null!;

        [Range(MinLatitude, MaxLatitude)]
        public double StartLongitude { get; init; }

        [Range(MinLatitude, MaxLatitude)]
        public double SartLatitude { get; init; }

        [Range(MinLongitude, MaxLongitude)]
        public double FinishLongitude { get; init; }

        [Range(MinLongitude, MaxLongitude)]
        public double FinishLatitude { get; init; }

        [Required]
        [Range(MaxLength, MinLength)]
        public double LengthKm { get; init; }
        public TimeSpan BestTime { get; init; }
    }
}
