using Microsoft.EntityFrameworkCore;

namespace RN_International_Website.Models
{
    

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Define a DbSet for TeamMember
        public DbSet<TeamMember> TeamMembers { get; set; }
    }

}
