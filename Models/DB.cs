using Microsoft.EntityFrameworkCore;

namespace ContactCenter.Models
{
    public class DB : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DB(DbContextOptions options) : base(options)
        {
        }
    }
}
