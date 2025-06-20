using Microsoft.AspNetCore.Identity;
using SocialNetwork309.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork309.Domain.Entities.Chat
{
    public class Chat : BaseAuditableEntity
    {

        public string Name { get; set; }
        public string SenderId { get; set; }
        public IdentityUser Sender { get; set; }

        //public ICollection<Message> Messages { get; set; } = new List<Message>();
    }

   
}

