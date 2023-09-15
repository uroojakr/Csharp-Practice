using Event_Management_System.Models;

public class EventModel
{
    public int EventId { get; set;}
    public string Title { get; set;}    
    public string Description { get; set;}
    public DateTime Date { get; set;}
    public string Location { get; set;}
    public User Organizer { get; set;}
    public IEnumerable<TicketModel> Tickets { get; set;}
    public IEnumerable<ReviewModel> Reviews { get; set;}
}