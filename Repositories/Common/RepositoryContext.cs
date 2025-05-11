
using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Common;

public class RepositoryContext:IdentityDbContext<UserApp>
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options)
    {
        
    }
    public DbSet<Room> Rooms { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
