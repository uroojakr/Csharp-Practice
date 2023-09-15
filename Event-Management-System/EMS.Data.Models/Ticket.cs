using System.ComponentModel.DataAnnotations;

namespace Event_Management_System.Models
{
    public class Ticket
    {
        [Key] 
        public int TickerId { get; set; }   
        public int UserId { get; set; }
        public int EventId { get; set; }
        public Events Event { get; set; } = null!;
    }
}
