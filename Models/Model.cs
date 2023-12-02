using Microsoft.EntityFrameworkCore;

namespace ProjectManagementApi;

public class DbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<Product> Products { get; set; }

    public string DbPath { get; }

    public DbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "blogging.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

public class Product
{
    public int ProductId { get; set; }
    public string name { get; set; }
    public string description { get; set; }

}