using Microsoft.EntityFrameworkCore;
using SocialNetwork309.Application.Common;
using SocialNetwork309.Application.Interfaces.Repositories;
using SocialNetwork309.Domain.Entities;

namespace SocialNetwork309.Application.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly IGenericRepository<Post> _repository;

        public PostRepository(IGenericRepository<Post> repository)
        {
            _repository = repository;
        }

        public async Task<List<Post>> GetByUserPageIdAsync(int userPageId)
        {
            return await _repository.Entities.Where(x => x.UserPageId == userPageId).ToListAsync();
        }
    }
}
