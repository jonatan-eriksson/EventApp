using System;
using System.Linq;
using EventApp.Models;

namespace EventApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EventContext context)
        {
            context.Database.EnsureCreated();
            if (context.Events.Any())
            {
                return;
            }

            var organizer = new Organizer()
            {
                Name = "Organizer",
                Email = "organizer@events.com",
                PhoneNumber = "0000"
            };
            context.Organizers.Add(organizer);
            context.SaveChanges();

            var attendees = new Attendee()
            {
                Name = "John Doe",
                Email = "john.doe@abc.com",
                PhoneNumber = "0001"
            };

            context.Attendees.Add(attendees);
            context.SaveChanges();

            var events = new Event[]
            {
                new Event{ Title="Event 1", Description="test", Place="Arena", Address="Abc 123", Date=DateTime.Parse("2021-05-01"), SpotsAvailable=10, Organizer=organizer},
                new Event{ Title="Event 2", Description="test", Place="Club", Address="Abc 123", Date=DateTime.Parse("2021-06-01"), SpotsAvailable=20, Organizer=organizer},
                new Event{ Title="Event 3", Description="test", Place="Arena", Address="Abc 123", Date=DateTime.Parse("2021-07-01"), SpotsAvailable=30, Organizer=organizer}
            };
            context.Events.AddRange(events);
            context.SaveChanges();
        }
    }
}
