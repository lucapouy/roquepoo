 using Microsoft.EnityFrameworkCore;

namespace Company.ClassLibrary1; 
public class AppDbContext : DbContext
{
public DbSet <producto> Productos{get ; set;}

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    var connectionString="server=localhost;Database=LosPapus;User=root;Password=tupass;";
    optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
}
}