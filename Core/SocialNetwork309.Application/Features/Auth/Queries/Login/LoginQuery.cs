using MediatR;

namespace SocialNetwork309.Application.Features.Auth.Queries.Login
{

    public record LoginQuery(string email, string password) : IRequest<bool>;
}
