using Microsoft.EntityFrameworkCore;

namespace Playground.EntityFrameworkCore;

public class PlaygroundDbContext : DbContext
{
    public DbSet<WeatherForecast> WeatherForecasts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WeatherForecast>(b =>
        {
            b.Property(x => x.Date).IsRequired();
            b.Property(x => x.TemperatureC).IsRequired();
            b.Property(x => x.Summary).HasMaxLength(100);
        });
    }
}