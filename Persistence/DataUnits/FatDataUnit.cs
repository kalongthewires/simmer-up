using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

// source: https://www.thespruceeats.com/smoking-points-of-fats-and-oils-1328753
public class FatDataUnit
{
    private readonly ModelBuilder _modelBuilder;

    public FatDataUnit(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }

    public void SeedData()
    {
        var fats = new List<Fat>
        {
            new Fat
            {
                Id = 1,
                Guid = new Guid("{46F11F51-511A-4BB4-AD49-DBE3436A5102}"),
                Name = "extra virgin olive oil",
                SmokePointFahrenheit = 375,
                Description = "",
                DbCreateTimestamp = DateTime.UtcNow,
                DbLastModifiedTimestamp = DateTime.UtcNow
            },
            new Fat
            {
                Id = 2,
                Guid = new Guid("{470D7AC3-F921-47DA-AEAB-C544DFFD8332}"),
                Name = "butter",
                SmokePointFahrenheit = 350,
                SmokePointCelsius = 177,
                Description = "",
                DbCreateTimestamp = DateTime.UtcNow,
                DbLastModifiedTimestamp = DateTime.UtcNow
            },
            new Fat
            {
                Id = 3,
                Guid = new Guid("{EE867DDA-7A2E-4844-8D89-154127B26612}"),
                AlternateNames = { "ghee" },
                Name = "clarified butter",
                SmokePointFahrenheit = 485,
                SmokePointCelsius = 252,
                DbCreateTimestamp = DateTime.UtcNow,
                DbLastModifiedTimestamp = DateTime.UtcNow
            },
            new Fat
            {
                Id = 4,
                Guid = new Guid("{EE867DDA-7A2E-4844-8D89-154127B26612}"),
                Name = "canola oil",
                SmokePointFahrenheit = 400,
                SmokePointCelsius = 204,
                DbCreateTimestamp = DateTime.UtcNow,
                DbLastModifiedTimestamp = DateTime.UtcNow
            }
        };

        _modelBuilder.Entity<Fat>().HasData(fats);
    }
}
