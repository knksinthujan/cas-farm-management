using Microsoft.EntityFrameworkCore;

namespace FarmApi;

public class FarmDbContext : DbContext
{
    public FarmDbContext(DbContextOptions<FarmDbContext> options) : base(options)
    {
    }

    public DbSet<FieldsDataModel> Fields { get; set; }
}


