using ProjectD.Data.Entities;
using ProjectD.Models.Event;
using System.ComponentModel.DataAnnotations;
using static ProjectD.Common.Constants.DataConstants.Racer;

namespace ProjectD.Models.Racer
{
    public class RacerViewModel
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
        public string UserId { get; set; } = null!;
        public User User { get; set; } = null!;
        public ICollection<EventViewModel> Events { get; set; } = new List<EventViewModel>();
    }
}
