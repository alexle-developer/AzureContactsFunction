using Microsoft.EntityFrameworkCore;

namespace ContactsFunction
{
    public class ContactsDbContext : DbContext
    {
        public ContactsDbContext()
        {
        }

        public ContactsDbContext(DbContextOptions<ContactsDbContext> options) : base(options)
        {
        }

        public DbSet<Model.Contact> Contacts { get; set; }
    }
    
}
