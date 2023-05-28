using ContactCenter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;


namespace ContactCenter.Pages
{
    public class ContactListModel : PageModel
    {
        public ContactListModel(DB dB)
        {
            this._dB = dB;
        }
        public List<Contact> listContact = new List<Contact>();
        private readonly DB _dB;

        public void OnGet()
        {
            listContact = _dB.Contacts.ToList();


        }
    }

    
}
