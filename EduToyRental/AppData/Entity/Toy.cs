namespace EduToyRental.AppData.Entity
{
	public class Toy
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public string Name { get; set; }
		public string? Description { get; set; }
		public decimal Price { get; set; }
		public string? Image { get; set; }
		public int RemainingQuantity { get; set; }
		public int SoldQuantity { get; set; }
		public string Option { get; set; }
		public string CreatedBy { get; set; }
		public string? LastUpdatedBy { get; set; }
		public string? DeletedBy { get; set; }
		public DateTimeOffset CreatedTime { get; set; }
		public DateTimeOffset? LastUpdatedTime { get; set; }
		public DateTimeOffset? DeletedTime { get; set; }


		public virtual ICollection<ContractDetail> ContractDetails { get; set; }
		public virtual ICollection<Feedback> Feedbacks { get; set; }
	}
}
