using MediatR;

namespace SocialNetwork309.Application.Features.Auth.Commands.Register
{
    public class RegisterCommand : IRequest<bool>
    {
        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }
    }
}
