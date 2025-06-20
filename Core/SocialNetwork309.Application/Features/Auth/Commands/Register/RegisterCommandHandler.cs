using MediatR;
using SocialNetwork309.Application.Interfaces.Services;

namespace SocialNetwork309.Application.Features.Auth.Commands.Register
{
    public class RegisterCommandHandler(IAuthService _authService) : IRequestHandler<RegisterCommand, bool>
    {
        public async Task<bool> Handle(RegisterCommand command, CancellationToken cancellationToken) 
             => await _authService.RegisterAsync(command.FirstName, command.LastName, command.Email, command.Password);
    }
}
