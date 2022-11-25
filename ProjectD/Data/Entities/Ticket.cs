using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectD.Data.Entities
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public bool IsRacer { get; set; }
        [Required]
        [ForeignKey(nameof(Event))]
        public Guid EventId { get; set; }
        public Event Event { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(Owner))]
        public string OwnerId { get; set; } = null!;
        public User Owner { get; set; } = null!;
    }
}
