using System;
using System.Collections.Generic;

namespace EventApp.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public int SpotsAvailable { get; set; }

        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }

        public ICollection<Attendee> Attendees { get; set; }
    }
}
