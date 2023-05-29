using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactCenter.Models;

namespace ContactCenter.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly ContactCenter.Models.DB _context;

        public IndexModel(ContactCenter.Models.DB context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Contacts != null)
            {
                Contact = await _context.Contacts.ToListAsync();
            }
        }
    }
}
