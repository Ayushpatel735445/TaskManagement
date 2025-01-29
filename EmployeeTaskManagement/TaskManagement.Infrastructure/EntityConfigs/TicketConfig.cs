

namespace TaskManagement.Infrastructure.EntityConfigs
{

    internal class TicketConfig : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            // Set the primary key
            builder.HasKey(x => x.Id);

            // Configure properties
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100); // Limit Title to 100 characters

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(500); // Limit Description to 500 characters

            builder.Property(x => x.Status)
                .IsRequired();

            builder.Property(x => x.CreatedDate)
                .IsRequired();

            builder.Property(x => x.DueDate)
                .IsRequired();

            builder.Property(x => x.AssignedFromDate)
                .IsRequired();

            builder.Property(x => x.AssignedToDate)
                .IsRequired(false); // Nullable

            
            builder.HasOne(x => x.User)
                .WithMany(u => u.Tickets) 
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
