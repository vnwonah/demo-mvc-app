using DemoWebApp.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DemoWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}