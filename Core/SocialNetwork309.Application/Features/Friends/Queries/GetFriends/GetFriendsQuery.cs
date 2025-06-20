using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork309.Application.Features.Friends.Queries.GetFriends
{
    public record GetFriendsQuery(string UserId) : IRequest<List<IdentityUser>>;
}
