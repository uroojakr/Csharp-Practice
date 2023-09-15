
using System.ComponentModel.DataAnnotations;

namespace EMS.Business.Models
{
    public class TicketModel
    {
        [Key]
        public int TicketId { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public EventsModel Event { get; set; } = null!;
    }
}