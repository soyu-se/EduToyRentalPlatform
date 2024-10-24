using EduToyRental.AppData.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EduToyRental.AppData.DbContext
{
	public class ApplicationDbContext : IdentityDbContext<User, Role, Guid>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		#region DbSet
		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<RestoreToy> RestoreToys { get; set; }
		public virtual DbSet<Delivery> Deliveries { get; set; }
		public virtual DbSet<Feedback> Feedbacks { get; set; }
		public virtual DbSet<Message> Messages { get; set; }
		public virtual DbSet<Toy> Toys { get; set; }
		public virtual DbSet<Transaction> Transactions { get; set; }
		public virtual DbSet<ContractDetail> ContractDetails { get; set; }
		public virtual DbSet<Chat> Chats { get; set; }
		public virtual DbSet<Contract> Contracts { get; set; }
		public virtual DbSet<Role> Roles { get; set; }


		#endregion

		#region connect configure
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{

			if (!optionsBuilder.IsConfigured)
			{

				var configuration = new ConfigurationBuilder()
					.SetBasePath(Directory.GetCurrentDirectory())
					.AddJsonFile("appsettings.json")
					.Build();

				optionsBuilder.UseSqlServer(configuration.GetConnectionString("Default"));
			}
		}
		#endregion

		#region create relationship and key
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<RestoreToy>(entity =>
			{
				entity.HasKey(rt => rt.Id);
				entity.Property(rt => rt.CreatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(rt => rt.LastUpdatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(rt => rt.DeletedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(rt => rt.OverdueTime).HasColumnType("float(53)");
				entity.Property(rt => rt.ToyQuality).HasColumnType("float(53)");
				entity.Property(rt => rt.TotalMoney).HasColumnType("decimal(18,2)");
				entity.HasOne(rt => rt.Contract).WithOne(c => c.RestoreToy).HasForeignKey<RestoreToy>(rt => rt.ContractId).HasConstraintName("FK_Contract_RestoreToy");
			});

			modelBuilder.Entity<Contract>(entity =>
			{
				entity.HasKey(c => c.Id);
				entity.Property(c => c.CreatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(c => c.LastUpdatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(c => c.DeletedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(c => c.TotalCost).HasColumnType("decimal(18,2)");
				entity.Property(c => c.StartDate).HasColumnType("date");
				entity.Property(c => c.EndDate).HasColumnType("date");
				entity.HasOne(c => c.User).WithMany(u => u.Contracts).HasForeignKey(c => c.UserId).HasConstraintName("FK_User__Contracts");
			});

			modelBuilder.Entity<Transaction>(entity =>
			{
				entity.HasKey(t => t.Id);
				entity.Property(t => t.CreatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(t => t.LastUpdatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(t => t.DeletedTime).HasColumnType("datetimeoffset(7)");
				entity.HasOne(t => t.Contract).WithMany(c => c.Transactions).HasForeignKey(t => t.ContractId).HasConstraintName("FK_Contract__Transactions");
			});

			modelBuilder.Entity<Delivery>(entity =>
			{
				entity.HasKey(d => d.Id);
				entity.Property(d => d.CreatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(d => d.LastUpdatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(d => d.DeletedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(d => d.SendingDate).HasColumnType("date");
				entity.Property(d => d.ReceivingDate).HasColumnType("date");
				entity.Property(d => d.DeliveryCost).HasColumnType("decimal(18,2)");
				entity.HasOne(d => d.Contract).WithMany(c => c.Deliveries).HasForeignKey(d => d.ContractId).HasConstraintName("FK_Contract__Deliveries");
			});

			modelBuilder.Entity<ContractDetail>(entity =>
			{
				entity.HasKey(cd => cd.Id);
				entity.Property(cd => cd.CreatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(cd => cd.LastUpdatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(cd => cd.DeletedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(cd => cd.Price).HasColumnType("decimal(18,2)");
				entity.HasOne(cd => cd.Contract).WithMany(c => c.ContractDetails).HasForeignKey(cd => cd.ContractId).HasConstraintName("FK_Contract__ContractDetails");
			});

			modelBuilder.Entity<Toy>(entity =>
			{
				entity.HasKey(t => t.Id);
				entity.Property(t => t.CreatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(t => t.LastUpdatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(t => t.DeletedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(t => t.Price).HasColumnType("decimal(18,2)");
				entity.HasMany(t => t.ContractDetails).WithOne(cd => cd.Toy).HasForeignKey(cd => cd.ToyId).HasConstraintName("FK_Toy__ContractDetails");
			});

			modelBuilder.Entity<Feedback>(entity =>
			{
				entity.HasKey(f => f.Id);
				entity.Property(u => u.CreatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(u => u.LastUpdatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(u => u.DeletedTime).HasColumnType("datetimeoffset(7)");
				entity.HasOne(f => f.Toy).WithMany(t => t.Feedbacks).HasForeignKey(f => f.ToyId).HasConstraintName("FK_Toy__Feedbacks");
			});

			modelBuilder.Entity<Chat>(entity =>
			{
				entity.HasKey(c => c.Id);
				entity.Property(c => c.CreatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(c => c.LastUpdatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(c => c.DeletedTime).HasColumnType("datetimeoffset(7)");
				entity.HasOne(c => c.User).WithMany(u => u.Chats).HasForeignKey(c => c.UserId).HasConstraintName("FK_User__Chats");
				entity.HasMany(c => c.Messages).WithOne(m => m.Chat).HasForeignKey(m => m.ChatId).HasConstraintName("FK_Chat__Messages");
			});

			modelBuilder.Entity<Message>(entity =>
			{
				entity.HasKey(m => m.Id);
				entity.Property(m => m.CreatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(m => m.LastUpdatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(m => m.DeletedTime).HasColumnType("datetimeoffset(7)");
				entity.HasOne(m => m.User).WithMany(u => u.Messages).HasForeignKey(m => m.SenderId).HasConstraintName("FK_User__Messages").OnDelete(DeleteBehavior.NoAction);
			});

			modelBuilder.Entity<User>(entity =>
			{
				entity.HasKey(u => u.Id);
				entity.Property(u => u.CreatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(u => u.LastUpdatedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(u => u.DeletedTime).HasColumnType("datetimeoffset(7)");
				entity.Property(u => u.Money).HasColumnType("decimal(18,2)");
			});

			modelBuilder.Entity<Role>().HasKey(r => r.Id);
		}
		#endregion
	}
}
