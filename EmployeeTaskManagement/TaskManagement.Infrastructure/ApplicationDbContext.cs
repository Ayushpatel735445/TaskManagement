namespace TaskManagement.Infrastructure
{

    public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Role> Role { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleConfig());
            modelBuilder.ApplyConfiguration(new TicketConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
        }
    }
}
