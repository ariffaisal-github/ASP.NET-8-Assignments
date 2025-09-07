using EventManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementSystem.Controllers {
    public class UserController : Controller {
        public IActionResult Users() {
            // Create a list of 5 users
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
                }
            ];

            return View(users);
        }
    }
}
