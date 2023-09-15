using Event_Management_System.Models;

public class TicketModel
{
    public int TicketId { get; set; }
    public User User { get; set; }
    public Events Events { get; set; }
}