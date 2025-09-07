namespace EventManagementSystem.Models {
    public enum EventType {
        Wedding = 1,
        Conference = 2,
        Party = 3,
        Meeting = 4
    }

    public class EventViewModel {
        public string? Name { get; set; }   
        public string? Description { get; set; }   
        public DateTime Date { get; set; } 
        public string? Address { get; set; }    
        public string? AssignedUserName { get; set; } 
        public EventType EventType { get; set; }     
    }
}
