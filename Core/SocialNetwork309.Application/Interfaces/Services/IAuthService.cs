namespace SocialNetwork309.Application.Interfaces.Services
{
    public interface IAuthService
    {
        Task<bool> RegisterAsync(string firstname, string lastname, string email, string password);
        Task<bool> LoginAsync(string email, string password);
    }
}
