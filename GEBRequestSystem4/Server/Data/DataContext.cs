
using GEBRequestSystem4.Shared;

namespace GEBRequestSystem4.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if(!options.IsConfigured)
            {
                options.UseSqlServer("DefaultConnection");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<BussinesDirection>().HasData(
                new BussinesDirection
                {
                    IdBussinesDirection = 1,
                    NameBussinesDirection = "Marvel"
                },
                new BussinesDirection
                {
                    IdBussinesDirection = 2,
                    NameBussinesDirection = "DC"
                }
            );

            modelBuilder.Entity<BussinesArea>().HasData(
                new BussinesArea
                {
                    IdBussinesArea = 1,
                    IdBussinesDirection = 1,
                    NameBussinesArea = "HolaMundo"
                },
                new BussinesArea
                {
                    IdBussinesArea = 2,
                    IdBussinesDirection = 2,
                    NameBussinesArea = "HolaCompita"
                }
            );

        }

        public DbSet<BussinesArea> BussinesAreas { get; set; }

        public DbSet<BussinesDirection> BussinesDirections { get; set; }
    }
}
