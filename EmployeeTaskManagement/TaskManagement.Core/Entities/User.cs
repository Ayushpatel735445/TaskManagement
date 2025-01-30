namespace TaskManagement.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }
        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<Ticket>? Tickets { get; set; }
    }
}
