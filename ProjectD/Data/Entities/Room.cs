using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ProjectD.Common.Constants.DataConstants.Room;

namespace ProjectD.Data.Entities
{
    public class Room 
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(MaxNameLength, MinimumLength = MinNameLength)]
        public string Name { get; set; } = null!;
        public bool IsOpen { get; set; }

        [ForeignKey(nameof(Event))]
        public Guid EventId { get; set; }
        public Event Event { get; set; } = null!;
        public ICollection<Message> Messages { get; set; } = new List<Message>();
    }
}
