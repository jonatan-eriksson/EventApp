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
    public class JoinEventModel : PageModel
    {
        private readonly EventContext _context;

        public JoinEventModel(EventContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }
        public Attendee Attendee { get; set; }
        public bool HasJoined { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Attendee = await _context.Attendees.FirstOrDefaultAsync();
            Event = await _context.Events.Include(e => e.Attendees).FirstOrDefaultAsync(m => m.Id == id);
            HasJoined = Event.Attendees.Contains(Attendee);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null) return NotFound();

            Attendee = await _context.Attendees.FirstOrDefaultAsync();
            Event = await _context.Events.Include(e => e.Attendees).FirstOrDefaultAsync(m => m.Id == id);

            if (Event.Attendees == null)
                Event.Attendees = new List<Attendee>();

            if (!Event.Attendees.Contains(Attendee))
            {
                Event.Attendees.Add(Attendee);
                Event.SpotsAvailable--;
                await _context.SaveChangesAsync();
            }

            return RedirectToPage(new { id });
        }
    }
}
