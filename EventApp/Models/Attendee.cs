using System.Collections.Generic;

namespace EventApp.Models
{
    public class Attendee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
