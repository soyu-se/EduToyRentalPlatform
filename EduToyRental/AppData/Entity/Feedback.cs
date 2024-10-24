namespace EduToyRental.AppData.Entity
{
	public class Feedback
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public Guid ToyId { get; set; }
		public Guid UserId { get; set; }
		public string Content { get; set; }
		public string CreatedBy { get; set; }
		public string? LastUpdatedBy { get; set; }
		public string? DeletedBy { get; set; }
		public DateTimeOffset CreatedTime { get; set; }
		public DateTimeOffset? LastUpdatedTime { get; set; }
		public DateTimeOffset? DeletedTime { get; set; }

		
		public virtual Toy Toy { get; set; }
	}
}
