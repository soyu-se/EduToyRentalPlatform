using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Entities.Entity
{
    public class UserLogin
    {
        [Key]
        [MaxLength(450)]
        public string LoginProvider {  get; set; }
        [Key]
        [MaxLength(450)]
        public string ProviderKey {  get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset LastUpdatedTime { get; set; }
        public DateTimeOffset? DeletedTime { get; set; }
        public string ProviderDisplayName {  get; set; }

        [ForeignKey("Id")]
        public Guid Id { get; set; }
        public virtual Users Users { get; set; }
    }
}
