using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

#pragma warning disable CS1591
public class HealthContext(DbContextOptions<HealthContext> options) : DbContext(options)
{
    public DbSet<HealthCheck> HealthChecks => Set<HealthCheck>();
}
#pragma warning restore CS1591
