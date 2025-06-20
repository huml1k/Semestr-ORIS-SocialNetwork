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
    public class Message : BaseAuditableEntity
    {

        public int ChatId { get; set; }
        public Chat Chat { get; set; }
        public string SenderId { get; set; }
        public IdentityUser Sender { get; set; }
        public string Text { get; set; }
        public DateTime SentAt { get; set; }
    }

}
