using Event_Management_System.Models;
using Event_Management_System.Models;

public class ReviewModel
{
    public int ReviewId { get; set; }
    public string Comment { get; set; } 
    public int Rating { get; set; }
    public User User { get; set; }
    public Events Event { get; set; }   
    public Vendor Vendor { get; set; }
}
