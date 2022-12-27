using AgendaDeContatosMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaDeContatosMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Contact> AgContacts { get; set; }
    }
}
