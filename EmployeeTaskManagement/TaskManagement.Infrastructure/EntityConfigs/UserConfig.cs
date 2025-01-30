namespace TaskManagement.Infrastructure.EntityConfigs
{
    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
           
            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(2);

            builder.HasOne(x => x.Role)
                .WithMany(r => r.Users) 
                .HasForeignKey(x => x.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
