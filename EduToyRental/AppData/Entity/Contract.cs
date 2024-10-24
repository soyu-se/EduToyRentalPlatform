namespace EduToyRental.AppData.Entity
{
	public class Contract
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public Guid UserId { get; set; }
		public Guid RestoreToyId { get; set; }
		public bool StaffConfirmed { get; set; }
		public int NumberOfRentals { get; set; }
		public DateOnly CreatedDate { get; set; }
		public DateOnly StartDate { get; set; }
		public DateOnly EndDate { get; set; }
		public decimal TotalCost { get; set; }
		public string Status { get; set; }
		public string CreatedBy { get; set; }
		public string? LastUpdatedBy { get; set; }
		public string? DeletedBy { get; set; }
		public DateTimeOffset CreatedTime { get; set; }
		public DateTimeOffset? LastUpdatedTime { get; set; }
		public DateTimeOffset? DeletedTime { get; set; }

		public virtual RestoreToy RestoreToy { get; set; }
		public virtual ICollection<Transaction> Transactions { get; set; }
		public virtual ICollection<Delivery> Deliveries { get; set; }
		public virtual ICollection<ContractDetail> ContractDetails { get; set; }
		public virtual User User { get; set; }
	}
}
