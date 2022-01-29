using Blog.Api.Models;

namespace Blog.Api.Data.EFCore
{
    public class EFCoreUserRepository : EFCoreRepository<User, BlogApiContext>
    {
        public EFCoreUserRepository(BlogApiContext context) : base(context)
        {
        }
    }
}
