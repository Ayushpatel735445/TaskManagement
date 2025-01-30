namespace TaskManagement.Core.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Constant.RecordStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime AssignedFromDate { get; set; }
        public DateTime? AssignedToDate { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
