using Microsoft.AspNetCore.Identity;
using SocialNetwork309.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork309.Persistence.Migrations.Entities
{
    public class Friend : BaseAuditableEntity
    {
        public IdentityUser User { get; set; }
        public IdentityUser Dude { get; set; }
    }
}
