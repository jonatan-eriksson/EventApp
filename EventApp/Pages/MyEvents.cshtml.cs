using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventApp.Data;
using EventApp.Models;

namespace EventApp.Pages
{
    public class MyEventsModel : PageModel
    {
        private readonly EventContext _context;

        public MyEventsModel(EventContext context)
        {
            _context = context;
        }

        public List<Event> Event { get; set; }

        public async Task OnGetAsync()
        {
            var userId = 1;
            Event = await _context.Events
                .Include(e => e.Organizer)
                .Where(
                    e => e.Attendees.Any(a => a.Id == userId)
                ).ToListAsync();
        }
    }
}
