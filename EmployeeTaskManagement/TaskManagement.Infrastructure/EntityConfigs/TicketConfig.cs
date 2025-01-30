namespace TaskManagement.Infrastructure.EntityConfigs
{
    internal class TicketConfig : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100); 

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(500); 

            builder.Property(x => x.Status)
                .IsRequired();

            builder.Property(x => x.CreatedDate)
                .IsRequired();

            builder.Property(x => x.DueDate)
                .IsRequired();

            builder.Property(x => x.AssignedFromDate)
                .IsRequired();

            builder.Property(x => x.AssignedToDate)
                .IsRequired(false); 

            builder.HasOne(x => x.User)
                .WithMany(u => u.Tickets) 
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
