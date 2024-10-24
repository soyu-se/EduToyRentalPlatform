namespace EduToyRental.AppData.Entity
{
	public class Message
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public Guid ChatId { get; set; }
		public Guid SenderId { get; set; }
		public string MessageText { get; set; }
		public Guid ReceiverId { get; set; }
		public string CreatedBy { get; set; }
		public string? LastUpdatedBy { get; set; }
		public string? DeletedBy { get; set; }
		public DateTimeOffset CreatedTime { get; set; }
		public DateTimeOffset? LastUpdatedTime { get; set; }
		public DateTimeOffset? DeletedTime { get; set; }


		public virtual Chat Chat { get; set; }
		public virtual User User { get; set; }
	}
}
