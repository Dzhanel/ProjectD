using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ProjectD.Common.Constants.DataConstants.Message;

namespace ProjectD.Data.Entities
{
    public class Message
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(MaxTextLength)]
        public string Text { get; set; } = null!;

        [ForeignKey(nameof(Room))]
        public Guid RoomId { get; set; }
        public Room Room { get; set; } = null!;

        [ForeignKey(nameof(Sender))]
        public string SenderId { get; set; } = null!;
        public User Sender { get; set; } = null!;

    }
}
