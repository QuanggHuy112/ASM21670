using ASM2.Areas.Identity.Data;
using ASM2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASM2.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Category> BookCategories { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}