using Microsoft.EntityFrameworkCore;
using api_pertama.Models;

namespace api_pertama.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<Hobby> Hobbies => Set<Hobby>();
    public DbSet<WorkExperience> WorkExperiences => Set<WorkExperience>();

}
