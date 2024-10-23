using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Entities.Entity
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public Guid Id { get; set; }        
        public string FullName { get; set; }        
        public string Password { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset LastUpdatedTime { get; set; }
        public DateTimeOffset? DeletedTime { get; set; }
        public string UserName {  get; set; }
        public string NormalizedFullName { get; set; }        
        public string Email { get; set; }        
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash {  get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp {  get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public bool LockoutEnabled { get; set; }

        public DateTimeOffset? LockoutEnd { get; set; }
        public int AccessFailedCount { get; set; }
        public string Phone {  get; set; }
        public decimal Money { get; set; }

        public virtual UserLogin UserLogin { get; set; }
    }
}
