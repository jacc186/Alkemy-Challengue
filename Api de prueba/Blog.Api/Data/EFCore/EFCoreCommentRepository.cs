using Blog.Api.Models;

namespace Blog.Api.Data.EFCore
{
    public class EFCoreCommentRepository : EFCoreRepository<Comments, BlogApiContext>
    {
        public EFCoreCommentRepository(BlogApiContext context) : base(context)
        {
        }
    }
}
