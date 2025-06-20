using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork309.Application.Interfaces.Services
{
    public interface IFriendService
    {
        Task<List<IdentityUser>> GetFriendsAsync(string userId);
        Task<bool> AddFriendAsync(string userId, string friendId);
    }
}
