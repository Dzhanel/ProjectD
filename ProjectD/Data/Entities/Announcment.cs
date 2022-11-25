using System.ComponentModel.DataAnnotations;
namespace ProjectD.Data.Entities
{
    public class Announcment
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        public int Position { get; set; }

        public ICollection<Event> Events = new List<Event>();

    }
}
