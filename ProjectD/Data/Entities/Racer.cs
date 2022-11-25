using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ProjectD.Common.Constants.DataConstants.Racer;

namespace ProjectD.Data.Entities
{
    public class Racer
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(MaxCarInfoLength)]
        public string CarInfo { get; set; } = null!;

        [Required]
        [StringLength(MaxNicknameLength)]
        public string Nickname { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        public User User { get; set; } = null!;
        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
