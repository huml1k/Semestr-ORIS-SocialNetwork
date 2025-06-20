using SocialNetwork309.Domain.Common;

namespace SocialNetwork309.Domain.Entities
{
    public class Post : BaseAuditableEntity
    {
        public string Content { get; set; }

        public int UserPageId { get; set; }

        public int LikeCount { get; set; }

        public int DislikeCount { get; set; }
    }
}
