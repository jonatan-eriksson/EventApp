using System.Collections.Generic;

namespace EventApp.Models
{
    public class Organizer
    {
        public int OrganizerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public List<Event> Events { get; set; }
    }
}
