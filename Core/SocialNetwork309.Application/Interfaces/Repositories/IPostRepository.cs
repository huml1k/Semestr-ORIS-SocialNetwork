using SocialNetwork309.Domain.Entities;

namespace SocialNetwork309.Application.Interfaces.Repositories
{
    public interface IPostRepository
    {
        Task<List<Post>> GetByUserPageIdAsync(int userPageId);
    }
}
