using EventManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementSystem.Controllers {
    public class UserController : Controller {
        public IActionResult Users() {
            // Create a list of 15 users
            List<UserViewModel> users =
            [
                new UserViewModel()
                {
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Email = "alice.johnson@example.com",
                    ContactNumber = "123-456-7890",
                    UserType = UserType.Admin,
                    Address = "123 Main St, City A"
                },
                new UserViewModel()
                {
                    FirstName = "Bob",
                    LastName = "Smith",
                    Email = "bob.smith@example.com",
                    ContactNumber = "234-567-8901",
                    UserType = UserType.Standard,
                    Address = "456 Oak Ave, City B"
                },
                new UserViewModel()
                {
                    FirstName = "Charlie",
                    LastName = "Brown",
                    Email = "charlie.brown@example.com",
                    ContactNumber = "345-678-9012",
                    UserType = UserType.External,
                    Address = "789 Pine Rd, City C"
                },
                new UserViewModel()
                {
                    FirstName = "Diana",
                    LastName = "Evans",
                    Email = "diana.evans@example.com",
                    ContactNumber = "456-789-0123",
                    UserType = UserType.Guest,
                    Address = "321 Maple St, City D"
                },
                new UserViewModel()
                {
                    FirstName = "Edward",
                    LastName = "Wilson",
                    Email = "edward.wilson@example.com",
                    ContactNumber = "567-890-1234",
                    UserType = UserType.Standard,
                    Address = "654 Cedar Ln, City E"
                },
                new UserViewModel()
                {
                    FirstName = "Fiona",
                    LastName = "Green",
                    Email = "fiona.green@example.com",
                    ContactNumber = "678-901-2345",
                    UserType = UserType.Admin,
                    Address = "987 Willow Dr, City F"
                },
                new UserViewModel()
                {
                    FirstName = "George",
                    LastName = "Clark",
                    Email = "george.clark@example.com",
                    ContactNumber = "789-012-3456",
                    UserType = UserType.External,
                    Address = "321 Elm St, City G"
                },
                new UserViewModel()
                {
                    FirstName = "Helen",
                    LastName = "Davis",
                    Email = "helen.davis@example.com",
                    ContactNumber = "890-123-4567",
                    UserType = UserType.Standard,
                    Address = "654 Birch Rd, City H"
                },
                new UserViewModel()
                {
                    FirstName = "Ian",
                    LastName = "Miller",
                    Email = "ian.miller@example.com",
                    ContactNumber = "901-234-5678",
                    UserType = UserType.Guest,
                    Address = "987 Spruce Ln, City I"
                },
                new UserViewModel()
                {
                    FirstName = "Jane",
                    LastName = "White",
                    Email = "jane.white@example.com",
                    ContactNumber = "012-345-6789",
                    UserType = UserType.External,
                    Address = "123 Cherry Ave, City J"
                },
                new UserViewModel()
                {
                    FirstName = "Kevin",
                    LastName = "Taylor",
                    Email = "kevin.taylor@example.com",
                    ContactNumber = "111-222-3333",
                    UserType = UserType.Admin,
                    Address = "456 Magnolia St, City K"
                },
                new UserViewModel()
                {
                    FirstName = "Laura",
                    LastName = "Hall",
                    Email = "laura.hall@example.com",
                    ContactNumber = "222-333-4444",
                    UserType = UserType.Standard,
                    Address = "789 Aspen Rd, City L"
                },
                new UserViewModel()
                {
                    FirstName = "Michael",
                    LastName = "Adams",
                    Email = "michael.adams@example.com",
                    ContactNumber = "333-444-5555",
                    UserType = UserType.External,
                    Address = "321 Palm St, City M"
                },
                new UserViewModel()
                {
                    FirstName = "Nora",
                    LastName = "Baker",
                    Email = "nora.baker@example.com",
                    ContactNumber = "444-555-6666",
                    UserType = UserType.Guest,
                    Address = "654 Walnut Ave, City N"
                },
                new UserViewModel()
                {
                    FirstName = "Oliver",
                    LastName = "King",
                    Email = "oliver.king@example.com",
                    ContactNumber = "555-666-7777",
                    UserType = UserType.Standard,
                    Address = "987 Poplar Rd, City O"
                }
            ];

            return View(users);
        }
    }
}
