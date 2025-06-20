using MediatR;
using SocialNetwork309.Application.Interfaces.Repositories;
using SocialNetwork309.Application.Interfaces.Services;

namespace SocialNetwork309.Application.Features.Auth.Queries.Login
{
    public class LoginQueryHandler(IAuthService _authService) : IRequestHandler<LoginQuery, bool>
    {
        public async Task<bool> Handle(LoginQuery query, CancellationToken cancellationToken)
         => await _authService.LoginAsync(query.email, query.password);
    }
}
