namespace EduToyRental.AppData.Entity
{
    public class RestoreToy
    {
        public Guid Id { get; set; } = Guid.NewGuid();
		public Guid ContractId { get; set; }
        public float ToyQuality { get; set; }
        public int Reward { get; set; }
        public float OverdueTime { get; set; }
        public float TotalMoney { get; set; }
        public string CreatedBy { get; set; }
        public string? LastUpdatedBy { get; set; }
        public string? DeletedBy { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset? LastUpdatedTime { get; set; }
        public DateTimeOffset? DeletedTime { get; set; }


        public virtual Contract Contract { get; set; }
	}
}
