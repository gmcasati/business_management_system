using Microsoft.EntityFrameworkCore;

namespace Bms.Infrastructure.Persistence;

public class BusinessesDbContext : DbContext
{
    public BusinessesDbContext(DbContextOptions<BusinessesDbContext> options)
        : base(options) { }

    public DbSet<Domain.Entities.Business> Todos => Set<Domain.Entities.Business>();
}