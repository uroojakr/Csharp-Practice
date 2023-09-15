using EMS.Data.Interfaces;
using Event_Management_System.Models;
using Microsoft.Extensions.Logging;


namespace EMSWebApi1
{
    public  class DataSeeder
    {
        private readonly ILogger<DataSeeder> _logger;

        public DataSeeder(ILogger<DataSeeder> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public  void SeedData(IUnitOfWork unitOfWork)
        {

            try
            {
                var userRepository = unitOfWork.UserRepositories;
                var eventRepository = unitOfWork.EventRepository;
                var reviewRepository = unitOfWork.ReviewRepositories;
                var ticketRepository = unitOfWork.TicketRepositories;
                var vendorRepository = unitOfWork.VendorRepositories;
                var vendorEventRepository = unitOfWork.VendorEventRepositories;

                // Check if data already exists in the tables
                if (userRepository.GetAll().Any() || eventRepository.GetAll().Any() || reviewRepository.GetAll().Any() || ticketRepository.GetAll().Any() || vendorRepository.GetAll().Any() || vendorEventRepository.GetAll().Any())
                {
                    // Data already seeded
                    return;
                }

                // Seed User data
                var user1 = new User
                {
                    UserName = "Urooj Akram",
                    Email = "urooj@example.com",
                    Password = "33j443",
                    UserType = UserType.Attendee
                };

                var user2 = new User
                {
                    UserName = "Samia Amjad",
                    Email = "samia@example.com",
                    Password = "gfj89jdd",
                    UserType = UserType.Attendee
                };

                userRepository.Add(user1);
                userRepository.Add(user2);

                // Seed Event data
                var event1 = new Events
                {
                    Title = "Cooking Show",
                    Description = "Description for a Cooking Show",
                    Date = DateTime.Now.AddDays(7),
                    Location = "Islamabad",
                    Organizer = user1
                };

                var event2 = new Events
                {
                    Title = "Concert",
                    Description = "Concert taking place in Karachi",
                    Date = DateTime.Now.AddDays(14),
                    Location = "Karachi",
                    Organizer = user2
                };

                eventRepository.Add(event1);
                eventRepository.Add(event2);

                // Seed Review data
                var review1 = new Review
                {
                    Comment = "Review 1 Comment",
                    Rating = 4,
                    UserId = user1.UserId,
                    Event = event1
                };

                var review2 = new Review
                {
                    Comment = "Review 2 Comment",
                    Rating = 5,
                    UserId = user2.UserId,
                    Event = event2
                };

                reviewRepository.Add(review1);
                reviewRepository.Add(review2);

                // Seed Ticket data
                var ticket1 = new Ticket
                {
                    UserId = user1.UserId,
                    Event = event1
                };

                var ticket2 = new Ticket
                {
                    UserId = user2.UserId,
                    Event = event2
                };

                ticketRepository.Add(ticket1);
                ticketRepository.Add(ticket2);

                // Seed Vendor data
                var vendor1 = new Vendor
                {
                    Name = "Catering Service",
                    Description = "provide food and beverage services, including catering for weddings, corporate events, and parties.",
                    ContactInformation = "033-243929"
                };

                var vendor2 = new Vendor
                {
                    Name = "Photographers and Videographers",
                    Description = " Professionals to capture the moments of an event through best photography and videography services.",
                    ContactInformation = "032-393929"
                };

                vendorRepository.Add(vendor1);
                vendorRepository.Add(vendor2);

                // Seed VendorEvent data (Many-to-Many relationship)
                var vendorEvent1 = new VendorEvent
                {
                    Vendor = vendor1,
                    Event = event1
                };

                var vendorEvent2 = new VendorEvent
                {
                    Vendor = vendor2,
                    Event = event2
                };

                vendorEventRepository.Add(vendorEvent1);
                vendorEventRepository.Add(vendorEvent2);
            }
            catch (Exception ex) 
            {
                _logger.LogError(ex, "Error occured ");
            }
        }

       
    }
}
