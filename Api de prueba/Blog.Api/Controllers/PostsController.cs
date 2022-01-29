using Blog.Api.Data.EFCore;
using Blog.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : BlogApiController<Posts, EFCorePostsRepository>
    {
        public PostsController(EFCorePostsRepository repository) : base(repository)
        {
        }
    }
}
