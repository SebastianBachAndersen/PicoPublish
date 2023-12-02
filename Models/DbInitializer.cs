using Microsoft.EntityFrameworkCore;

namespace ProjectManagementApi.Models;

public class DbInitializer
{
    private readonly ModelBuilder _modelBuilder;

    public DbInitializer(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        _modelBuilder.Entity<Product>().HasData(
            new Product(){Id = 1, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 2, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 3, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 4, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 5, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 6, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 7, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 8, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 9, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 10, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 11, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 12, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 13, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 14, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 15, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 16, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 17, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 18, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 19, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 20, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 21, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 22, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 23, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 24, Name = "test", Description = "dette er en beskrivelse"},
            new Product(){Id = 25, Name = "test", Description = "dette er en beskrivelse"}
        );
    }
}