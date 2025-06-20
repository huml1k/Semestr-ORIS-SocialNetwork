using Microsoft.AspNetCore.Identity;
using SocialNetwork309.Domain.Entities.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork309.Application.Interfaces.Repositories
{
    public interface IChatRepository
    {
        Task<List<Chat>> GetAllChatsUser(Guid userId);

        Task<Chat> GetChatCurrentUser(IdentityUser SenderId);
    }
}
