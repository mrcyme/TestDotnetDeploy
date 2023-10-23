global using Microsoft.EntityFrameworkCore;

namespace MinimalBookApi
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        // You can remove this entire method if you're configuring the database connection string elsewhere (e.g., in Startup.cs or Program.cs)
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     base.OnConfiguring(optionsBuilder);
        //     // This line is for SQL Server, which you won't need if you're switching to PostgreSQL
        //     // optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=minimalbookdb;Trusted_Connection=true;TrustServerCertificate=true;");
        // }

        public DbSet<Book> Books => Set<Book>();
    }
}
