namespace EduToyRental.AppData.Entity
{
	public class Delivery
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public Guid ContractId { get; set; }
		public DateOnly SendingDate { get; set; }
		public DateOnly? ReceivingDate { get; set; }
		public decimal DeliveryCost { get; set; }
		public string CreatedBy { get; set; }
		public string? LastUpdatedBy { get; set; }
		public string? DeletedBy { get; set; }
		public DateTimeOffset CreatedTime { get; set; }
		public DateTimeOffset? LastUpdatedTime { get; set; }
		public DateTimeOffset? DeletedTime { get; set; }


		public virtual Contract Contract { get; set; }
	}
}
