namespace EduToyRental.AppData.Entity
{
	public class ContractDetail
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public Guid ContractId { get; set; }
		public Guid ToyId { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
		public string CreatedBy { get; set; }
		public string? LastUpdatedBy { get; set; }
		public string? DeletedBy { get; set; }
		public DateTimeOffset CreatedTime { get; set; }
		public DateTimeOffset? LastUpdatedTime { get; set; }
		public DateTimeOffset? DeletedTime { get; set; }


		public virtual Contract Contract { get; set; }
		public virtual Toy Toy { get; set; }
	}
}
