using First_Web_Ablication.Models;
using Microsoft.EntityFrameworkCore;
namespace First_Web_Ablication.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Skill> skills { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
