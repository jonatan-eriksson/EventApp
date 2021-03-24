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
        private readonly EventApp.Data.EventContext _context;

        public MyEventsModel(EventApp.Data.EventContext context)
        {
            _context = context;
        }

        public List<Event> Event { get; set; }

        public async Task OnGetAsync()
        {
            Event = new List<Event>();
            var user = await _context.Attendees.FirstOrDefaultAsync(a => a.Id == 1);
            if (user.Events != null)
                Event.AddRange(user.Events);
        }
    }
}
