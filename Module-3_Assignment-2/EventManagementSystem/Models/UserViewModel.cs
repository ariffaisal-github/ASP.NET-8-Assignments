namespace EventManagementSystem.Models {
    public enum UserType {
        Admin=1,
        Standard=2,
        External=3,
        Guest=4
    }
    public class UserViewModel {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? ContactNumber { get; set; }
        public UserType UserType { get; set; }
        public string? Address { get; set; }

    }
}
