using Event_Management_System.Models;
using System.ComponentModel.DataAnnotations;

public class Events
{
    [Key]
    public int EventId { get; set; }
    [Required]
    public string Title { get; set; } = null!;
    [Required]
    public string Description { get; set; } = null!;
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public string Location { get; set; } = null!;

    public int OrganizerId { get; set; }
    public User Organizer { get; set; } = null!;
    public ICollection<Ticket> Tickets { get; set; } = null!;
    public ICollection<VendorEvent> VendorEvents { get; set; } = null!;
    public ICollection<Review> Reviews { get; set; } = null!;

}
