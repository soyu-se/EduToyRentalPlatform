using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EduToyRental.AppData.Entity
{
	public class User : IdentityUser<Guid>
	{
		public string FullName { get; set; }
		public DateTimeOffset CreatedTime { get; set; }
		public DateTimeOffset? LastUpdatedTime { get; set; }
		public DateTimeOffset? DeletedTime { get; set; }
		public decimal Money { get; set; }


		public virtual ICollection<Feedback> Feedbacks { get; set; }
		public virtual ICollection<Contract> Contracts { get; set; }
		public virtual ICollection<Chat> Chats { get; set; }
		public virtual ICollection<Message> Messages { get; set; }
	}
}
