﻿using Microsoft.AspNetCore.Identity;
using ToyShop.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop.Contract.Repositories.Entity
{
    public class ApplicationUserClaims : IdentityUserClaim<Guid>
    {
        public DateTimeOffset CreatedTime { get; set; }

        public DateTimeOffset LastUpdatedTime { get; set; }

        public DateTimeOffset? DeletedTime { get; set; }
        public ApplicationUserClaims()
        {
            CreatedTime = CoreHelper.SystemTimeNow;
            LastUpdatedTime = CreatedTime;
        }
    }
}
