using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using St10145657_POEPart2.Models;

namespace St10145657_POEPart2.Data;

public class St10145657_POEPart2Context : IdentityDbContext<IdentityUser>
{
    public St10145657_POEPart2Context(DbContextOptions<St10145657_POEPart2Context> options)
        : base(options)
    {
    }
  
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
