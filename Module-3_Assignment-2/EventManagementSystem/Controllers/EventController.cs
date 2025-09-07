using EventManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementSystem.Controllers {
    public class EventController : Controller {
        public IActionResult AllEvents() {
            var events = GetSampleEvents();
            return View(events);
        }
        public IActionResult UpcomingEvents() {
            var events = GetSampleEvents().Where(e => e.Date > DateTime.Today).ToList();
            return View(events);
        }
        private List<EventViewModel> GetSampleEvents() {
            return new List<EventViewModel>
            {
                // Past Events (Jan–Feb 2025)
                new EventViewModel
                {
                    Name = "New Year Wedding",
                    Description = "A grand wedding to celebrate the new year.",
                    Date = new DateTime(2025, 1, 5),
                    Address = "123 Celebration Hall, City A",
                    AssignedUserName = "Alice Johnson",
                    EventType = EventType.Wedding
                },
                new EventViewModel
                {
                    Name = "Business Kickoff Meeting",
                    Description = "Annual strategy meeting for Q1 planning.",
                    Date = new DateTime(2025, 1, 15),
                    Address = "456 Corporate Center, City B",
                    AssignedUserName = "Bob Smith",
                    EventType = EventType.Meeting
                },
                new EventViewModel
                {
                    Name = "Winter Conference",
                    Description = "Tech conference covering emerging trends.",
                    Date = new DateTime(2025, 1, 25),
                    Address = "789 Innovation Hub, City C",
                    AssignedUserName = "Charlie Brown",
                    EventType = EventType.Conference
                },
                new EventViewModel
                {
                    Name = "Charity Gala Party",
                    Description = "Fundraising party for local charities.",
                    Date = new DateTime(2025, 2, 10),
                    Address = "321 Gala Venue, City D",
                    AssignedUserName = "Diana Evans",
                    EventType = EventType.Party
                },
                new EventViewModel
                {
                    Name = "Valentine’s Wedding",
                    Description = "Romantic wedding celebration on Valentine’s Day.",
                    Date = new DateTime(2025, 2, 14),
                    Address = "654 Love Lane, City E",
                    AssignedUserName = "Edward Wilson",
                    EventType = EventType.Wedding
                },

                // Future Events (Nov–Dec 2025)
                new EventViewModel
                {
                    Name = "Autumn Business Meeting",
                    Description = "Final board meeting before year-end.",
                    Date = new DateTime(2025, 11, 10),
                    Address = "789 Finance Rd, City F",
                    AssignedUserName = "Fiona Green",
                    EventType = EventType.Meeting
                },
                new EventViewModel
                {
                    Name = "Tech Conference 2025",
                    Description = "International tech conference on AI and Cloud.",
                    Date = new DateTime(2025, 11, 20),
                    Address = "123 Expo Center, City G",
                    AssignedUserName = "George Clark",
                    EventType = EventType.Conference
                },
                new EventViewModel
                {
                    Name = "Company Holiday Party",
                    Description = "Annual holiday celebration with employees.",
                    Date = new DateTime(2025, 12, 5),
                    Address = "456 Banquet Hall, City H",
                    AssignedUserName = "Helen Davis",
                    EventType = EventType.Party
                },
                new EventViewModel
                {
                    Name = "Christmas Wedding",
                    Description = "Wedding celebration on Christmas Eve.",
                    Date = new DateTime(2025, 12, 24),
                    Address = "789 Church St, City I",
                    AssignedUserName = "Ian Miller",
                    EventType = EventType.Wedding
                },
                new EventViewModel
                {
                    Name = "New Year Countdown Meeting",
                    Description = "Final business wrap-up meeting for the year.",
                    Date = new DateTime(2025, 12, 30),
                    Address = "321 Office Plaza, City J",
                    AssignedUserName = "Jane White",
                    EventType = EventType.Meeting
                }
            };
        }
    }
}