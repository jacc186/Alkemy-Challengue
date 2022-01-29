using Blog.Api.Models;

namespace Blog.Api.Data.EFCore
{
    public class EFCorePostsRepository : EFCoreRepository<Posts, BlogApiContext>
    {
        public EFCorePostsRepository(BlogApiContext context) : base(context)
        {
        }
    }
}
