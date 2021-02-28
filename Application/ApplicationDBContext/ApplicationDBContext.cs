using Microsoft.EntityFrameworkCore;
using Application.Models;
namespace Application.ApplicationDBContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<SignUp> SignUp { get; set; }
        public DbSet<Registration> Registration { get; set; }
    }
}
