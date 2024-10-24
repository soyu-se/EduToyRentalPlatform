namespace EduToyRental.AppData.Entity
{
	public class Transaction
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public int TranCode { get; set; }
		public DateTime DateCreated { get; set; }
		public string Status { get; set; }
		public bool Method { get; set; }
		public Guid ContractId { get; set; }
		public string CreatedBy { get; set; }
		public string? LastUpdatedBy { get; set; }
		public string? DeletedBy { get; set; }
		public DateTimeOffset CreatedTime { get; set; }
		public DateTimeOffset? LastUpdatedTime { get; set; }
		public DateTimeOffset? DeletedTime { get; set; }

		public virtual Contract Contract { get; set; }
	}
}
